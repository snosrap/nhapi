using System;
using NHapi.Base.model;
namespace NHapi.Base.model.v24.datatype
{
///<summary>
///<p>Represents the HL7 FT (formatted text data) datatype.  A FT contains a single String value.
///<summary>
[Serializable]
public class FT : AbstractPrimitive  {

	///<summary>
	///Constructs an uninitialized FT.
	///<param name="message">The Message to which this Type belongs</param>
	///<summary>
	public FT(Message message) : base(message){
	}

	///<summary>
	///  @return "2.4"
	///</summary>
	public String getVersion() {
	    return "2.4";
}
}
}