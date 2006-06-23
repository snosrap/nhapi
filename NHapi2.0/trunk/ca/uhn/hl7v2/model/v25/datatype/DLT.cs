using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 DLT (Delta) data type.  Consists of the following components: </p><ol>
/// <li>Normal Range (NR)</li>
/// <li>Numeric Threshold (NM)</li>
/// <li>Change Computation (ID)</li>
/// <li>Days Retained (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class DLT : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a DLT.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public DLT(Message message) : base(message){
		data = new Type[4];
		data[0] = new NR(message);
		data[1] = new NM(message);
		data[2] = new ID(message, 523);
		data[3] = new NM(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element DLT composite"); 
		} 
	} 
	///<summary>
	/// Returns Normal Range (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NR NormalRange {
get{
	   NR ret = null;
	   try {
	      ret = (NR)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Numeric Threshold (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM NumericThreshold {
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
	///<summary>
	/// Returns Change Computation (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID ChangeComputation {
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
	///<summary>
	/// Returns Days Retained (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM DaysRetained {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}