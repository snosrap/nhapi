using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 OSP (Occurrence Span Code and Date) data type.  Consists of the following components: </p><ol>
/// <li>Occurrence Span Code (CNE)</li>
/// <li>Occurrence Span Start Date (DT)</li>
/// <li>Occurrence Span Stop Date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class OSP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a OSP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public OSP(Message message) : base(message){
		data = new Type[3];
		data[0] = new CNE(message);
		data[1] = new DT(message);
		data[2] = new DT(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element OSP composite"); 
		} 
	} 
	///<summary>
	/// Returns Occurrence Span Code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CNE OccurrenceSpanCode {
get{
	   CNE ret = null;
	   try {
	      ret = (CNE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Occurrence Span Start Date (component #1).  This is a convenience method that saves you from 
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
	/// Returns Occurrence Span Stop Date (component #2).  This is a convenience method that saves you from 
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