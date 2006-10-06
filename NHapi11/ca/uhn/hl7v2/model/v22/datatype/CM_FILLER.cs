using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_FILLER (Bearbeitungsnummer der Leistungsstelle) data type.  Consists of the following components: </p><ol>
/// <li>unique filler id (ID)</li>
/// <li>filler application ID (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_FILLER : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_FILLER.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_FILLER(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_FILLER.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_FILLER(Message message, string description) : base(message, description){
		data = new Type[2];
		data[0] = new ID(message, 0,"Unique filler id");
		data[1] = new ID(message, 0,"Filler application ID");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 2 element CM_FILLER composite"); 
		} 
	} 
	///<summary>
	/// Returns unique filler id (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID UniqueFillerId {
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
	/// Returns filler application ID (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID FillerApplicationID {
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
}}