using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_ELD (error) data type.  Consists of the following components: </p><ol>
/// <li>Segment-ID (ST)</li>
/// <li>Sequence (NM)</li>
/// <li>Field-Position (NM)</li>
/// <li>Code Identifying Error (CE)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_ELD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_ELD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_ELD(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_ELD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_ELD(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new ST(message,"Segment-ID");
		data[1] = new NM(message,"Sequence");
		data[2] = new NM(message,"Field-Position");
		data[3] = new CE(message,"Code Identifying Error");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element CM_ELD composite"); 
		} 
	} 
	///<summary>
	/// Returns Segment-ID (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SegmentID {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Sequence (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Sequence {
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
	/// Returns Field-Position (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM FieldPosition {
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
	/// Returns Code Identifying Error (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE CodeIdentifyingError {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}