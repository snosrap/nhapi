using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v22.datatype
{

///<summary>
/// <p>The HL7 CN_PHYSICIAN (CN für Ärzte) data type.  Consists of the following components: </p><ol>
/// <li>physician ID (ID)</li>
/// <li>familiy name (ST)</li>
/// <li>given name (ST)</li>
/// <li>middle initial or name (ST)</li>
/// <li>suffix (e.g. JR or III) (ST)</li>
/// <li>prefix (e.g. DR) (ST)</li>
/// <li>degree (e.g. MD) (ST)</li>
/// <li>source table id (ID)</li>
/// <li>Adresse (AD)</li>
/// <li>Telefon (TN)</li>
/// <li>Faxnummer (TN)</li>
/// <li>Online-Nummer (TN)</li>
/// <li>E-Mail (ST)</li>
/// </ol>
///</summary>
[Serializable]
public class CN_PHYSICIAN : AbstractType, Composite{
	private Type[] data;

	///<summary>
	/// Creates a CN_PHYSICIAN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CN_PHYSICIAN(Message message) : this(message, null){}

	///<summary>
	/// Creates a CN_PHYSICIAN.
	/// <param name="message">The Message to which this Type belongs</param>
	///</summary>
	public CN_PHYSICIAN(Message message, string description) : base(message, description){
		data = new Type[13];
		data[0] = new ID(message, 0,"Physician ID");
		data[1] = new ST(message,"Familiy name");
		data[2] = new ST(message,"Given name");
		data[3] = new ST(message,"Middle initial or name");
		data[4] = new ST(message,"Suffix (e.g. JR or III)");
		data[5] = new ST(message,"Prefix (e.g. DR)");
		data[6] = new ST(message,"Degree (e.g. MD)");
		data[7] = new ID(message, 0,"Source table id");
		data[8] = new AD(message,"Adresse");
		data[9] = new TN(message,"Telefon");
		data[10] = new TN(message,"Faxnummer");
		data[11] = new TN(message,"Online-Nummer");
		data[12] = new ST(message,"E-Mail");
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
			throw new DataTypeException("Element " + number + " doesn't exist in 13 element CN_PHYSICIAN composite"); 
		} 
	} 
	///<summary>
	/// Returns physician ID (component #0).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ID PhysicianID {
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
	///<summary>
	/// Returns Adresse (component #8).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public AD Adresse {
get{
	   AD ret = null;
	   try {
	      ret = (AD)getComponent(8);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Telefon (component #9).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TN Telefon {
get{
	   TN ret = null;
	   try {
	      ret = (TN)getComponent(9);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Faxnummer (component #10).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TN Faxnummer {
get{
	   TN ret = null;
	   try {
	      ret = (TN)getComponent(10);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns Online-Nummer (component #11).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public TN OnlineNummer {
get{
	   TN ret = null;
	   try {
	      ret = (TN)getComponent(11);
	   } catch (DataTypeException e) {
	      HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
}

}
	///<summary>
	/// Returns E-Mail (component #12).  This is a convenience method that saves you from 
	/// casting and handling an exception.
	///</summary>
	public ST EMail {
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
}}