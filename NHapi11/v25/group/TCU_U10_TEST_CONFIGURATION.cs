using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the TCU_U10_TEST_CONFIGURATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SPM (Specimen) <b>optional </b><br>
 * 1: TCC (Test Code Configuration) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class TCU_U10_TEST_CONFIGURATION : AbstractGroup {

	/** 
	 * Creates a new TCU_U10_TEST_CONFIGURATION Group.
	 */
	public TCU_U10_TEST_CONFIGURATION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(SPM), false, false);
	      this.add(typeof(TCC), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating TCU_U10_TEST_CONFIGURATION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns SPM (Specimen) - creates it if necessary
	 */
	public SPM SPM { 
get{
	   SPM ret = null;
	   try {
	      ret = (SPM)this.get_Renamed("SPM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of TCC (Test Code Configuration) - creates it if necessary
	 */
	public TCC getTCC() {
	   TCC ret = null;
	   try {
	      ret = (TCC)this.get_Renamed("TCC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of TCC
	 * (Test Code Configuration) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public TCC getTCC(int rep) { 
	   return (TCC)this.get_Renamed("TCC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of TCC 
	 */ 
	public int TCCReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("TCC").Length; 
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
