using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 SPD (Specialty Description) data type.  Consists of the following components: </p><ol>
/// <li>Specialty Name (ST)</li>
/// <li>Governing Board (ST)</li>
/// <li>Eligible or Certified (ID)</li>
/// <li>Date of Certification (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class SPD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a SPD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SPD(Message message) : base(message){
		data = new Type[4];
		data[0] = new ST(message);
		data[1] = new ST(message);
		data[2] = new ID(message, 337);
		data[3] = new DT(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element SPD composite"); 
		} 
	} 
	///<summary>
	/// Returns Specialty Name (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SpecialtyName {
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
	/// Returns Governing Board (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST GoverningBoard {
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
	/// Returns Eligible or Certified (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID EligibleOrCertified {
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
	/// Returns Date of Certification (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT DateOfCertification {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}