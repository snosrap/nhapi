using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 RPT (Repeat Pattern) data type.  Consists of the following components: </p><ol>
/// <li>Repeat Pattern Code (CWE)</li>
/// <li>Calendar Alignment (ID)</li>
/// <li>Phase Range Begin Value (NM)</li>
/// <li>Phase Range End Value (NM)</li>
/// <li>Period Quantity (NM)</li>
/// <li>Period Units (IS)</li>
/// <li>Institution Specified Time (ID)</li>
/// <li>Event (ID)</li>
/// <li>Event Offset Quantity (NM)</li>
/// <li>Event Offset Units (IS)</li>
/// <li>General Timing Specification (GTS)</li>
/// </ol>
///</summary>
[Serializable]
public class RPT : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a RPT.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RPT(Message message) : this(message, null){}

	///<summary>
	/// Creates a RPT.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public RPT(Message message, string description) : base(message, description){
		data = new Type[11];
		data[0] = new CWE(message,"Repeat Pattern Code");
		data[1] = new ID(message, 527,"Calendar Alignment");
		data[2] = new NM(message,"Phase Range Begin Value");
		data[3] = new NM(message,"Phase Range End Value");
		data[4] = new NM(message,"Period Quantity");
		data[5] = new IS(message, 0,"Period Units");
		data[6] = new ID(message, 136,"Institution Specified Time");
		data[7] = new ID(message, 528,"Event");
		data[8] = new NM(message,"Event Offset Quantity");
		data[9] = new IS(message, 0,"Event Offset Units");
		data[10] = new GTS(message,"General Timing Specification");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 11 element RPT composite"); 
		} 
	} 
	///<summary>
	/// Returns Repeat Pattern Code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE RepeatPatternCode {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Calendar Alignment (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID CalendarAlignment {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Phase Range Begin Value (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM PhaseRangeBeginValue {
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
	/// Returns Phase Range End Value (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM PhaseRangeEndValue {
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
	/// Returns Period Quantity (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM PeriodQuantity {
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
	/// Returns Period Units (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS PeriodUnits {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Institution Specified Time (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID InstitutionSpecifiedTime {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Event (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Event {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Event Offset Quantity (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM EventOffsetQuantity {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(8);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Event Offset Units (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS EventOffsetUnits {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(9);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns General Timing Specification (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public GTS GeneralTimingSpecification {
get{
	   GTS ret = null;
	   try {
	      ret = (GTS)getComponent(10);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}