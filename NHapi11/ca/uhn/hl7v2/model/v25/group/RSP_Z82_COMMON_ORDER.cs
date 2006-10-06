using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RSP_Z82_COMMON_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RSP_Z82_TIMING (a Group object) <b></b><br>
 * 2: RSP_Z82_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 3: RSP_Z82_ENCODED_ORDER (a Group object) <b>optional </b><br>
 * 4: RXD (Pharmacy/Treatment Dispense) <b></b><br>
 * 5: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
 * 6: RXC (Pharmacy/Treatment Component Order) <b>optional repeating</b><br>
 * 7: RSP_Z82_OBSERVATION (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RSP_Z82_COMMON_ORDER : AbstractGroup {

	/** 
	 * Creates a new RSP_Z82_COMMON_ORDER Group.
	 */
	public RSP_Z82_COMMON_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(RSP_Z82_TIMING), true, false);
	      this.add(typeof(RSP_Z82_ORDER_DETAIL), false, false);
	      this.add(typeof(RSP_Z82_ENCODED_ORDER), false, false);
	      this.add(typeof(RXD), true, false);
	      this.add(typeof(RXR), true, true);
	      this.add(typeof(RXC), false, true);
	      this.add(typeof(RSP_Z82_OBSERVATION), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_Z82_COMMON_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns RSP_Z82_TIMING (a Group object) - creates it if necessary
	 */
	public RSP_Z82_TIMING TIMING { 
get{
	   RSP_Z82_TIMING ret = null;
	   try {
	      ret = (RSP_Z82_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RSP_Z82_ORDER_DETAIL (a Group object) - creates it if necessary
	 */
	public RSP_Z82_ORDER_DETAIL ORDER_DETAIL { 
get{
	   RSP_Z82_ORDER_DETAIL ret = null;
	   try {
	      ret = (RSP_Z82_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RSP_Z82_ENCODED_ORDER (a Group object) - creates it if necessary
	 */
	public RSP_Z82_ENCODED_ORDER ENCODED_ORDER { 
get{
	   RSP_Z82_ENCODED_ORDER ret = null;
	   try {
	      ret = (RSP_Z82_ENCODED_ORDER)this.get_Renamed("ENCODED_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RXD (Pharmacy/Treatment Dispense) - creates it if necessary
	 */
	public RXD RXD { 
get{
	   RXD ret = null;
	   try {
	      ret = (RXD)this.get_Renamed("RXD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
	 */
	public RXR getRXR() {
	   RXR ret = null;
	   try {
	      ret = (RXR)this.get_Renamed("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXR
	 * (Pharmacy/Treatment Route) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXR getRXR(int rep) { 
	   return (RXR)this.get_Renamed("RXR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXR 
	 */ 
	public int RXRReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("RXR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary
	 */
	public RXC getRXC() {
	   RXC ret = null;
	   try {
	      ret = (RXC)this.get_Renamed("RXC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXC
	 * (Pharmacy/Treatment Component Order) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXC getRXC(int rep) { 
	   return (RXC)this.get_Renamed("RXC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXC 
	 */ 
	public int RXCReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("RXC").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of RSP_Z82_OBSERVATION (a Group object) - creates it if necessary
	 */
	public RSP_Z82_OBSERVATION getOBSERVATION() {
	   RSP_Z82_OBSERVATION ret = null;
	   try {
	      ret = (RSP_Z82_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RSP_Z82_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RSP_Z82_OBSERVATION getOBSERVATION(int rep) { 
	   return (RSP_Z82_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RSP_Z82_OBSERVATION 
	 */ 
	public int OBSERVATIONReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("OBSERVATION").Length; 
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
