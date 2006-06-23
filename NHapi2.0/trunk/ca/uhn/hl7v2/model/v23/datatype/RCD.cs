using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 RCD (row column definition) data type.  Consists of the following components: </p><ol>
/// <li>HL7 item number (ST)</li>
/// <li>HL7 date type (ST)</li>
/// <li>maximum column width (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class RCD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a RCD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RCD(Message message) : base(message){
		data = new Type[3];
		data[0] = new ST(message);
		data[1] = new ST(message);
		data[2] = new NM(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element RCD composite"); 
		} 
	} 
	///<summary>
	/// Returns HL7 item number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST HL7ItemNumber {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns HL7 date type (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST HL7DateType {
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
	/// Returns maximum column width (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MaximumColumnWidth {
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