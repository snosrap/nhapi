using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

///<summary>
/// <p>The HL7 FN (family + last name prefix) data type.  Consists of the following components: </p><ol>
/// <li>family name (ST)</li>
/// <li>last name prefix (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class FN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a FN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public FN(Message message) : this(message, null){}

	///<summary>
	/// Creates a FN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public FN(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new ST(message,"Family name");
		data[1] = new ST(message,"Last name prefix");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element FN composite"); 
		} 
	} 
	///<summary>
	/// Returns family name (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST FamilyName {
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
	/// Returns last name prefix (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST LastNamePrefix {
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