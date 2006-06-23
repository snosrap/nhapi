using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OML_O21_ORDER_PRIOR Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b>optional </b><br>
 * 1: OBR (Observation Request) <b></b><br>
 * 2: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 3: OML_O21_TIMING_PRIOR (a Group object) <b></b><br>
 * 4: OML_O21_OBSERVATION_PRIOR (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OML_O21_ORDER_PRIOR : AbstractGroup {

	/** 
	 * Creates a new OML_O21_ORDER_PRIOR Group.
	 */
	public OML_O21_ORDER_PRIOR(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), false, false);
	      this.add(factory.getSegmentClass("OBR", "2.5"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.5"), false, true);
	      this.add(factory.getGroupClass("OML_O21_TIMING_PRIOR", "2.5"), true, false);
	      this.add(factory.getGroupClass("OML_O21_OBSERVATION_PRIOR", "2.5"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OML_O21_ORDER_PRIOR - this is probably a bug in the source code generator.", e);
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
	 * Returns OML_O21_TIMING_PRIOR (a Group object) - creates it if necessary
	 */
	public OML_O21_TIMING_PRIOR TIMING_PRIOR { 
get{
	   OML_O21_TIMING_PRIOR ret = null;
	   try {
	      ret = (OML_O21_TIMING_PRIOR)this.get_Renamed("TIMING_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OML_O21_OBSERVATION_PRIOR (a Group object) - creates it if necessary
	 */
	public OML_O21_OBSERVATION_PRIOR  getOBSERVATION_PRIOR() { 
	   OML_O21_OBSERVATION_PRIOR ret = null;
	   try {
	      ret = (OML_O21_OBSERVATION_PRIOR)this.get_Renamed("OBSERVATION_PRIOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OML_O21_OBSERVATION_PRIOR
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OML_O21_OBSERVATION_PRIOR getOBSERVATION_PRIOR(int rep) { 
	   return (OML_O21_OBSERVATION_PRIOR)this.get_Renamed("OBSERVATION_PRIOR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OML_O21_OBSERVATION_PRIOR 
	 */ 
	public int OBSERVATION_PRIORReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("OBSERVATION_PRIOR").Length; 
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
