using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PRR_PC5_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (PID - patient identification segment) <b></b><br>
 * 1: PRR_PC5_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 2: PRR_PC5_PROBLEM (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class PRR_PC5_PATIENT : AbstractGroup {

	/** 
	 * Creates a new PRR_PC5_PATIENT Group.
	 */
	public PRR_PC5_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.3.1"), true, false);
	      this.add(factory.getGroupClass("PRR_PC5_PATIENT_VISIT", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("PRR_PC5_PROBLEM", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PRR_PC5_PATIENT - this is probably a bug in the source code generator.", e);
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
	 * Returns PRR_PC5_PATIENT_VISIT (a Group object) - creates it if necessary
	 */
	public PRR_PC5_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PRR_PC5_PATIENT_VISIT ret = null;
	   try {
	      ret = (PRR_PC5_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PRR_PC5_PROBLEM (a Group object) - creates it if necessary
	 */
	public PRR_PC5_PROBLEM  getPROBLEM() { 
	   PRR_PC5_PROBLEM ret = null;
	   try {
	      ret = (PRR_PC5_PROBLEM)this.get_Renamed("PROBLEM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PRR_PC5_PROBLEM
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PRR_PC5_PROBLEM getPROBLEM(int rep) { 
	   return (PRR_PC5_PROBLEM)this.get_Renamed("PROBLEM", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRR_PC5_PROBLEM 
	 */ 
	public int PROBLEMReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROBLEM").Length; 
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
