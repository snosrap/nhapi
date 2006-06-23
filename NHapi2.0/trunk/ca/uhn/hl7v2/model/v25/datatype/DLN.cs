using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 DLN (Driver_s License Number) data type.  Consists of the following components: </p><ol>
/// <li>License Number (ST)</li>
/// <li>Issuing State, Province, Country (IS)</li>
/// <li>Expiration Date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class DLN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a DLN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public DLN(Message message) : base(message){
		data = new Type[3];
		data[0] = new ST(message);
		data[1] = new IS(message, 333);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element DLN composite"); 
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
	/// Returns Issuing State, Province, Country (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS IssuingStateProvinceCountry {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Expiration Date (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ExpirationDate {
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