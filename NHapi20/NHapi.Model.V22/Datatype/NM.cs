using System;
using NHapi.Base.Model;
using NHapi.Base;
using NHapi.Base.Model.Primitive;
namespace NHapi.Model.V22.Datatype
{
///<summary>
///<p>Represents the HL7 NM (numeric) datatype.  A NM contains a single String value.
///<summary>
[Serializable]
public class NM : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized NM.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public NM(IMessage message) : base(message){
	}

	public NM(IMessage message, string description) : base(message,description){
	}

	///<summary>
	///  @return "2.2"
	///</summary>
	public string getVersion() {
	    return "2.2";
}
}
}