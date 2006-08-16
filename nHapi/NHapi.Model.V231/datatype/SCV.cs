using System;using NHapi.Base.model;
using ca.uhn.log;

namespace NHapi.Base.model.v231.datatype
{

///<summary>
/// <p>The HL7 SCV (scheduling class value pair) data type.  Consists of the following components: </p><ol>
/// <li>parameter class (IS)</li>
/// <li>parameter value (IS)</li>
/// </ol>
///</summary>
[Serializable]
public class SCV : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a SCV.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SCV(Message message) : base(message){
		data = new Type[2];
		data[0] = new IS(message, 0);
		data[1] = new IS(message, 0);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element SCV composite"); 
		} 
	} 
	///<summary>
	/// Returns parameter class (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS ParameterClass {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns parameter value (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS ParameterValue {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}