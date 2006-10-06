using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_RFR (reference range) data type.  Consists of the following components: </p><ol>
/// <li>Reference Range (CM_RANGE)</li>
/// <li>Sex (ID)</li>
/// <li>Age Range (CM_RANGE)</li>
/// <li>Gestational Age Range (CM_RANGE)</li>
/// <li>Species (ST)</li>
/// <li>Race / Subspecies (ID)</li>
/// <li>Text Condition (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_RFR : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_RFR.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_RFR(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_RFR.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_RFR(Message message, string description) : base(message, description){
		data = new Type[7];
		data[0] = new CM_RANGE(message,"Reference Range");
		data[1] = new ID(message, 0,"Sex");
		data[2] = new CM_RANGE(message,"Age Range");
		data[3] = new CM_RANGE(message,"Gestational Age Range");
		data[4] = new ST(message,"Species");
		data[5] = new ID(message, 0,"Race / Subspecies");
		data[6] = new ST(message,"Text Condition");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 7 element CM_RFR composite"); 
		} 
	} 
	///<summary>
	/// Returns Reference Range (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CM_RANGE ReferenceRange {
get{
	   CM_RANGE ret = null;
	   try {
	      ret = (CM_RANGE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Sex (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Sex {
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
	/// Returns Age Range (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CM_RANGE AgeRange {
get{
	   CM_RANGE ret = null;
	   try {
	      ret = (CM_RANGE)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Gestational Age Range (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CM_RANGE GestationalAgeRange {
get{
	   CM_RANGE ret = null;
	   try {
	      ret = (CM_RANGE)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Species (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Species {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Race / Subspecies (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID RaceSubspecies {
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
	///<summary>
	/// Returns Text Condition (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST TextCondition {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}