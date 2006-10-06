using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_LA1 (Location with address information) data type.  Consists of the following components: </p><ol>
/// <li>Dispense / Deliver to Location (CM_INTERNAL_LOCATION)</li>
/// <li>location (AD)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_LA1 : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_LA1.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_LA1(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_LA1.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_LA1(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new CM_INTERNAL_LOCATION(message,"Dispense / Deliver to Location");
		data[1] = new AD(message,"Location");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_LA1 composite"); 
		} 
	} 
	///<summary>
	/// Returns Dispense / Deliver to Location (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CM_INTERNAL_LOCATION DispenseDeliverToLocation {
get{
	   CM_INTERNAL_LOCATION ret = null;
	   try {
	      ret = (CM_INTERNAL_LOCATION)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns location (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public AD Location {
get{
	   AD ret = null;
	   try {
	      ret = (AD)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}