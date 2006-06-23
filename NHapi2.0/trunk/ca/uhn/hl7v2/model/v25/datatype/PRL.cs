using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 PRL (Parent Result Link) data type.  Consists of the following components: </p><ol>
/// <li>Parent Observation Identifier (CE)</li>
/// <li>Parent Observation Sub-identifier (ST)</li>
/// <li>Parent Observation Value Descriptor (TX)</li>
/// </ol>
///</summary>
[Serializable]
public class PRL : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a PRL.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PRL(Message message) : base(message){
		data = new Type[3];
		data[0] = new CE(message);
		data[1] = new ST(message);
		data[2] = new TX(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element PRL composite"); 
		} 
	} 
	///<summary>
	/// Returns Parent Observation Identifier (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE ParentObservationIdentifier {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Parent Observation Sub-identifier (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ParentObservationSubIdentifier {
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
	///<summary>
	/// Returns Parent Observation Value Descriptor (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX ParentObservationValueDescriptor {
get{
	   TX ret = null;
	   try {
	      ret = (TX)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}