using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 PT (Processing Type) data type.  Consists of the following components: </p><ol>
/// <li>Processing ID (ID)</li>
/// <li>Processing Mode (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class PT : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a PT.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PT(Message message) : this(message, null){}

	///<summary>
	/// Creates a PT.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PT(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new ID(message, 103,"Processing ID");
		data[1] = new ID(message, 207,"Processing Mode");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element PT composite"); 
		} 
	} 
	///<summary>
	/// Returns Processing ID (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID ProcessingID {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Processing Mode (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID ProcessingMode {
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