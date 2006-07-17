using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NCK (System Clock) <b>optional </b><br>
 * 1: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 2: NST (Application control level statistics) <b>optional </b><br>
 * 3: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 4: NSC (Application Status Change) <b>optional </b><br>
 * 5: NTE (Notes and Comments) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT : AbstractGroup {

	/** 
	 * Creates a new NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT Group.
	 */
	public NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(NCK), false, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(NST), false, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(NSC), false, false);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating NMR_N01_CLOCK_AND_STATS_WITH_NOTES_ALT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns NCK (System Clock) - creates it if necessary
	 */
	public NCK NCK { 
get{
	   NCK ret = null;
	   try {
	      ret = (NCK)this.get_Renamed("NCK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	 */
	public NTE getNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (Notes and Comments) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.get_Renamed("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns NST (Application control level statistics) - creates it if necessary
	 */
	public NST NST { 
get{
	   NST ret = null;
	   try {
	      ret = (NST)this.get_Renamed("NST");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE2 (Notes and Comments) - creates it if necessary
	 */
	public NTE getNTE2() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE2
	 * (Notes and Comments) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE2(int rep) { 
	   return (NTE)this.get_Renamed("NTE2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE2 
	 */ 
	public int NTE2Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NTE2").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns NSC (Application Status Change) - creates it if necessary
	 */
	public NSC NSC { 
get{
	   NSC ret = null;
	   try {
	      ret = (NSC)this.get_Renamed("NSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE3 (Notes and Comments) - creates it if necessary
	 */
	public NTE getNTE3() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE3
	 * (Notes and Comments) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE3(int rep) { 
	   return (NTE)this.get_Renamed("NTE3", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE3 
	 */ 
	public int NTE3Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NTE3").Length; 
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
