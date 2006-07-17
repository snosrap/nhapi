using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_CCP (channel calibration parameters) data type.  Consists of the following components: </p><ol>
/// <li>Sensitivity correction factory (NM)</li>
/// <li>Baseline (NM)</li>
/// <li>Time skew (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_CCP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_CCP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_CCP(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_CCP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_CCP(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new NM(message,"Sensitivity correction factory");
		data[1] = new NM(message,"Baseline");
		data[2] = new NM(message,"Time skew");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element CM_CCP composite"); 
		} 
	} 
	///<summary>
	/// Returns Sensitivity correction factory (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM SensitivityCorrectionFactory {
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
	/// Returns Baseline (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Baseline {
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
	/// Returns Time skew (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM TimeSkew {
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