using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M04_MF_CDM Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (MFE - master file entry segment) <b></b><br>
 * 1: CDM (CDM -  charge description master segment) <b></b><br>
 * 2: PRC (PRC -  pricing segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class MFN_M04_MF_CDM : AbstractGroup {

	/** 
	 * Creates a new MFN_M04_MF_CDM Group.
	 */
	public MFN_M04_MF_CDM(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("CDM", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("PRC", "2.3.1"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M04_MF_CDM - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (MFE - master file entry segment) - creates it if necessary
	 */
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.get_Renamed("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns CDM (CDM -  charge description master segment) - creates it if necessary
	 */
	public CDM CDM { 
get{
	   CDM ret = null;
	   try {
	      ret = (CDM)this.get_Renamed("CDM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PRC (PRC -  pricing segment) - creates it if necessary
	 */
	public PRC  getPRC() { 
	   PRC ret = null;
	   try {
	      ret = (PRC)this.get_Renamed("PRC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PRC
	 * (PRC -  pricing segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PRC getPRC(int rep) { 
	   return (PRC)this.get_Renamed("PRC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRC 
	 */ 
	public int PRCReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PRC").Length; 
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
