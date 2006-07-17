using System;

namespace ca.uhn.hl7v2.model.v22.datatype
{
	/// <summary>
	/// Summary description for ID.
	/// </summary>
	public class ID:ca.uhn.hl7v2.model.primitive.ID
	{
		/// <returns> "2.2"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.2";
			}
			
		}
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		/// <param name="theTable">HL7 table from which values are to be drawn 
		/// </param>
		public ID(Message theMessage, int theTable):base(theMessage, theTable)
		{
		}
		

		public ID(Message theMessage, System.Int32 theTable, string description):base(theMessage, theTable, description)
		{
		}
	}
}
