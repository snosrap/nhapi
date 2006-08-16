using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M05_MF_LOC_DEPT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: LDP (Location Department) <b></b><br>
 * 1: LCH (Location Characteristic) <b>optional repeating</b><br>
 * 2: LCC (Location Charge Code) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class MFN_M05_MF_LOC_DEPT : AbstractGroup {

	/** 
	 * Creates a new MFN_M05_MF_LOC_DEPT Group.
	 */
	public MFN_M05_MF_LOC_DEPT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("LDP", "2.3"), true, false);
	      this.add(factory.getSegmentClass("LCH", "2.3"), false, true);
	      this.add(factory.getSegmentClass("LCC", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M05_MF_LOC_DEPT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns LDP (Location Department) - creates it if necessary
	 */
	public LDP LDP { 
get{
	   LDP ret = null;
	   try {
	      ret = (LDP)this.get_Renamed("LDP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of LCH (Location Characteristic) - creates it if necessary
	 */
	public LCH  getLCH() { 
	   LCH ret = null;
	   try {
	      ret = (LCH)this.get_Renamed("LCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of LCH
	 * (Location Characteristic) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public LCH getLCH(int rep) { 
	   return (LCH)this.get_Renamed("LCH", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCH 
	 */ 
	public int LCHReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LCH").Length; 
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

	/**
	 * Returns  first repetition of LCC (Location Charge Code) - creates it if necessary
	 */
	public LCC  getLCC() { 
	   LCC ret = null;
	   try {
	      ret = (LCC)this.get_Renamed("LCC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of LCC
	 * (Location Charge Code) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public LCC getLCC(int rep) { 
	   return (LCC)this.get_Renamed("LCC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCC 
	 */ 
	public int LCCReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LCC").Length; 
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
