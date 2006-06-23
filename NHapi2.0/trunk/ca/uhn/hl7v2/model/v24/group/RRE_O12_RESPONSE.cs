using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRE_O12_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RRE_O12_PATIENT (a Group object) <b>optional </b><br>
 * 1: RRE_O12_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class RRE_O12_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new RRE_O12_RESPONSE Group.
	 */
	public RRE_O12_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("RRE_O12_PATIENT", "2.4"), false, false);
	      this.add(factory.getGroupClass("RRE_O12_ORDER", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRE_O12_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RRE_O12_PATIENT (a Group object) - creates it if necessary
	 */
	public RRE_O12_PATIENT PATIENT { 
get{
	   RRE_O12_PATIENT ret = null;
	   try {
	      ret = (RRE_O12_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RRE_O12_ORDER (a Group object) - creates it if necessary
	 */
	public RRE_O12_ORDER  getORDER() { 
	   RRE_O12_ORDER ret = null;
	   try {
	      ret = (RRE_O12_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RRE_O12_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RRE_O12_ORDER getORDER(int rep) { 
	   return (RRE_O12_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RRE_O12_ORDER 
	 */ 
	public int ORDERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER").Length; 
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
