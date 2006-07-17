using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 MOC (Money and Code) data type.  Consists of the following components: </p><ol>
/// <li>Monetary Amount (MO)</li>
/// <li>Charge Code (CE)</li>
/// </ol>
///</summary>
[Serializable]
public class MOC : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a MOC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MOC(Message message) : this(message, null){}

	///<summary>
	/// Creates a MOC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MOC(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new MO(message,"Monetary Amount");
		data[1] = new CE(message,"Charge Code");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element MOC composite"); 
		} 
	} 
	///<summary>
	/// Returns Monetary Amount (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public MO MonetaryAmount {
get{
	   MO ret = null;
	   try {
	      ret = (MO)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Charge Code (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE ChargeCode {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}