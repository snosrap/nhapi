using System;
using NHapi.Base.Log;
using NHapi.Model.V25.Group;
using NHapi.Model.V25.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V25.Message

{
///<summary>
/// Represents a NMQ_N01 message structure (see chapter 14.3.1). This structure contains the 
/// following elements:
/// * 0: MSH (Message Header) 
/// * 1: SFT (Software Segment) optional repeating
/// * 2: NMQ_N01_QRY_WITH_DETAIL (a Group object) optional 
/// * 3: NMQ_N01_CLOCK_AND_STATISTICS (a Group object) repeating
///</summary>
[Serializable]
public class NMQ_N01 : AbstractMessage  {

	///<summary> 
	/// Creates a new NMQ_N01 Group with custom IModelClassFactory.
	///</summary>
	public NMQ_N01(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	///<summary>
	/// Creates a new NMQ_N01 Group with DefaultModelClassFactory. 
	///</summary> 
	public NMQ_N01() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	///<summary>
	/// initalize method for NMQ_N01.  This does the segment setup for the message. 
	///</summary> 
	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(SFT), false, true);
	      this.add(typeof(NMQ_N01_QRY_WITH_DETAIL), false, false);
	      this.add(typeof(NMQ_N01_CLOCK_AND_STATISTICS), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMQ_N01 - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MSH (Message Header) - creates it if necessary
	///</summary>
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.GetStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of SFT (Software Segment) - creates it if necessary
	///</summary>
	public SFT getSFT() {
	   SFT ret = null;
	   try {
	      ret = (SFT)this.GetStructure("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of SFT
	/// * (Software Segment) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public SFT getSFT(int rep) { 
	   return (SFT)this.GetStructure("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("SFT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	///<summary>
	/// Returns NMQ_N01_QRY_WITH_DETAIL (a Group object) - creates it if necessary
	///</summary>
	public NMQ_N01_QRY_WITH_DETAIL QRY_WITH_DETAIL { 
get{
	   NMQ_N01_QRY_WITH_DETAIL ret = null;
	   try {
	      ret = (NMQ_N01_QRY_WITH_DETAIL)this.GetStructure("QRY_WITH_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NMQ_N01_CLOCK_AND_STATISTICS (a Group object) - creates it if necessary
	///</summary>
	public NMQ_N01_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS() {
	   NMQ_N01_CLOCK_AND_STATISTICS ret = null;
	   try {
	      ret = (NMQ_N01_CLOCK_AND_STATISTICS)this.GetStructure("CLOCK_AND_STATISTICS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NMQ_N01_CLOCK_AND_STATISTICS
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NMQ_N01_CLOCK_AND_STATISTICS getCLOCK_AND_STATISTICS(int rep) { 
	   return (NMQ_N01_CLOCK_AND_STATISTICS)this.GetStructure("CLOCK_AND_STATISTICS", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NMQ_N01_CLOCK_AND_STATISTICS 
	 */ 
	public int CLOCK_AND_STATISTICSReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("CLOCK_AND_STATISTICS").Length; 
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
