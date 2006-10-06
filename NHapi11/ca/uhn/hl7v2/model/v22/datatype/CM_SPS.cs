using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CM_SPS (specimen source) data type.  Consists of the following components: </p><ol>
/// <li>Specimen source name or code (CE)</li>
/// <li>additives (TX)</li>
/// <li>freetext (TX)</li>
/// <li>body site (CE)</li>
/// <li>site modifier (CE)</li>
/// </ol>
///</summary>
[Serializable]
public class CM_SPS : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CM_SPS.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_SPS(Message message) : this(message, null){}

	///<summary>
	/// Creates a CM_SPS.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CM_SPS(Message message, string description) : base(message, description){
		data = new Type[5];
		data[0] = new CE(message,"Specimen source name or code");
		data[1] = new TX(message,"Additives");
		data[2] = new TX(message,"Freetext");
		data[3] = new CE(message,"Body site");
		data[4] = new CE(message,"Site modifier");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 5 element CM_SPS composite"); 
		} 
	} 
	///<summary>
	/// Returns Specimen source name or code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE SpecimenSourceNameOrCode {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns additives (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX Additives {
get{
	   TX ret = null;
	   try {
	      ret = (TX)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns freetext (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX Freetext {
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
	///<summary>
	/// Returns body site (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE BodySite {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns site modifier (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE SiteModifier {
get{
	   CE ret = null;
	   try {
	      ret = (CE)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}