using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORF_R04_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORF_R04_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORF_R04_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class ORF_R04_QUERY_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new ORF_R04_QUERY_RESPONSE Group.
	 */
	public ORF_R04_QUERY_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("ORF_R04_PATIENT", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("ORF_R04_ORDER", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORF_R04_QUERY_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORF_R04_PATIENT (a Group object) - creates it if necessary
	 */
	public ORF_R04_PATIENT PATIENT { 
get{
	   ORF_R04_PATIENT ret = null;
	   try {
	      ret = (ORF_R04_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ORF_R04_ORDER (a Group object) - creates it if necessary
	 */
	public ORF_R04_ORDER  getORDER() { 
	   ORF_R04_ORDER ret = null;
	   try {
	      ret = (ORF_R04_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORF_R04_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORF_R04_ORDER getORDER(int rep) { 
	   return (ORF_R04_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORF_R04_ORDER 
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
