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

    public sealed class DummyLogger : ILog
    {
        #region Log Members

        public bool DebugEnabled
        {
            get {return false;}
        }

        public bool ErrorEnabled
        {
            get {return false;}
        }

        public bool FatalEnabled
        {
            get {return false;}
        }

        public bool InfoEnabled
        {
            get {return false;}
        }

        public bool TraceEnabled
        {
            get {return false;}
        }

        public bool WarnEnabled
        {
            get { return false; }
        }

        public void debug(object message)
        {
            // No implementation
        }

        public void debug(object message, Exception t)
        {
            // No implementation
        }

        public void error(object message)
        {
            // No implementation
        }

        public void error(object message, Exception t)
        {
            // No implementation
        }

        public void fatal(object message)
        {
            // No implementation
        }

        public void fatal(object message, Exception t)
        {
            // No implementation
        }

        public void info(object message)
        {
            // No implementation
        }

        public void info(object message, Exception t)
        {
            // No implementation
        }

        public void trace(object message)
        {
            // No implementation
        }

        public void trace(object message, Exception t)
        {
            // No implementation
        }

        public void warn(object message)
        {
            // No implementation
        }

        public void warn(object message, Exception t)
        {
            // No implementation
        }

        #endregion
    }
}
