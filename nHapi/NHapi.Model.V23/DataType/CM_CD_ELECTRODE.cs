using System;using NHapi.Base.model;
using ca.uhn.log;

namespace NHapi.Base.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_CD_ELECTRODE () data type.  Consists of the following components: </p><ol>
/// <li>source name 1 (ST)</li>
/// <li>source name 2 (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_CD_ELECTRODE : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_CD_ELECTRODE.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_CD_ELECTRODE(Message message) : base(message){
		data = new Type[2];
		data[0] = new ST(message);
		data[1] = new ST(message);
	}

	///<summary>
	/// Returns an array containing the data elements.
	///</summary>
	public Type[] Components
	{ 
		get{
			return this.data; 
		}
	}

	///<summary>
	/// Returns an individual data component.
	/// @throws DataTypeException if the given element number is out of range.
	///<param name="number">The ordinal item to get</param>
	///<returns>The data component (as a type) at the requested number (ordinal)</returns>
	///<summary>
	public Type getComponent(int number) { 

		try { 
			return this.data[number]; 
		} catch (System.ArgumentOutOfRangeException) { 
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_CD_ELECTRODE composite"); 
		} 
	} 
	///<summary>
	/// Returns source name 1 (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SourceName1 {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns source name 2 (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SourceName2 {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}