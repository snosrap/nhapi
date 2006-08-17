using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V21.Segment;

using NHapi.Base.Model;
/**
 * <p>Represents the ORU_R01_PATIENT_RESULT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORU_R01_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORU_R01_ORDER_OBSERVATION (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Model.V21.Group
{
[Serializable]
public class ORU_R01_PATIENT_RESULT : AbstractGroup {

	/** 
	 * Creates a new ORU_R01_PATIENT_RESULT Group.
	 */
	public ORU_R01_PATIENT_RESULT(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORU_R01_PATIENT), false, false);
	      this.add(typeof(ORU_R01_ORDER_OBSERVATION), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORU_R01_PATIENT_RESULT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORU_R01_PATIENT (a Group object) - creates it if necessary
	 */
	public ORU_R01_PATIENT PATIENT { 
get{
	   ORU_R01_PATIENT ret = null;
	   try {
	      ret = (ORU_R01_PATIENT)this.getStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ORU_R01_ORDER_OBSERVATION (a Group object) - creates it if necessary
	 */
	public ORU_R01_ORDER_OBSERVATION getORDER_OBSERVATION() {
	   ORU_R01_ORDER_OBSERVATION ret = null;
	   try {
	      ret = (ORU_R01_ORDER_OBSERVATION)this.getStructure("ORDER_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORU_R01_ORDER_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORU_R01_ORDER_OBSERVATION getORDER_OBSERVATION(int rep) { 
	   return (ORU_R01_ORDER_OBSERVATION)this.getStructure("ORDER_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORU_R01_ORDER_OBSERVATION 
	 */ 
	public int ORDER_OBSERVATIONReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ORDER_OBSERVATION").Length; 
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
