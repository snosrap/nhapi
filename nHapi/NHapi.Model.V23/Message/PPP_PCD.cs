using System;
using ca.uhn.log;
using NHapi.Base.model.v23.group;
using NHapi.Base.model.v23.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a PPP_PCD message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: PID (Patient Identification) <b></b><br>
 * 2: PPP_PCD_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 3: PPP_PCD_PATHWAY (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Base.model.v23.message

{
[Serializable]
public class PPP_PCD : AbstractMessage  {

	/** 
	 * Creates a new PPP_PCD Group with custom ModelClassFactory.
	 */
	public PPP_PCD(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new PPP_PCD Group with DefaultModelClassFactory. 
	 */ 
	public PPP_PCD() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3"), true, false);
	      this.add(factory.getSegmentClass("PID", "2.3"), true, false);
	      this.add(factory.getGroupClass("PPP_PCD_PATIENT_VISIT", "2.3"), false, false);
	      this.add(factory.getGroupClass("PPP_PCD_PATHWAY", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPP_PCD - this is probably a bug in the source code generator.", e);
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
	 * Returns PPP_PCD_PATIENT_VISIT (a Group object) - creates it if necessary
	 */
	public PPP_PCD_PATIENT_VISIT PATIENT_VISIT { 
get{
	   PPP_PCD_PATIENT_VISIT ret = null;
	   try {
	      ret = (PPP_PCD_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PPP_PCD_PATHWAY (a Group object) - creates it if necessary
	 */
	public PPP_PCD_PATHWAY  getPATHWAY() { 
	   PPP_PCD_PATHWAY ret = null;
	   try {
	      ret = (PPP_PCD_PATHWAY)this.get_Renamed("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPP_PCD_PATHWAY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPP_PCD_PATHWAY getPATHWAY(int rep) { 
	   return (PPP_PCD_PATHWAY)this.get_Renamed("PATHWAY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPP_PCD_PATHWAY 
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
