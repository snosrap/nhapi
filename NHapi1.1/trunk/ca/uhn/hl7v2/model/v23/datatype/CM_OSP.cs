using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_OSP (occurence span) data type.  Consists of the following components: </p><ol>
/// <li>occurrence span code (CE)</li>
/// <li>occurrence span start date (DT)</li>
/// <li>occurrence span stop date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_OSP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_OSP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_OSP(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_OSP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_OSP(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new CE(message,"Occurrence span code");
		data[1] = new DT(message,"Occurrence span start date");
		data[2] = new DT(message,"Occurrence span stop date");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_OSP composite"); 
		} 
	} 
	///<summary>
	/// Returns occurrence span code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE OccurrenceSpanCode {
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
	/// Returns occurrence span start date (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT OccurrenceSpanStartDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns occurrence span stop date (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT OccurrenceSpanStopDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}