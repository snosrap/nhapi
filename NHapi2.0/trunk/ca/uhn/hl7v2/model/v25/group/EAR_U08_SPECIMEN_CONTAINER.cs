using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the EAR_U08_SPECIMEN_CONTAINER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SAC (Specimen Container detail) <b></b><br>
 * 1: SPM (Specimen) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class EAR_U08_SPECIMEN_CONTAINER : AbstractGroup {

	/** 
	 * Creates a new EAR_U08_SPECIMEN_CONTAINER Group.
	 */
	public EAR_U08_SPECIMEN_CONTAINER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("SAC", "2.5"), true, false);
	      this.add(factory.getSegmentClass("SPM", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating EAR_U08_SPECIMEN_CONTAINER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns SAC (Specimen Container detail) - creates it if necessary
	 */
	public SAC SAC { 
get{
	   SAC ret = null;
	   try {
	      ret = (SAC)this.get_Renamed("SAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SPM (Specimen) - creates it if necessary
	 */
	public SPM  getSPM() { 
	   SPM ret = null;
	   try {
	      ret = (SPM)this.get_Renamed("SPM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SPM
	 * (Specimen) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SPM getSPM(int rep) { 
	   return (SPM)this.get_Renamed("SPM", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SPM 
	 */ 
	public int SPMReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("SPM").Length; 
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
