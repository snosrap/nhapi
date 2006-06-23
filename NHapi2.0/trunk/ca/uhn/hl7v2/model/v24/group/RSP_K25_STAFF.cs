using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RSP_K25_STAFF Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: STF (Staff Identification) <b></b><br>
 * 1: PRA (Practitioner Detail) <b>optional </b><br>
 * 2: ORG (Practitioner Organization Unit) <b>optional repeating</b><br>
 * 3: AFF (Professional Affiliation) <b>optional repeating</b><br>
 * 4: LAN (Language Detail) <b>optional repeating</b><br>
 * 5: EDU (Educational Detail) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class RSP_K25_STAFF : AbstractGroup {

	/** 
	 * Creates a new RSP_K25_STAFF Group.
	 */
	public RSP_K25_STAFF(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("STF", "2.4"), true, false);
	      this.add(factory.getSegmentClass("PRA", "2.4"), false, false);
	      this.add(factory.getSegmentClass("ORG", "2.4"), false, true);
	      this.add(factory.getSegmentClass("AFF", "2.4"), false, true);
	      this.add(factory.getSegmentClass("LAN", "2.4"), false, true);
	      this.add(factory.getSegmentClass("EDU", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_K25_STAFF - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns STF (Staff Identification) - creates it if necessary
	 */
	public STF STF { 
get{
	   STF ret = null;
	   try {
	      ret = (STF)this.get_Renamed("STF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PRA (Practitioner Detail) - creates it if necessary
	 */
	public PRA PRA { 
get{
	   PRA ret = null;
	   try {
	      ret = (PRA)this.get_Renamed("PRA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ORG (Practitioner Organization Unit) - creates it if necessary
	 */
	public ORG  getORG() { 
	   ORG ret = null;
	   try {
	      ret = (ORG)this.get_Renamed("ORG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORG
	 * (Practitioner Organization Unit) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORG getORG(int rep) { 
	   return (ORG)this.get_Renamed("ORG", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORG 
	 */ 
	public int ORGReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORG").Length; 
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
	 * Returns  first repetition of AFF (Professional Affiliation) - creates it if necessary
	 */
	public AFF  getAFF() { 
	   AFF ret = null;
	   try {
	      ret = (AFF)this.get_Renamed("AFF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of AFF
	 * (Professional Affiliation) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public AFF getAFF(int rep) { 
	   return (AFF)this.get_Renamed("AFF", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AFF 
	 */ 
	public int AFFReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("AFF").Length; 
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
	 * Returns  first repetition of LAN (Language Detail) - creates it if necessary
	 */
	public LAN  getLAN() { 
	   LAN ret = null;
	   try {
	      ret = (LAN)this.get_Renamed("LAN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of LAN
	 * (Language Detail) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public LAN getLAN(int rep) { 
	   return (LAN)this.get_Renamed("LAN", rep);
	}

	/** 
	 * Returns the number of existing repetitions of LAN 
	 */ 
	public int LANReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("LAN").Length; 
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
	 * Returns  first repetition of EDU (Educational Detail) - creates it if necessary
	 */
	public EDU  getEDU() { 
	   EDU ret = null;
	   try {
	      ret = (EDU)this.get_Renamed("EDU");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of EDU
	 * (Educational Detail) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public EDU getEDU(int rep) { 
	   return (EDU)this.get_Renamed("EDU", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EDU 
	 */ 
	public int EDUReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("EDU").Length; 
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
