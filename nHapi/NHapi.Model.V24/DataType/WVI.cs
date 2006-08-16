using System;
using NHapi.Base.model;
using ca.uhn.log;

namespace NHapi.Base.model.v24.datatype
{

///<summary>
/// <p>The HL7 WVI (channel identifier) data type.  Consists of the following components: </p><ol>
/// <li>Channel Number (NM)</li>
/// <li>Channel Name (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class WVI : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a WVI.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public WVI(Message message) : base(message){
		data = new Type[2];
		data[0] = new NM(message);
		data[1] = new ST(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element WVI composite"); 
		} 
	} 
	///<summary>
	/// Returns Channel Number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM ChannelNumber {
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
	/// Returns Channel Name (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ChannelName {
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
}}