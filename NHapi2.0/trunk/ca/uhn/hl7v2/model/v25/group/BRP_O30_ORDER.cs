using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the BRP_O30_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: BRP_O30_TIMING (a Group object) <b></b><br>
 * 2: BPO (Blood product order) <b>optional </b><br>
 * 3: BPX (Blood product dispense status) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class BRP_O30_ORDER : AbstractGroup {

	/** 
	 * Creates a new BRP_O30_ORDER Group.
	 */
	public BRP_O30_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), true, false);
	      this.add(factory.getGroupClass("BRP_O30_TIMING", "2.5"), true, false);
	      this.add(factory.getSegmentClass("BPO", "2.5"), false, false);
	      this.add(factory.getSegmentClass("BPX", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BRP_O30_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns BRP_O30_TIMING (a Group object) - creates it if necessary
	 */
	public BRP_O30_TIMING TIMING { 
get{
	   BRP_O30_TIMING ret = null;
	   try {
	      ret = (BRP_O30_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns BPO (Blood product order) - creates it if necessary
	 */
	public BPO BPO { 
get{
	   BPO ret = null;
	   try {
	      ret = (BPO)this.get_Renamed("BPO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of BPX (Blood product dispense status) - creates it if necessary
	 */
	public BPX  getBPX() { 
	   BPX ret = null;
	   try {
	      ret = (BPX)this.get_Renamed("BPX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of BPX
	 * (Blood product dispense status) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public BPX getBPX(int rep) { 
	   return (BPX)this.get_Renamed("BPX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BPX 
	 */ 
	public int BPXReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("BPX").Length; 
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
