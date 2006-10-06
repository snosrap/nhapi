using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RDR_RDR_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RDR_RDR_ENCODING (a Group object) <b>optional </b><br>
 * 2: RDR_RDR_DISPENSE (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RDR_RDR_ORDER : AbstractGroup {

	/** 
	 * Creates a new RDR_RDR_ORDER Group.
	 */
	public RDR_RDR_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(RDR_RDR_ENCODING), false, false);
	      this.add(typeof(RDR_RDR_DISPENSE), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RDR_RDR_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns RDR_RDR_ENCODING (a Group object) - creates it if necessary
	 */
	public RDR_RDR_ENCODING ENCODING { 
get{
	   RDR_RDR_ENCODING ret = null;
	   try {
	      ret = (RDR_RDR_ENCODING)this.get_Renamed("ENCODING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RDR_RDR_DISPENSE (a Group object) - creates it if necessary
	 */
	public RDR_RDR_DISPENSE getDISPENSE() {
	   RDR_RDR_DISPENSE ret = null;
	   try {
	      ret = (RDR_RDR_DISPENSE)this.get_Renamed("DISPENSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RDR_RDR_DISPENSE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RDR_RDR_DISPENSE getDISPENSE(int rep) { 
	   return (RDR_RDR_DISPENSE)this.get_Renamed("DISPENSE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RDR_RDR_DISPENSE 
	 */ 
	public int DISPENSEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("DISPENSE").Length; 
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
