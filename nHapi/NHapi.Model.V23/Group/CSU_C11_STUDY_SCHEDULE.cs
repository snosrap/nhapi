using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the CSU_C11_STUDY_SCHEDULE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: CSS (Clinical Study Data Schedule) <b>optional </b><br>
 * 1: CSU_C11_STUDY_OBSERVATION (a Group object) <b>optional repeating</b><br>
 * 2: CSU_C11_STUDY_PHARM (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class CSU_C11_STUDY_SCHEDULE : AbstractGroup {

	/** 
	 * Creates a new CSU_C11_STUDY_SCHEDULE Group.
	 */
	public CSU_C11_STUDY_SCHEDULE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("CSS", "2.3"), false, false);
	      this.add(factory.getGroupClass("CSU_C11_STUDY_OBSERVATION", "2.3"), false, true);
	      this.add(factory.getGroupClass("CSU_C11_STUDY_PHARM", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C11_STUDY_SCHEDULE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns CSS (Clinical Study Data Schedule) - creates it if necessary
	 */
	public CSS CSS { 
get{
	   CSS ret = null;
	   try {
	      ret = (CSS)this.get_Renamed("CSS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of CSU_C11_STUDY_OBSERVATION (a Group object) - creates it if necessary
	 */
	public CSU_C11_STUDY_OBSERVATION  getSTUDY_OBSERVATION() { 
	   CSU_C11_STUDY_OBSERVATION ret = null;
	   try {
	      ret = (CSU_C11_STUDY_OBSERVATION)this.get_Renamed("STUDY_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSU_C11_STUDY_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSU_C11_STUDY_OBSERVATION getSTUDY_OBSERVATION(int rep) { 
	   return (CSU_C11_STUDY_OBSERVATION)this.get_Renamed("STUDY_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSU_C11_STUDY_OBSERVATION 
	 */ 
	public int STUDY_OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("STUDY_OBSERVATION").Length; 
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
	 * Returns  first repetition of CSU_C11_STUDY_PHARM (a Group object) - creates it if necessary
	 */
	public CSU_C11_STUDY_PHARM  getSTUDY_PHARM() { 
	   CSU_C11_STUDY_PHARM ret = null;
	   try {
	      ret = (CSU_C11_STUDY_PHARM)this.get_Renamed("STUDY_PHARM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSU_C11_STUDY_PHARM
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSU_C11_STUDY_PHARM getSTUDY_PHARM(int rep) { 
	   return (CSU_C11_STUDY_PHARM)this.get_Renamed("STUDY_PHARM", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSU_C11_STUDY_PHARM 
	 */ 
	public int STUDY_PHARMReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("STUDY_PHARM").Length; 
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
