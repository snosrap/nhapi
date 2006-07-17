using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RAS_O17_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RAS_O17_TIMING (a Group object) <b></b><br>
 * 2: RAS_O17_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 3: RAS_O17_ENCODING (a Group object) <b>optional </b><br>
 * 4: RAS_O17_ADMINISTRATION (a Group object) <b>repeating</b><br>
 * 5: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RAS_O17_ORDER : AbstractGroup {

	/** 
	 * Creates a new RAS_O17_ORDER Group.
	 */
	public RAS_O17_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ORC), true, false);
	      this.add(typeof(RAS_O17_TIMING), true, false);
	      this.add(typeof(RAS_O17_ORDER_DETAIL), false, false);
	      this.add(typeof(RAS_O17_ENCODING), false, false);
	      this.add(typeof(RAS_O17_ADMINISTRATION), true, true);
	      this.add(typeof(CTI), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RAS_O17_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns RAS_O17_TIMING (a Group object) - creates it if necessary
	 */
	public RAS_O17_TIMING TIMING { 
get{
	   RAS_O17_TIMING ret = null;
	   try {
	      ret = (RAS_O17_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RAS_O17_ORDER_DETAIL (a Group object) - creates it if necessary
	 */
	public RAS_O17_ORDER_DETAIL ORDER_DETAIL { 
get{
	   RAS_O17_ORDER_DETAIL ret = null;
	   try {
	      ret = (RAS_O17_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RAS_O17_ENCODING (a Group object) - creates it if necessary
	 */
	public RAS_O17_ENCODING ENCODING { 
get{
	   RAS_O17_ENCODING ret = null;
	   try {
	      ret = (RAS_O17_ENCODING)this.get_Renamed("ENCODING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RAS_O17_ADMINISTRATION (a Group object) - creates it if necessary
	 */
	public RAS_O17_ADMINISTRATION getADMINISTRATION() {
	   RAS_O17_ADMINISTRATION ret = null;
	   try {
	      ret = (RAS_O17_ADMINISTRATION)this.get_Renamed("ADMINISTRATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RAS_O17_ADMINISTRATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RAS_O17_ADMINISTRATION getADMINISTRATION(int rep) { 
	   return (RAS_O17_ADMINISTRATION)this.get_Renamed("ADMINISTRATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RAS_O17_ADMINISTRATION 
	 */ 
	public int ADMINISTRATIONReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ADMINISTRATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary
	 */
	public CTI getCTI() {
	   CTI ret = null;
	   try {
	      ret = (CTI)this.get_Renamed("CTI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CTI
	 * (Clinical Trial Identification) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CTI getCTI(int rep) { 
	   return (CTI)this.get_Renamed("CTI", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CTI 
	 */ 
	public int CTIReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("CTI").Length; 
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
