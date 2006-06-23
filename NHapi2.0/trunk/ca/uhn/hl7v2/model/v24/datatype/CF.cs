using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 CF (coded element with formatted values) data type.  Consists of the following components: </p><ol>
/// <li>identifier (ID) (ID)</li>
/// <li>formatted text (FT)</li>
/// <li>name of coding system (IS)</li>
/// <li>alternate identifier (ID) (ID)</li>
/// <li>alternate formatted text (FT)</li>
/// <li>name of alternate coding system (IS)</li>
/// </ol>
///</summary>
[Serializable]
public class CF : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CF.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CF(Message message) : base(message){
		data = new Type[6];
		data[0] = new ID(message, 0);
		data[1] = new FT(message);
		data[2] = new IS(message, 0);
		data[3] = new ID(message, 0);
		data[4] = new FT(message);
		data[5] = new IS(message, 0);
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
	/// Returns identifier (ID) (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Identifier {
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
	/// Returns formatted text (component #1).  This is a convenience method that saves you from 
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
	/// Returns alternate identifier (ID) (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID AlternateIdentifier {
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
	///<summary>
	/// Returns alternate formatted text (component #4).  This is a convenience method that saves you from 
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