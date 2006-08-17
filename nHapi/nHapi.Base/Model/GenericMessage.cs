using System;
using NHapi.Base.parser;
using NHapi.Base;
using NHapi.Base.Log;

namespace NHapi.Base.model
{
	
	/// <summary> A generic HL7 message, meant for parsing message with unrecognized structures
	/// into a flat list of segments.
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public abstract class GenericMessage:AbstractMessage
	{
		
		/// <summary> Creates a new instance of GenericMessage. 
		/// 
		/// </summary>
		/// <param name="factory">class factory for contained structures 
		/// </param>
		public GenericMessage(IModelClassFactory factory):base(factory)
		{
			try
			{
				this.addNonstandardSegment("MSH");
			}
			catch (HL7Exception e)
			{
				System.String message = "Unexpected error adding GenericSegment to GenericMessage.";
				HapiLogFactory.getHapiLog(this.GetType()).error(message, e);
				throw new System.ApplicationException(message);
			}
		}
		
		/// <summary> Returns a subclass of GenericMessage corresponding to a certain version.  
		/// This is needed so that version-specific segments can be added as the message
		/// is parsed.  
		/// </summary>
		public static System.Type getGenericMessageClass(System.String version)
		{
			if (!Parser.validVersion(version))
				throw new System.ArgumentException("The version " + version + " is not recognized");
			
			System.Type c = null;
			if (version.Equals("2.1"))
			{
				c = typeof(V21);
			}
			else if (version.Equals("2.2"))
			{
				c = typeof(V22);
			}
			else if (version.Equals("2.3"))
			{
				c = typeof(V23);
			}
			else if (version.Equals("2.3.1"))
			{
				c = typeof(V231);
			}
			else if (version.Equals("2.4"))
			{
				c = typeof(V24);
			}
			else if (version.Equals("2.5"))
			{
				c = typeof(V25);
			}
			return c;
		}
		
		public class V21:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.1";
				}
				
			}
			public V21(IModelClassFactory factory):base(factory)
			{
			}
		}
		
		public class V22:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.2";
				}
				
			}
			public V22(IModelClassFactory factory):base(factory)
			{
			}
		}
		
		public class V23:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.3";
				}
				
			}
			public V23(IModelClassFactory factory):base(factory)
			{
			}
		}
		
		public class V231:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.3.1";
				}
				
			}
			public V231(IModelClassFactory factory):base(factory)
			{
			}
		}
		
		public class V24:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.4";
				}
				
			}
			public V24(IModelClassFactory factory):base(factory)
			{
			}
		}
		
		public class V25:GenericMessage
		{
			override public System.String Version
			{
				get
				{
					return "2.5";
				}
				
			}
			public V25(IModelClassFactory factory):base(factory)
			{
			}
		}
	}
}