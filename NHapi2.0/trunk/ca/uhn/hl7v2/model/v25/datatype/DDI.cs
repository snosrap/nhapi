using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 DDI (Daily Deductible Information) data type.  Consists of the following components: </p><ol>
/// <li>Delay Days (NM)</li>
/// <li>Monetary Amount (MO)</li>
/// <li>Number of Days (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class DDI : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a DDI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public DDI(Message message) : base(message){
		data = new Type[3];
		data[0] = new NM(message);
		data[1] = new MO(message);
		data[2] = new NM(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element DDI composite"); 
		} 
	} 
	///<summary>
	/// Returns Delay Days (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM DelayDays {
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
	/// Returns Monetary Amount (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public MO MonetaryAmount {
get{
	   MO ret = null;
	   try {
	      ret = (MO)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Number of Days (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM NumberOfDays {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}