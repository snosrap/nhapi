using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OSR_Q06_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OSR_Q06_PATIENT (a Group object) <b>optional </b><br>
 * 1: OSR_Q06_OBSERVATION (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class OSR_Q06_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new OSR_Q06_RESPONSE Group.
	 */
	public OSR_Q06_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("OSR_Q06_PATIENT", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("OSR_Q06_OBSERVATION", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OSR_Q06_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OSR_Q06_PATIENT (a Group object) - creates it if necessary
	 */
	public OSR_Q06_PATIENT PATIENT { 
get{
	   OSR_Q06_PATIENT ret = null;
	   try {
	      ret = (OSR_Q06_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OSR_Q06_OBSERVATION (a Group object) - creates it if necessary
	 */
	public OSR_Q06_OBSERVATION  getOBSERVATION() { 
	   OSR_Q06_OBSERVATION ret = null;
	   try {
	      ret = (OSR_Q06_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OSR_Q06_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OSR_Q06_OBSERVATION getOBSERVATION(int rep) { 
	   return (OSR_Q06_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OSR_Q06_OBSERVATION 
	 */ 
	public int OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("OBSERVATION").Length; 
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
