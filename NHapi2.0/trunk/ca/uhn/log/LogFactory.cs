using System;
using System.Collections.Generic;
using System.Text;

namespace ca.uhn.log
{
    /// <summary>
    /// Placeholder for LogFactory to get project to compile.
    /// </summary>
    class LogFactory
    {
        public static Log getLog(System.Type classType)
        {
            return new EntLibLogger();
        }

        public static Log getLog(System.String name)
        {
            return new EntLibLogger();
        }
    }
}
