using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPV_PCA_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (PID - patient identification segment) <b></b><br>
 * 1: PPV_PCA_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 2: PPV_PCA_GOAL (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class PPV_PCA_PATIENT : AbstractGroup {

	/** 
	 * Creates a new PPV_PCA_PATIENT Group.
	 */
	public PPV_PCA_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.3.1"), true, false);
	      this.add(factory.getGroupClass("PPV_PCA_PATIENT_VISIT", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("PPV_PCA_GOAL", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPV_PCA_PATIENT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PID (PID - patient identification segment) - creates it if necessary
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
	 * Returns PPV_PCA_PATIENT_VISIT (a Group object) - creates it if necessary
	 */
	public PPV_PCA_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PPV_PCA_PATIENT_VISIT ret = null;
	   try {
	      ret = (PPV_PCA_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PPV_PCA_GOAL (a Group object) - creates it if necessary
	 */
	public PPV_PCA_GOAL  getGOAL() { 
	   PPV_PCA_GOAL ret = null;
	   try {
	      ret = (PPV_PCA_GOAL)this.get_Renamed("GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPV_PCA_GOAL
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPV_PCA_GOAL getGOAL(int rep) { 
	   return (PPV_PCA_GOAL)this.get_Renamed("GOAL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPV_PCA_GOAL 
	 */ 
	public int GOALReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GOAL").Length; 
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
