using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_ASSOCIATED_RX_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXE (Pharmacy/Treatment Encoded Order) <b></b><br>
 * 1: PEX_P07_NK1_TIMING_QTY (a Group object) <b>repeating</b><br>
 * 2: RXR (Pharmacy/Treatment Route) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class PEX_P07_ASSOCIATED_RX_ORDER : AbstractGroup {

	/** 
	 * Creates a new PEX_P07_ASSOCIATED_RX_ORDER Group.
	 */
	public PEX_P07_ASSOCIATED_RX_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("RXE", "2.5"), true, false);
	      this.add(factory.getGroupClass("PEX_P07_NK1_TIMING_QTY", "2.5"), true, true);
	      this.add(factory.getSegmentClass("RXR", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_ASSOCIATED_RX_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RXE (Pharmacy/Treatment Encoded Order) - creates it if necessary
	 */
	public RXE RXE { 
get{
	   RXE ret = null;
	   try {
	      ret = (RXE)this.get_Renamed("RXE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PEX_P07_NK1_TIMING_QTY (a Group object) - creates it if necessary
	 */
	public PEX_P07_NK1_TIMING_QTY  getNK1_TIMING_QTY() { 
	   PEX_P07_NK1_TIMING_QTY ret = null;
	   try {
	      ret = (PEX_P07_NK1_TIMING_QTY)this.get_Renamed("NK1_TIMING_QTY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PEX_P07_NK1_TIMING_QTY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PEX_P07_NK1_TIMING_QTY getNK1_TIMING_QTY(int rep) { 
	   return (PEX_P07_NK1_TIMING_QTY)this.get_Renamed("NK1_TIMING_QTY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PEX_P07_NK1_TIMING_QTY 
	 */ 
	public int NK1_TIMING_QTYReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NK1_TIMING_QTY").Length; 
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
	 * Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
	 */
	public RXR  getRXR() { 
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
	public int RXRReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RXR").Length; 
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
