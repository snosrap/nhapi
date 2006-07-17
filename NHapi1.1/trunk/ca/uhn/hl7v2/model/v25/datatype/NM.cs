using System;
using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v25.datatype
{
///<summary>
///<p>Represents the HL7 NM (Numeric) datatype.  A NM contains a single String value.
///<summary>
[Serializable]
public class NM : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized NM.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public NM(Message message) : base(message){
	}

	public NM(Message message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.5"
	///</summary>
	public string getVersion() {
	    return "2.5";
}
}
}