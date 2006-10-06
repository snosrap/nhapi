using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_BATCH_TOTAL (CM for Batch Totals) data type.  Consists of the following components: </p><ol>
/// <li>Batch total 1 (NM)</li>
/// <li>Batch total 2 (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_BATCH_TOTAL : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_BATCH_TOTAL.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_BATCH_TOTAL(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_BATCH_TOTAL.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_BATCH_TOTAL(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new NM(message,"Batch total 1");
		data[1] = new NM(message,"Batch total 2");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_BATCH_TOTAL composite"); 
		} 
	} 
	///<summary>
	/// Returns Batch total 1 (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM BatchTotal1 {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Batch total 2 (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM BatchTotal2 {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}