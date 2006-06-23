using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_ASSOCIATED_PERSON Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NK1 (Next of Kin / Associated Parties) <b></b><br>
 * 1: PEX_P07_ASSOCIATED_RX_ORDER (a Group object) <b>optional </b><br>
 * 2: PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) <b></b><br>
 * 3: PRB (Problem Details) <b>optional repeating</b><br>
 * 4: OBX (Observation/Result) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class PEX_P07_ASSOCIATED_PERSON : AbstractGroup {

	/** 
	 * Creates a new PEX_P07_ASSOCIATED_PERSON Group.
	 */
	public PEX_P07_ASSOCIATED_PERSON(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("NK1", "2.5"), true, false);
	      this.add(factory.getGroupClass("PEX_P07_ASSOCIATED_RX_ORDER", "2.5"), false, false);
	      this.add(factory.getGroupClass("PEX_P07_ASSOCIATED_RX_ADMIN", "2.5"), true, false);
	      this.add(factory.getSegmentClass("PRB", "2.5"), false, true);
	      this.add(factory.getSegmentClass("OBX", "2.5"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_ASSOCIATED_PERSON - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns NK1 (Next of Kin / Associated Parties) - creates it if necessary
	 */
	public NK1 NK1 { 
get{
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.get_Renamed("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PEX_P07_ASSOCIATED_RX_ORDER (a Group object) - creates it if necessary
	 */
	public PEX_P07_ASSOCIATED_RX_ORDER ASSOCIATED_RX_ORDER { 
get{
	   PEX_P07_ASSOCIATED_RX_ORDER ret = null;
	   try {
	      ret = (PEX_P07_ASSOCIATED_RX_ORDER)this.get_Renamed("ASSOCIATED_RX_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PEX_P07_ASSOCIATED_RX_ADMIN (a Group object) - creates it if necessary
	 */
	public PEX_P07_ASSOCIATED_RX_ADMIN ASSOCIATED_RX_ADMIN { 
get{
	   PEX_P07_ASSOCIATED_RX_ADMIN ret = null;
	   try {
	      ret = (PEX_P07_ASSOCIATED_RX_ADMIN)this.get_Renamed("ASSOCIATED_RX_ADMIN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PRB (Problem Details) - creates it if necessary
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
	 * (Problem Details) - creates it if necessary
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
