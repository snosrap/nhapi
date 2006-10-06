using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 LA2 (Location with Address Variation 2) data type.  Consists of the following components: </p><ol>
/// <li>Point of Care (IS)</li>
/// <li>Room (IS)</li>
/// <li>Bed (IS)</li>
/// <li>Facility (HD)</li>
/// <li>Location Status (IS)</li>
/// <li>Patient Location Type (IS)</li>
/// <li>Building (IS)</li>
/// <li>Floor (IS)</li>
/// <li>Street Address (ST)</li>
/// <li>Other Designation (ST)</li>
/// <li>City (ST)</li>
/// <li>State or Province (ST)</li>
/// <li>Zip or Postal Code (ST)</li>
/// <li>Country (ID)</li>
/// <li>Address Type (ID)</li>
/// <li>Other Geographic Designation (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class LA2 : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a LA2.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public LA2(Message message) : this(message, null){}

	///<summary>
	/// Creates a LA2.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public LA2(Message message, string description) : base(message, description){
		data = new Type[16];
		data[0] = new IS(message, 302,"Point of Care");
		data[1] = new IS(message, 303,"Room");
		data[2] = new IS(message, 304,"Bed");
		data[3] = new HD(message,"Facility");
		data[4] = new IS(message, 306,"Location Status");
		data[5] = new IS(message, 305,"Patient Location Type");
		data[6] = new IS(message, 307,"Building");
		data[7] = new IS(message, 308,"Floor");
		data[8] = new ST(message,"Street Address");
		data[9] = new ST(message,"Other Designation");
		data[10] = new ST(message,"City");
		data[11] = new ST(message,"State or Province");
		data[12] = new ST(message,"Zip or Postal Code");
		data[13] = new ID(message, 399,"Country");
		data[14] = new ID(message, 190,"Address Type");
		data[15] = new ST(message,"Other Geographic Designation");
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
	/// Returns Point of Care (component #0).  This is a convenience method that saves you from 
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
	/// Returns Room (component #1).  This is a convenience method that saves you from 
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
	/// Returns Bed (component #2).  This is a convenience method that saves you from 
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
	/// Returns Facility (component #3).  This is a convenience method that saves you from 
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
	/// Returns Location Status (component #4).  This is a convenience method that saves you from 
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
	/// Returns Patient Location Type (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS PatientLocationType {
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
	/// Returns Building (component #6).  This is a convenience method that saves you from 
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
	/// Returns Floor (component #7).  This is a convenience method that saves you from 
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
	/// Returns Street Address (component #8).  This is a convenience method that saves you from 
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
	/// Returns Other Designation (component #9).  This is a convenience method that saves you from 
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
	/// Returns City (component #10).  This is a convenience method that saves you from 
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
	/// Returns State or Province (component #11).  This is a convenience method that saves you from 
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
	/// Returns Zip or Postal Code (component #12).  This is a convenience method that saves you from 
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
	/// Returns Country (component #13).  This is a convenience method that saves you from 
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
	/// Returns Address Type (component #14).  This is a convenience method that saves you from 
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
	/// Returns Other Geographic Designation (component #15).  This is a convenience method that saves you from 
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