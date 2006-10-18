using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_CSU (channel sensitivity/units) data type.  Consists of the following components: </p><ol>
/// <li>Sensitivity (NM)</li>
/// <li>Units identifier (ID)</li>
/// <li>Units text (ST)</li>
/// <li>Units name of coding system (ST)</li>
/// <li>Units alternate identifer (ID)</li>
/// <li>Units alternate text (ST)</li>
/// <li>Units name of alternate coding system (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_CSU : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_CSU.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_CSU(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_CSU.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_CSU(Message message, string description) : base(message, description){
		data = new Type[7];
		data[0] = new NM(message,"Sensitivity");
		data[1] = new ID(message, 0,"Units identifier");
		data[2] = new ST(message,"Units text");
		data[3] = new ST(message,"Units name of coding system");
		data[4] = new ID(message, 0,"Units alternate identifer");
		data[5] = new ST(message,"Units alternate text");
		data[6] = new ST(message,"Units name of alternate coding system");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 7 element CM_CSU composite"); 
		} 
	} 
	///<summary>
	/// Returns Sensitivity (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Sensitivity {
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
	/// Returns Units identifier (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID UnitsIdentifier {
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
	/// Returns Units text (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnitsText {
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
	/// Returns Units name of coding system (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnitsNameOfCodingSystem {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Units alternate identifer (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID UnitsAlternateIdentifer {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Units alternate text (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnitsAlternateText {
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
	/// Returns Units name of alternate coding system (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnitsNameOfAlternateCodingSystem {
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