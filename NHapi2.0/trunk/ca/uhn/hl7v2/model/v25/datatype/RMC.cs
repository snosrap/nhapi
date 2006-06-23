using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 RMC (Room Coverage) data type.  Consists of the following components: </p><ol>
/// <li>Room Type (IS)</li>
/// <li>Amount Type (IS)</li>
/// <li>Coverage Amount (NM)</li>
/// <li>Money or Percentage (MOP)</li>
/// </ol>
///</summary>
[Serializable]
public class RMC : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a RMC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RMC(Message message) : base(message){
		data = new Type[4];
		data[0] = new IS(message, 145);
		data[1] = new IS(message, 146);
		data[2] = new NM(message);
		data[3] = new MOP(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element RMC composite"); 
		} 
	} 
	///<summary>
	/// Returns Room Type (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS RoomType {
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
	/// Returns Amount Type (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS AmountType {
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
	/// Returns Coverage Amount (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM CoverageAmount {
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
	///<summary>
	/// Returns Money or Percentage (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public MOP MoneyOrPercentage {
get{
	   MOP ret = null;
	   try {
	      ret = (MOP)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}