using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CK_ACCOUNT_NO (Abrechnungsnummer) data type.  Consists of the following components: </p><ol>
/// <li>account number (NM)</li>
/// <li>Check digit (NM)</li>
/// <li>Check digit scheme (ID)</li>
/// <li>Facility ID (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CK_ACCOUNT_NO : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CK_ACCOUNT_NO.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CK_ACCOUNT_NO(Message message) : this(message, null){}

	///<summary>
	/// Creates a CK_ACCOUNT_NO.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CK_ACCOUNT_NO(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new NM(message,"Account number");
		data[1] = new NM(message,"Check digit");
		data[2] = new ID(message, 0,"Check digit scheme");
		data[3] = new ID(message, 0,"Facility ID");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element CK_ACCOUNT_NO composite"); 
		} 
	} 
	///<summary>
	/// Returns account number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM AccountNumber {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Check digit (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM CheckDigit {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Check digit scheme (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID CheckDigitScheme {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Facility ID (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID FacilityID {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}