using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRD_O14_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RRD_O14_PATIENT (a Group object) <b>optional </b><br>
 * 1: RRD_O14_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RRD_O14_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new RRD_O14_RESPONSE Group.
	 */
	public RRD_O14_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("RRD_O14_PATIENT", "2.5"), false, false);
	      this.add(factory.getGroupClass("RRD_O14_ORDER", "2.5"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRD_O14_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RRD_O14_PATIENT (a Group object) - creates it if necessary
	 */
	public RRD_O14_PATIENT PATIENT { 
get{
	   RRD_O14_PATIENT ret = null;
	   try {
	      ret = (RRD_O14_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RRD_O14_ORDER (a Group object) - creates it if necessary
	 */
	public RRD_O14_ORDER  getORDER() { 
	   RRD_O14_ORDER ret = null;
	   try {
	      ret = (RRD_O14_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RRD_O14_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RRD_O14_ORDER getORDER(int rep) { 
	   return (RRD_O14_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RRD_O14_ORDER 
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
