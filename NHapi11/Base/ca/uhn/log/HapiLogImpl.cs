/*
* HapiLog.java
* 
* Created on May 7, 2003 at 2:23:45 PM
*/
using System;
namespace ca.uhn.log
{
	
	/// <summary> Provides a base implementation of the <code>HapiLog</code> interface.
	/// 
	/// It delegates all method calls declared by <code>Log</code> to the delegate specified in
	/// the contructor.
	/// 
	/// </summary>
	/// <author>  <a href="mailto:alexei.guevara@uhn.on.ca">Alexei Guevara</a>
	/// </author>
	/// <version>  $Revision: 1.1.1.1 $ updated on $Date: 2006/05/16 19:49:23 $ by $Author: whitedog12 $
	/// </version>
	public class HapiLogImpl : HapiLog
	{
		/// <returns>
		/// </returns>
		virtual public bool DebugEnabled
		{
			get
			{
				return innerLog.DebugEnabled;
			}
			
		}
		/// <returns>
		/// </returns>
		virtual public bool ErrorEnabled
		{
			get
			{
				return innerLog.ErrorEnabled;
			}
			
		}
		/// <returns>
		/// </returns>
		virtual public bool FatalEnabled
		{
			get
			{
				return innerLog.FatalEnabled;
			}
			
		}
		/// <returns>
		/// </returns>
		virtual public bool InfoEnabled
		{
			get
			{
				return innerLog.InfoEnabled;
			}
			
		}
		/// <returns>
		/// </returns>
		virtual public bool TraceEnabled
		{
			get
			{
				return innerLog.TraceEnabled;
			}
			
		}
		/// <returns>
		/// </returns>
		virtual public bool WarnEnabled
		{
			get
			{
				return innerLog.WarnEnabled;
			}
			
		}
		
		//UPGRADE_NOTE: Final was removed from the declaration of 'delegate '. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1003'"
		private Log innerLog;
		
		internal HapiLogImpl(Log log)
		{
			this.innerLog = log;
		}
		
		/// <param name="message">
		/// </param>
		public virtual void  debug(System.Object message)
		{
			innerLog.debug(message);
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="t">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public virtual void  debug(System.Object message, System.Exception t)
		{
			innerLog.debug(message, t);
		}
		
		/// <param name="message">
		/// </param>
		public virtual void  error(System.Object message)
		{
			innerLog.error(message);
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="t">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public virtual void  error(System.Object message, System.Exception t)
		{
			innerLog.error(message, t);
		}
		
		/// <param name="message">
		/// </param>
		public virtual void  fatal(System.Object message)
		{
			innerLog.fatal(message);
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="t">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public virtual void  fatal(System.Object message, System.Exception t)
		{
			innerLog.fatal(message, t);
		}
		
		/// <param name="message">
		/// </param>
		public virtual void  info(System.Object message)
		{
			innerLog.info(message);
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="t">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public virtual void  info(System.Object message, System.Exception t)
		{
			innerLog.info(message, t);
		}
		
		/* (non-Javadoc)
		* @see java.lang.Object#toString()
		*/
		public override System.String ToString()
		{
			return innerLog.ToString();
		}
		
		/// <param name="message">
		/// </param>
		public virtual void  trace(System.Object message)
		{
			innerLog.trace(message);
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="t">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public virtual void  trace(System.Object message, System.Exception t)
		{
			innerLog.trace(message, t);
		}
		
		/// <param name="message">
		/// </param>
		public virtual void  warn(System.Object message)
		{
			innerLog.warn(message);
		}
		
		/// <param name="message">
		/// </param>
		/// <param name="t">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public virtual void  warn(System.Object message, System.Exception t)
		{
			innerLog.warn(message, t);
		}
		
		/* (non-Javadoc)
		* @see ca.uhn.log.HapiLog#debug(java.lang.String, java.lang.Object[], java.lang.Throwable)
		*/
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		public virtual void  debug(System.String msgPattern, System.Object[] values, System.Exception t)
		{
			//UPGRADE_TODO: Method 'java.text.MessageFormat.format' was converted to 'System.String.Format' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073'"
			System.String message = System.String.Format(msgPattern, values);
			innerLog.debug(message, t);
		}
	}
}