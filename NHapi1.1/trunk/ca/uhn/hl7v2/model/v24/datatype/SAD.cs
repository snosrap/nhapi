using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 SAD (street address) data type.  Consists of the following components: </p><ol>
/// <li>street or mailing address (ST)</li>
/// <li>street name (ST)</li>
/// <li>dwelling number (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class SAD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a SAD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SAD(Message message) : this(message, null){}

	///<summary>
	/// Creates a SAD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SAD(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new ST(message,"Street or mailing address");
		data[1] = new ST(message,"Street name");
		data[2] = new ST(message,"Dwelling number");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element SAD composite"); 
		} 
	} 
	///<summary>
	/// Returns street or mailing address (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST StreetOrMailingAddress {
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
	/// Returns street name (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST StreetName {
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
	/// Returns dwelling number (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST DwellingNumber {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}