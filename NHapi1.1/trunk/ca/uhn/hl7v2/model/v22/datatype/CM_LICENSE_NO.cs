using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_LICENSE_NO (CM für Führerscheinlizenzen) data type.  Consists of the following components: </p><ol>
/// <li>License Number (ST)</li>
/// <li>issuing state,province,country (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_LICENSE_NO : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_LICENSE_NO.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_LICENSE_NO(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_LICENSE_NO.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_LICENSE_NO(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new ST(message,"License Number");
		data[1] = new ST(message,"Issuing state,province,country");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_LICENSE_NO composite"); 
		} 
	} 
	///<summary>
	/// Returns License Number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST LicenseNumber {
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
	/// Returns issuing state,province,country (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST IssuingStateProvinceCountry {
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