using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

///<summary>
/// <p>The HL7 XAD (extended address) data type.  Consists of the following components: </p><ol>
/// <li>street address (SAD) (SAD)</li>
/// <li>other designation (ST)</li>
/// <li>city (ST)</li>
/// <li>state or province (ST)</li>
/// <li>zip or postal code (ST)</li>
/// <li>country (ID)</li>
/// <li>address type (ID)</li>
/// <li>other geographic designation (ST)</li>
/// <li>county/parish code (IS)</li>
/// <li>census tract (IS)</li>
/// <li>address representation code (ID)</li>
/// <li>address validity range (DR)</li>
/// </ol>
///</summary>
[Serializable]
public class XAD : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a XAD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public XAD(Message message) : this(message, null){}

	///<summary>
	/// Creates a XAD.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public XAD(Message message, string description) : base(message, description){
		data = new Type[12];
		data[0] = new SAD(message,"Street address (SAD)");
		data[1] = new ST(message,"Other designation");
		data[2] = new ST(message,"City");
		data[3] = new ST(message,"State or province");
		data[4] = new ST(message,"Zip or postal code");
		data[5] = new ID(message, 0,"Country");
		data[6] = new ID(message, 0,"Address type");
		data[7] = new ST(message,"Other geographic designation");
		data[8] = new IS(message, 0,"County/parish code");
		data[9] = new IS(message, 0,"Census tract");
		data[10] = new ID(message, 0,"Address representation code");
		data[11] = new DR(message,"Address validity range");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 12 element XAD composite"); 
		} 
	} 
	///<summary>
	/// Returns street address (SAD) (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public SAD StreetAddress {
get{
	   SAD ret = null;
	   try {
	      ret = (SAD)getComponent(0);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns other designation (component #1).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OtherDesignation {
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
	/// Returns city (component #2).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST City {
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
	/// Returns state or province (component #3).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST StateOrProvince {
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
	/// Returns zip or postal code (component #4).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST ZipOrPostalCode {
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
	/// Returns country (component #5).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID Country {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(5);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns address type (component #6).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID AddressType {
get{
	   ID ret = null;
	   try {
	      ret = (ID)getComponent(6);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns other geographic designation (component #7).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST OtherGeographicDesignation {
get{
	   ST ret = null;
	   try {
	      ret = (ST)getComponent(7);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns county/parish code (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS CountyParishCode {
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
	/// Returns census tract (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public IS CensusTract {
get{
	   IS ret = null;
	   try {
	      ret = (IS)getComponent(9);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns address representation code (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID AddressRepresentationCode {
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
	///<summary>
	/// Returns address validity range (component #11).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public DR AddressValidityRange {
get{
	   DR ret = null;
	   try {
	      ret = (DR)getComponent(11);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
}}