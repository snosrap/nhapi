using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_DDI (daily deductible) data type.  Consists of the following components: </p><ol>
/// <li>delay days (NM)</li>
/// <li>amount (NM)</li>
/// <li>number of days (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_DDI : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_DDI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_DDI(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_DDI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_DDI(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new NM(message,"Delay days");
		data[1] = new NM(message,"Amount");
		data[2] = new NM(message,"Number of days");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_DDI composite"); 
		} 
	} 
	///<summary>
	/// Returns delay days (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM DelayDays {
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
	/// Returns amount (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Amount {
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
	/// Returns number of days (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM NumberOfDays {
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
}}