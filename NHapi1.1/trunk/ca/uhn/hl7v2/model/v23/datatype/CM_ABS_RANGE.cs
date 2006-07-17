using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_ABS_RANGE (absolute range) data type.  Consists of the following components: </p><ol>
/// <li>Range (CM_RANGE)</li>
/// <li>Numeric Change (NM)</li>
/// <li>Percent per Change (NM)</li>
/// <li>Days (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_ABS_RANGE : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_ABS_RANGE.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_ABS_RANGE(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_ABS_RANGE.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_ABS_RANGE(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new CM_RANGE(message,"Range");
		data[1] = new NM(message,"Numeric Change");
		data[2] = new NM(message,"Percent per Change");
		data[3] = new NM(message,"Days");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element CM_ABS_RANGE composite"); 
		} 
	} 
	///<summary>
	/// Returns Range (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CM_RANGE Range {
get{
	   CM_RANGE ret = null;
	   try {
	      ret = (CM_RANGE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Numeric Change (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM NumericChange {
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
	/// Returns Percent per Change (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM PercentPerChange {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Days (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Days {
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