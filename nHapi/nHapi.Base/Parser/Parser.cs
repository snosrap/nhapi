/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Parser.java".  Description: 
/// "Parses HL7 message Strings into HL7 Message objects and 
/// encodes HL7 Message objects into HL7 message Strings" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using NHapi.Base;
using NHapi.Base.model;
using NHapi.Base.validation;
using NHapi.Base.validation.impl;
using NHapi.Base.Log;

namespace NHapi.Base.parser
{
	
	/// <summary> Parses HL7 message Strings into HL7 Message objects and 
	/// encodes HL7 Message objects into HL7 message Strings.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public abstract class Parser
	{
		/// <returns> the factory used by this Parser for model class lookup
		/// </returns>
		virtual public IModelClassFactory Factory
		{
			get
			{
				return myFactory;
			}
			
		}
		//UPGRADE_NOTE: Respective javadoc comments were merged.  It should be changed in order to comply with .NET documentation conventions. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1199'"
		/// <returns> the set of validation rules that is applied to messages parsed or encoded by this parser
		/// </returns>
		/// <param name="theContext">the set of validation rules to be applied to messages parsed or 
		/// encoded by this parser (defaults to ValidationContextFactory.DefaultValidation)
		/// </param>
		virtual public IValidationContext ValidationContext
		{
			get
			{
				return myContext;
			}
			
			set
			{
				myContext = value;
				myValidator = new MessageValidator(value, true);
			}
			
		}
		/// <returns> the preferred encoding of this Parser
		/// </returns>
		public abstract System.String DefaultEncoding{get;}
		/// <summary> Returns event->structure maps.  </summary>
		//UPGRADE_NOTE: Synchronized keyword was removed from method 'getMessageStructures'. Lock expression was added. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1027'"
		private static System.Collections.IDictionary MessageStructures
		{
			get
			{
				lock (typeof(NHapi.Base.parser.Parser))
				{
					if (messageStructures == null)
					{
						messageStructures = loadMessageStructures();
					}
					return messageStructures;
				}
			}
			
		}
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'log '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		//UPGRADE_NOTE: The initialization of  'log' was moved to static method 'NHapi.Base.parser.Parser'. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1005'"
		private static readonly IHapiLog log;
		
		private static System.Collections.IDictionary messageStructures = null;
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'versions'. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		private static readonly System.String[] versions = new System.String[]{"2.0", "2.0D", "2.1", "2.2", "2.3", "2.3.1", "2.4", "2.5"};
		
		private IModelClassFactory myFactory;
		private IValidationContext myContext;
		private MessageValidator myValidator;
		
		/// <summary> Uses DefaultModelClassFactory for model class lookup. </summary>
		public Parser()
		{
			myFactory = new DefaultModelClassFactory();
			ValidationContext = new DefaultValidation();
		}
		
		/// <param name="theFactory">custom factory to use for model class lookup 
		/// </param>
		public Parser(IModelClassFactory theFactory)
		{
			myFactory = theFactory;
			ValidationContext = new DefaultValidation();
		}
		
		/// <summary> Returns a String representing the encoding of the given message, if 
		/// the encoding is recognized.  For example if the given message appears 
		/// to be encoded using HL7 2.x XML rules then "XML" would be returned.  
		/// If the encoding is not recognized then null is returned.  That this 
		/// method returns a specific encoding does not guarantee that the 
		/// message is correctly encoded (e.g. well formed XML) - just that  
		/// it is not encoded using any other encoding than the one returned.  
		/// Returns null if the encoding is not recognized.  
		/// </summary>
		public abstract System.String getEncoding(System.String message);
		
		/// <summary> Returns true if and only if the given encoding is supported 
		/// by this Parser.  
		/// </summary>
		public abstract bool supportsEncoding(System.String encoding);
		
		/// <summary> Parses a message string and returns the corresponding Message object.
		/// 
		/// </summary>
		/// <param name="message">a String that contains an HL7 message 
		/// </param>
		/// <returns> a HAPI Message object parsed from the given String 
		/// </returns>
		/// <throws>  HL7Exception if the message is not correctly formatted.   </throws>
		/// <throws>  EncodingNotSupportedException if the message encoded  </throws>
		/// <summary>      is not supported by this parser.   
		/// </summary>
		public virtual IMessage parse(System.String message)
		{
			System.String encoding = getEncoding(message);
			if (!supportsEncoding(encoding))
			{
				throw new EncodingNotSupportedException("Can't parse message beginning " + message.Substring(0, (System.Math.Min(message.Length, 50)) - (0)));
			}
			
			System.String version = getVersion(message);
			if (!validVersion(version))
			{
				throw new HL7Exception("Can't process message of version '" + version + "' - version not recognized", HL7Exception.UNSUPPORTED_VERSION_ID);
			}
			
			myValidator.validate(message, encoding.Equals("XML"), version);
			IMessage result = doParse(message, version);
			myValidator.validate(result);
			
			return result;
		}
		
		/// <summary> Called by parse() to perform implementation-specific parsing work.  
		/// 
		/// </summary>
		/// <param name="message">a String that contains an HL7 message 
		/// </param>
		/// <param name="version">the name of the HL7 version to which the message belongs (eg "2.5") 
		/// </param>
		/// <returns> a HAPI Message object parsed from the given String 
		/// </returns>
		/// <throws>  HL7Exception if the message is not correctly formatted.   </throws>
		/// <throws>  EncodingNotSupportedException if the message encoded  </throws>
		/// <summary>      is not supported by this parser.   
		/// </summary>
		protected internal abstract IMessage doParse(System.String message, System.String version);
		
		/// <summary> Formats a Message object into an HL7 message string using the given 
		/// encoding. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <param name="encoding">the name of the HL7 encoding to use (eg "XML"; most implementations support only  
		/// one encoding) 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not  </throws>
		/// <summary>      supported by this parser.  
		/// </summary>
		public virtual System.String encode(IMessage source, System.String encoding)
		{
			myValidator.validate(source);
			System.String result = doEncode(source, encoding);
			myValidator.validate(result, encoding.Equals("XML"), source.Version);
			
			return result;
		}
		
		/// <summary> Called by encode(Message, String) to perform implementation-specific encoding work. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <param name="encoding">the name of the HL7 encoding to use (eg "XML"; most implementations support only 
		/// one encoding) 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not  </throws>
		/// <summary>      supported by this parser.  
		/// </summary>
		protected internal abstract System.String doEncode(IMessage source, System.String encoding);
		
		/// <summary> Formats a Message object into an HL7 message string using this parser's  
		/// default encoding. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <param name="encoding">the name of the encoding to use (eg "XML"; most implementations support only one 
		/// encoding) 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		public virtual System.String encode(IMessage source)
		{
			System.String encoding = DefaultEncoding;
			
			myValidator.validate(source);
			System.String result = doEncode(source);
			myValidator.validate(result, encoding.Equals("XML"), source.Version);
			
			return result;
		}
		
		/// <summary> Called by encode(Message) to perform implementation-specific encoding work. 
		/// 
		/// </summary>
		/// <param name="source">a Message object from which to construct an encoded message string 
		/// </param>
		/// <returns> the encoded message 
		/// </returns>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding  </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not  </throws>
		/// <summary>      supported by this parser.  
		/// </summary>
		protected internal abstract System.String doEncode(IMessage source);
		
		/// <summary> <p>Returns a minimal amount of data from a message string, including only the 
		/// data needed to send a response to the remote system.  This includes the 
		/// following fields: 
		/// <ul><li>field separator</li>
		/// <li>encoding characters</li>
		/// <li>processing ID</li>
		/// <li>message control ID</li></ul>
		/// This method is intended for use when there is an error parsing a message, 
		/// (so the Message object is unavailable) but an error message must be sent 
		/// back to the remote system including some of the information in the inbound
		/// message.  This method parses only that required information, hopefully 
		/// avoiding the condition that caused the original error.</p>  
		/// </summary>
		/// <returns> an MSH segment 
		/// </returns>
		public abstract ISegment getCriticalResponseData(System.String message);
		
		/// <summary> For response messages, returns the value of MSA-2 (the message ID of the message 
		/// sent by the sending system).  This value may be needed prior to main message parsing, 
		/// so that (particularly in a multi-threaded scenario) the message can be routed to 
		/// the thread that sent the request.  We need this information first so that any 
		/// parse exceptions are thrown to the correct thread.  Implementers of Parsers should 
		/// take care to make the implementation of this method very fast and robust.  
		/// Returns null if MSA-2 can not be found (e.g. if the message is not a 
		/// response message). 
		/// </summary>
		public abstract System.String getAckID(System.String message);
		
		/// <summary> Returns the version ID (MSH-12) from the given message, without fully parsing the message. 
		/// The version is needed prior to parsing in order to determine the message class
		/// into which the text of the message should be parsed. 
		/// </summary>
		/// <throws>  HL7Exception if the version field can not be found.  </throws>
		public abstract System.String getVersion(System.String message);
		
		
		/// <summary> Creates a version-specific MSH object and returns it as a version-independent 
		/// MSH interface. 
		/// throws HL7Exception if there is a problem, e.g. invalid version, code not available 
		/// for given version. 
		/// </summary>
		public static ISegment makeControlMSH(System.String version, IModelClassFactory factory)
		{
			ISegment msh = null;
			
			try
			{
				IMessage dummy = (IMessage) GenericMessage.getGenericMessageClass(version).GetConstructor(new System.Type[]{typeof(IModelClassFactory)}).Invoke(new System.Object[]{factory});
				
				System.Type[] constructorParamTypes = new System.Type[]{typeof(IGroup), typeof(IModelClassFactory)};
				System.Object[] constructorParamArgs = new System.Object[]{dummy, factory};
				System.Type c = factory.getSegmentClass("MSH", version);
				System.Reflection.ConstructorInfo constructor = c.GetConstructor(constructorParamTypes);
				msh = (ISegment) constructor.Invoke(constructorParamArgs);
			}
			catch (System.Exception e)
			{
				throw new HL7Exception("Couldn't create MSH for version " + version + " (does your classpath include this version?) ... ", HL7Exception.APPLICATION_INTERNAL_ERROR, e);
			}
			return msh;
		}
		
		/// <summary> Returns true if the given string represents a valid 2.x version.  Valid versions 
		/// include "2.0", "2.0D", "2.1", "2.2", "2.3", "2.3.1", "2.4", "2.5". 
		/// </summary>
		public static bool validVersion(System.String version)
		{
			bool versionOK = false;
			int c = 0;
			while (versionOK == false && c < versions.Length)
			{
				if (versions[c++].Equals(version))
					versionOK = true;
			}
			return versionOK;
		}
		
		/// <summary> Given a concatenation of message type and event (e.g. ADT_A04), and the 
		/// version, finds the corresponding message structure (e.g. ADT_A01).  This  
		/// is needed because some events share message structures, although it is not needed
		/// when the message structure is explicitly valued in MSH-9-3. 
		/// If no mapping is found, returns the original name.
		/// </summary>
		/// <throws>  HL7Exception if there is an error retrieving the map, or if the given  </throws>
		/// <summary>      version is invalid  
		/// </summary>
		public static System.String getMessageStructureForEvent(System.String name, System.String version)
		{
			System.String structure = null;
			
			if (!validVersion(version))
				throw new HL7Exception("The version " + version + " is unknown");
			
			//UPGRADE_ISSUE: Class hierarchy differences between 'java.util.Properties' and 'System.Collections.Specialized.NameValueCollection' may cause compilation errors. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1186'"
			System.Collections.Specialized.NameValueCollection p = null;
			try
			{
				//UPGRADE_ISSUE: Class hierarchy differences between 'java.util.Properties' and 'System.Collections.Specialized.NameValueCollection' may cause compilation errors. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1186'"
				p = (System.Collections.Specialized.NameValueCollection) MessageStructures[version];
			}
			catch (System.IO.IOException ioe)
			{
				throw new HL7Exception("Unable to access message strutures", ioe);
			}
			
			if (p == null)
				throw new HL7Exception("No map found for version " + version);
			
			structure = p.Get(name);
			
			if (structure == null)
			{
				structure = name;
			}
			
			return structure;
		}
		
		//UPGRADE_NOTE: Synchronized keyword was removed from method 'loadMessageStructures'. Lock expression was added. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1027'"
		private static System.Collections.IDictionary loadMessageStructures()
		{
			lock (typeof(NHapi.Base.parser.Parser))
			{
				//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
				System.Collections.IDictionary map = new System.Collections.Hashtable();
				for (int i = 0; i < versions.Length; i++)
				{
                    System.String resource = "NHapi.Base.parser.eventmap." + versions[i] + ".properties";
                    System.IO.Stream inResource = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
                    System.Collections.Specialized.NameValueCollection structures = new System.Collections.Specialized.NameValueCollection() ;
                    if (inResource != null)
					{
                        System.IO.StreamReader sr = new System.IO.StreamReader(inResource);
                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            if ((line.Length > 0) && ('#' != line[0]))
                            {
                                string[] lineElements = line.Split(' ','\t');
                                structures.Add(lineElements[0], lineElements[1]);
                            }
                            line = sr.ReadLine();
                            
                        }
					}
					
					map[versions[i]] = structures;
				}
				return map;
			}
		}
		
		/// <summary> Note that the validation context of the resulting message is set to this parser's validation 
		/// context.  The validation context is used within Primitive.setValue().
		/// 
		/// </summary>
		/// <param name="name">name of the desired structure in the form XXX_YYY
		/// </param>
		/// <param name="version">HL7 version (e.g. "2.3")  
		/// </param>
		/// <param name="isExplicit">true if the structure was specified explicitly in MSH-9-3, false if it 
		/// was inferred from MSH-9-1 and MSH-9-2.  If false, a lookup may be performed to find 
		/// an alternate structure corresponding to that message type and event.   
		/// </param>
		/// <returns> a Message instance 
		/// </returns>
		/// <throws>  HL7Exception if the version is not recognized or no appropriate class can be found or the Message  </throws>
		/// <summary>      class throws an exception on instantiation (e.g. if args are not as expected) 
		/// </summary>
		protected internal virtual IMessage instantiateMessage(System.String theName, System.String theVersion, bool isExplicit)
		{
			IMessage result = null;
			
			try
			{
				System.Type messageClass = myFactory.getMessageClass(theName, theVersion, isExplicit);
				if (messageClass == null)
				{
					//UPGRADE_NOTE: Exception 'java.lang.ClassNotFoundException' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
					throw new System.Exception("Can't find message class in current package list: " + theName);
				}
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				log.info("Instantiating msg of class " + messageClass.FullName);
				System.Reflection.ConstructorInfo constructor = messageClass.GetConstructor(new System.Type[]{typeof(IModelClassFactory)});
				result = (IMessage) constructor.Invoke(new System.Object[]{myFactory});
			}
			catch (System.Exception e)
			{
				throw new HL7Exception("Couldn't create Message object of type " + theName, HL7Exception.UNSUPPORTED_MESSAGE_TYPE, e);
			}
			
			result.ValidationContext = myContext;
			
			return result;
		}
		static Parser()
		{
			log = HapiLogFactory.getHapiLog(typeof(Parser));
		}
	}
}