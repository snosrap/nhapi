using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_PCF (Pre-certification required) data type.  Consists of the following components: </p><ol>
/// <li>pre-certification patient type (ID)</li>
/// <li>pre-certication required (ID)</li>
/// <li>pre-certification window (TS)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_PCF : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_PCF.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_PCF(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_PCF.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_PCF(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new ID(message, 0,"Pre-certification patient type");
		data[1] = new ID(message, 0,"Pre-certication required");
		data[2] = new TS(message,"Pre-certification window");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_PCF composite"); 
		} 
	} 
	///<summary>
	/// Returns pre-certification patient type (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID PreCertificationPatientType {
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
	/// Returns pre-certication required (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID PreCerticationRequired {
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
	///<summary>
	/// Returns pre-certification window (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS PreCertificationWindow {
get{
	   TS ret = null;
	   try {
	      ret = (TS)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}