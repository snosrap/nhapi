using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 HD (Hierarchic Designator) data type.  Consists of the following components: </p><ol>
/// <li>Namespace ID (IS)</li>
/// <li>Universal ID (ST)</li>
/// <li>Universal ID Type (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class HD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a HD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public HD(Message message) : base(message){
		data = new Type[3];
		data[0] = new IS(message, 300);
		data[1] = new ST(message);
		data[2] = new ID(message, 301);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element HD composite"); 
		} 
	} 
	///<summary>
	/// Returns Namespace ID (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS NamespaceID {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Universal ID (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UniversalID {
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
	/// Returns Universal ID Type (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID UniversalIDType {
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
}}