using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_RFR (reference range) data type.  Consists of the following components: </p><ol>
/// <li>reference range (CM_RANGE)</li>
/// <li>sex (IS)</li>
/// <li>age range (CM_RANGE)</li>
/// <li>age gestation (CM_RANGE)</li>
/// <li>species (TX)</li>
/// <li>race/subspecies (ST)</li>
/// <li>conditions (TX)</li>
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
		data[0] = new CM_RANGE(message,"Reference range");
		data[1] = new IS(message, 0,"Sex");
		data[2] = new CM_RANGE(message,"Age range");
		data[3] = new CM_RANGE(message,"Age gestation");
		data[4] = new TX(message,"Species");
		data[5] = new ST(message,"Race/subspecies");
		data[6] = new TX(message,"Conditions");
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
	/// Returns reference range (component #0).  This is a convenience method that saves you from 
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
	/// Returns sex (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS Sex {
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
	/// Returns age gestation (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CM_RANGE AgeGestation {
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