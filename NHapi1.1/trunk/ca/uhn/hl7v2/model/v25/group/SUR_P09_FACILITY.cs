using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SUR_P09_FACILITY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: FAC (Facility) <b></b><br>
 * 1: SUR_P09_PRODUCT (a Group object) <b>repeating</b><br>
 * 2: PSH (Product Summary Header) <b></b><br>
 * 3: SUR_P09_FACILITY_DETAIL (a Group object) <b>repeating</b><br>
 * 4: ED (Encapsulated Data (wrong segment)) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class SUR_P09_FACILITY : AbstractGroup {

	/** 
	 * Creates a new SUR_P09_FACILITY Group.
	 */
	public SUR_P09_FACILITY(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(FAC), true, false);
	      this.add(typeof(SUR_P09_PRODUCT), true, true);
	      this.add(typeof(PSH), true, false);
	      this.add(typeof(SUR_P09_FACILITY_DETAIL), true, true);
	      this.add(typeof(ED), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SUR_P09_FACILITY - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns FAC (Facility) - creates it if necessary
	 */
	public FAC FAC { 
get{
	   FAC ret = null;
	   try {
	      ret = (FAC)this.get_Renamed("FAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SUR_P09_PRODUCT (a Group object) - creates it if necessary
	 */
	public SUR_P09_PRODUCT getPRODUCT() {
	   SUR_P09_PRODUCT ret = null;
	   try {
	      ret = (SUR_P09_PRODUCT)this.get_Renamed("PRODUCT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SUR_P09_PRODUCT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SUR_P09_PRODUCT getPRODUCT(int rep) { 
	   return (SUR_P09_PRODUCT)this.get_Renamed("PRODUCT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SUR_P09_PRODUCT 
	 */ 
	public int PRODUCTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("PRODUCT").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns PSH (Product Summary Header) - creates it if necessary
	 */
	public PSH PSH { 
get{
	   PSH ret = null;
	   try {
	      ret = (PSH)this.get_Renamed("PSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SUR_P09_FACILITY_DETAIL (a Group object) - creates it if necessary
	 */
	public SUR_P09_FACILITY_DETAIL getFACILITY_DETAIL() {
	   SUR_P09_FACILITY_DETAIL ret = null;
	   try {
	      ret = (SUR_P09_FACILITY_DETAIL)this.get_Renamed("FACILITY_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SUR_P09_FACILITY_DETAIL
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SUR_P09_FACILITY_DETAIL getFACILITY_DETAIL(int rep) { 
	   return (SUR_P09_FACILITY_DETAIL)this.get_Renamed("FACILITY_DETAIL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SUR_P09_FACILITY_DETAIL 
	 */ 
	public int FACILITY_DETAILReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("FACILITY_DETAIL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns ED (Encapsulated Data (wrong segment)) - creates it if necessary
	 */
	public ED ED { 
get{
	   ED ret = null;
	   try {
	      ret = (ED)this.get_Renamed("ED");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
