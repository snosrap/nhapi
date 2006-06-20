using System;

namespace ca.uhn.hl7v2.model.v24.datatype
{
	/// <summary>
	/// Summary description for DT.
	/// </summary>
	public class DT:ca.uhn.hl7v2.model.primitive.DT
	{
		/// <returns> "2.4"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.4";
			}
			
		}
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		public DT(Message theMessage):base(theMessage)
		{
		}
	}
}
