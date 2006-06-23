using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 TQ (Timing Quantity) data type.  Consists of the following components: </p><ol>
/// <li>Quantity (CQ)</li>
/// <li>Interval (RI)</li>
/// <li>Duration (ST)</li>
/// <li>Start Date/Time (TS)</li>
/// <li>End Date/Time (TS)</li>
/// <li>Priority (ST)</li>
/// <li>Condition (ST)</li>
/// <li>Text (TX)</li>
/// <li>Conjunction (ID)</li>
/// <li>Order Sequencing (OSD)</li>
/// <li>Occurrence Duration (CE)</li>
/// <li>Total Occurrences (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class TQ : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a TQ.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public TQ(Message message) : base(message){
		data = new Type[12];
		data[0] = new CQ(message);
		data[1] = new RI(message);
		data[2] = new ST(message);
		data[3] = new TS(message);
		data[4] = new TS(message);
		data[5] = new ST(message);
		data[6] = new ST(message);
		data[7] = new TX(message);
		data[8] = new ID(message, 472);
		data[9] = new OSD(message);
		data[10] = new CE(message);
		data[11] = new NM(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 12 element TQ composite"); 
		} 
	} 
	///<summary>
	/// Returns Quantity (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CQ Quantity {
get{
	   CQ ret = null;
	   try {
	      ret = (CQ)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Interval (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public RI Interval {
get{
	   RI ret = null;
	   try {
	      ret = (RI)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Duration (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Duration {
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
	/// Returns Start Date/Time (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS StartDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns End Date/Time (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TS EndDateTime {
get{
	   TS ret = null;
	   try {
	      ret = (TS)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Priority (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Priority {
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
	/// Returns Condition (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Condition {
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
	///<summary>
	/// Returns Text (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX Text {
get{
	   TX ret = null;
	   try {
	      ret = (TX)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Conjunction (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Conjunction {
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
	/// Returns Order Sequencing (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public OSD OrderSequencing {
get{
	   OSD ret = null;
	   try {
	      ret = (OSD)getComponent(9);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Occurrence Duration (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE OccurrenceDuration {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(10);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Total Occurrences (component #11).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM TotalOccurrences {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(11);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}