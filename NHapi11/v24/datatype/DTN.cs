using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 DTN (Day Type and Number) data type.  Consists of the following components: </p><ol>
/// <li>day type (IS)</li>
/// <li>number of days (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class DTN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a DTN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public DTN(Message message) : this(message, null){}

	///<summary>
	/// Creates a DTN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public DTN(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new IS(message, 0,"Day type");
		data[1] = new NM(message,"Number of days");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element DTN composite"); 
		} 
	} 
	///<summary>
	/// Returns day type (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS DayType {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns number of days (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM NumberOfDays {
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