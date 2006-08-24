/*
* HapiLog.java
* 
* Created on May 7, 2003 at 2:23:45 PM
*/
using System;
namespace NHapi.Base.Log
{
	
	/// <summary> Provides a base implementation of the <code>HapiLog</code> interface.
	/// 
	/// It delegates all method calls declared by <code>Log</code> to the delegate specified in
	/// the contructor.
	/// 
	/// </summary>
	/// <author>  <a href="mailto:alexei.guevara@uhn.on.ca">Alexei Guevara</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2003/05/26 20:17:06 $ by $Author: aguevara $
	/// </version>
	public class HapiLogImpl : IHapiLog
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
		
		private ILog innerLog;
		
		internal HapiLogImpl(ILog log)
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
		public virtual void  info(System.Object message, System.Exception t)
		{
			innerLog.info(message, t);
		}
		
		
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
		public virtual void  warn(System.Object message, System.Exception t)
		{
			innerLog.warn(message, t);
		}
		
	
		public virtual void  debug(System.String msgPattern, System.Object[] values, System.Exception t)
		{
			System.String message = System.String.Format(msgPattern, values);
			innerLog.debug(message, t);
		}
	}
}