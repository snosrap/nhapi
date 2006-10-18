using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

///<summary>
/// <p>The HL7 MSG (Message Type) data type.  Consists of the following components: </p><ol>
/// <li>message type (ID)</li>
/// <li>trigger event (ID)</li>
/// <li>message structure (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class MSG : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a MSG.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MSG(Message message) : this(message, null){}

	///<summary>
	/// Creates a MSG.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MSG(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new ID(message, 0,"Message type");
		data[1] = new ID(message, 0,"Trigger event");
		data[2] = new ID(message, 0,"Message structure");
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
	/// Returns message type (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID MessageType {
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
	/// Returns trigger event (component #1).  This is a convenience method that saves you from 
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
	/// Returns message structure (component #2).  This is a convenience method that saves you from 
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