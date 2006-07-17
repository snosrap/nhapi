using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 CP (composite price) data type.  Consists of the following components: </p><ol>
/// <li>price (MO)</li>
/// <li>price type (ID)</li>
/// <li>from value (NM)</li>
/// <li>to value (NM)</li>
/// <li>range units (CE)</li>
/// <li>range type (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CP(Message message) : this(message, null){}

	///<summary>
	/// Creates a CP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CP(Message message, string description) : base(message, description){
		data = new Type[6];
		data[0] = new MO(message,"Price");
		data[1] = new ID(message, 205,"Price type");
		data[2] = new NM(message,"From value");
		data[3] = new NM(message,"To value");
		data[4] = new CE(message,"Range units");
		data[5] = new ID(message, 298,"Range type");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 6 element CP composite"); 
		} 
	} 
	///<summary>
	/// Returns price (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public MO Price {
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
	/// Returns price type (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID PriceType {
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
	/// Returns from value (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM FromValue {
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
	/// Returns to value (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM ToValue {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns range units (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE RangeUnits {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns range type (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID RangeType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}