using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 CX (Extended Composite ID with Check Digit) data type.  Consists of the following components: </p><ol>
/// <li>ID Number (ST)</li>
/// <li>Check Digit (ST)</li>
/// <li>Check Digit Scheme (ID)</li>
/// <li>Assigning Authority (HD)</li>
/// <li>Identifier Type Code (ID)</li>
/// <li>Assigning Facility (HD)</li>
/// <li>Effective Date (DT)</li>
/// <li>Expiration Date (DT)</li>
/// <li>Assigning Jurisdiction (CWE)</li>
/// <li>Assigning Agency or Department (CWE)</li>
/// </ol>
///</summary>
[Serializable]
public class CX : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CX.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CX(Message message) : base(message){
		data = new Type[10];
		data[0] = new ST(message);
		data[1] = new ST(message);
		data[2] = new ID(message, 61);
		data[3] = new HD(message);
		data[4] = new ID(message, 203);
		data[5] = new HD(message);
		data[6] = new DT(message);
		data[7] = new DT(message);
		data[8] = new CWE(message);
		data[9] = new CWE(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 10 element CX composite"); 
		} 
	} 
	///<summary>
	/// Returns ID Number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST IDNumber {
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
	/// Returns Check Digit (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST CheckDigit {
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
	/// Returns Check Digit Scheme (component #2).  This is a convenience method that saves you from 
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
	/// Returns Assigning Authority (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public HD AssigningAuthority {
get{
	   HD ret = null;
	   try {
	      ret = (HD)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Identifier Type Code (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID IdentifierTypeCode {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Assigning Facility (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public HD AssigningFacility {
get{
	   HD ret = null;
	   try {
	      ret = (HD)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Effective Date (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT EffectiveDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Expiration Date (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ExpirationDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Assigning Jurisdiction (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE AssigningJurisdiction {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(8);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Assigning Agency or Department (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE AssigningAgencyOrDepartment {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(9);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}