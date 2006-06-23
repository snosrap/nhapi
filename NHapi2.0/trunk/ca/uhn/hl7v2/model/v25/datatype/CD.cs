using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 CD (Channel Definition) data type.  Consists of the following components: </p><ol>
/// <li>Channel Identifier (WVI)</li>
/// <li>Waveform Source (WVS)</li>
/// <li>Channel Sensitivity/Units (CSU)</li>
/// <li>Channel Calibration Parameters (CCP)</li>
/// <li>Channel Sampling Frequency (NM)</li>
/// <li>Minimum/Maximum Data Values (NR)</li>
/// </ol>
///</summary>
[Serializable]
public class CD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CD(Message message) : base(message){
		data = new Type[6];
		data[0] = new WVI(message);
		data[1] = new WVS(message);
		data[2] = new CSU(message);
		data[3] = new CCP(message);
		data[4] = new NM(message);
		data[5] = new NR(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 6 element CD composite"); 
		} 
	} 
	///<summary>
	/// Returns Channel Identifier (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public WVI ChannelIdentifier {
get{
	   WVI ret = null;
	   try {
	      ret = (WVI)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Waveform Source (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public WVS WaveformSource {
get{
	   WVS ret = null;
	   try {
	      ret = (WVS)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Channel Sensitivity/Units (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CSU ChannelSensitivityUnits {
get{
	   CSU ret = null;
	   try {
	      ret = (CSU)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Channel Calibration Parameters (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CCP ChannelCalibrationParameters {
get{
	   CCP ret = null;
	   try {
	      ret = (CCP)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Channel Sampling Frequency (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM ChannelSamplingFrequency {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Minimum/Maximum Data Values (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NR MinimumMaximumDataValues {
get{
	   NR ret = null;
	   try {
	      ret = (NR)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}