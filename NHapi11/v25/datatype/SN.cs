using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 SN (Structured Numeric) data type.  Consists of the following components: </p><ol>
/// <li>Comparator (ST)</li>
/// <li>Num1 (NM)</li>
/// <li>Separator/Suffix (ST)</li>
/// <li>Num2 (NM)</li>
/// </ol>
///</summary>
[Serializable]
public class SN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a SN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SN(Message message) : this(message, null){}

	///<summary>
	/// Creates a SN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public SN(Message message, string description) : base(message, description){
		data = new Type[4];
		data[0] = new ST(message,"Comparator");
		data[1] = new NM(message,"Num1");
		data[2] = new ST(message,"Separator/Suffix");
		data[3] = new NM(message,"Num2");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 4 element SN composite"); 
		} 
	} 
	///<summary>
	/// Returns Comparator (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST Comparator {
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
	/// Returns Num1 (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Num1 {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(1);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Separator/Suffix (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SeparatorSuffix {
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
	/// Returns Num2 (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Num2 {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}