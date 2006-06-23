using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the CSU_C09_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (PID - patient identification segment) <b></b><br>
 * 1: PD1 (PD1 - patient additional demographic segment) <b>optional </b><br>
 * 2: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
 * 3: CSU_C09_VISIT (a Group object) <b>optional </b><br>
 * 4: CSR (CSR - clinical study registration segment) <b></b><br>
 * 5: CSU_C09_STUDY_PHASE (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class CSU_C09_PATIENT : AbstractGroup {

	/** 
	 * Creates a new CSU_C09_PATIENT Group.
	 */
	public CSU_C09_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("PD1", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("NTE", "2.3.1"), false, true);
	      this.add(factory.getGroupClass("CSU_C09_VISIT", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("CSR", "2.3.1"), true, false);
	      this.add(factory.getGroupClass("CSU_C09_STUDY_PHASE", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C09_PATIENT - this is probably a bug in the source code generator.", e);
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
	 * Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
	 */
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.get_Renamed("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
	 */
	public NTE  getNTE() { 
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (NTE - notes and comments segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.get_Renamed("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NTE").Length; 
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
	 * Returns CSU_C09_VISIT (a Group object) - creates it if necessary
	 */
	public CSU_C09_VISIT VISIT { 
get{
	   CSU_C09_VISIT ret = null;
	   try {
	      ret = (CSU_C09_VISIT)this.get_Renamed("VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns CSR (CSR - clinical study registration segment) - creates it if necessary
	 */
	public CSR CSR { 
get{
	   CSR ret = null;
	   try {
	      ret = (CSR)this.get_Renamed("CSR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of CSU_C09_STUDY_PHASE (a Group object) - creates it if necessary
	 */
	public CSU_C09_STUDY_PHASE  getSTUDY_PHASE() { 
	   CSU_C09_STUDY_PHASE ret = null;
	   try {
	      ret = (CSU_C09_STUDY_PHASE)this.get_Renamed("STUDY_PHASE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSU_C09_STUDY_PHASE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSU_C09_STUDY_PHASE getSTUDY_PHASE(int rep) { 
	   return (CSU_C09_STUDY_PHASE)this.get_Renamed("STUDY_PHASE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSU_C09_STUDY_PHASE 
	 */ 
	public int STUDY_PHASEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("STUDY_PHASE").Length; 
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
