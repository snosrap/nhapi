using System;

namespace ca.uhn.hl7v2.model.v25.datatype
{
	/// <summary>
	/// Summary description for DTM.
	/// </summary>
	public class DTM : ca.uhn.hl7v2.model.primitive.TSComponentOne
	{
		public DTM(Message message) : base(message)
		{
			
		}

		public DTM(Message message, string description) : base(message,description)
		{}

		
		public String getVersion() 
		{
			return "2.5";
		}

	}
}
