using System;
using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v21.datatype
{
///<summary>
///<p>Represents the HL7 TN (telephone number) datatype.  A TN contains a single String value.
///<summary>
[Serializable]
public class TN : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized TN.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public TN(Message message) : base(message){
	}

	public TN(Message message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.1"
	///</summary>
	public string getVersion() {
	    return "2.1";
}
}
}