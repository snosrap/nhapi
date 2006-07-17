using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 QSC (Query Selection Criteria) data type.  Consists of the following components: </p><ol>
/// <li>Segment Field Name (ST)</li>
/// <li>Relational Operator (ID)</li>
/// <li>Value (ST)</li>
/// <li>Relational Conjunction (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class QSC : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a QSC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public QSC(Message message) : this(message, null){}

	///<summary>
	/// Creates a QSC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public QSC(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new ST(message,"Segment Field Name");
		data[1] = new ID(message, 209,"Relational Operator");
		data[2] = new ST(message,"Value");
		data[3] = new ID(message, 210,"Relational Conjunction");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element QSC composite"); 
		} 
	} 
	///<summary>
	/// Returns Segment Field Name (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SegmentFieldName {
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
	/// Returns Relational Operator (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID RelationalOperator {
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
	/// Returns Value (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Value {
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
	/// Returns Relational Conjunction (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID RelationalConjunction {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}