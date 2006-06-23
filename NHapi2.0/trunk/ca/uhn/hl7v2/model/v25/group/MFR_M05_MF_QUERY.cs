using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFR_M05_MF_QUERY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: LOC (Location Identification) <b></b><br>
 * 2: LCH (Location Characteristic) <b>optional repeating</b><br>
 * 3: LRL (Location Relationship) <b>optional repeating</b><br>
 * 4: LDP (Location Department) <b>repeating</b><br>
 * 5: LCH (Location Characteristic) <b>optional repeating</b><br>
 * 6: LCC (Location Charge Code) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class MFR_M05_MF_QUERY : AbstractGroup {

	/** 
	 * Creates a new MFR_M05_MF_QUERY Group.
	 */
	public MFR_M05_MF_QUERY(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.5"), true, false);
	      this.add(factory.getSegmentClass("LOC", "2.5"), true, false);
	      this.add(factory.getSegmentClass("LCH", "2.5"), false, true);
	      this.add(factory.getSegmentClass("LRL", "2.5"), false, true);
	      this.add(factory.getSegmentClass("LDP", "2.5"), true, true);
	      this.add(factory.getSegmentClass("LCH", "2.5"), false, true);
	      this.add(factory.getSegmentClass("LCC", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFR_M05_MF_QUERY - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (Master File Entry) - creates it if necessary
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
	 * Returns LOC (Location Identification) - creates it if necessary
	 */
	public LOC LOC { 
get{
	   LOC ret = null;
	   try {
	      ret = (LOC)this.get_Renamed("LOC");
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
	 * Returns  first repetition of LRL (Location Relationship) - creates it if necessary
	 */
	public LRL  getLRL() { 
	   LRL ret = null;
	   try {
	      ret = (LRL)this.get_Renamed("LRL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of LRL
	 * (Location Relationship) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public LRL getLRL(int rep) { 
	   return (LRL)this.get_Renamed("LRL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LRL 
	 */ 
	public int LRLReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LRL").Length; 
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
	 * Returns  first repetition of LDP (Location Department) - creates it if necessary
	 */
	public LDP  getLDP() { 
	   LDP ret = null;
	   try {
	      ret = (LDP)this.get_Renamed("LDP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of LDP
	 * (Location Department) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public LDP getLDP(int rep) { 
	   return (LDP)this.get_Renamed("LDP", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LDP 
	 */ 
	public int LDPReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LDP").Length; 
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
	 * Returns  first repetition of LCH2 (Location Characteristic) - creates it if necessary
	 */
	public LCH  getLCH2() { 
	   LCH ret = null;
	   try {
	      ret = (LCH)this.get_Renamed("LCH2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of LCH2
	 * (Location Characteristic) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public LCH getLCH2(int rep) { 
	   return (LCH)this.get_Renamed("LCH2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LCH2 
	 */ 
	public int LCH2Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LCH2").Length; 
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
