using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v23.datatype

{
	///<summary>
	///<p>Represents the HL7 ST (string data) datatype.  A ST contains a single String value.
	///<summary>
	public class ST : AbstractPrimitive  
	{

		///<summary>
		///Constructs an uninitialized ST.
		///<param name="message">The Message to which this Type belongs</param>
		///<summary>
		public ST(Message message) : base(message)
		{
		}

		///<summary>
		///  @return "2.3"
		///</summary>
		public string getVersion() 
		{
			return "2.3";
		}

	}
}