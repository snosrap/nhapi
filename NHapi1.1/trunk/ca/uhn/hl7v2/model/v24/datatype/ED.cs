using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 ED (encapsulated data) data type.  Consists of the following components: </p><ol>
/// <li>source application (HD)</li>
/// <li>type of data (ID)</li>
/// <li>data (ID)</li>
/// <li>encoding (ID)</li>
/// <li>data2 (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class ED : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a ED.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public ED(Message message) : this(message, null){}

	///<summary>
	/// Creates a ED.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public ED(Message message, string description) : base(message, description){
		data = new Type[5];
		data[0] = new HD(message,"Source application");
		data[1] = new ID(message, 191,"Type of data");
		data[2] = new ID(message, 291,"Data");
		data[3] = new ID(message, 299,"Encoding");
		data[4] = new ST(message,"Data2");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 5 element ED composite"); 
		} 
	} 
	///<summary>
	/// Returns source application (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public HD SourceApplication {
get{
	   HD ret = null;
	   try {
	      ret = (HD)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns type of data (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID TypeOfData {
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
	/// Returns data (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Data {
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
	/// Returns encoding (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Encoding {
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
	/// Returns data2 (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Data2 {
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
}}