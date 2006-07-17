using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v21.group;
using ca.uhn.hl7v2.model.v21.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a ADT_A17 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: EVN (EVENT TYPE) <b></b><br>
 * 2: ADT_A17_PATIENT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v21.message

{
[Serializable]
public class ADT_A17 : AbstractMessage  {

	/** 
	 * Creates a new ADT_A17 Group with custom ModelClassFactory.
	 */
	public ADT_A17(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new ADT_A17 Group with DefaultModelClassFactory. 
	 */ 
	public ADT_A17() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(EVN), true, false);
	      this.add(typeof(ADT_A17_PATIENT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A17 - this is probably a bug in the source code generator.", e);
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
	 * Returns EVN (EVENT TYPE) - creates it if necessary
	 */
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.get_Renamed("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ADT_A17_PATIENT (a Group object) - creates it if necessary
	 */
	public ADT_A17_PATIENT getPATIENT() {
	   ADT_A17_PATIENT ret = null;
	   try {
	      ret = (ADT_A17_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ADT_A17_PATIENT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ADT_A17_PATIENT getPATIENT(int rep) { 
	   return (ADT_A17_PATIENT)this.get_Renamed("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ADT_A17_PATIENT 
	 */ 
	public int PATIENTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("PATIENT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
