using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SPM (Specimen) <b></b><br>
 * 1: OBX (Observation/Result) <b>optional repeating</b><br>
 * 2: OUL_R23_CONTAINER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI : AbstractGroup {

	/** 
	 * Creates a new OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI Group.
	 */
	public OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("SPM", "2.5"), true, false);
	      this.add(factory.getSegmentClass("OBX", "2.5"), false, true);
	      this.add(factory.getGroupClass("OUL_R23_CONTAINER", "2.5"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OUL_R23_SPMOBXSACINVOBRORCNTETQ1TQ2OBXTCDSIDNTECTI - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of OUL_R23_CONTAINER (a Group object) - creates it if necessary
	 */
	public OUL_R23_CONTAINER  getCONTAINER() { 
	   OUL_R23_CONTAINER ret = null;
	   try {
	      ret = (OUL_R23_CONTAINER)this.get_Renamed("CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OUL_R23_CONTAINER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OUL_R23_CONTAINER getCONTAINER(int rep) { 
	   return (OUL_R23_CONTAINER)this.get_Renamed("CONTAINER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OUL_R23_CONTAINER 
	 */ 
	public int CONTAINERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("CONTAINER").Length; 
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
