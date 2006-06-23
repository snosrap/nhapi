using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPT_PCL_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient identification) <b></b><br>
 * 1: PPT_PCL_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 2: PPT_PCL_PATHWAY (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class PPT_PCL_PATIENT : AbstractGroup {

	/** 
	 * Creates a new PPT_PCL_PATIENT Group.
	 */
	public PPT_PCL_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.4"), true, false);
	      this.add(factory.getGroupClass("PPT_PCL_PATIENT_VISIT", "2.4"), false, false);
	      this.add(factory.getGroupClass("PPT_PCL_PATHWAY", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPT_PCL_PATIENT - this is probably a bug in the source code generator.", e);
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
	 * Returns PPT_PCL_PATIENT_VISIT (a Group object) - creates it if necessary
	 */
	public PPT_PCL_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PPT_PCL_PATIENT_VISIT ret = null;
	   try {
	      ret = (PPT_PCL_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PPT_PCL_PATHWAY (a Group object) - creates it if necessary
	 */
	public PPT_PCL_PATHWAY  getPATHWAY() { 
	   PPT_PCL_PATHWAY ret = null;
	   try {
	      ret = (PPT_PCL_PATHWAY)this.get_Renamed("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPT_PCL_PATHWAY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPT_PCL_PATHWAY getPATHWAY(int rep) { 
	   return (PPT_PCL_PATHWAY)this.get_Renamed("PATHWAY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPT_PCL_PATHWAY 
	 */ 
	public int PATHWAYReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PATHWAY").Length; 
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
