using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SIU_S12_RESOURCES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RGS (Resource Group) <b></b><br>
 * 1: SIU_S12_SERVICE (a Group object) <b></b><br>
 * 2: SIU_S12_GENERAL_RESOURCE (a Group object) <b></b><br>
 * 3: SIU_S12_LOCATION_RESOURCE (a Group object) <b></b><br>
 * 4: SIU_S12_PERSONNEL_RESOURCE (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class SIU_S12_RESOURCES : AbstractGroup {

	/** 
	 * Creates a new SIU_S12_RESOURCES Group.
	 */
	public SIU_S12_RESOURCES(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RGS), true, false);
	      this.add(typeof(SIU_S12_SERVICE), true, false);
	      this.add(typeof(SIU_S12_GENERAL_RESOURCE), true, false);
	      this.add(typeof(SIU_S12_LOCATION_RESOURCE), true, false);
	      this.add(typeof(SIU_S12_PERSONNEL_RESOURCE), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SIU_S12_RESOURCES - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RGS (Resource Group) - creates it if necessary
	 */
	public RGS RGS { 
get{
	   RGS ret = null;
	   try {
	      ret = (RGS)this.get_Renamed("RGS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SIU_S12_SERVICE (a Group object) - creates it if necessary
	 */
	public SIU_S12_SERVICE SERVICE { 
get{
	   SIU_S12_SERVICE ret = null;
	   try {
	      ret = (SIU_S12_SERVICE)this.get_Renamed("SERVICE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SIU_S12_GENERAL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SIU_S12_GENERAL_RESOURCE GENERAL_RESOURCE { 
get{
	   SIU_S12_GENERAL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S12_GENERAL_RESOURCE)this.get_Renamed("GENERAL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SIU_S12_LOCATION_RESOURCE (a Group object) - creates it if necessary
	 */
	public SIU_S12_LOCATION_RESOURCE LOCATION_RESOURCE { 
get{
	   SIU_S12_LOCATION_RESOURCE ret = null;
	   try {
	      ret = (SIU_S12_LOCATION_RESOURCE)this.get_Renamed("LOCATION_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SIU_S12_PERSONNEL_RESOURCE (a Group object) - creates it if necessary
	 */
	public SIU_S12_PERSONNEL_RESOURCE PERSONNEL_RESOURCE { 
get{
	   SIU_S12_PERSONNEL_RESOURCE ret = null;
	   try {
	      ret = (SIU_S12_PERSONNEL_RESOURCE)this.get_Renamed("PERSONNEL_RESOURCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
