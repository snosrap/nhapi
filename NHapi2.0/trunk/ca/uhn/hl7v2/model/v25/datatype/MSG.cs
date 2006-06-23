using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 MSG (Message Type) data type.  Consists of the following components: </p><ol>
/// <li>Message Code (ID)</li>
/// <li>Trigger Event (ID)</li>
/// <li>Message Structure (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class MSG : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a MSG.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MSG(Message message) : base(message){
		data = new Type[3];
		data[0] = new ID(message, 76);
		data[1] = new ID(message, 3);
		data[2] = new ID(message, 354);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element MSG composite"); 
		} 
	} 
	///<summary>
	/// Returns Message Code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID MessageCode {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Trigger Event (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID TriggerEvent {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Message Structure (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID MessageStructure {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}