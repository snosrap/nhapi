using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M09_MF_TEST_CAT_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OM3 (Categorical test/observation) <b></b><br>
 * 1: OM4 (Observations that require specimens) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class MFN_M09_MF_TEST_CAT_DETAIL : AbstractGroup {

	/** 
	 * Creates a new MFN_M09_MF_TEST_CAT_DETAIL Group.
	 */
	public MFN_M09_MF_TEST_CAT_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OM3", "2.3"), true, false);
	      this.add(factory.getSegmentClass("OM4", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M09_MF_TEST_CAT_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OM3 (Categorical test/observation) - creates it if necessary
	 */
	public OM3 OM3 { 
get{
	   OM3 ret = null;
	   try {
	      ret = (OM3)this.get_Renamed("OM3");
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
