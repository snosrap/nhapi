using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMG_O19_PRIOR_RESULT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OMG_O19_PATIENT_PRIOR (a Group object) <b>optional </b><br>
 * 1: OMG_O19_PATIENT_VISIT_PRIOR (a Group object) <b>optional </b><br>
 * 2: AL1 (Patient Allergy Information) <b>optional repeating</b><br>
 * 3: OMG_O19_ORDER_PRIOR (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OMG_O19_PRIOR_RESULT : AbstractGroup {

	/** 
	 * Creates a new OMG_O19_PRIOR_RESULT Group.
	 */
	public OMG_O19_PRIOR_RESULT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OMG_O19_PATIENT_PRIOR), false, false);
	      this.add(typeof(OMG_O19_PATIENT_VISIT_PRIOR), false, false);
	      this.add(typeof(AL1), false, true);
	      this.add(typeof(OMG_O19_ORDER_PRIOR), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMG_O19_PRIOR_RESULT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OMG_O19_PATIENT_PRIOR (a Group object) - creates it if necessary
	 */
	public OMG_O19_PATIENT_PRIOR PATIENT_PRIOR { 
get{
	   OMG_O19_PATIENT_PRIOR ret = null;
	   try {
	      ret = (OMG_O19_PATIENT_PRIOR)this.get_Renamed("PATIENT_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns OMG_O19_PATIENT_VISIT_PRIOR (a Group object) - creates it if necessary
	 */
	public OMG_O19_PATIENT_VISIT_PRIOR PATIENT_VISIT_PRIOR { 
get{
	   OMG_O19_PATIENT_VISIT_PRIOR ret = null;
	   try {
	      ret = (OMG_O19_PATIENT_VISIT_PRIOR)this.get_Renamed("PATIENT_VISIT_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of AL1 (Patient Allergy Information) - creates it if necessary
	 */
	public AL1 getAL1() {
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.get_Renamed("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of AL1
	 * (Patient Allergy Information) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public AL1 getAL1(int rep) { 
	   return (AL1)this.get_Renamed("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("AL1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of OMG_O19_ORDER_PRIOR (a Group object) - creates it if necessary
	 */
	public OMG_O19_ORDER_PRIOR getORDER_PRIOR() {
	   OMG_O19_ORDER_PRIOR ret = null;
	   try {
	      ret = (OMG_O19_ORDER_PRIOR)this.get_Renamed("ORDER_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OMG_O19_ORDER_PRIOR
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OMG_O19_ORDER_PRIOR getORDER_PRIOR(int rep) { 
	   return (OMG_O19_ORDER_PRIOR)this.get_Renamed("ORDER_PRIOR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OMG_O19_ORDER_PRIOR 
	 */ 
	public int ORDER_PRIORReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ORDER_PRIOR").Length; 
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
