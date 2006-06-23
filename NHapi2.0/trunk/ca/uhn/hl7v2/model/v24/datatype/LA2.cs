using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 LA2 (Location with address information (variant 2)) data type.  Consists of the following components: </p><ol>
/// <li>point of care (IS) (IS)</li>
/// <li>room (IS)</li>
/// <li>bed (IS)</li>
/// <li>facility (HD) (HD)</li>
/// <li>location status (IS)</li>
/// <li>person location type (IS)</li>
/// <li>building (IS)</li>
/// <li>floor (IS)</li>
/// <li>street address (ST) (ST)</li>
/// <li>other designation (ST)</li>
/// <li>city (ST)</li>
/// <li>state or province (ST)</li>
/// <li>zip or postal code (ST)</li>
/// <li>country (ID)</li>
/// <li>address type (ID)</li>
/// <li>other geographic designation (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class LA2 : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a LA2.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public LA2(Message message) : base(message){
		data = new Type[16];
		data[0] = new IS(message, 0);
		data[1] = new IS(message, 0);
		data[2] = new IS(message, 0);
		data[3] = new HD(message);
		data[4] = new IS(message, 0);
		data[5] = new IS(message, 0);
		data[6] = new IS(message, 0);
		data[7] = new IS(message, 0);
		data[8] = new ST(message);
		data[9] = new ST(message);
		data[10] = new ST(message);
		data[11] = new ST(message);
		data[12] = new ST(message);
		data[13] = new ID(message, 0);
		data[14] = new ID(message, 0);
		data[15] = new ST(message);
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
			throw new DataTypeException("Element " + number + " doesn't exist in 16 element LA2 composite"); 
		} 
	} 
	///<summary>
	/// Returns point of care (IS) (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS PointOfCare {
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
	/// Returns room (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS Room {
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
	/// Returns bed (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS Bed {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns facility (HD) (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public HD Facility {
get{
	   HD ret = null;
	   try {
	      ret = (HD)getComponent(3);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns location status (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS LocationStatus {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns person location type (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS PersonLocationType {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns building (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS Building {
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
	/// Returns floor (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS Floor {
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
	/// Returns street address (ST) (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST StreetAddress {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(8);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns other designation (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OtherDesignation {
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
	/// Returns city (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST City {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(10);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns state or province (component #11).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST StateOrProvince {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(11);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns zip or postal code (component #12).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ZipOrPostalCode {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(12);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns country (component #13).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Country {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(13);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns address type (component #14).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID AddressType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(14);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns other geographic designation (component #15).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OtherGeographicDesignation {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(15);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}