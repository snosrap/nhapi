using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a PPP_PCB message structure (see chapter 12). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: PID (Patient identification) <b></b><br>
 * 2: PPP_PCB_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 3: PPP_PCB_PATHWAY (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class PPP_PCB : AbstractMessage  {

	/** 
	 * Creates a new PPP_PCB Group with custom ModelClassFactory.
	 */
	public PPP_PCB(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new PPP_PCB Group with DefaultModelClassFactory. 
	 */ 
	public PPP_PCB() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("PID", "2.4"), true, false);
	      this.add(factory.getGroupClass("PPP_PCB_PATIENT_VISIT", "2.4"), false, false);
	      this.add(factory.getGroupClass("PPP_PCB_PATHWAY", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPP_PCB - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message Header) - creates it if necessary
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
	 * Returns PPP_PCB_PATIENT_VISIT (a Group object) - creates it if necessary
	 */
	public PPP_PCB_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PPP_PCB_PATIENT_VISIT ret = null;
	   try {
	      ret = (PPP_PCB_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PPP_PCB_PATHWAY (a Group object) - creates it if necessary
	 */
	public PPP_PCB_PATHWAY  getPATHWAY() { 
	   PPP_PCB_PATHWAY ret = null;
	   try {
	      ret = (PPP_PCB_PATHWAY)this.get_Renamed("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPP_PCB_PATHWAY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPP_PCB_PATHWAY getPATHWAY(int rep) { 
	   return (PPP_PCB_PATHWAY)this.get_Renamed("PATHWAY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPP_PCB_PATHWAY 
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
