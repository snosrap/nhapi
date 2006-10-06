using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v25.datatype
{

///<summary>
/// <p>The HL7 XTN (Extended Telecommunication Number) data type.  Consists of the following components: </p><ol>
/// <li>Telephone Number (ST)</li>
/// <li>Telecommunication Use Code (ID)</li>
/// <li>Telecommunication Equipment Type (ID)</li>
/// <li>Email Address (ST)</li>
/// <li>Country Code (NM)</li>
/// <li>Area/City Code (NM)</li>
/// <li>Local Number (NM)</li>
/// <li>Extension (NM)</li>
/// <li>Any Text (ST)</li>
/// <li>Extension Prefix (ST)</li>
/// <li>Speed Dial Code (ST)</li>
/// <li>Unformatted Telephone number (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class XTN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a XTN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public XTN(Message message) : this(message, null){}

	///<summary>
	/// Creates a XTN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public XTN(Message message, string description) : base(message, description){
		data = new Type[12];
		data[0] = new ST(message,"Telephone Number");
		data[1] = new ID(message, 201,"Telecommunication Use Code");
		data[2] = new ID(message, 202,"Telecommunication Equipment Type");
		data[3] = new ST(message,"Email Address");
		data[4] = new NM(message,"Country Code");
		data[5] = new NM(message,"Area/City Code");
		data[6] = new NM(message,"Local Number");
		data[7] = new NM(message,"Extension");
		data[8] = new ST(message,"Any Text");
		data[9] = new ST(message,"Extension Prefix");
		data[10] = new ST(message,"Speed Dial Code");
		data[11] = new ST(message,"Unformatted Telephone number");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 12 element XTN composite"); 
		} 
	} 
	///<summary>
	/// Returns Telephone Number (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST TelephoneNumber {
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
	/// Returns Telecommunication Use Code (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID TelecommunicationUseCode {
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
	///<summary>
	/// Returns Telecommunication Equipment Type (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID TelecommunicationEquipmentType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(2);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Email Address (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST EmailAddress {
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
	/// Returns Country Code (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM CountryCode {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(4);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Area/City Code (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM AreaCityCode {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Local Number (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM LocalNumber {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Extension (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public NM Extension {
get{
	   NM ret = null;
	   try {
	      ret = (NM)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Any Text (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST AnyText {
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
	/// Returns Extension Prefix (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ExtensionPrefix {
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
	/// Returns Speed Dial Code (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST SpeedDialCode {
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
	/// Returns Unformatted Telephone number (component #11).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST UnformattedTelephoneNumber {
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
}}