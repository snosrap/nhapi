using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 CSU (Channel Sensitivity) data type.  Consists of the following components: </p><ol>
/// <li>Channel Sensitivity (NM)</li>
/// <li>Unit of Measure Identifier (ST)</li>
/// <li>Unit of Measure Description (ST)</li>
/// <li>Unit of Measure Coding System (ID)</li>
/// <li>Alternate Unit of Measure Identifier (ST)</li>
/// <li>Alternate Unit of Measure Description (ST)</li>
/// <li>Alternate Unit of Measure Coding System (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CSU : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CSU.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CSU(Message message) : base(message){
		data = new Type[7];
		data[0] = new NM(message);
		data[1] = new ST(message);
		data[2] = new ST(message);
		data[3] = new ID(message, 396);
		data[4] = new ST(message);
		data[5] = new ST(message);
		data[6] = new ID(message, 396);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 7 element CSU composite"); 
		} 
	} 
	///<summary>
	/// Returns Channel Sensitivity (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM ChannelSensitivity {
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
	/// Returns Unit of Measure Identifier (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnitOfMeasureIdentifier {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Unit of Measure Description (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnitOfMeasureDescription {
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
	/// Returns Unit of Measure Coding System (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID UnitOfMeasureCodingSystem {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Alternate Unit of Measure Identifier (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST AlternateUnitOfMeasureIdentifier {
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
	/// Returns Alternate Unit of Measure Description (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST AlternateUnitOfMeasureDescription {
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
	/// Returns Alternate Unit of Measure Coding System (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID AlternateUnitOfMeasureCodingSystem {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}