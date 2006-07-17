using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v25.group;
using ca.uhn.hl7v2.model.v25.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a NMD_N02 message structure (see chapter 14.3.2). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: SFT (Software Segment) <b>optional repeating</b><br>
 * 2: NMD_N02_CLOCK_AND_STATS_WITH_NOTES (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.message

{
[Serializable]
public class NMD_N02 : AbstractMessage  {

	/** 
	 * Creates a new NMD_N02 Group with custom ModelClassFactory.
	 */
	public NMD_N02(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new NMD_N02 Group with DefaultModelClassFactory. 
	 */ 
	public NMD_N02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SFT), false, true);
	      this.add(typeof(NMD_N02_CLOCK_AND_STATS_WITH_NOTES), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMD_N02 - this is probably a bug in the source code generator.", e);
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
	public SFT getSFT() {
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
	public int SFTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("SFT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of NMD_N02_CLOCK_AND_STATS_WITH_NOTES (a Group object) - creates it if necessary
	 */
	public NMD_N02_CLOCK_AND_STATS_WITH_NOTES getCLOCK_AND_STATS_WITH_NOTES() {
	   NMD_N02_CLOCK_AND_STATS_WITH_NOTES ret = null;
	   try {
	      ret = (NMD_N02_CLOCK_AND_STATS_WITH_NOTES)this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NMD_N02_CLOCK_AND_STATS_WITH_NOTES
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NMD_N02_CLOCK_AND_STATS_WITH_NOTES getCLOCK_AND_STATS_WITH_NOTES(int rep) { 
	   return (NMD_N02_CLOCK_AND_STATS_WITH_NOTES)this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NMD_N02_CLOCK_AND_STATS_WITH_NOTES 
	 */ 
	public int CLOCK_AND_STATS_WITH_NOTESReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("CLOCK_AND_STATS_WITH_NOTES").Length; 
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
