using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 CCP (Channel Calibration Parameters) data type.  Consists of the following components: </p><ol>
/// <li>Channel Calibration Sensitivity Correction Factor (NM)</li>
/// <li>Channel Calibration Baseline (NM)</li>
/// <li>Channel Calibration Time Skew (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class CCP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CCP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CCP(Message message) : this(message, null){}

	///<summary>
	/// Creates a CCP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CCP(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new NM(message,"Channel Calibration Sensitivity Correction Factor");
		data[1] = new NM(message,"Channel Calibration Baseline");
		data[2] = new NM(message,"Channel Calibration Time Skew");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element CCP composite"); 
		} 
	} 
	///<summary>
	/// Returns Channel Calibration Sensitivity Correction Factor (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM ChannelCalibrationSensitivityCorrectionFactor {
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
	/// Returns Channel Calibration Baseline (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM ChannelCalibrationBaseline {
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
	/// Returns Channel Calibration Time Skew (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM ChannelCalibrationTimeSkew {
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