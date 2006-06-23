using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMG_O19_PATIENT_PRIOR Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient identification) <b></b><br>
 * 1: PD1 (patient additional demographic) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class OMG_O19_PATIENT_PRIOR : AbstractGroup {

	/** 
	 * Creates a new OMG_O19_PATIENT_PRIOR Group.
	 */
	public OMG_O19_PATIENT_PRIOR(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.4"), true, false);
	      this.add(factory.getSegmentClass("PD1", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMG_O19_PATIENT_PRIOR - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PID (Patient identification) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PD1 (patient additional demographic) - creates it if necessary
	 */
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.get_Renamed("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
