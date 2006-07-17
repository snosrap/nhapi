using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the BAR_P01_INSURANCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: IN1 (Insurance) <b></b><br>
 * 1: IN2 (Insurance Additional Information) <b>optional </b><br>
 * 2: IN3 (Insurance Additional Information, Certification) <b>optional repeating</b><br>
 * 3: ROL (Role) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class BAR_P01_INSURANCE : AbstractGroup {

	/** 
	 * Creates a new BAR_P01_INSURANCE Group.
	 */
	public BAR_P01_INSURANCE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(IN1), true, false);
	      this.add(typeof(IN2), false, false);
	      this.add(typeof(IN3), false, true);
	      this.add(typeof(ROL), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P01_INSURANCE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns IN1 (Insurance) - creates it if necessary
	 */
	public IN1 IN1 { 
get{
	   IN1 ret = null;
	   try {
	      ret = (IN1)this.get_Renamed("IN1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns IN2 (Insurance Additional Information) - creates it if necessary
	 */
	public IN2 IN2 { 
get{
	   IN2 ret = null;
	   try {
	      ret = (IN2)this.get_Renamed("IN2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of IN3 (Insurance Additional Information, Certification) - creates it if necessary
	 */
	public IN3 getIN3() {
	   IN3 ret = null;
	   try {
	      ret = (IN3)this.get_Renamed("IN3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of IN3
	 * (Insurance Additional Information, Certification) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public IN3 getIN3(int rep) { 
	   return (IN3)this.get_Renamed("IN3", rep);
	}

	/** 
	 * Returns the number of existing repetitions of IN3 
	 */ 
	public int IN3Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("IN3").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of ROL (Role) - creates it if necessary
	 */
	public ROL getROL() {
	   ROL ret = null;
	   try {
	      ret = (ROL)this.get_Renamed("ROL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ROL
	 * (Role) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ROL getROL(int rep) { 
	   return (ROL)this.get_Renamed("ROL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ROL 
	 */ 
	public int ROLReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ROL").Length; 
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
