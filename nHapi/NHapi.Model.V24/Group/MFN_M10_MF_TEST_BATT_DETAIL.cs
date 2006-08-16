using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v24.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M10_MF_TEST_BATT_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OM5 (Observation Batteries (Sets)) <b></b><br>
 * 1: OM4 (Observations that Require Specimens) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v24.group
{
[Serializable]
public class MFN_M10_MF_TEST_BATT_DETAIL : AbstractGroup {

	/** 
	 * Creates a new MFN_M10_MF_TEST_BATT_DETAIL Group.
	 */
	public MFN_M10_MF_TEST_BATT_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OM5", "2.4"), true, false);
	      this.add(factory.getSegmentClass("OM4", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M10_MF_TEST_BATT_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OM5 (Observation Batteries (Sets)) - creates it if necessary
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
	 * Returns  first repetition of OM4 (Observations that Require Specimens) - creates it if necessary
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
	 * (Observations that Require Specimens) - creates it if necessary
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
