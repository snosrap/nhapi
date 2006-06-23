using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 SPS (Specimen Source) data type.  Consists of the following components: </p><ol>
/// <li>Specimen Source Name or Code (CWE)</li>
/// <li>Additives (CWE)</li>
/// <li>Specimen Collection Method (TX)</li>
/// <li>Body Site (CWE)</li>
/// <li>Site Modifier (CWE)</li>
/// <li>Collection Method Modifier Code (CWE)</li>
/// <li>Specimen Role (CWE)</li>
/// </ol>
///</summary>
[Serializable]
public class SPS : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a SPS.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SPS(Message message) : base(message){
		data = new Type[7];
		data[0] = new CWE(message);
		data[1] = new CWE(message);
		data[2] = new TX(message);
		data[3] = new CWE(message);
		data[4] = new CWE(message);
		data[5] = new CWE(message);
		data[6] = new CWE(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 7 element SPS composite"); 
		} 
	} 
	///<summary>
	/// Returns Specimen Source Name or Code (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE SpecimenSourceNameOrCode {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Additives (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE Additives {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Specimen Collection Method (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TX SpecimenCollectionMethod {
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
	/// Returns Body Site (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE BodySite {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Site Modifier (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE SiteModifier {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Collection Method Modifier Code (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE CollectionMethodModifierCode {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Specimen Role (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CWE SpecimenRole {
get{
	   CWE ret = null;
	   try {
	      ret = (CWE)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}