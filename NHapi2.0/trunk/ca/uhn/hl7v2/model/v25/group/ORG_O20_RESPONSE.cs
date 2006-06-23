using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORG_O20_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORG_O20_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORG_O20_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class ORG_O20_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new ORG_O20_RESPONSE Group.
	 */
	public ORG_O20_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("ORG_O20_PATIENT", "2.5"), false, false);
	      this.add(factory.getGroupClass("ORG_O20_ORDER", "2.5"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORG_O20_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORG_O20_PATIENT (a Group object) - creates it if necessary
	 */
	public ORG_O20_PATIENT PATIENT { 
get{
	   ORG_O20_PATIENT ret = null;
	   try {
	      ret = (ORG_O20_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ORG_O20_ORDER (a Group object) - creates it if necessary
	 */
	public ORG_O20_ORDER  getORDER() { 
	   ORG_O20_ORDER ret = null;
	   try {
	      ret = (ORG_O20_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORG_O20_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORG_O20_ORDER getORDER(int rep) { 
	   return (ORG_O20_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORG_O20_ORDER 
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
