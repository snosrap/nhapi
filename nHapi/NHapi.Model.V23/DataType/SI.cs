using System;
using NHapi.Base.model;
namespace NHapi.Base.model.v23.datatype
{
///<summary>
///<p>Represents the HL7 SI (sequence ID) datatype.  A SI contains a single String value.
///<summary>
[Serializable]
public class SI : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized SI.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public SI(Message message) : base(message){
	}

	///<summary>
	///  @return "2.3"
	///</summary>
	public String getVersion() {
	    return "2.3";
}
}
}