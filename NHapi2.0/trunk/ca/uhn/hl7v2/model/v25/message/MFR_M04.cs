using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v25.group;
using ca.uhn.hl7v2.model.v25.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a MFR_M04 message structure (see chapter 8.10.1). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: SFT (Software Segment) <b>optional repeating</b><br>
 * 2: MSA (Message Acknowledgment) <b></b><br>
 * 3: ERR (Error) <b>optional repeating</b><br>
 * 4: QAK (Query Acknowledgment) <b>optional </b><br>
 * 5: QRD (Original-Style Query Definition) <b></b><br>
 * 6: QRF (Original style query filter) <b>optional </b><br>
 * 7: MFI (Master File Identification) <b></b><br>
 * 8: MFR_M04_MF_QUERY (a Group object) <b>repeating</b><br>
 * 9: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.message

{
[Serializable]
public class MFR_M04 : AbstractMessage  {

	/** 
	 * Creates a new MFR_M04 Group with custom ModelClassFactory.
	 */
	public MFR_M04(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new MFR_M04 Group with DefaultModelClassFactory. 
	 */ 
	public MFR_M04() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.5"), true, false);
	      this.add(factory.getSegmentClass("SFT", "2.5"), false, true);
	      this.add(factory.getSegmentClass("MSA", "2.5"), true, false);
	      this.add(factory.getSegmentClass("ERR", "2.5"), false, true);
	      this.add(factory.getSegmentClass("QAK", "2.5"), false, false);
	      this.add(factory.getSegmentClass("QRD", "2.5"), true, false);
	      this.add(factory.getSegmentClass("QRF", "2.5"), false, false);
	      this.add(factory.getSegmentClass("MFI", "2.5"), true, false);
	      this.add(factory.getGroupClass("MFR_M04_MF_QUERY", "2.5"), true, true);
	      this.add(factory.getSegmentClass("DSC", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFR_M04 - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of ERR (Error) - creates it if necessary
	 */
	public ERR  getERR() { 
	   ERR ret = null;
	   try {
	      ret = (ERR)this.get_Renamed("ERR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ERR
	 * (Error) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ERR getERR(int rep) { 
	   return (ERR)this.get_Renamed("ERR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ERR 
	 */ 
	public int ERRReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ERR").Length; 
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
	 * Returns QRF (Original style query filter) - creates it if necessary
	 */
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.get_Renamed("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns MFI (Master File Identification) - creates it if necessary
	 */
	public MFI MFI { 
get{
	   MFI ret = null;
	   try {
	      ret = (MFI)this.get_Renamed("MFI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of MFR_M04_MF_QUERY (a Group object) - creates it if necessary
	 */
	public MFR_M04_MF_QUERY  getMF_QUERY() { 
	   MFR_M04_MF_QUERY ret = null;
	   try {
	      ret = (MFR_M04_MF_QUERY)this.get_Renamed("MF_QUERY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of MFR_M04_MF_QUERY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public MFR_M04_MF_QUERY getMF_QUERY(int rep) { 
	   return (MFR_M04_MF_QUERY)this.get_Renamed("MF_QUERY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFR_M04_MF_QUERY 
	 */ 
	public int MF_QUERYReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("MF_QUERY").Length; 
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
	 * Returns DSC (Continuation Pointer) - creates it if necessary
	 */
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.get_Renamed("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
