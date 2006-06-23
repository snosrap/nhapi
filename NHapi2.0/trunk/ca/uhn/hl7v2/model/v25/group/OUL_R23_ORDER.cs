using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OUL_R23_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (Observation Request) <b></b><br>
 * 1: ORC (Common Order) <b>optional </b><br>
 * 2: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 3: OUL_R23_TIMING_QTY (a Group object) <b></b><br>
 * 4: OUL_R23_RESULT (a Group object) <b></b><br>
 * 5: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OUL_R23_ORDER : AbstractGroup {

	/** 
	 * Creates a new OUL_R23_ORDER Group.
	 */
	public OUL_R23_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OBR", "2.5"), true, false);
	      this.add(factory.getSegmentClass("ORC", "2.5"), false, false);
	      this.add(factory.getSegmentClass("NTE", "2.5"), false, true);
	      this.add(factory.getGroupClass("OUL_R23_TIMING_QTY", "2.5"), true, false);
	      this.add(factory.getGroupClass("OUL_R23_RESULT", "2.5"), true, false);
	      this.add(factory.getSegmentClass("CTI", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OUL_R23_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBR (Observation Request) - creates it if necessary
	 */
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.get_Renamed("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ORC (Common Order) - creates it if necessary
	 */
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.get_Renamed("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	 */
	public NTE  getNTE() { 
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (Notes and Comments) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.get_Renamed("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NTE").Length; 
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
	 * Returns OUL_R23_TIMING_QTY (a Group object) - creates it if necessary
	 */
	public OUL_R23_TIMING_QTY TIMING_QTY { 
get{
	   OUL_R23_TIMING_QTY ret = null;
	   try {
	      ret = (OUL_R23_TIMING_QTY)this.get_Renamed("TIMING_QTY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns OUL_R23_RESULT (a Group object) - creates it if necessary
	 */
	public OUL_R23_RESULT RESULT { 
get{
	   OUL_R23_RESULT ret = null;
	   try {
	      ret = (OUL_R23_RESULT)this.get_Renamed("RESULT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary
	 */
	public CTI  getCTI() { 
	   CTI ret = null;
	   try {
	      ret = (CTI)this.get_Renamed("CTI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CTI
	 * (Clinical Trial Identification) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CTI getCTI(int rep) { 
	   return (CTI)this.get_Renamed("CTI", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CTI 
	 */ 
	public int CTIReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("CTI").Length; 
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
