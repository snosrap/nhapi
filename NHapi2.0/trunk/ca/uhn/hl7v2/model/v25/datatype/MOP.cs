using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 MOP (Money or Percentage) data type.  Consists of the following components: </p><ol>
/// <li>Money or Percentage Indicator (ID)</li>
/// <li>Money or Percentage Quantity (NM)</li>
/// <li>Currency Denomination (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class MOP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a MOP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MOP(Message message) : base(message){
		data = new Type[3];
		data[0] = new ID(message, 148);
		data[1] = new NM(message);
		data[2] = new ID(message, 0);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element MOP composite"); 
		} 
	} 
	///<summary>
	/// Returns Money or Percentage Indicator (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID MoneyOrPercentageIndicator {
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
	/// Returns Money or Percentage Quantity (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MoneyOrPercentageQuantity {
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
	/// Returns Currency Denomination (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID CurrencyDenomination {
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
}}