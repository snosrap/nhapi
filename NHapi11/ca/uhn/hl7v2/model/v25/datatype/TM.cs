using System;

namespace ca.uhn.hl7v2.model.v25.datatype
{
	/// <summary>
	/// Summary description for TM.
	/// </summary>
	[Serializable]
	public class TM:ca.uhn.hl7v2.model.primitive.TM
	{
		/// <returns> "2.5"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.5";
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
