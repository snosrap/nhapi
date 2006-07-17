using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

///<summary>
/// <p>The HL7 CD (channel definition) data type.  Consists of the following components: </p><ol>
/// <li>channel identifier (WVI)</li>
/// <li>electrode names (WVS)</li>
/// <li>channel sensitivity/units (CSU)</li>
/// <li>calibration parameters (CCP)</li>
/// <li>sampling frequency (NM)</li>
/// <li>minimum/maximum data values (NR)</li>
/// </ol>
///</summary>
[Serializable]
public class CD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CD(Message message) : this(message, null){}

	///<summary>
	/// Creates a CD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CD(Message message, string description) : base(message, description){
		data = new Type[6];
		data[0] = new WVI(message,"Channel identifier");
		data[1] = new WVS(message,"Electrode names");
		data[2] = new CSU(message,"Channel sensitivity/units");
		data[3] = new CCP(message,"Calibration parameters");
		data[4] = new NM(message,"Sampling frequency");
		data[5] = new NR(message,"Minimum/maximum data values");
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
	/// Returns channel identifier (component #0).  This is a convenience method that saves you from 
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
	/// Returns electrode names (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public WVS ElectrodeNames {
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
	/// Returns channel sensitivity/units (component #2).  This is a convenience method that saves you from 
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
	/// Returns calibration parameters (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CCP CalibrationParameters {
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
	/// Returns sampling frequency (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM SamplingFrequency {
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
	/// Returns minimum/maximum data values (component #5).  This is a convenience method that saves you from 
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