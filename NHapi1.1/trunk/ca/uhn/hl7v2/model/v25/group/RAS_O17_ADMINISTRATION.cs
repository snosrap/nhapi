using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RAS_O17_ADMINISTRATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXA (Pharmacy/Treatment Administration) <b>repeating</b><br>
 * 1: RXR (Pharmacy/Treatment Route) <b></b><br>
 * 2: RAS_O17_OBSERVATION (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RAS_O17_ADMINISTRATION : AbstractGroup {

	/** 
	 * Creates a new RAS_O17_ADMINISTRATION Group.
	 */
	public RAS_O17_ADMINISTRATION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RXA), true, true);
	      this.add(typeof(RXR), true, false);
	      this.add(typeof(RAS_O17_OBSERVATION), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RAS_O17_ADMINISTRATION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns  first repetition of RXA (Pharmacy/Treatment Administration) - creates it if necessary
	 */
	public RXA getRXA() {
	   RXA ret = null;
	   try {
	      ret = (RXA)this.get_Renamed("RXA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXA
	 * (Pharmacy/Treatment Administration) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXA getRXA(int rep) { 
	   return (RXA)this.get_Renamed("RXA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXA 
	 */ 
	public int RXAReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("RXA").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns RXR (Pharmacy/Treatment Route) - creates it if necessary
	 */
	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.get_Renamed("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RAS_O17_OBSERVATION (a Group object) - creates it if necessary
	 */
	public RAS_O17_OBSERVATION OBSERVATION { 
get{
	   RAS_O17_OBSERVATION ret = null;
	   try {
	      ret = (RAS_O17_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
