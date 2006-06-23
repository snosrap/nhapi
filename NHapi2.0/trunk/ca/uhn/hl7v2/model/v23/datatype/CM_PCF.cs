using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_PCF (Pre-certification required) data type.  Consists of the following components: </p><ol>
/// <li>pre-certification patient type (IS)</li>
/// <li>pre-certification required (ID)</li>
/// <li>pre-certification windwow (TS)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_PCF : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_PCF.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_PCF(Message message) : base(message){
		data = new Type[3];
		data[0] = new IS(message, 0);
		data[1] = new ID(message, 0);
		data[2] = new TS(message);
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
	public IS PreCertificationPatientType {
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
	/// Returns pre-certification required (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID PreCertificationRequired {
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
	/// Returns pre-certification windwow (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS PreCertificationWindwow {
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