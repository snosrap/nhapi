using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRG_O16_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RRG_O16_PATIENT (a Group object) <b>optional </b><br>
 * 1: RRG_O16_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class RRG_O16_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new RRG_O16_RESPONSE Group.
	 */
	public RRG_O16_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("RRG_O16_PATIENT", "2.4"), false, false);
	      this.add(factory.getGroupClass("RRG_O16_ORDER", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRG_O16_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RRG_O16_PATIENT (a Group object) - creates it if necessary
	 */
	public RRG_O16_PATIENT PATIENT { 
get{
	   RRG_O16_PATIENT ret = null;
	   try {
	      ret = (RRG_O16_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RRG_O16_ORDER (a Group object) - creates it if necessary
	 */
	public RRG_O16_ORDER  getORDER() { 
	   RRG_O16_ORDER ret = null;
	   try {
	      ret = (RRG_O16_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RRG_O16_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RRG_O16_ORDER getORDER(int rep) { 
	   return (RRG_O16_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RRG_O16_ORDER 
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
