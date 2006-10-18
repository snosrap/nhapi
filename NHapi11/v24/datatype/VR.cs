using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 VR (value qualifier) data type.  Consists of the following components: </p><ol>
/// <li>first data code value (ST)</li>
/// <li>Last data code calue (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class VR : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a VR.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public VR(Message message) : this(message, null){}

	///<summary>
	/// Creates a VR.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public VR(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new ST(message,"First data code value");
		data[1] = new ST(message,"Last data code calue");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element VR composite"); 
		} 
	} 
	///<summary>
	/// Returns first data code value (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST FirstDataCodeValue {
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
	/// Returns Last data code calue (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST LastDataCodeCalue {
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