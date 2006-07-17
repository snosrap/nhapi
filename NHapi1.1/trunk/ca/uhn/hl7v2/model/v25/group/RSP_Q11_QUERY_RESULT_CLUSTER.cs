using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RSP_Q11_QUERY_RESULT_CLUSTER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: LOC (Location Identification) <b></b><br>
 * 2: LCH (Location Characteristic) <b>optional repeating</b><br>
 * 3: LRL (Location Relationship) <b>optional repeating</b><br>
 * 4: RSP_Q11_MF_LOC_DEPT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RSP_Q11_QUERY_RESULT_CLUSTER : AbstractGroup {

	/** 
	 * Creates a new RSP_Q11_QUERY_RESULT_CLUSTER Group.
	 */
	public RSP_Q11_QUERY_RESULT_CLUSTER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(LOC), true, false);
	      this.add(typeof(LCH), false, true);
	      this.add(typeof(LRL), false, true);
	      this.add(typeof(RSP_Q11_MF_LOC_DEPT), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_Q11_QUERY_RESULT_CLUSTER - this is probably a bug in the source code generator.", e);
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
	public LCH getLCH() {
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
	public int LCHReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("LCH").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of LRL (Location Relationship) - creates it if necessary
	 */
	public LRL getLRL() {
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
	public int LRLReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("LRL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of RSP_Q11_MF_LOC_DEPT (a Group object) - creates it if necessary
	 */
	public RSP_Q11_MF_LOC_DEPT getMF_LOC_DEPT() {
	   RSP_Q11_MF_LOC_DEPT ret = null;
	   try {
	      ret = (RSP_Q11_MF_LOC_DEPT)this.get_Renamed("MF_LOC_DEPT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RSP_Q11_MF_LOC_DEPT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RSP_Q11_MF_LOC_DEPT getMF_LOC_DEPT(int rep) { 
	   return (RSP_Q11_MF_LOC_DEPT)this.get_Renamed("MF_LOC_DEPT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RSP_Q11_MF_LOC_DEPT 
	 */ 
	public int MF_LOC_DEPTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("MF_LOC_DEPT").Length; 
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
