using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the CSU_C09_STUDY_PHASE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: CSP (CSP - clinical study phase segment) <b>optional </b><br>
 * 1: CSU_C09_STUDY_SCHEDULE (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class CSU_C09_STUDY_PHASE : AbstractGroup {

	/** 
	 * Creates a new CSU_C09_STUDY_PHASE Group.
	 */
	public CSU_C09_STUDY_PHASE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("CSP", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("CSU_C09_STUDY_SCHEDULE", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C09_STUDY_PHASE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns CSP (CSP - clinical study phase segment) - creates it if necessary
	 */
	public CSP CSP { 
get{
	   CSP ret = null;
	   try {
	      ret = (CSP)this.get_Renamed("CSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
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
