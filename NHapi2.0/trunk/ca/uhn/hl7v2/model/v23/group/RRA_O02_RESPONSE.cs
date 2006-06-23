using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRA_O02_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RRA_O02_PATIENT (a Group object) <b>optional </b><br>
 * 1: RRA_O02_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class RRA_O02_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new RRA_O02_RESPONSE Group.
	 */
	public RRA_O02_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("RRA_O02_PATIENT", "2.3"), false, false);
	      this.add(factory.getGroupClass("RRA_O02_ORDER", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRA_O02_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RRA_O02_PATIENT (a Group object) - creates it if necessary
	 */
	public RRA_O02_PATIENT PATIENT { 
get{
	   RRA_O02_PATIENT ret = null;
	   try {
	      ret = (RRA_O02_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RRA_O02_ORDER (a Group object) - creates it if necessary
	 */
	public RRA_O02_ORDER  getORDER() { 
	   RRA_O02_ORDER ret = null;
	   try {
	      ret = (RRA_O02_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RRA_O02_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RRA_O02_ORDER getORDER(int rep) { 
	   return (RRA_O02_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RRA_O02_ORDER 
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
