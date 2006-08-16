using System;
using NHapi.Base.model;
using ca.uhn.log;

namespace NHapi.Base.model.v24.datatype
{

///<summary>
/// <p>The HL7 RI (repeat interval) data type.  Consists of the following components: </p><ol>
/// <li>repeat pattern (IS)</li>
/// <li>explicit time interval (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class RI : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a RI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RI(Message message) : base(message){
		data = new Type[2];
		data[0] = new IS(message, 0);
		data[1] = new ST(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element RI composite"); 
		} 
	} 
	///<summary>
	/// Returns repeat pattern (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS RepeatPattern {
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
	/// Returns explicit time interval (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ExplicitTimeInterval {
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