using System;
using NHapi.Base.Log;
using NHapi.Model.V21.Group;
using NHapi.Model.V21.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

/**
 * <p>Represents a ORU_R01 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: ORU_R01_PATIENT_RESULT (a Group object) <b>repeating</b><br>
 * 2: DSC (CONTINUATION POINTER) <b>optional </b><br>
 */
namespace NHapi.Model.V21.Message

{
[Serializable]
public class ORU_R01 : AbstractMessage  {

	/** 
	 * Creates a new ORU_R01 Group with custom IModelClassFactory.
	 */
	public ORU_R01(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new ORU_R01 Group with DefaultModelClassFactory. 
	 */ 
	public ORU_R01() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(ORU_R01_PATIENT_RESULT), true, true);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORU_R01 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MESSAGE HEADER) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.getStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ORU_R01_PATIENT_RESULT (a Group object) - creates it if necessary
	 */
	public ORU_R01_PATIENT_RESULT getPATIENT_RESULT() {
	   ORU_R01_PATIENT_RESULT ret = null;
	   try {
	      ret = (ORU_R01_PATIENT_RESULT)this.getStructure("PATIENT_RESULT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORU_R01_PATIENT_RESULT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORU_R01_PATIENT_RESULT getPATIENT_RESULT(int rep) { 
	   return (ORU_R01_PATIENT_RESULT)this.getStructure("PATIENT_RESULT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORU_R01_PATIENT_RESULT 
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
	      ret = (DSC)this.getStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
