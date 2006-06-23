using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v25.group;
using ca.uhn.hl7v2.model.v25.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a EAC_U07 message structure (see chapter 13.3.7). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: SFT (Software Segment) <b>optional repeating</b><br>
 * 2: EQU (Equipment Detail) <b></b><br>
 * 3: EAC_U07_COMMAND (a Group object) <b>repeating</b><br>
 * 4: ROL (Role) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.message

{
[Serializable]
public class EAC_U07 : AbstractMessage  {

	/** 
	 * Creates a new EAC_U07 Group with custom ModelClassFactory.
	 */
	public EAC_U07(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new EAC_U07 Group with DefaultModelClassFactory. 
	 */ 
	public EAC_U07() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.5"), true, false);
	      this.add(factory.getSegmentClass("SFT", "2.5"), false, true);
	      this.add(factory.getSegmentClass("EQU", "2.5"), true, false);
	      this.add(factory.getGroupClass("EAC_U07_COMMAND", "2.5"), true, true);
	      this.add(factory.getSegmentClass("ROL", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating EAC_U07 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message Header) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.get_Renamed("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SFT (Software Segment) - creates it if necessary
	 */
	public SFT  getSFT() { 
	   SFT ret = null;
	   try {
	      ret = (SFT)this.get_Renamed("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SFT
	 * (Software Segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SFT getSFT(int rep) { 
	   return (SFT)this.get_Renamed("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("SFT").Length; 
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
	 * Returns EQU (Equipment Detail) - creates it if necessary
	 */
	public EQU EQU { 
get{
	   EQU ret = null;
	   try {
	      ret = (EQU)this.get_Renamed("EQU");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of EAC_U07_COMMAND (a Group object) - creates it if necessary
	 */
	public EAC_U07_COMMAND  getCOMMAND() { 
	   EAC_U07_COMMAND ret = null;
	   try {
	      ret = (EAC_U07_COMMAND)this.get_Renamed("COMMAND");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of EAC_U07_COMMAND
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public EAC_U07_COMMAND getCOMMAND(int rep) { 
	   return (EAC_U07_COMMAND)this.get_Renamed("COMMAND", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EAC_U07_COMMAND 
	 */ 
	public int COMMANDReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("COMMAND").Length; 
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
	 * Returns ROL (Role) - creates it if necessary
	 */
	public ROL ROL { 
get{
	   ROL ret = null;
	   try {
	      ret = (ROL)this.get_Renamed("ROL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
