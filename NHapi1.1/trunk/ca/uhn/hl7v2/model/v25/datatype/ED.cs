using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 ED (Encapsulated Data) data type.  Consists of the following components: </p><ol>
/// <li>Source Application (HD)</li>
/// <li>Type of Data (ID)</li>
/// <li>Data Subtype (ID)</li>
/// <li>Encoding (ID)</li>
/// <li>Data (TX)</li>
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
		data[0] = new HD(message,"Source Application");
		data[1] = new ID(message, 191,"Type of Data");
		data[2] = new ID(message, 291,"Data Subtype");
		data[3] = new ID(message, 299,"Encoding");
		data[4] = new TX(message,"Data");
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
	/// Returns Source Application (component #0).  This is a convenience method that saves you from 
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
	/// Returns Type of Data (component #1).  This is a convenience method that saves you from 
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
	/// Returns Data Subtype (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID DataSubtype {
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
	/// Returns Encoding (component #3).  This is a convenience method that saves you from 
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
	/// Returns Data (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX Data {
get{
	   TX ret = null;
	   try {
	      ret = (TX)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}