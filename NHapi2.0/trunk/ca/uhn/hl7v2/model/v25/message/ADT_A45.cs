using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v25.group;
using ca.uhn.hl7v2.model.v25.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a ADT_A45 message structure (see chapter 3.3.45). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: SFT (Software Segment) <b>optional repeating</b><br>
 * 2: EVN (Event Type) <b></b><br>
 * 3: PID (Patient Identification) <b></b><br>
 * 4: PD1 (Patient Additional Demographic) <b>optional </b><br>
 * 5: ADT_A45_MERGE_INFO (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.message

{
[Serializable]
public class ADT_A45 : AbstractMessage  {

	/** 
	 * Creates a new ADT_A45 Group with custom ModelClassFactory.
	 */
	public ADT_A45(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new ADT_A45 Group with DefaultModelClassFactory. 
	 */ 
	public ADT_A45() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.5"), true, false);
	      this.add(factory.getSegmentClass("SFT", "2.5"), false, true);
	      this.add(factory.getSegmentClass("EVN", "2.5"), true, false);
	      this.add(factory.getSegmentClass("PID", "2.5"), true, false);
	      this.add(factory.getSegmentClass("PD1", "2.5"), false, false);
	      this.add(factory.getGroupClass("ADT_A45_MERGE_INFO", "2.5"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A45 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message Header) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.get_Renamed("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SFT (Software Segment) - creates it if necessary
	 */
	public SFT  getSFT() { 
	   SFT ret = null;
	   try {
	      ret = (SFT)this.get_Renamed("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SFT
	 * (Software Segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SFT getSFT(int rep) { 
	   return (SFT)this.get_Renamed("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("SFT").Length; 
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
	 * Returns EVN (Event Type) - creates it if necessary
	 */
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.get_Renamed("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PID (Patient Identification) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PD1 (Patient Additional Demographic) - creates it if necessary
	 */
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.get_Renamed("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ADT_A45_MERGE_INFO (a Group object) - creates it if necessary
	 */
	public ADT_A45_MERGE_INFO  getMERGE_INFO() { 
	   ADT_A45_MERGE_INFO ret = null;
	   try {
	      ret = (ADT_A45_MERGE_INFO)this.get_Renamed("MERGE_INFO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ADT_A45_MERGE_INFO
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ADT_A45_MERGE_INFO getMERGE_INFO(int rep) { 
	   return (ADT_A45_MERGE_INFO)this.get_Renamed("MERGE_INFO", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ADT_A45_MERGE_INFO 
	 */ 
	public int MERGE_INFOReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("MERGE_INFO").Length; 
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
