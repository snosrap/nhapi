using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P08_PEX_CAUSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PCR (Possible Causal Relationship) <b></b><br>
 * 1: PEX_P08_RX_ORDER (a Group object) <b>optional </b><br>
 * 2: PEX_P08_RX_ADMINISTRATION (a Group object) <b>optional repeating</b><br>
 * 3: PRB (Problem Detail) <b>optional repeating</b><br>
 * 4: OBX (Observation segment) <b>optional repeating</b><br>
 * 5: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 6: PEX_P08_ASSOCIATED_PERSON (a Group object) <b>optional </b><br>
 * 7: PEX_P08_STUDY (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class PEX_P08_PEX_CAUSE : AbstractGroup {

	/** 
	 * Creates a new PEX_P08_PEX_CAUSE Group.
	 */
	public PEX_P08_PEX_CAUSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PCR", "2.3"), true, false);
	      this.add(factory.getGroupClass("PEX_P08_RX_ORDER", "2.3"), false, false);
	      this.add(factory.getGroupClass("PEX_P08_RX_ADMINISTRATION", "2.3"), false, true);
	      this.add(factory.getSegmentClass("PRB", "2.3"), false, true);
	      this.add(factory.getSegmentClass("OBX", "2.3"), false, true);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	      this.add(factory.getGroupClass("PEX_P08_ASSOCIATED_PERSON", "2.3"), false, false);
	      this.add(factory.getGroupClass("PEX_P08_STUDY", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P08_PEX_CAUSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PCR (Possible Causal Relationship) - creates it if necessary
	 */
	public PCR PCR { 
get{
	   PCR ret = null;
	   try {
	      ret = (PCR)this.get_Renamed("PCR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PEX_P08_RX_ORDER (a Group object) - creates it if necessary
	 */
	public PEX_P08_RX_ORDER RX_ORDER { 
get{
	   PEX_P08_RX_ORDER ret = null;
	   try {
	      ret = (PEX_P08_RX_ORDER)this.get_Renamed("RX_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PEX_P08_RX_ADMINISTRATION (a Group object) - creates it if necessary
	 */
	public PEX_P08_RX_ADMINISTRATION  getRX_ADMINISTRATION() { 
	   PEX_P08_RX_ADMINISTRATION ret = null;
	   try {
	      ret = (PEX_P08_RX_ADMINISTRATION)this.get_Renamed("RX_ADMINISTRATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PEX_P08_RX_ADMINISTRATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PEX_P08_RX_ADMINISTRATION getRX_ADMINISTRATION(int rep) { 
	   return (PEX_P08_RX_ADMINISTRATION)this.get_Renamed("RX_ADMINISTRATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PEX_P08_RX_ADMINISTRATION 
	 */ 
	public int RX_ADMINISTRATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RX_ADMINISTRATION").Length; 
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
	 * Returns  first repetition of PRB (Problem Detail) - creates it if necessary
	 */
	public PRB  getPRB() { 
	   PRB ret = null;
	   try {
	      ret = (PRB)this.get_Renamed("PRB");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PRB
	 * (Problem Detail) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PRB getPRB(int rep) { 
	   return (PRB)this.get_Renamed("PRB", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRB 
	 */ 
	public int PRBReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PRB").Length; 
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
	 * Returns  first repetition of OBX (Observation segment) - creates it if necessary
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
	 * (Observation segment) - creates it if necessary
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
	 * Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
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
	 * (Notes and comments segment) - creates it if necessary
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
	 * Returns PEX_P08_ASSOCIATED_PERSON (a Group object) - creates it if necessary
	 */
	public PEX_P08_ASSOCIATED_PERSON ASSOCIATED_PERSON { 
get{
	   PEX_P08_ASSOCIATED_PERSON ret = null;
	   try {
	      ret = (PEX_P08_ASSOCIATED_PERSON)this.get_Renamed("ASSOCIATED_PERSON");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PEX_P08_STUDY (a Group object) - creates it if necessary
	 */
	public PEX_P08_STUDY  getSTUDY() { 
	   PEX_P08_STUDY ret = null;
	   try {
	      ret = (PEX_P08_STUDY)this.get_Renamed("STUDY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PEX_P08_STUDY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PEX_P08_STUDY getSTUDY(int rep) { 
	   return (PEX_P08_STUDY)this.get_Renamed("STUDY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PEX_P08_STUDY 
	 */ 
	public int STUDYReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("STUDY").Length; 
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
