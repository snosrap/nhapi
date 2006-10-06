using System;

namespace ca.uhn.hl7v2.model.v24.datatype
{
	/// <summary>
	/// Summary description for TM.
	/// </summary>
	public class TM:ca.uhn.hl7v2.model.primitive.TM
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
		public TM(Message theMessage):base(theMessage)
		{
		}

		public TM(Message theMessage, string description):base(theMessage, description)
		{
		}
	}
}
