using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 DR (Date/Time Range) data type.  Consists of the following components: </p><ol>
/// <li>Range Start Date/Time (TS)</li>
/// <li>Range End Date/Time (TS)</li>
/// </ol>
///</summary>
[Serializable]
public class DR : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a DR.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public DR(Message message) : base(message){
		data = new Type[2];
		data[0] = new TS(message);
		data[1] = new TS(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element DR composite"); 
		} 
	} 
	///<summary>
	/// Returns Range Start Date/Time (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS RangeStartDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Range End Date/Time (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS RangeEndDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}