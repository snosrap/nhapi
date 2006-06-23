using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the CSU_C09_STUDY_PHASE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: CSP (Clinical Study Phase) <b>optional repeating</b><br>
 * 1: CSU_C09_STUDY_SCHEDULE (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class CSU_C09_STUDY_PHASE : AbstractGroup {

	/** 
	 * Creates a new CSU_C09_STUDY_PHASE Group.
	 */
	public CSU_C09_STUDY_PHASE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("CSP", "2.4"), false, true);
	      this.add(factory.getGroupClass("CSU_C09_STUDY_SCHEDULE", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C09_STUDY_PHASE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns  first repetition of CSP (Clinical Study Phase) - creates it if necessary
	 */
	public CSP  getCSP() { 
	   CSP ret = null;
	   try {
	      ret = (CSP)this.get_Renamed("CSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSP
	 * (Clinical Study Phase) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSP getCSP(int rep) { 
	   return (CSP)this.get_Renamed("CSP", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSP 
	 */ 
	public int CSPReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("CSP").Length; 
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

	/**
	 * Returns  first repetition of CSU_C09_STUDY_SCHEDULE (a Group object) - creates it if necessary
	 */
	public CSU_C09_STUDY_SCHEDULE  getSTUDY_SCHEDULE() { 
	   CSU_C09_STUDY_SCHEDULE ret = null;
	   try {
	      ret = (CSU_C09_STUDY_SCHEDULE)this.get_Renamed("STUDY_SCHEDULE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSU_C09_STUDY_SCHEDULE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSU_C09_STUDY_SCHEDULE getSTUDY_SCHEDULE(int rep) { 
	   return (CSU_C09_STUDY_SCHEDULE)this.get_Renamed("STUDY_SCHEDULE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSU_C09_STUDY_SCHEDULE 
	 */ 
	public int STUDY_SCHEDULEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("STUDY_SCHEDULE").Length; 
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
