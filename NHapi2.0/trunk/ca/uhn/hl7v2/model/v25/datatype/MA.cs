using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 MA (Multiplexed Array) data type.  Consists of the following components: </p><ol>
/// <li>Sample 1 From Channel 1 (NM)</li>
/// <li>Sample 1 From Channel 2 (NM)</li>
/// <li>Sample 1 From Channel N (NM)</li>
/// <li>Sample 2 From Channel 1 (NM)</li>
/// <li>Sample 2 From Channel N (NM)</li>
/// <li>Sample N From Channel N (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class MA : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a MA.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public MA(Message message) : base(message){
		data = new Type[6];
		data[0] = new NM(message);
		data[1] = new NM(message);
		data[2] = new NM(message);
		data[3] = new NM(message);
		data[4] = new NM(message);
		data[5] = new NM(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 6 element MA composite"); 
		} 
	} 
	///<summary>
	/// Returns Sample 1 From Channel 1 (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Sample1FromChannel1 {
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
	/// Returns Sample 1 From Channel 2 (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Sample1FromChannel2 {
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
	/// Returns Sample 1 From Channel N (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Sample1FromChannelN {
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
	/// Returns Sample 2 From Channel 1 (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Sample2FromChannel1 {
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
	/// Returns Sample 2 From Channel N (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Sample2FromChannelN {
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
	/// Returns Sample N From Channel N (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM SampleNFromChannelN {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}