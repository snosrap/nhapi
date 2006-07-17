using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 PRL (parent result link) data type.  Consists of the following components: </p><ol>
/// <li>OBX-3 observation identifier of parent result (CE)</li>
/// <li>OBX-4 sub-ID of parent result (ST)</li>
/// <li>part of OBX-5 observation result from parent (TX)</li>
/// </ol>
///</summary>
[Serializable]
public class PRL : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a PRL.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PRL(Message message) : this(message, null){}

	///<summary>
	/// Creates a PRL.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PRL(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new CE(message,"OBX-3 observation identifier of parent result");
		data[1] = new ST(message,"OBX-4 sub-ID of parent result");
		data[2] = new TX(message,"Part of OBX-5 observation result from parent");
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
	/// Returns OBX-3 observation identifier of parent result (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE OBX3ObservationIdentifierOfParentResult {
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
	/// Returns OBX-4 sub-ID of parent result (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OBX4SubIDOfParentResult {
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
	/// Returns part of OBX-5 observation result from parent (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX PartOfOBX5ObservationResultFromParent {
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