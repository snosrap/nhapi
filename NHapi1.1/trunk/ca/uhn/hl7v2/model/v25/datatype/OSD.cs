using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 OSD (Order Sequence Definition) data type.  Consists of the following components: </p><ol>
/// <li>Sequence/Results Flag (ID)</li>
/// <li>Placer Order Number: Entity Identifier (ST)</li>
/// <li>Placer Order Number: Namespace ID (IS)</li>
/// <li>Filler Order Number: Entity Identifier (ST)</li>
/// <li>Filler Order Number: Namespace ID (IS)</li>
/// <li>Sequence Condition Value (ST)</li>
/// <li>Maximum Number of Repeats (NM)</li>
/// <li>Placer Order Number: Universal ID (ST)</li>
/// <li>Placer Order Number: Universal ID Type (ID)</li>
/// <li>Filler Order Number: Universal ID (ST)</li>
/// <li>Filler Order Number: Universal ID Type (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class OSD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a OSD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public OSD(Message message) : this(message, null){}

	///<summary>
	/// Creates a OSD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public OSD(Message message, string description) : base(message, description){
		data = new Type[11];
		data[0] = new ID(message, 524,"Sequence/Results Flag");
		data[1] = new ST(message,"Placer Order Number: Entity Identifier");
		data[2] = new IS(message, 363,"Placer Order Number: Namespace ID");
		data[3] = new ST(message,"Filler Order Number: Entity Identifier");
		data[4] = new IS(message, 363,"Filler Order Number: Namespace ID");
		data[5] = new ST(message,"Sequence Condition Value");
		data[6] = new NM(message,"Maximum Number of Repeats");
		data[7] = new ST(message,"Placer Order Number: Universal ID");
		data[8] = new ID(message, 301,"Placer Order Number: Universal ID Type");
		data[9] = new ST(message,"Filler Order Number: Universal ID");
		data[10] = new ID(message, 301,"Filler Order Number: Universal ID Type");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 11 element OSD composite"); 
		} 
	} 
	///<summary>
	/// Returns Sequence/Results Flag (component #0).  This is a convenience method that saves you from 
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
	/// Returns Placer Order Number: Entity Identifier (component #1).  This is a convenience method that saves you from 
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
	/// Returns Placer Order Number: Namespace ID (component #2).  This is a convenience method that saves you from 
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
	/// Returns Filler Order Number: Entity Identifier (component #3).  This is a convenience method that saves you from 
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
	/// Returns Filler Order Number: Namespace ID (component #4).  This is a convenience method that saves you from 
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
	/// Returns Sequence Condition Value (component #5).  This is a convenience method that saves you from 
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
	/// Returns Maximum Number of Repeats (component #6).  This is a convenience method that saves you from 
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
	/// Returns Placer Order Number: Universal ID (component #7).  This is a convenience method that saves you from 
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
	/// Returns Placer Order Number: Universal ID Type (component #8).  This is a convenience method that saves you from 
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
	/// Returns Filler Order Number: Universal ID (component #9).  This is a convenience method that saves you from 
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
	/// Returns Filler Order Number: Universal ID Type (component #10).  This is a convenience method that saves you from 
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