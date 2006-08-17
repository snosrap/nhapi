using System;
using NHapi.Base.Log;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

/**
 * <p>Represents a NMQ_N02 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: NMQ_N02_QRY_WITH_DETAIL (a Group object) <b>optional </b><br>
 * 2: NMQ_N02_CLOCK_AND_STATISTICS (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Model.V22.Message

{
[Serializable]
public class NMQ_N02 : AbstractMessage  {

	/** 
	 * Creates a new NMQ_N02 Group with custom IModelClassFactory.
	 */
	public NMQ_N02(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new NMQ_N02 Group with DefaultModelClassFactory. 
	 */ 
	public NMQ_N02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(NMQ_N02_QRY_WITH_DETAIL), false, false);
	      this.add(typeof(NMQ_N02_CLOCK_AND_STATISTICS), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMQ_N02 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MESSAGE HEADER) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.getStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns NMQ_N02_QRY_WITH_DETAIL (a Group object) - creates it if necessary
	 */
	public NMQ_N02_QRY_WITH_DETAIL QRY_WITH_DETAIL { 
get{
	   NMQ_N02_QRY_WITH_DETAIL ret = null;
	   try {
	      ret = (NMQ_N02_QRY_WITH_DETAIL)this.getStructure("QRY_WITH_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NMQ_N02_CLOCK_AND_STATISTICS (a Group object) - creates it if necessary
	 */
	public NMQ_N02_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS() {
	   NMQ_N02_CLOCK_AND_STATISTICS ret = null;
	   try {
	      ret = (NMQ_N02_CLOCK_AND_STATISTICS)this.getStructure("CLOCK_AND_STATISTICS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NMQ_N02_CLOCK_AND_STATISTICS
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NMQ_N02_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS(int rep) { 
	   return (NMQ_N02_CLOCK_AND_STATISTICS)this.getStructure("CLOCK_AND_STATISTICS", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NMQ_N02_CLOCK_AND_STATISTICS 
	 */ 
	public int CLOCK_AND_STATISTICSReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("CLOCK_AND_STATISTICS").Length; 
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
