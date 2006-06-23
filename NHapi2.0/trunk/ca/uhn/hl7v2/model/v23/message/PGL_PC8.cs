using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a PGL_PC8 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: PID (Patient Identification) <b></b><br>
 * 2: PGL_PC8_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 3: PGL_PC8_GOAL (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
[Serializable]
public class PGL_PC8 : AbstractMessage  {

	/** 
	 * Creates a new PGL_PC8 Group with custom ModelClassFactory.
	 */
	public PGL_PC8(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new PGL_PC8 Group with DefaultModelClassFactory. 
	 */ 
	public PGL_PC8() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3"), true, false);
	      this.add(factory.getSegmentClass("PID", "2.3"), true, false);
	      this.add(factory.getGroupClass("PGL_PC8_PATIENT_VISIT", "2.3"), false, false);
	      this.add(factory.getGroupClass("PGL_PC8_GOAL", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PGL_PC8 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message header segment) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.get_Renamed("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PID (Patient Identification) - creates it if necessary
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
	 * Returns PGL_PC8_PATIENT_VISIT (a Group object) - creates it if necessary
	 */
	public PGL_PC8_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PGL_PC8_PATIENT_VISIT ret = null;
	   try {
	      ret = (PGL_PC8_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PGL_PC8_GOAL (a Group object) - creates it if necessary
	 */
	public PGL_PC8_GOAL  getGOAL() { 
	   PGL_PC8_GOAL ret = null;
	   try {
	      ret = (PGL_PC8_GOAL)this.get_Renamed("GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC8_GOAL
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC8_GOAL getGOAL(int rep) { 
	   return (PGL_PC8_GOAL)this.get_Renamed("GOAL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC8_GOAL 
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
