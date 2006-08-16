using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Filters;

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
            get { return Logger.Writer.IsLoggingEnabled(); }
        }

        public bool ErrorEnabled
        {
            get { return Logger.Writer.IsLoggingEnabled(); }
        }

        public bool FatalEnabled
        {
            get { return Logger.Writer.IsLoggingEnabled(); }
        }

        public bool InfoEnabled
        {
            get { return Logger.Writer.IsLoggingEnabled(); }
        }

        public bool TraceEnabled
        {
            get { return Logger.Writer.IsLoggingEnabled(); }
        }

        public bool WarnEnabled
        {
            get { return Logger.Writer.IsLoggingEnabled(); }
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
            WriteLog(message, t, System.Diagnostics.TraceEventType.Verbose);
        }

        public void error(object message)
        {
           error(message, null);
        }

        public void error(object message, Exception t)
        {
           WriteLog(message, t, System.Diagnostics.TraceEventType.Error);
        }

        public void fatal(object message)
        {
            fatal(message, null);
        }

        public void fatal(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceEventType.Critical);
        }

        public void info(object message)
        {
            info(message, null);
        }

        public void info(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceEventType.Information);
        }

        public void trace(object message)
        {
            trace(message, null);
        }

        public void trace(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceEventType.Information);
        }

        public void warn(object message)
        {
            warn(message, null);
        }

        public void warn(object message, Exception t)
        {
            WriteLog(message, t, System.Diagnostics.TraceEventType.Warning);
        }

        #endregion

        private static void WriteLog(object message, Exception t, System.Diagnostics.TraceEventType severity)
        {
            WriteLog(message, t, severity, null);
        }


        private static void WriteLog(object message, Exception t, System.Diagnostics.TraceEventType severity, string category)
        {
            LogEntry le = new LogEntry();
            le.Severity = severity;
            le.Message = message.ToString();
            if (null != category && !string.Empty.Equals(category))
            {
                le.Categories.Add(category);
            }
            if (null != t)
                le.AddErrorMessage(t.ToString());
            Logger.Write(le);
        }

    }
}
