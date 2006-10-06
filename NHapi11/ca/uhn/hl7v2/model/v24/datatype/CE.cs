using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 CE (coded element) data type.  Consists of the following components: </p><ol>
/// <li>identifier (ST) (ST)</li>
/// <li>text (ST)</li>
/// <li>name of coding system (IS)</li>
/// <li>alternate identifier (ST) (ST)</li>
/// <li>alternate text (ST)</li>
/// <li>name of alternate coding system (IS)</li>
/// </ol>
///</summary>
[Serializable]
public class CE : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CE.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CE(Message message) : this(message, null){}

	///<summary>
	/// Creates a CE.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CE(Message message, string description) : base(message, description){
		data = new Type[6];
		data[0] = new ST(message,"Identifier (ST)");
		data[1] = new ST(message,"Text");
		data[2] = new IS(message, 0,"Name of coding system");
		data[3] = new ST(message,"Alternate identifier (ST)");
		data[4] = new ST(message,"Alternate text");
		data[5] = new IS(message, 0,"Name of alternate coding system");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 6 element CE composite"); 
		} 
	} 
	///<summary>
	/// Returns identifier (ST) (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Identifier {
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
	/// Returns text (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Text {
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
	/// Returns name of coding system (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS NameOfCodingSystem {
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
	/// Returns alternate identifier (ST) (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST AlternateIdentifier {
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
	/// Returns alternate text (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST AlternateText {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns name of alternate coding system (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS NameOfAlternateCodingSystem {
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
}}