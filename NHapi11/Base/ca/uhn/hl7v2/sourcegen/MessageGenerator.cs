/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "MessageGenerator.java".  Description:
/// "Creates source code for HL7 Message objects, using the normative DB"
/// 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Contributor(s):  Eric Poiseau. 
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  �GPL�), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using HL7Exception = ca.uhn.hl7v2.HL7Exception;
using NormativeDatabase = ca.uhn.hl7v2.NormativeDatabase;
using HapiLog = ca.uhn.log.HapiLog;
using HapiLogFactory = ca.uhn.log.HapiLogFactory;
using System.Data.OleDb;
using System.Data;
using System.Text;

namespace ca.uhn.hl7v2.sourcegen
{
	
	/// <summary> Creates source code for HL7 Message objects, using the normative DB.  HL7 Group
	/// objects are also created as a byproduct.
	/// 
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	/// <author>  Eric Poiseau
	/// </author>
	public class MessageGenerator:System.Object
	{
		
		/// <summary> If the system property by this name is true, groups are generated to use a ModelClassFactory
		/// for segment class lookup.  This makes segment creation more flexible, but may slow down parsing 
		/// substantially.  
		/// </summary>
		public static System.String MODEL_CLASS_FACTORY_KEY = "ca.uhn.hl7v2.sourcegen.modelclassfactory";
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'log '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		//UPGRADE_NOTE: The initialization of  'log' was moved to static method 'ca.uhn.hl7v2.sourcegen.MessageGenerator'. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1005'"
		private static readonly HapiLog log;
				
		/// <summary>Creates new MessageGenerator </summary>
		public MessageGenerator()
		{
		}
		
		/// <summary> Creates and writes source code for all Messages and Groups.</summary>
		public static void  makeAll(System.String baseDirectory, System.String version)
		{
			//get list of messages ...
			//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
			using(System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection)
			{
				//UPGRADE_TODO: Method 'java.sql.Connection.createStatement' was converted to 'SupportClass.TransactionManager.manager.CreateStatement' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlConnectioncreateStatement'"
				System.String sql = getMessageListQuery(version);
				//UPGRADE_TODO: Interface 'java.sql.ResultSet' was converted to 'System.Data.OleDb.OleDbDataReader' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlResultSet'"
				System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
				System.Data.OleDb.OleDbCommand temp_OleDbCommand;
				temp_OleDbCommand = stmt;
				temp_OleDbCommand.CommandText = sql;
				System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
				System.Collections.ArrayList messages = new System.Collections.ArrayList();
				System.Collections.ArrayList chapters = new System.Collections.ArrayList();
				while (rs.Read())
				{
					messages.Add(System.Convert.ToString(rs[1 - 1]));
					chapters.Add(System.Convert.ToString(rs[2 - 1]));
				}
				//UPGRADE_ISSUE: Method 'java.sql.Statement.close' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javasqlStatementclose'"
				rs.Close();
				NormativeDatabase.Instance.returnConnection(conn);
			
				if (messages.Count == 0)
				{
					//UPGRADE_ISSUE: Method 'java.lang.System.getProperty' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangSystem'"
					log.warn("No version " + version + " messages found in database " + conn.Database);
				}
			
				for (int i = 0; i < messages.Count; i++)
				{
					make((System.String) messages[i], baseDirectory, (System.String) chapters[i], version);
				}
			}
		}
		
		/// <summary> Returns an SQL query with which to get a list of messages from the normative
		/// database.  
		/// </summary>
		private static System.String getMessageListQuery(System.String version)
		{
			// UNION because the messages are defined in different tables for different versions.
			return "SELECT distinct  [message_type]+'_'+[event_code] AS msg_struct, '[AAA]'" + " FROM HL7Versions RIGHT JOIN HL7EventMessageTypeSegments ON HL7EventMessageTypeSegments.version_id = HL7Versions.version_id " + "WHERE HL7Versions.hl7_version ='" + version + "' and Not (message_type='ACK') " + "UNION " + "select distinct HL7MsgStructIDs.message_structure, [section] from HL7Versions RIGHT JOIN (HL7MsgStructIDSegments " + " inner join HL7MsgStructIDs on HL7MsgStructIDSegments.message_structure = HL7MsgStructIDs.message_structure " + " and HL7MsgStructIDSegments.version_id = HL7MsgStructIDs.version_id) " + " ON HL7MsgStructIDSegments.version_id = HL7Versions.version_id " + " where HL7Versions.hl7_version = '" + version + "' and HL7MsgStructIDs.message_structure not like 'ACK_%'"; //note: allows "ACK" itself
		}
		
		/// <summary> Creates source code for a specific message structure and
		/// writes it under the specified directory.
		/// throws IllegalArgumentException if there is no message structure
		/// for this message in the normative database
		/// </summary>
		public static void  make(System.String message, System.String baseDirectory, System.String chapter, System.String version)
		{
			
			try
			{
				SegmentDef[] segments = getSegments(message, version);
				//System.out.println("Making: " + message + " with " + segments.length + " segments (not writing message code - just groups)");
				
				GroupDef group = GroupGenerator.getGroupDef(segments, null, baseDirectory, version, message);
				StructureDef[] contents = group.Structures;
				
				//make base directory
				if (!(baseDirectory.EndsWith("\\") || baseDirectory.EndsWith("/")))
				{
					baseDirectory = baseDirectory + "/";
				}
				
				System.IO.FileInfo targetDir = SourceGenerator.makeDirectory(baseDirectory + SourceGenerator.getVersionPackageDirectory(version) + "message");
				System.Console.Out.WriteLine("Writing " + message + " to " + targetDir.FullName);
				//UPGRADE_WARNING: At least one expression was used more than once in the target code. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1181'"
				//UPGRADE_TODO: Constructor 'java.io.FileWriter.FileWriter' was converted to 'System.IO.StreamWriter' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaioFileWriterFileWriter_javalangString_boolean'"
				//UPGRADE_TODO: Class 'java.io.FileWriter' was converted to 'System.IO.StreamWriter' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javaioFileWriter'"
				using(System.IO.StreamWriter out_Renamed = new System.IO.StreamWriter(targetDir.FullName + "/" + message + ".cs"))
				{
					//System.IO.StreamWriter out_Renamed = new System.IO.StreamWriter(new System.IO.StreamWriter(targetDir.FullName + "/" + message + ".java", false, System.Text.Encoding.Default).BaseStream, new System.IO.StreamWriter(targetDir.FullName + "/" + message + ".cs", false, System.Text.Encoding.Default).Encoding);
					out_Renamed.Write(makePreamble(contents, message, chapter, version));
					out_Renamed.Write(makeConstructor(contents, message, version));
					for (int i = 0; i < contents.Length; i++)
					{
						out_Renamed.Write(GroupGenerator.makeAccessor(group, i));
					}
					out_Renamed.Write(makeVersion(version));
					//add implementation of model.control interface, if any
					//out.write(Control.getImplementation(Control.getInterfaceImplementedBy(message), version));            
					out_Renamed.Write("}\r\n");	//End class
					out_Renamed.Write("}\r\n");	//End namespace
					}
			}
			catch (System.Exception e)
			{
				log.error("Error while creating source code", e);
				
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Class.getName' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Throwable.getMessage' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
				log.warn("Warning: could not write source code for message structure " + message + " - " + e.GetType().FullName + ": " + e.Message);
			}
		}

		private static string makeVersion(string version)
		{
			StringBuilder sb = new StringBuilder();
			if(version.Equals(Constants.VERSION_UCH_2_3))
			{
				sb.Append("public override System.String Version\n");
				sb.Append("{\n");
				sb.Append("get{\n");
				sb.Append("return Constants.VERSION_UCH_2_3;\n");
				sb.Append("}\n");
				sb.Append("}\n");
			}
			return sb.ToString();
		}
		
		/// <summary> Queries the normative database for a list of segments comprising
		/// the message structure.  The returned list may also contain strings
		/// that denote repetition and optionality.  Choice indicators (i.e. begin choice,
		/// next choice, end choice) for alternative segments are ignored, so that the class
		/// structure allows all choices.  The matter of enforcing that only a single choice is
		/// populated can't be handled by the class structure, and should be handled elsewhere.
		/// </summary>
		private static SegmentDef[] getSegments(System.String message, System.String version)
		{
			/*String sql = "select HL7Segments.seg_code, repetitional, optional, description " +
			"from (HL7MsgStructIDSegments inner join HL7Segments on HL7MsgStructIDSegments.seg_code = HL7Segments.seg_code " +
			"and HL7MsgStructIDSegments.version_id = HL7Segments.version_id) " +
			"where HL7Segments.version_id = 6 and message_structure = '" + message + "' order by seq_no";*/
			System.String sql = getSegmentListQuery(message, version);
			//System.out.println(sql.toString()); 	
			SegmentDef[] segments = new SegmentDef[200]; //presumably there won't be more than 200
			//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
			using(System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection)
			{
				//UPGRADE_TODO: Method 'java.sql.Connection.createStatement' was converted to 'SupportClass.TransactionManager.manager.CreateStatement' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlConnectioncreateStatement'"
				System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
				//UPGRADE_TODO: Interface 'java.sql.ResultSet' was converted to 'System.Data.OleDb.OleDbDataReader' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlResultSet'"
				System.Data.OleDb.OleDbCommand temp_OleDbCommand;
				temp_OleDbCommand = stmt;
				temp_OleDbCommand.CommandText = sql;
				System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
				int c = - 1;
				while (rs.Read())
				{
					System.String name = SegmentGenerator.altSegName(System.Convert.ToString(rs[1 - 1]));
					bool repeating = rs.GetBoolean(2 - 1);
					bool optional = rs.GetBoolean(3 - 1);
					System.String desc = System.Convert.ToString(rs[4 - 1]);
					System.String groupName = System.Convert.ToString(rs[6 - 1]);
				
					//ignore the "choice" directives ... the message class structure has to include all choices ...
					//  if this is enforced (i.e. exception thrown if >1 choice populated) this will have to be done separately.
					if (!(name.Equals("<") || name.Equals("|") || name.Equals(">")))
					{
						c++;
						segments[c] = new SegmentDef(name, groupName, !optional, repeating, desc);
					}
				}
				rs.Close();
				SegmentDef[] ret = new SegmentDef[c + 1];
				Array.Copy(segments, 0, ret, 0, c + 1);
				return ret;
			}
			
		}
		
		/// <summary> Returns an SQL query with which to get a list of the segments that
		/// are part of the given message from the normative database.  The query
		/// varies with different versions.  The fields returned are as follows:
		/// segment_code, repetitional, optional, description
		/// </summary>
		private static System.String getSegmentListQuery(System.String message, System.String version)
		{
			System.String sql = null;
			
			sql = "SELECT HL7Segments.seg_code, repetitional, optional, HL7Segments.description, seq_no, groupname " + "FROM HL7Versions RIGHT JOIN (HL7Segments INNER JOIN HL7EventMessageTypeSegments ON (HL7Segments.version_id = HL7EventMessageTypeSegments.version_id) " + "AND (HL7Segments.seg_code = HL7EventMessageTypeSegments.seg_code)) " + "ON HL7Segments.version_id = HL7Versions.version_id " + "WHERE (((HL7Versions.hl7_version)= '" + version + "') " + "AND (([message_type]+'_'+[event_code])='" + message + "')) order by seq_no UNION " + "select HL7Segments.seg_code, repetitional, optional, HL7Segments.description, seq_no, groupname  " + "from HL7Versions RIGHT JOIN (HL7MsgStructIDSegments inner join HL7Segments on HL7MsgStructIDSegments.seg_code = HL7Segments.seg_code " + "and HL7MsgStructIDSegments.version_id = HL7Segments.version_id) " + "ON HL7Segments.version_id = HL7Versions.version_id " + "where HL7Versions.hl7_version = '" + version + "' and message_structure = '" + message + "' order by seq_no";
			return sql;
		}
		
		/// <summary> Returns header material for the source code of a Message class (including
		/// package, imports, JavaDoc, and class declaration).
		/// </summary>
		public static System.String makePreamble(StructureDef[] contents, System.String message, System.String chapter, System.String version)
		{
			System.Text.StringBuilder preamble = new System.Text.StringBuilder();
			preamble.Append("using System;\r\n");
			preamble.Append("using ca.uhn.log;\r\n");
			preamble.Append("using ");
			preamble.Append(SourceGenerator.getVersionPackageName(version));
			preamble.Append("group;\r\n");
			preamble.Append("using ");
			preamble.Append(SourceGenerator.getVersionPackageName(version));
			preamble.Append("segment;\r\n");
			preamble.Append("using ca.uhn.hl7v2;\r\n");
			preamble.Append("using ca.uhn.hl7v2.parser;\r\n");
			preamble.Append("using ca.uhn.hl7v2.model;\r\n\r\n");
			preamble.Append("/**\r\n");
			preamble.Append(" * <p>Represents a ");
			preamble.Append(message);
			preamble.Append(" message structure (see chapter ");
			preamble.Append(chapter);
			preamble.Append("). This structure contains the \r\n");
			preamble.Append(" * following elements: </p>\r\n");
			preamble.Append(GroupGenerator.makeElementsDoc(contents));
			preamble.Append(" */\r\n");
			preamble.Append("namespace ");
			preamble.Append(SourceGenerator.getVersionPackageName(version));
			preamble.Append("message\r\n\r\n");
			preamble.Append("{\r\n");
			preamble.Append("[Serializable]\r\n");
			preamble.Append("public class ");
			preamble.Append(message);
			preamble.Append(" : AbstractMessage ");
			
			//implement interface from model.control package if required
			/*Class correspondingControlInterface = Control.getInterfaceImplementedBy(message);
			if (correspondingControlInterface != null) {
			preamble.append("implements ");
			preamble.append(correspondingControlInterface.getName());
			}*/
			
			preamble.Append(" {\r\n\r\n");
			
			return preamble.ToString();
		}
		
		/// <summary> Returns source code for the contructor for this Message class.</summary>
		public static System.String makeConstructor(StructureDef[] structs, System.String messageName, System.String version)
		{
			//UPGRADE_ISSUE: Method 'java.lang.System.getProperty' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangSystem'"
			bool useFactory = ca.uhn.Properties.Settings.Default.useFactory;
			
			System.Text.StringBuilder source = new System.Text.StringBuilder();
			
			source.Append("\t/** \r\n");
			source.Append("\t * Creates a new ");
			source.Append(messageName);
			source.Append(" Group with custom ModelClassFactory.\r\n");
			source.Append("\t */\r\n");
			source.Append("\tpublic ");
			source.Append(messageName);
			source.Append("(ModelClassFactory factory) : base(factory){\r\n");
			source.Append("\t   init(factory);\r\n");
			source.Append("\t}\r\n\r\n");
			source.Append("\t/**\r\n");
			source.Append("\t * Creates a new ");
			source.Append(messageName);
			source.Append(" Group with DefaultModelClassFactory. \r\n");
			source.Append("\t */ \r\n");
			source.Append("\tpublic ");
			source.Append(messageName);
			source.Append("() : base(new DefaultModelClassFactory()) { \r\n");
			source.Append("\t   init(new DefaultModelClassFactory());\r\n");
			source.Append("\t}\r\n\r\n");
			source.Append("\tprivate void init(ModelClassFactory factory) {\r\n");
			source.Append("\t   try {\r\n");
			int numStructs = structs.Length;
			for (int i = 0; i < numStructs; i++)
			{
				StructureDef def = structs[i];
				if (useFactory)
				{
					source.Append("\t      this.add(factory.get");
					source.Append((def is GroupDef)?"Group":"Segment");
					source.Append("Class(\"");
					source.Append(def.Name);
					source.Append("\", \"");
					source.Append(version);
					source.Append("\"), ");
				}
				else
				{
					source.Append("\t      this.add(typeof(");
					source.Append(def.Name);
					source.Append("), ");
				}
				source.Append(def.Required.ToString().ToLower());
				source.Append(", ");
				source.Append(def.Repeating.ToString().ToLower());
				source.Append(");\r\n");
			}
			source.Append("\t   } catch(HL7Exception e) {\r\n");
			source.Append("\t      HapiLogFactory.getHapiLog(GetType()).error(\"Unexpected error creating ");
			source.Append(messageName);
			source.Append(" - this is probably a bug in the source code generator.\", e);\r\n");
			source.Append("\t   }\r\n");
			source.Append("\t}\r\n\r\n");
			return source.ToString();
		}
		
		/// <summary> Test harness ...</summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			if (args.Length != 3)
			{
				System.Console.Out.WriteLine("Usage: MessageGenerator message_name version source_dir");
				System.Environment.Exit(1);
			}
			System.String mess = args[0];
			System.Console.Out.WriteLine("Testing source gen for message " + mess);
			//System.setProperty("ca.on.uhn.hl7.database.url", "jdbc:odbc:hl7");
			try
			{
				//UPGRADE_TODO: The differences in the format  of parameters for method 'java.lang.Class.forName'  may cause compilation errors.  "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1092'"
				System.Type.GetType("sun.jdbc.odbc.JdbcOdbcDriver");
				make(mess, args[2], "0", args[1]);
				//makeAll(args[2], args[1]);            
			}
			catch (System.Exception e)
			{
				SupportClass.WriteStackTrace(e, Console.Error);
			}
		}
		static MessageGenerator()
		{
			log = HapiLogFactory.getHapiLog(typeof(MessageGenerator));
		}
	}
}