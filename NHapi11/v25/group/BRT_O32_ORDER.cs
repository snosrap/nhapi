using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the BRT_O32_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: BRT_O32_TIMING (a Group object) <b></b><br>
 * 2: BPO (Blood product order) <b>optional </b><br>
 * 3: BTX (Blood Product Transfusion/Disposition) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class BRT_O32_ORDER : AbstractGroup {

	/** 
	 * Creates a new BRT_O32_ORDER Group.
	 */
	public BRT_O32_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(BRT_O32_TIMING), true, false);
	      this.add(typeof(BPO), false, false);
	      this.add(typeof(BTX), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BRT_O32_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns BRT_O32_TIMING (a Group object) - creates it if necessary
	 */
	public BRT_O32_TIMING TIMING { 
get{
	   BRT_O32_TIMING ret = null;
	   try {
	      ret = (BRT_O32_TIMING)this.get_Renamed("TIMING");
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
	 * Returns  first repetition of BTX (Blood Product Transfusion/Disposition) - creates it if necessary
	 */
	public BTX getBTX() {
	   BTX ret = null;
	   try {
	      ret = (BTX)this.get_Renamed("BTX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of BTX
	 * (Blood Product Transfusion/Disposition) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public BTX getBTX(int rep) { 
	   return (BTX)this.get_Renamed("BTX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BTX 
	 */ 
	public int BTXReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("BTX").Length; 
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
