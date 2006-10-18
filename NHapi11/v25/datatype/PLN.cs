using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 PLN (Practitioner License or Other ID Number) data type.  Consists of the following components: </p><ol>
/// <li>ID Number (ST)</li>
/// <li>Type of ID Number (IS)</li>
/// <li>State/other Qualifying Information (ST)</li>
/// <li>Expiration Date (DT)</li>
/// </ol>
///</summary>
[Serializable]
public class PLN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a PLN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PLN(Message message) : this(message, null){}

	///<summary>
	/// Creates a PLN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PLN(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new ST(message,"ID Number");
		data[1] = new IS(message, 338,"Type of ID Number");
		data[2] = new ST(message,"State/other Qualifying Information");
		data[3] = new DT(message,"Expiration Date");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element PLN composite"); 
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
	/// Returns Type of ID Number (component #1).  This is a convenience method that saves you from 
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
	/// Returns State/other Qualifying Information (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST StateOtherQualifyingInformation {
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
	/// Returns Expiration Date (component #3).  This is a convenience method that saves you from 
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