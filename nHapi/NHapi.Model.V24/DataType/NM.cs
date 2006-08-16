using System;
using NHapi.Base.model;
namespace NHapi.Base.model.v24.datatype
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
	public NM(Message message) : base(message){
	}

	///<summary>
	///  @return "2.4"
	///</summary>
	public String getVersion() {
	    return "2.4";
}
}
}