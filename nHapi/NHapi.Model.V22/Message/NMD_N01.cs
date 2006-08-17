using System;
using NHapi.Base.Log;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

/**
 * <p>Represents a NMD_N01 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: NMD_N01_CLOCK_AND_STATS_WITH_NOTES (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Model.V22.Message

{
[Serializable]
public class NMD_N01 : AbstractMessage  {

	/** 
	 * Creates a new NMD_N01 Group with custom IModelClassFactory.
	 */
	public NMD_N01(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new NMD_N01 Group with DefaultModelClassFactory. 
	 */ 
	public NMD_N01() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(NMD_N01_CLOCK_AND_STATS_WITH_NOTES), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMD_N01 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MESSAGE HEADER) - creates it if necessary
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
	 * Returns  first repetition of NMD_N01_CLOCK_AND_STATS_WITH_NOTES (a Group object) - creates it if necessary
	 */
	public NMD_N01_CLOCK_AND_STATS_WITH_NOTES getCLOCK_AND_STATS_WITH_NOTES() {
	   NMD_N01_CLOCK_AND_STATS_WITH_NOTES ret = null;
	   try {
	      ret = (NMD_N01_CLOCK_AND_STATS_WITH_NOTES)this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NMD_N01_CLOCK_AND_STATS_WITH_NOTES
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NMD_N01_CLOCK_AND_STATS_WITH_NOTES getCLOCK_AND_STATS_WITH_NOTES(int rep) { 
	   return (NMD_N01_CLOCK_AND_STATS_WITH_NOTES)this.get_Renamed("CLOCK_AND_STATS_WITH_NOTES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NMD_N01_CLOCK_AND_STATS_WITH_NOTES 
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
