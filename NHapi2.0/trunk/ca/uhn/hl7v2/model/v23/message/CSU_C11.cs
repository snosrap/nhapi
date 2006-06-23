using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a CSU_C11 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: CSU_C11_PATIENT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
[Serializable]
public class CSU_C11 : AbstractMessage  {

	/** 
	 * Creates a new CSU_C11 Group with custom ModelClassFactory.
	 */
	public CSU_C11(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new CSU_C11 Group with DefaultModelClassFactory. 
	 */ 
	public CSU_C11() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3"), true, false);
	      this.add(factory.getGroupClass("CSU_C11_PATIENT", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C11 - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of CSU_C11_PATIENT (a Group object) - creates it if necessary
	 */
	public CSU_C11_PATIENT  getPATIENT() { 
	   CSU_C11_PATIENT ret = null;
	   try {
	      ret = (CSU_C11_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSU_C11_PATIENT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSU_C11_PATIENT getPATIENT(int rep) { 
	   return (CSU_C11_PATIENT)this.get_Renamed("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSU_C11_PATIENT 
	 */ 
	public int PATIENTReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PATIENT").Length; 
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
