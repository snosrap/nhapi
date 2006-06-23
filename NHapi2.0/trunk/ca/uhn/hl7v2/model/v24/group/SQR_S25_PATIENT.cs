using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SQR_S25_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient identification) <b></b><br>
 * 1: PV1 (Patient visit) <b>optional </b><br>
 * 2: PV2 (Patient visit - additional information) <b>optional </b><br>
 * 3: DG1 (Diagnosis) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class SQR_S25_PATIENT : AbstractGroup {

	/** 
	 * Creates a new SQR_S25_PATIENT Group.
	 */
	public SQR_S25_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.4"), true, false);
	      this.add(factory.getSegmentClass("PV1", "2.4"), false, false);
	      this.add(factory.getSegmentClass("PV2", "2.4"), false, false);
	      this.add(factory.getSegmentClass("DG1", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SQR_S25_PATIENT - this is probably a bug in the source code generator.", e);
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
	 * Returns PV1 (Patient visit) - creates it if necessary
	 */
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.get_Renamed("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PV2 (Patient visit - additional information) - creates it if necessary
	 */
	public PV2 PV2 { 
get{
	   PV2 ret = null;
	   try {
	      ret = (PV2)this.get_Renamed("PV2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DG1 (Diagnosis) - creates it if necessary
	 */
	public DG1 DG1 { 
get{
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.get_Renamed("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
