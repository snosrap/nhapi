using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CN_PERSON (CN für Personen) data type.  Consists of the following components: </p><ol>
/// <li>ID number (ID)</li>
/// <li>familiy name (ST)</li>
/// <li>given name (ST)</li>
/// <li>middle initial or name (ST)</li>
/// <li>suffix (e.g. JR or III) (ST)</li>
/// <li>prefix (e.g. DR) (ST)</li>
/// <li>degree (e.g. MD) (ST)</li>
/// <li>source table id (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CN_PERSON : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CN_PERSON.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CN_PERSON(Message message) : this(message, null){}

	///<summary>
	/// Creates a CN_PERSON.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CN_PERSON(Message message, string description) : base(message, description){
		data = new Type[8];
		data[0] = new ID(message, 0,"ID number");
		data[1] = new ST(message,"Familiy name");
		data[2] = new ST(message,"Given name");
		data[3] = new ST(message,"Middle initial or name");
		data[4] = new ST(message,"Suffix (e.g. JR or III)");
		data[5] = new ST(message,"Prefix (e.g. DR)");
		data[6] = new ST(message,"Degree (e.g. MD)");
		data[7] = new ID(message, 0,"Source table id");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 8 element CN_PERSON composite"); 
		} 
	} 
	///<summary>
	/// Returns ID number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID IDNumber {
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
	/// Returns familiy name (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST FamiliyName {
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
	/// Returns given name (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST GivenName {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns middle initial or name (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST MiddleInitialOrName {
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
	/// Returns suffix (e.g. JR or III) (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SuffixEgJRorIII {
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
	///<summary>
	/// Returns prefix (e.g. DR) (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST PrefixEgDR {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns degree (e.g. MD) (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST DegreeEgMD {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns source table id (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID SourceTableId {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}