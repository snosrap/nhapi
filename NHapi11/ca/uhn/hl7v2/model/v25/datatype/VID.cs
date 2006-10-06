using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 VID (Version Identifier) data type.  Consists of the following components: </p><ol>
/// <li>Version ID (ID)</li>
/// <li>Internationalization Code (CE)</li>
/// <li>International Version ID (CE)</li>
/// </ol>
///</summary>
[Serializable]
public class VID : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a VID.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public VID(Message message) : this(message, null){}

	///<summary>
	/// Creates a VID.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public VID(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new ID(message, 104,"Version ID");
		data[1] = new CE(message,"Internationalization Code");
		data[2] = new CE(message,"International Version ID");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element VID composite"); 
		} 
	} 
	///<summary>
	/// Returns Version ID (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID VersionID {
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
	/// Returns Internationalization Code (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE InternationalizationCode {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns International Version ID (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE InternationalVersionID {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}