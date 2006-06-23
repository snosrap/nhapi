using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the CSU_C10_STUDY_PHARM Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common order segment) <b>optional </b><br>
 * 1: CSU_C10_RX_ADMIN (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class CSU_C10_STUDY_PHARM : AbstractGroup {

	/** 
	 * Creates a new CSU_C10_STUDY_PHARM Group.
	 */
	public CSU_C10_STUDY_PHARM(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.3"), false, false);
	      this.add(factory.getGroupClass("CSU_C10_RX_ADMIN", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C10_STUDY_PHARM - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common order segment) - creates it if necessary
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
	 * Returns  first repetition of CSU_C10_RX_ADMIN (a Group object) - creates it if necessary
	 */
	public CSU_C10_RX_ADMIN  getRX_ADMIN() { 
	   CSU_C10_RX_ADMIN ret = null;
	   try {
	      ret = (CSU_C10_RX_ADMIN)this.get_Renamed("RX_ADMIN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSU_C10_RX_ADMIN
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSU_C10_RX_ADMIN getRX_ADMIN(int rep) { 
	   return (CSU_C10_RX_ADMIN)this.get_Renamed("RX_ADMIN", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSU_C10_RX_ADMIN 
	 */ 
	public int RX_ADMINReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RX_ADMIN").Length; 
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
