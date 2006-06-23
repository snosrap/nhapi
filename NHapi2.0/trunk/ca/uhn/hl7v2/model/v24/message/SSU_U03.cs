using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a SSU_U03 message structure (see chapter 13). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: EQU (Equipment Detail) <b></b><br>
 * 2: SSU_U03_SPECIMEN_CONTAINER (a Group object) <b>repeating</b><br>
 * 3: ROL (Role) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class SSU_U03 : AbstractMessage  {

	/** 
	 * Creates a new SSU_U03 Group with custom ModelClassFactory.
	 */
	public SSU_U03(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new SSU_U03 Group with DefaultModelClassFactory. 
	 */ 
	public SSU_U03() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("EQU", "2.4"), true, false);
	      this.add(factory.getGroupClass("SSU_U03_SPECIMEN_CONTAINER", "2.4"), true, true);
	      this.add(factory.getSegmentClass("ROL", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SSU_U03 - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of SSU_U03_SPECIMEN_CONTAINER (a Group object) - creates it if necessary
	 */
	public SSU_U03_SPECIMEN_CONTAINER  getSPECIMEN_CONTAINER() { 
	   SSU_U03_SPECIMEN_CONTAINER ret = null;
	   try {
	      ret = (SSU_U03_SPECIMEN_CONTAINER)this.get_Renamed("SPECIMEN_CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SSU_U03_SPECIMEN_CONTAINER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SSU_U03_SPECIMEN_CONTAINER getSPECIMEN_CONTAINER(int rep) { 
	   return (SSU_U03_SPECIMEN_CONTAINER)this.get_Renamed("SPECIMEN_CONTAINER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SSU_U03_SPECIMEN_CONTAINER 
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
