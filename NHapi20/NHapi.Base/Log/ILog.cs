using System;
using System.Collections.Generic;
using System.Text;

namespace NHapi.Base.Log
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>Added for conversion will need to replace.</remarks>
    public interface ILog
    {
        bool DebugEnabled { get;}
        bool ErrorEnabled { get;}
        bool FatalEnabled { get;}
        bool InfoEnabled { get;}
        bool TraceEnabled { get;}
        bool WarnEnabled { get;}


        void debug(System.Object message);
        void debug(System.Object message, System.Exception t);
        void error(System.Object message);
        void error(System.Object message, System.Exception t);
        void fatal(System.Object message);
        void fatal(System.Object message, System.Exception t);
        void info(System.Object message);
        void info(System.Object message, System.Exception t);
        void trace(System.Object message);
        void trace(System.Object message, System.Exception t);
        void warn(System.Object message);
        void warn(System.Object message, System.Exception t);

    }

    /// <summary>
    /// Dummy logger
    /// </summary>
    public sealed class DummyLogger : ILog
    {
        #region Log Members
        /// <summary>
        /// Is debug enabled
        /// </summary>
        public bool DebugEnabled
        {
            get { return false; }
        }

        /// <summary>
        /// Is error enabled
        /// </summary>
        public bool ErrorEnabled
        {
            get { return false; }
        }

        /// <summary>
        /// Is fatal enabled
        /// </summary>
        public bool FatalEnabled
        {
            get { return false; }
        }

        /// <summary>
        /// Is info enabled
        /// </summary>
        public bool InfoEnabled
        {
            get { return false; }
        }

        /// <summary>
        /// is trace enabled
        /// </summary>
        public bool TraceEnabled
        {
            get { return false; }
        }

        /// <summary>
        /// Is warn enabled
        /// </summary>
        public bool WarnEnabled
        {
            get { return false; }
        }

        /// <summary>
        /// Write debug message
        /// </summary>
        /// <param name="message"></param>
        public void debug(object message)
        {
            // No implementation
        }

        /// <summary>
        /// Write debug message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public void debug(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>
        /// Write error
        /// </summary>
        /// <param name="message"></param>
        public void error(object message)
        {
            // No implementation
        }

        /// <summary>
        /// Write error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public void error(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>
        /// Write fatal
        /// </summary>
        /// <param name="message"></param>
        public void fatal(object message)
        {
            // No implementation
        }

        /// <summary>
        /// Write fatal
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public void fatal(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>
        /// Write info
        /// </summary>
        /// <param name="message"></param>
        public void info(object message)
        {
            // No implementation
        }

        /// <summary>
        /// Write info
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public void info(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>
        /// Write trace
        /// </summary>
        /// <param name="message"></param>
        public void trace(object message)
        {
            // No implementation
        }

        /// <summary>
        /// Write trace
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public void trace(object message, Exception t)
        {
            // No implementation
        }

        /// <summary>
        /// Write warn
        /// </summary>
        /// <param name="message"></param>
        public void warn(object message)
        {
            // No implementation
        }

        /// <summary>
        /// Write warn
        /// </summary>
        /// <param name="message"></param>
        /// <param name="t"></param>
        public void warn(object message, Exception t)
        {
            // No implementation
        }

        #endregion
    }
}
