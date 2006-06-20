using System;
using System.Collections;
using System.Text;
using System.Diagnostics;


namespace ca.uhn.log
{
	/// <summary>
	/// Logger implementation logging to Enterprise Library Logging Block.
	/// </summary>
	class EntLibLogger : Log
	{
		private const string DefaultDebugCategory = "Debug";
		#region Log Members

		/// <summary>
		/// EntLib does not allow us to check for DebugEnabled, so we return true always.  
		/// This can be filtered out at the configuration level.
		/// </summary>
		public bool DebugEnabled
		{
			
			get 
			{
				
				return false;}
		}

		public bool ErrorEnabled
		{
			get { return false; }
		}

		public bool FatalEnabled
		{
			get { return false; }
		}

		public bool InfoEnabled
		{
			get {return false; }
		}

		public bool TraceEnabled
		{
			get { return false; }
		}

		public bool WarnEnabled
		{
			get 
			{ 
				return false;
			}
		}

		public void debug(object message)
		{
			debug(message, null);
		}

		public void debug(object message, Exception t)
		{
			// Instead of setting a category, we use the Verbose severity to indicate
			// the need for debugging.  This avoids the need to have a consumer of 
			// the library setup a category in the logging configuration.
			WriteLog(message, t, System.Diagnostics.TraceLevel.Verbose);
		}

		public void error(object message)
		{
			error(message, null);
		}

		public void error(object message, Exception t)
		{
			WriteLog(message, t, System.Diagnostics.TraceLevel.Error);
		}

		public void fatal(object message)
		{
			fatal(message, null);
		}

		public void fatal(object message, Exception t)
		{
			WriteLog(message, t, System.Diagnostics.TraceLevel.Error);
		}

		public void info(object message)
		{
			info(message, null);
		}

		public void info(object message, Exception t)
		{
			WriteLog(message, t, System.Diagnostics.TraceLevel.Info);
		}

		public void trace(object message)
		{
			trace(message, null);
		}

		public void trace(object message, Exception t)
		{
			WriteLog(message, t, System.Diagnostics.TraceLevel.Info);
		}

		public void warn(object message)
		{
			warn(message, null);
		}

		public void warn(object message, Exception t)
		{
			WriteLog(message, t, System.Diagnostics.TraceLevel.Warning);
		}

		#endregion

		private static void WriteLog(object message, Exception t, System.Diagnostics.TraceLevel severity)
		{
			WriteLog(message, t, severity, null);
		}


		private static void WriteLog(object message, Exception t, System.Diagnostics.TraceLevel severity, string category)
		{
			TraceSwitch ts = new TraceSwitch("nHapi","nHapi Trace Switch");
			
			bool writeTrace=false;
			if(ts.Level>=severity)
				writeTrace=true;

			if(writeTrace)
			{
				Exception ex;
				if(message==null)
					ex = t;
				else
					ex = new Exception(message.ToString(),t);

				
				WriteTrace(ts, ex,category);           
			}	
		}

		private static void WriteTrace(TraceSwitch ts, Exception ex, string category)
		{
			if(category==null)
				Trace.WriteLine(ex);           
			else
				Trace.WriteLine(ex,category);           
		}

	}
}
