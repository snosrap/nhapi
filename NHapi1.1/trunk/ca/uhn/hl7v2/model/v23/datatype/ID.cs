using System;

namespace ca.uhn.hl7v2.model.v23.datatype
{
	/// <summary>
	/// Summary description for ID.
	/// </summary>
	public class ID:ca.uhn.hl7v2.model.primitive.ID
	{
		/// <returns> "2.3"
		/// </returns>
		virtual public System.String Version
		{
			get
			{
				return "2.3";
			}
			
		}
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		/// <param name="theTable">HL7 table from which values are to be drawn 
		/// </param>
		public ID(Message theMessage, int theTable):base(theMessage, theTable)
		{
		}
		
		/// <param name="theMessage">message to which this Type belongs
		/// </param>
		/// <param name="theTable">HL7 table from which values are to be drawn 
		/// </param>
		//UPGRADE_NOTE: ref keyword was added to struct-type parameters. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1303'"
		//UPGRADE_ISSUE: Parameter of type 'java.lang.Integer' was migrated to type 'Int32' which is identical to 'int'. You will get a compilation error with method overloads. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1205'"
		//UPGRADE_NOTE: ref keyword was added to struct-type parameters. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1303'"
		public ID(Message theMessage, ref System.Int32 theTable):base(theMessage, ref theTable)
		{
		}
	}
}
