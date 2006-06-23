using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a PRR_PC5 message structure (see chapter 12). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MSA (Message Acknowledgment) <b></b><br>
 * 2: ERR (Error) <b>optional </b><br>
 * 3: QAK (Query Acknowledgment) <b>optional </b><br>
 * 4: QRD (Original-Style Query Definition) <b></b><br>
 * 5: PRR_PC5_PATIENT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class PRR_PC5 : AbstractMessage  {

	/** 
	 * Creates a new PRR_PC5 Group with custom ModelClassFactory.
	 */
	public PRR_PC5(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new PRR_PC5 Group with DefaultModelClassFactory. 
	 */ 
	public PRR_PC5() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("MSA", "2.4"), true, false);
	      this.add(factory.getSegmentClass("ERR", "2.4"), false, false);
	      this.add(factory.getSegmentClass("QAK", "2.4"), false, false);
	      this.add(factory.getSegmentClass("QRD", "2.4"), true, false);
	      this.add(factory.getGroupClass("PRR_PC5_PATIENT", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PRR_PC5 - this is probably a bug in the source code generator.", e);
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
	 * Returns MSA (Message Acknowledgment) - creates it if necessary
	 */
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.get_Renamed("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ERR (Error) - creates it if necessary
	 */
	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.get_Renamed("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QAK (Query Acknowledgment) - creates it if necessary
	 */
	public QAK QAK { 
get{
	   QAK ret = null;
	   try {
	      ret = (QAK)this.get_Renamed("QAK");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QRD (Original-Style Query Definition) - creates it if necessary
	 */
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.get_Renamed("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PRR_PC5_PATIENT (a Group object) - creates it if necessary
	 */
	public PRR_PC5_PATIENT  getPATIENT() { 
	   PRR_PC5_PATIENT ret = null;
	   try {
	      ret = (PRR_PC5_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PRR_PC5_PATIENT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PRR_PC5_PATIENT getPATIENT(int rep) { 
	   return (PRR_PC5_PATIENT)this.get_Renamed("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRR_PC5_PATIENT 
	 */ 
	public int PATIENTReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PATIENT").Length; 
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
