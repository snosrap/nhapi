using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

///<summary>
/// <p>The HL7 RFR (reference range) data type.  Consists of the following components: </p><ol>
/// <li>numeric range (NR)</li>
/// <li>administrative sex (IS)</li>
/// <li>age range (NR)</li>
/// <li>gestational age range (NR)</li>
/// <li>species (TX)</li>
/// <li>race/subspecies (ST)</li>
/// <li>conditions (TX)</li>
/// </ol>
///</summary>
[Serializable]
public class RFR : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a RFR.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RFR(Message message) : base(message){
		data = new Type[7];
		data[0] = new NR(message);
		data[1] = new IS(message, 0);
		data[2] = new NR(message);
		data[3] = new NR(message);
		data[4] = new TX(message);
		data[5] = new ST(message);
		data[6] = new TX(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 7 element RFR composite"); 
		} 
	} 
	///<summary>
	/// Returns numeric range (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NR NumericRange {
get{
	   NR ret = null;
	   try {
	      ret = (NR)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns administrative sex (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS AdministrativeSex {
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
	/// Returns age range (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NR AgeRange {
get{
	   NR ret = null;
	   try {
	      ret = (NR)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns gestational age range (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NR GestationalAgeRange {
get{
	   NR ret = null;
	   try {
	      ret = (NR)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns species (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX Species {
get{
	   TX ret = null;
	   try {
	      ret = (TX)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns race/subspecies (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST RaceSubspecies {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns conditions (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX Conditions {
get{
	   TX ret = null;
	   try {
	      ret = (TX)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}