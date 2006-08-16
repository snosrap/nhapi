using System;using NHapi.Base.model;
using ca.uhn.log;

namespace NHapi.Base.model.v23.datatype
{

///<summary>
/// <p>The HL7 CM_OSD (order sequence) data type.  Consists of the following components: </p><ol>
/// <li>sequence/results flag (ID)</li>
/// <li>placer order number: entity identifier (ST)</li>
/// <li>placer order number: namespace ID (IS)</li>
/// <li>filler order number: entity identifier (ST)</li>
/// <li>filler order number: namespace ID (IS)</li>
/// <li>sequence condition value (ST)</li>
/// <li>maximum number of repeats (NM)</li>
/// <li>placer order number: universal ID (ST)</li>
/// <li>placer order number; universal ID type (ID)</li>
/// <li>filler order number: universal ID (ST)</li>
/// <li>filler order number: universal ID type (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_OSD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_OSD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_OSD(Message message) : base(message){
		data = new Type[11];
		data[0] = new ID(message, 0);
		data[1] = new ST(message);
		data[2] = new IS(message, 0);
		data[3] = new ST(message);
		data[4] = new IS(message, 0);
		data[5] = new ST(message);
		data[6] = new NM(message);
		data[7] = new ST(message);
		data[8] = new ID(message, 0);
		data[9] = new ST(message);
		data[10] = new ID(message, 0);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 11 element CM_OSD composite"); 
		} 
	} 
	///<summary>
	/// Returns sequence/results flag (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID SequenceResultsFlag {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns placer order number: entity identifier (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST PlacerOrderNumberEntityIdentifier {
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
	/// Returns placer order number: namespace ID (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS PlacerOrderNumberNamespaceID {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns filler order number: entity identifier (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST FillerOrderNumberEntityIdentifier {
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
	/// Returns filler order number: namespace ID (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS FillerOrderNumberNamespaceID {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns sequence condition value (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SequenceConditionValue {
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
	/// Returns maximum number of repeats (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM MaximumNumberOfRepeats {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns placer order number: universal ID (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST PlacerOrderNumberUniversalID {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns placer order number; universal ID type (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID PlacerOrderNumberUniversalIDType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(8);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns filler order number: universal ID (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST FillerOrderNumberUniversalID {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(9);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns filler order number: universal ID type (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID FillerOrderNumberUniversalIDType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(10);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}