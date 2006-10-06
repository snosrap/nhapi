using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMG_O19_ORDER_PRIOR Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b>optional </b><br>
 * 1: OBR (Observation Request) <b></b><br>
 * 2: OMG_O19_TIMING_PRIOR (a Group object) <b></b><br>
 * 3: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 4: CTD (Contact Data) <b>optional </b><br>
 * 5: OMG_O19_OBSERVATION_PRIOR (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OMG_O19_ORDER_PRIOR : AbstractGroup {

	/** 
	 * Creates a new OMG_O19_ORDER_PRIOR Group.
	 */
	public OMG_O19_ORDER_PRIOR(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), false, false);
	      this.add(typeof(OBR), true, false);
	      this.add(typeof(OMG_O19_TIMING_PRIOR), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(CTD), false, false);
	      this.add(typeof(OMG_O19_OBSERVATION_PRIOR), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMG_O19_ORDER_PRIOR - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common Order) - creates it if necessary
	 */
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.get_Renamed("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns OBR (Observation Request) - creates it if necessary
	 */
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.get_Renamed("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns OMG_O19_TIMING_PRIOR (a Group object) - creates it if necessary
	 */
	public OMG_O19_TIMING_PRIOR TIMING_PRIOR { 
get{
	   OMG_O19_TIMING_PRIOR ret = null;
	   try {
	      ret = (OMG_O19_TIMING_PRIOR)this.get_Renamed("TIMING_PRIOR");
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
	 * Returns CTD (Contact Data) - creates it if necessary
	 */
	public CTD CTD { 
get{
	   CTD ret = null;
	   try {
	      ret = (CTD)this.get_Renamed("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OMG_O19_OBSERVATION_PRIOR (a Group object) - creates it if necessary
	 */
	public OMG_O19_OBSERVATION_PRIOR getOBSERVATION_PRIOR() {
	   OMG_O19_OBSERVATION_PRIOR ret = null;
	   try {
	      ret = (OMG_O19_OBSERVATION_PRIOR)this.get_Renamed("OBSERVATION_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OMG_O19_OBSERVATION_PRIOR
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OMG_O19_OBSERVATION_PRIOR getOBSERVATION_PRIOR(int rep) { 
	   return (OMG_O19_OBSERVATION_PRIOR)this.get_Renamed("OBSERVATION_PRIOR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OMG_O19_OBSERVATION_PRIOR 
	 */ 
	public int OBSERVATION_PRIORReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("OBSERVATION_PRIOR").Length; 
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
