using System;
using ca.uhn.hl7v2.model;
namespace ca.uhn.hl7v2.model.v25.datatype
{
///<summary>
///<p>Represents the HL7 SI (Sequence ID) datatype.  A SI contains a single String value.
///<summary>
[Serializable]
public class SI : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized SI.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public SI(Message message) : base(message){
	}

	public SI(Message message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.5"
	///</summary>
	public string getVersion() {
	    return "2.5";
}
}
}