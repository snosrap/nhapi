using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_PLN (Practitioner ID Numbers) data type.  Consists of the following components: </p><ol>
/// <li>ID number (ST)</li>
/// <li>type of ID number (IS) (IS)</li>
/// <li>state/other qualifying info (ST)</li>
/// <li>expiration date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_PLN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_PLN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_PLN(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_PLN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_PLN(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new ST(message,"ID number");
		data[1] = new IS(message, 0,"Type of ID number (IS)");
		data[2] = new ST(message,"State/other qualifying info");
		data[3] = new DT(message,"Expiration date");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element CM_PLN composite"); 
		} 
	} 
	///<summary>
	/// Returns ID number (component #0).  This is a convenience method that saves you from 
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
	/// Returns type of ID number (IS) (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS TypeOfIDNumber {
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
	/// Returns state/other qualifying info (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST StateOtherQualifyingInfo {
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
	///<summary>
	/// Returns expiration date (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ExpirationDate {
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