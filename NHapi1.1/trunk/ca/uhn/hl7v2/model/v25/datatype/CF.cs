using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 CF (Coded Element with Formatted Values) data type.  Consists of the following components: </p><ol>
/// <li>Identifier (ST)</li>
/// <li>Formatted Text (FT)</li>
/// <li>Name of Coding System (ID)</li>
/// <li>Alternate Identifier (ST)</li>
/// <li>Alternate Formatted Text (FT)</li>
/// <li>Name of Alternate Coding System (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CF : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CF.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CF(Message message) : this(message, null){}

	///<summary>
	/// Creates a CF.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CF(Message message, string description) : base(message, description){
		data = new Type[6];
		data[0] = new ST(message,"Identifier");
		data[1] = new FT(message,"Formatted Text");
		data[2] = new ID(message, 396,"Name of Coding System");
		data[3] = new ST(message,"Alternate Identifier");
		data[4] = new FT(message,"Alternate Formatted Text");
		data[5] = new ID(message, 396,"Name of Alternate Coding System");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 6 element CF composite"); 
		} 
	} 
	///<summary>
	/// Returns Identifier (component #0).  This is a convenience method that saves you from 
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
	/// Returns Formatted Text (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public FT FormattedText {
get{
	   FT ret = null;
	   try {
	      ret = (FT)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Name of Coding System (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID NameOfCodingSystem {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Alternate Identifier (component #3).  This is a convenience method that saves you from 
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
	/// Returns Alternate Formatted Text (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public FT AlternateFormattedText {
get{
	   FT ret = null;
	   try {
	      ret = (FT)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Name of Alternate Coding System (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID NameOfAlternateCodingSystem {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}