/*
* HapiLog.java
* 
* Created on May 7, 2003 at 3:53:44 PM
*/
using System;
//UPGRADE_TODO: The type 'org.apache.commons.logging.Log' could not be found. If it was not included in the conversion, there may be compiler issues. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1262'"
//using Log = org.apache.commons.logging.Log;
namespace NHapi.Base.Log
{
	
	/// <summary> A logging interface that enhances the <code> Log </code>
	/// interface with ancillary method to easy up the log messages generation
	/// by adding MessageFormat like functionality.
	/// 
	/// Instantiate using {@link HapiLogFactory#getLog( Class clazz)}
	/// or {@link HapiLogFactory#getLog( String name)}
	/// 
	/// <pre>
	/// USASE PATTERN:
	/// (look at the jakarta-commons-logging and log4j documentation first)
	/// 
	/// ...
	/// import ca.uhn.log.*;
	/// ...
	/// class A {
	/// private static final HapiLog log = HapiLogFactory.getHapiLog( A.class );
	/// 
	/// public boolean methodA( Object param1 ) {
	/// boolean retVal = true;
	/// 
	/// //log debug messages (to be printed only when the debug mode is specified
	/// //in the configuration file)
	/// log.debug( "param1 = " + param1 );
	/// 
	/// Object copy = null;
	/// try {
	/// copy = param1.clone();
	/// }
	/// catch( CloneNotSupportedException e ) {
	/// //log the error
	/// log.error( "param1 must be cloneable", e );
	/// retVal = false;
	/// }
	/// 
	/// log.debug( "retVal = " + retVal );
	/// return retVal;
	/// }
	/// 
	/// ...
	/// 
	/// }
	/// </pre>
	/// 
	/// </summary>
	/// <author>  <a href="mailto:alexei.guevara@uhn.on.ca">Alexei Guevara</a>
	/// </author>
	/// <version>  $Revision: 1.4 $ updated on $Date: 2003/09/11 21:51:21 $ by $Author: bryan_tripp $
	/// </version>
    /// TODO: HapiLog inherited from base Log interface using Log = org.apache.commons.logging.Log;
	public interface IHapiLog:ILog
	{
		
		/// <summary> </summary>
		/// <seealso cref="MessageFormat.format( ... )">
		/// 
		/// </seealso>
		/// <param name="msgPattern">
		/// </param>
		/// <param name="values">
		/// </param>
		/// <param name="e">
		/// </param>
		//UPGRADE_NOTE: Exception 'java.lang.Throwable' was converted to 'System.Exception' which has different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1100'"
		void  debug(System.String msgPattern, System.Object[] values, System.Exception e);
	}
}