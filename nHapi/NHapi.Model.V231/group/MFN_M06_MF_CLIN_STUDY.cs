using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M06_MF_CLIN_STUDY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (MFE - master file entry segment) <b></b><br>
 * 1: CM0 (CM0 - clinical study master segment) <b></b><br>
 * 2: MFN_M06_MF_PHASE_SCHED_DETAIL (a Group object) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class MFN_M06_MF_CLIN_STUDY : AbstractGroup {

	/** 
	 * Creates a new MFN_M06_MF_CLIN_STUDY Group.
	 */
	public MFN_M06_MF_CLIN_STUDY(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("CM0", "2.3.1"), true, false);
	      this.add(factory.getGroupClass("MFN_M06_MF_PHASE_SCHED_DETAIL", "2.3.1"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M06_MF_CLIN_STUDY - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (MFE - master file entry segment) - creates it if necessary
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
	 * Returns CM0 (CM0 - clinical study master segment) - creates it if necessary
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
	 * Returns  first repetition of MFN_M06_MF_PHASE_SCHED_DETAIL (a Group object) - creates it if necessary
	 */
	public MFN_M06_MF_PHASE_SCHED_DETAIL  getMF_PHASE_SCHED_DETAIL() { 
	   MFN_M06_MF_PHASE_SCHED_DETAIL ret = null;
	   try {
	      ret = (MFN_M06_MF_PHASE_SCHED_DETAIL)this.get_Renamed("MF_PHASE_SCHED_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of MFN_M06_MF_PHASE_SCHED_DETAIL
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public MFN_M06_MF_PHASE_SCHED_DETAIL getMF_PHASE_SCHED_DETAIL(int rep) { 
	   return (MFN_M06_MF_PHASE_SCHED_DETAIL)this.get_Renamed("MF_PHASE_SCHED_DETAIL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFN_M06_MF_PHASE_SCHED_DETAIL 
	 */ 
	public int MF_PHASE_SCHED_DETAILReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("MF_PHASE_SCHED_DETAIL").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
