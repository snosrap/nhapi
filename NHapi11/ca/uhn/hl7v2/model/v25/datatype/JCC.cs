using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 JCC (Job Code/Class) data type.  Consists of the following components: </p><ol>
/// <li>Job Code (IS)</li>
/// <li>Job Class (IS)</li>
/// <li>Job Description Text (TX)</li>
/// </ol>
///</summary>
[Serializable]
public class JCC : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a JCC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public JCC(Message message) : this(message, null){}

	///<summary>
	/// Creates a JCC.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public JCC(Message message, string description) : base(message, description){
		data = new Type[3];
		data[0] = new IS(message, 327,"Job Code");
		data[1] = new IS(message, 328,"Job Class");
		data[2] = new TX(message,"Job Description Text");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 3 element JCC composite"); 
		} 
	} 
	///<summary>
	/// Returns Job Code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS JobCode {
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
	/// Returns Job Class (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS JobClass {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Job Description Text (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX JobDescriptionText {
get{
	   TX ret = null;
	   try {
	      ret = (TX)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}