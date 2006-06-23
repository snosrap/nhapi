using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORL_O36_SPECIMEN Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SPM (Specimen) <b></b><br>
 * 1: OBX (Observation/Result) <b>optional repeating</b><br>
 * 2: ORL_O36_SPECIMEN_CONTAINER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class ORL_O36_SPECIMEN : AbstractGroup {

	/** 
	 * Creates a new ORL_O36_SPECIMEN Group.
	 */
	public ORL_O36_SPECIMEN(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("SPM", "2.5"), true, false);
	      this.add(factory.getSegmentClass("OBX", "2.5"), false, true);
	      this.add(factory.getGroupClass("ORL_O36_SPECIMEN_CONTAINER", "2.5"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORL_O36_SPECIMEN - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns SPM (Specimen) - creates it if necessary
	 */
	public SPM SPM { 
get{
	   SPM ret = null;
	   try {
	      ret = (SPM)this.get_Renamed("SPM");
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

	/**
	 * Returns  first repetition of ORL_O36_SPECIMEN_CONTAINER (a Group object) - creates it if necessary
	 */
	public ORL_O36_SPECIMEN_CONTAINER  getSPECIMEN_CONTAINER() { 
	   ORL_O36_SPECIMEN_CONTAINER ret = null;
	   try {
	      ret = (ORL_O36_SPECIMEN_CONTAINER)this.get_Renamed("SPECIMEN_CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORL_O36_SPECIMEN_CONTAINER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORL_O36_SPECIMEN_CONTAINER getSPECIMEN_CONTAINER(int rep) { 
	   return (ORL_O36_SPECIMEN_CONTAINER)this.get_Renamed("SPECIMEN_CONTAINER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORL_O36_SPECIMEN_CONTAINER 
	 */ 
	public int SPECIMEN_CONTAINERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("SPECIMEN_CONTAINER").Length; 
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
