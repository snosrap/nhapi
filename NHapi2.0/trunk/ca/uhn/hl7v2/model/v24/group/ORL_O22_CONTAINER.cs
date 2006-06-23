using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORL_O22_CONTAINER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SAC (Specimen and container detail) <b></b><br>
 * 1: OBX (Observation/Result) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class ORL_O22_CONTAINER : AbstractGroup {

	/** 
	 * Creates a new ORL_O22_CONTAINER Group.
	 */
	public ORL_O22_CONTAINER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("SAC", "2.4"), true, false);
	      this.add(factory.getSegmentClass("OBX", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORL_O22_CONTAINER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns SAC (Specimen and container detail) - creates it if necessary
	 */
	public SAC SAC { 
get{
	   SAC ret = null;
	   try {
	      ret = (SAC)this.get_Renamed("SAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OBX (Observation/Result) - creates it if necessary
	 */
	public OBX  getOBX() { 
	   OBX ret = null;
	   try {
	      ret = (OBX)this.get_Renamed("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OBX
	 * (Observation/Result) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OBX getOBX(int rep) { 
	   return (OBX)this.get_Renamed("OBX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OBX 
	 */ 
	public int OBXReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("OBX").Length; 
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
