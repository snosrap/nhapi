using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RGV_O15_TIMING_ENCODED Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: TQ1 (Timing/Quantity) <b></b><br>
 * 1: TQ2 (Timing/Quantity Relationship) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RGV_O15_TIMING_ENCODED : AbstractGroup {

	/** 
	 * Creates a new RGV_O15_TIMING_ENCODED Group.
	 */
	public RGV_O15_TIMING_ENCODED(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(TQ1), true, false);
	      this.add(typeof(TQ2), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGV_O15_TIMING_ENCODED - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns TQ1 (Timing/Quantity) - creates it if necessary
	 */
	public TQ1 TQ1 { 
get{
	   TQ1 ret = null;
	   try {
	      ret = (TQ1)this.get_Renamed("TQ1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of TQ2 (Timing/Quantity Relationship) - creates it if necessary
	 */
	public TQ2 getTQ2() {
	   TQ2 ret = null;
	   try {
	      ret = (TQ2)this.get_Renamed("TQ2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of TQ2
	 * (Timing/Quantity Relationship) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public TQ2 getTQ2(int rep) { 
	   return (TQ2)this.get_Renamed("TQ2", rep);
	}

	/** 
	 * Returns the number of existing repetitions of TQ2 
	 */ 
	public int TQ2Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("TQ2").Length; 
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
