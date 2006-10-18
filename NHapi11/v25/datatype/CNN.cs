using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 CNN (Composite ID Number and Name Simplified) data type.  Consists of the following components: </p><ol>
/// <li>ID Number (ST)</li>
/// <li>Family Name (ST)</li>
/// <li>Given Name (ST)</li>
/// <li>Second and Further Given Names or Initials Thereof (ST)</li>
/// <li>Suffix (e.g., JR or III) (ST)</li>
/// <li>Prefix (e.g., DR) (ST)</li>
/// <li>Degree (e.g., MD (IS)</li>
/// <li>Source Table (IS)</li>
/// <li>Assigning Authority   - Namespace ID (IS)</li>
/// <li>Assigning Authority  - Universal ID (ST)</li>
/// <li>Assigning Authority  - Universal ID Type (ID)</li>
/// </ol>
///</summary>
[Serializable]
public class CNN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CNN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CNN(Message message) : this(message, null){}

	///<summary>
	/// Creates a CNN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CNN(Message message, string description) : base(message, description){
		data = new Type[11];
		data[0] = new ST(message,"ID Number");
		data[1] = new ST(message,"Family Name");
		data[2] = new ST(message,"Given Name");
		data[3] = new ST(message,"Second and Further Given Names or Initials Thereof");
		data[4] = new ST(message,"Suffix (e.g., JR or III)");
		data[5] = new ST(message,"Prefix (e.g., DR)");
		data[6] = new IS(message, 360,"Degree (e.g., MD");
		data[7] = new IS(message, 297,"Source Table");
		data[8] = new IS(message, 363,"Assigning Authority   - Namespace ID");
		data[9] = new ST(message,"Assigning Authority  - Universal ID");
		data[10] = new ID(message, 301,"Assigning Authority  - Universal ID Type");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 11 element CNN composite"); 
		} 
	} 
	///<summary>
	/// Returns ID Number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST IDNumber {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Family Name (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST FamilyName {
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
	/// Returns Given Name (component #2).  This is a convenience method that saves you from 
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
	/// Returns Second and Further Given Names or Initials Thereof (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SecondAndFurtherGivenNamesOrInitialsThereof {
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
	/// Returns Suffix (e.g., JR or III) (component #4).  This is a convenience method that saves you from 
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
	/// Returns Prefix (e.g., DR) (component #5).  This is a convenience method that saves you from 
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
	/// Returns Degree (e.g., MD (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS DegreeEgMD {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Source Table (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS SourceTable {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Assigning Authority   - Namespace ID (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS AssigningAuthorityNamespaceID {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(8);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Assigning Authority  - Universal ID (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST AssigningAuthorityUniversalID {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(9);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Assigning Authority  - Universal ID Type (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID AssigningAuthorityUniversalIDType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(10);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}