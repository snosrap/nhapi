using System;

namespace ca.uhn.hl7v2.model.v21.datatype
{
	/// <summary>
	/// Summary description for DT.
	/// </summary>
	[Serializable]
	public class DT : ca.uhn.hl7v2.model.primitive.DT
	{
		/// <returns> "2.1"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.1";
			}
			
		}
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		public DT(Message theMessage):base(theMessage)
		{
		}
	}
}
