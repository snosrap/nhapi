using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M10_MF_TEST_BATTERIES Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OM5 (Observation batteries) <b></b><br>
 * 1: OM4 (Observations that require specimens) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class MFN_M10_MF_TEST_BATTERIES : AbstractGroup {

	/** 
	 * Creates a new MFN_M10_MF_TEST_BATTERIES Group.
	 */
	public MFN_M10_MF_TEST_BATTERIES(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OM5", "2.3"), true, false);
	      this.add(factory.getSegmentClass("OM4", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M10_MF_TEST_BATTERIES - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OM5 (Observation batteries) - creates it if necessary
	 */
	public OM5 OM5 { 
get{
	   OM5 ret = null;
	   try {
	      ret = (OM5)this.get_Renamed("OM5");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OM4 (Observations that require specimens) - creates it if necessary
	 */
	public OM4  getOM4() { 
	   OM4 ret = null;
	   try {
	      ret = (OM4)this.get_Renamed("OM4");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OM4
	 * (Observations that require specimens) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OM4 getOM4(int rep) { 
	   return (OM4)this.get_Renamed("OM4", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OM4 
	 */ 
	public int OM4Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("OM4").Length; 
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
