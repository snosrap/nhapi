using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 TS (Time Stamp) data type.  Consists of the following components: </p><ol>
/// <li>Time (DTM)</li>
/// <li>Degree of Precision (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class TS : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a TS.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public TS(Message message) : base(message){
		data = new Type[2];
		data[0] = new DTM(message);
		data[1] = new ID(message, 529);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element TS composite"); 
		} 
	} 
	///<summary>
	/// Returns Time (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DTM Time {
get{
	   DTM ret = null;
	   try {
	      ret = (DTM)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Degree of Precision (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID DegreeOfPrecision {
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
}}