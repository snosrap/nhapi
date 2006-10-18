using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v21.group;
using ca.uhn.hl7v2.model.v21.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a ORU_R03 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: ORU_R03_PATIENT_RESULT (a Group object) <b>repeating</b><br>
 * 2: DSC (CONTINUATION POINTER) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v21.message

{
[Serializable]
public class ORU_R03 : AbstractMessage  {

	/** 
	 * Creates a new ORU_R03 Group with custom ModelClassFactory.
	 */
	public ORU_R03(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new ORU_R03 Group with DefaultModelClassFactory. 
	 */ 
	public ORU_R03() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(ORU_R03_PATIENT_RESULT), true, true);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORU_R03 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MESSAGE HEADER) - creates it if necessary
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
	 * Returns  first repetition of ORU_R03_PATIENT_RESULT (a Group object) - creates it if necessary
	 */
	public ORU_R03_PATIENT_RESULT getPATIENT_RESULT() {
	   ORU_R03_PATIENT_RESULT ret = null;
	   try {
	      ret = (ORU_R03_PATIENT_RESULT)this.get_Renamed("PATIENT_RESULT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORU_R03_PATIENT_RESULT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORU_R03_PATIENT_RESULT getPATIENT_RESULT(int rep) { 
	   return (ORU_R03_PATIENT_RESULT)this.get_Renamed("PATIENT_RESULT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORU_R03_PATIENT_RESULT 
	 */ 
	public int PATIENT_RESULTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("PATIENT_RESULT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns DSC (CONTINUATION POINTER) - creates it if necessary
	 */
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.get_Renamed("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
