using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M02_MF_STAFF Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: STF (Staff Identification) <b></b><br>
 * 2: PRA (Practitioner Detail) <b>optional repeating</b><br>
 * 3: ORG (Practitioner Organization Unit) <b>optional repeating</b><br>
 * 4: AFF (Professional Affiliation) <b>optional repeating</b><br>
 * 5: LAN (Language Detail) <b>optional repeating</b><br>
 * 6: EDU (Educational Detail) <b>optional repeating</b><br>
 * 7: CER (Certificate Detail) <b>optional repeating</b><br>
 * 8: NTE (Notes and Comments) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class MFN_M02_MF_STAFF : AbstractGroup {

	/** 
	 * Creates a new MFN_M02_MF_STAFF Group.
	 */
	public MFN_M02_MF_STAFF(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(STF), true, false);
	      this.add(typeof(PRA), false, true);
	      this.add(typeof(ORG), false, true);
	      this.add(typeof(AFF), false, true);
	      this.add(typeof(LAN), false, true);
	      this.add(typeof(EDU), false, true);
	      this.add(typeof(CER), false, true);
	      this.add(typeof(NTE), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M02_MF_STAFF - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (Master File Entry) - creates it if necessary
	 */
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.get_Renamed("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
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
	 * Returns  first repetition of PRA (Practitioner Detail) - creates it if necessary
	 */
	public PRA getPRA() {
	   PRA ret = null;
	   try {
	      ret = (PRA)this.get_Renamed("PRA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PRA
	 * (Practitioner Detail) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PRA getPRA(int rep) { 
	   return (PRA)this.get_Renamed("PRA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRA 
	 */ 
	public int PRAReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("PRA").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of ORG (Practitioner Organization Unit) - creates it if necessary
	 */
	public ORG getORG() {
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
	public int ORGReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ORG").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of AFF (Professional Affiliation) - creates it if necessary
	 */
	public AFF getAFF() {
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
	public int AFFReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("AFF").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of LAN (Language Detail) - creates it if necessary
	 */
	public LAN getLAN() {
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
	public int LANReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("LAN").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of EDU (Educational Detail) - creates it if necessary
	 */
	public EDU getEDU() {
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
	public int EDUReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("EDU").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of CER (Certificate Detail) - creates it if necessary
	 */
	public CER getCER() {
	   CER ret = null;
	   try {
	      ret = (CER)this.get_Renamed("CER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CER
	 * (Certificate Detail) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CER getCER(int rep) { 
	   return (CER)this.get_Renamed("CER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CER 
	 */ 
	public int CERReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("CER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	 */
	public NTE getNTE() {
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
	public int NTEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
