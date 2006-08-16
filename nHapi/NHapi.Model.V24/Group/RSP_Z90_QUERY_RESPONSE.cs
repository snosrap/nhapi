using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v24.segment;

using NHapi.Base.model;
/**
 * <p>Represents the RSP_Z90_QUERY_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RSP_Z90_PATIENT (a Group object) <b>optional </b><br>
 * 1: RSP_Z90_COMMON_ORDER (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Base.model.v24.group
{
[Serializable]
public class RSP_Z90_QUERY_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new RSP_Z90_QUERY_RESPONSE Group.
	 */
	public RSP_Z90_QUERY_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("RSP_Z90_PATIENT", "2.4"), false, false);
	      this.add(factory.getGroupClass("RSP_Z90_COMMON_ORDER", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_Z90_QUERY_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RSP_Z90_PATIENT (a Group object) - creates it if necessary
	 */
	public RSP_Z90_PATIENT PATIENT { 
get{
	   RSP_Z90_PATIENT ret = null;
	   try {
	      ret = (RSP_Z90_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RSP_Z90_COMMON_ORDER (a Group object) - creates it if necessary
	 */
	public RSP_Z90_COMMON_ORDER  getCOMMON_ORDER() { 
	   RSP_Z90_COMMON_ORDER ret = null;
	   try {
	      ret = (RSP_Z90_COMMON_ORDER)this.get_Renamed("COMMON_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RSP_Z90_COMMON_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RSP_Z90_COMMON_ORDER getCOMMON_ORDER(int rep) { 
	   return (RSP_Z90_COMMON_ORDER)this.get_Renamed("COMMON_ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RSP_Z90_COMMON_ORDER 
	 */ 
	public int COMMON_ORDERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("COMMON_ORDER").Length; 
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
