using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 PIP (Privileges) data type.  Consists of the following components: </p><ol>
/// <li>privilege (CE)</li>
/// <li>privilege class (CE)</li>
/// <li>expiration date (DT)</li>
/// <li>activation date (DT)</li>
/// <li>facility (EI) (EI)</li>
/// </ol>
///</summary>
[Serializable]
public class PIP : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a PIP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PIP(Message message) : this(message, null){}

	///<summary>
	/// Creates a PIP.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public PIP(Message message, string description) : base(message, description){
		data = new Type[5];
		data[0] = new CE(message,"Privilege");
		data[1] = new CE(message,"Privilege class");
		data[2] = new DT(message,"Expiration date");
		data[3] = new DT(message,"Activation date");
		data[4] = new EI(message,"Facility (EI)");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 5 element PIP composite"); 
		} 
	} 
	///<summary>
	/// Returns privilege (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE Privilege {
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
	/// Returns privilege class (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public CE PrivilegeClass {
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
	/// Returns expiration date (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ExpirationDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns activation date (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DT ActivationDate {
get{
	   DT ret = null;
	   try {
	      ret = (DT)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns facility (EI) (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public EI Facility {
get{
	   EI ret = null;
	   try {
	      ret = (EI)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}