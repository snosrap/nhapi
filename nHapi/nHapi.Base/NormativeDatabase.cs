/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "NormativeDatabase.java".  Description: 
/// "Point of access to a copy of the HL7 normative database" 
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
using System.Data;
using NHapi.Base.Log;

namespace NHapi.Base
{
	
	/// <summary> <p>Point of access to a copy of the HL7 normative database.  A typical way of 
	/// obtaining and using a database connection would be ...</p>
	/// <p><code>Connection c = NormativeDatabase.getInstance().getConnection();<br>
	/// // ... use the database ... <br>
	/// NormativeDatabase.returnConnection(c);</code></p>
	/// <p>Since the database may be installed differently on different systems, certain system
	/// properties must be set with the required connection information, as follows: </p>
	/// <p><code>ca.on.uhn.hl7.database.url</code> - the URL of the JDBC connection<br>
	/// <code>ca.on.uhn.hl7.database.user</code> - the user ID needed to connect (if required)<br>
	/// <code>ca.on.uhn.hl7.database.passsword</code> - the password associated with the above user 
	/// (if required)</p>
	/// <p>The required JDBC driver must also be loaded (this can be done by ensuring that the 
	/// required driver appears in the classpath and appending the class name to the 
	/// "jdbc.drivers" system property.  
	/// </summary>
	/// <author>  Bryan Tripp (bryan_tripp@sourceforge.net)
	/// </author>
	public class NormativeDatabase
	{
		/// <summary> Returns the singleton instance of NormativeDatabase.  </summary>
		//UPGRADE_NOTE: Synchronized keyword was removed from method 'getInstance'. Lock expression was added. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1027'"
		private System.Data.OleDb.OleDbConnection _conn;
		public static NormativeDatabase Instance
		{
			get
			{
				lock (typeof(NHapi.Base.NormativeDatabase))
				{
					if (db == null)
					{
						db = new NormativeDatabase();
					}
					return db;
				}
			}
			
		}
		/// <summary> Provides a Connection to the normative database. 
		/// A new connection may be created if none are available.
		/// </summary>
		//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
		//UPGRADE_NOTE: Synchronized keyword was removed from method 'getConnection'. Lock expression was added. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1027'"
		virtual public System.Data.OleDb.OleDbConnection Connection
		{
			get
			{
				lock (this)
				{
					//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
						try
						{
                            if (_conn.State != ConnectionState.Open)
							_conn.Open();
						}
					catch(Exception)
					{
						_conn = new System.Data.OleDb.OleDbConnection(_connectionString);
						_conn.Open();
					}
					return _conn;
				}
			}
			
		}
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'log '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		//UPGRADE_NOTE: The initialization of  'log' was moved to static method 'NHapi.Base.NormativeDatabase'. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1005'"
		private static readonly IHapiLog log;
		
		private static NormativeDatabase db = null;
		private string _connectionString;
		
		/// <summary> Private constructor ... checks system properties for connection 
		/// information
		/// </summary>
		private NormativeDatabase()
		{
			//UPGRADE_ISSUE: Method 'java.lang.System.getProperty' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangSystem'"
			_connectionString = Properties.Settings.Default.ConnectionString;
			_conn = new System.Data.OleDb.OleDbConnection(_connectionString);
			_conn.Open();
		}
		
		/// <summary> Used to return an HL7 normative database connection to the connection pool.  If the
		/// given connection is not in fact a connection to the normative database, it is
		/// discarded. 
		/// </summary>
		//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
		public virtual void  returnConnection(System.Data.OleDb.OleDbConnection conn)
		{
			//check if this is a normative DB connection 
			_conn.Close();
		}
		
		//test
		[STAThread]
		public static void  Main(System.String[] args)
		{
			try
			{
				//UPGRADE_TODO: The differences in the format  of parameters for method 'java.lang.Class.forName'  may cause compilation errors.  "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1092'"
				System.Type.GetType("sun.jdbc.odbc.JdbcOdbcDriver");
				//UPGRADE_ISSUE: Method 'java.lang.System.setProperty' was not converted. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1000_javalangSystem'"
				//System_Renamed.setProperty("ca.on.uhn.hl7.database.url", "jdbc:odbc:hl7v25");
                // Above line not supported...
				//UPGRADE_NOTE: There are other database providers or managers under System.Data namespace which can be used optionally to better fit the application requirements. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1208'"
				System.Data.OleDb.OleDbConnection conn = NormativeDatabase.Instance.Connection;
				//UPGRADE_TODO: Method 'java.sql.Connection.createStatement' was converted to 'SupportClass.TransactionManager.manager.CreateStatement' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlConnectioncreateStatement'"
				System.Data.OleDb.OleDbCommand stmt = SupportClass.TransactionManager.manager.CreateStatement(conn);
				//UPGRADE_TODO: Interface 'java.sql.ResultSet' was converted to 'System.Data.OleDb.OleDbDataReader' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javasqlResultSet'"
				System.Data.OleDb.OleDbCommand temp_OleDbCommand;
				temp_OleDbCommand = stmt;
				temp_OleDbCommand.CommandText = "select * from TableValues";
				System.Data.OleDb.OleDbDataReader rs = temp_OleDbCommand.ExecuteReader();
				while (rs.Read())
				{
					System.Object tabNum = rs.GetValue(1 - 1);
					System.Object val = rs.GetValue(3 - 1);
					System.Object desc = rs.GetValue(4 - 1);
					//UPGRADE_TODO: The equivalent in .NET for method 'java.lang.Object.toString' may return a different value. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1043'"
					System.Console.Out.WriteLine("Table: " + tabNum + " Value: " + val + " Description: " + desc);
				}
			}
			catch (System.Data.OleDb.OleDbException e)
			{
				log.error("test msg!!", e);
			}
			//UPGRADE_NOTE: Exception 'java.lang.ClassNotFoundException' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
			catch (System.Exception e)
			{
				log.error("test msg!!", e);
			}
		}
		static NormativeDatabase()
		{
			log = HapiLogFactory.getHapiLog(typeof(NormativeDatabase));
		}
	}
}