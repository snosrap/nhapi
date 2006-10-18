using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 WVS (waveform source) data type.  Consists of the following components: </p><ol>
/// <li>source name 1 (ST)</li>
/// <li>source name 2 (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class WVS : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a WVS.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public WVS(Message message) : this(message, null){}

	///<summary>
	/// Creates a WVS.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public WVS(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new ST(message,"Source name 1");
		data[1] = new ST(message,"Source name 2");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element WVS composite"); 
		} 
	} 
	///<summary>
	/// Returns source name 1 (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SourceName1 {
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
	/// Returns source name 2 (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SourceName2 {
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
}}