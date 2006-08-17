using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the SQM_S25_REQUEST Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ARQ (ARQ - appointment request segment) <b></b><br>
 * 1: APR (APR - appointment preferences segment) <b>optional </b><br>
 * 2: PID (PID - patient identification segment) <b>optional </b><br>
 * 3: SQM_S25_RESOURCES (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class SQM_S25_REQUEST : AbstractGroup {

	/** 
	 * Creates a new SQM_S25_REQUEST Group.
	 */
	public SQM_S25_REQUEST(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ARQ", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("APR", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("PID", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("SQM_S25_RESOURCES", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SQM_S25_REQUEST - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ARQ (ARQ - appointment request segment) - creates it if necessary
	 */
	public ARQ ARQ { 
get{
	   ARQ ret = null;
	   try {
	      ret = (ARQ)this.get_Renamed("ARQ");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns APR (APR - appointment preferences segment) - creates it if necessary
	 */
	public APR APR { 
get{
	   APR ret = null;
	   try {
	      ret = (APR)this.get_Renamed("APR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PID (PID - patient identification segment) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SQM_S25_RESOURCES (a Group object) - creates it if necessary
	 */
	public SQM_S25_RESOURCES  getRESOURCES() { 
	   SQM_S25_RESOURCES ret = null;
	   try {
	      ret = (SQM_S25_RESOURCES)this.get_Renamed("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SQM_S25_RESOURCES
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SQM_S25_RESOURCES getRESOURCES(int rep) { 
	   return (SQM_S25_RESOURCES)this.get_Renamed("RESOURCES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SQM_S25_RESOURCES 
	 */ 
	public int RESOURCESReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RESOURCES").Length; 
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