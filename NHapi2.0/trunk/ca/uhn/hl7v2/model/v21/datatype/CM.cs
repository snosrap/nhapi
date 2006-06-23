/*
* Created on 6-Jun-2005
*/
using System;
using GenericComposite = ca.uhn.hl7v2.model.GenericComposite;
using Message = ca.uhn.hl7v2.model.Message;
namespace ca.uhn.hl7v2.model.v21.datatype
{
	
	/// <summary> Version 2.1 contains a number of unspecified CM datatypes, which we model as 
	/// GenericComposites.  The type of each CM component can be set as needed, after 
	/// parsing a message.  
	/// 
	/// </summary>
	/// <author>  <a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a>
	/// </author>
	/// <version>  $Revision: 1.2 $ updated on $Date: 2005/06/08 00:28:25 $ by $Author: bryan_tripp $
	/// </version>
	public class CM:GenericComposite
	{
		/// <summary>Returns the name of the type (used in XML encoding and profile checking)  </summary>
		override public System.String Name
		{
			get
			{
				return "CM";
			}
			
		}
		
		/// <param name="message">message to which this Type belongs
		/// </param>
		public CM(Message message):base(message)
		{
		}
	}
}