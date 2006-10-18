using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M06_MF_CLIN_STUDY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: CM0 (Clinical Study Master) <b></b><br>
 * 2: MFN_M06_MF_PHASE_SCHED_DETAIL (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class MFN_M06_MF_CLIN_STUDY : AbstractGroup {

	/** 
	 * Creates a new MFN_M06_MF_CLIN_STUDY Group.
	 */
	public MFN_M06_MF_CLIN_STUDY(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(CM0), true, false);
	      this.add(typeof(MFN_M06_MF_PHASE_SCHED_DETAIL), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M06_MF_CLIN_STUDY - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (Master File Entry) - creates it if necessary
	 */
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.get_Renamed("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns CM0 (Clinical Study Master) - creates it if necessary
	 */
	public CM0 CM0 { 
get{
	   CM0 ret = null;
	   try {
	      ret = (CM0)this.get_Renamed("CM0");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns MFN_M06_MF_PHASE_SCHED_DETAIL (a Group object) - creates it if necessary
	 */
	public MFN_M06_MF_PHASE_SCHED_DETAIL MF_PHASE_SCHED_DETAIL { 
get{
	   MFN_M06_MF_PHASE_SCHED_DETAIL ret = null;
	   try {
	      ret = (MFN_M06_MF_PHASE_SCHED_DETAIL)this.get_Renamed("MF_PHASE_SCHED_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
