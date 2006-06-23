using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a REF_I15 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: RF1 (Referral Information Segment) <b>optional </b><br>
 * 2: REF_I15_AUTHORIZATION (a Group object) <b>optional </b><br>
 * 3: REF_I15_PROVIDER (a Group object) <b>repeating</b><br>
 * 4: PID (Patient Identification) <b></b><br>
 * 5: NK1 (Next of kin) <b>optional repeating</b><br>
 * 6: GT1 (Guarantor) <b>optional repeating</b><br>
 * 7: REF_I15_INSURANCE (a Group object) <b>optional repeating</b><br>
 * 8: ACC (Accident) <b>optional </b><br>
 * 9: DG1 (Diagnosis) <b>optional repeating</b><br>
 * 10: DRG (Diagnosis Related Group) <b>optional repeating</b><br>
 * 11: AL1 (Patient allergy information) <b>optional repeating</b><br>
 * 12: REF_I15_PROCEDURE (a Group object) <b>optional repeating</b><br>
 * 13: REF_I15_RESULTS (a Group object) <b>optional repeating</b><br>
 * 14: REF_I15_VISIT (a Group object) <b>optional </b><br>
 * 15: NTE (Notes and comments segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
[Serializable]
public class REF_I15 : AbstractMessage  {

	/** 
	 * Creates a new REF_I15 Group with custom ModelClassFactory.
	 */
	public REF_I15(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new REF_I15 Group with DefaultModelClassFactory. 
	 */ 
	public REF_I15() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3"), true, false);
	      this.add(factory.getSegmentClass("RF1", "2.3"), false, false);
	      this.add(factory.getGroupClass("REF_I15_AUTHORIZATION", "2.3"), false, false);
	      this.add(factory.getGroupClass("REF_I15_PROVIDER", "2.3"), true, true);
	      this.add(factory.getSegmentClass("PID", "2.3"), true, false);
	      this.add(factory.getSegmentClass("NK1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("GT1", "2.3"), false, true);
	      this.add(factory.getGroupClass("REF_I15_INSURANCE", "2.3"), false, true);
	      this.add(factory.getSegmentClass("ACC", "2.3"), false, false);
	      this.add(factory.getSegmentClass("DG1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("DRG", "2.3"), false, true);
	      this.add(factory.getSegmentClass("AL1", "2.3"), false, true);
	      this.add(factory.getGroupClass("REF_I15_PROCEDURE", "2.3"), false, true);
	      this.add(factory.getGroupClass("REF_I15_RESULTS", "2.3"), false, true);
	      this.add(factory.getGroupClass("REF_I15_VISIT", "2.3"), false, false);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating REF_I15 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message header segment) - creates it if necessary
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
	 * Returns RF1 (Referral Information Segment) - creates it if necessary
	 */
	public RF1 RF1 { 
get{
	   RF1 ret = null;
	   try {
	      ret = (RF1)this.get_Renamed("RF1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns REF_I15_AUTHORIZATION (a Group object) - creates it if necessary
	 */
	public REF_I15_AUTHORIZATION AUTHORIZATION { 
get{
	   REF_I15_AUTHORIZATION ret = null;
	   try {
	      ret = (REF_I15_AUTHORIZATION)this.get_Renamed("AUTHORIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of REF_I15_PROVIDER (a Group object) - creates it if necessary
	 */
	public REF_I15_PROVIDER  getPROVIDER() { 
	   REF_I15_PROVIDER ret = null;
	   try {
	      ret = (REF_I15_PROVIDER)this.get_Renamed("PROVIDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of REF_I15_PROVIDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public REF_I15_PROVIDER getPROVIDER(int rep) { 
	   return (REF_I15_PROVIDER)this.get_Renamed("PROVIDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of REF_I15_PROVIDER 
	 */ 
	public int PROVIDERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROVIDER").Length; 
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
	 * Returns PID (Patient Identification) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NK1 (Next of kin) - creates it if necessary
	 */
	public NK1  getNK1() { 
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.get_Renamed("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NK1
	 * (Next of kin) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NK1 getNK1(int rep) { 
	   return (NK1)this.get_Renamed("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NK1").Length; 
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
	 * Returns  first repetition of GT1 (Guarantor) - creates it if necessary
	 */
	public GT1  getGT1() { 
	   GT1 ret = null;
	   try {
	      ret = (GT1)this.get_Renamed("GT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of GT1
	 * (Guarantor) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public GT1 getGT1(int rep) { 
	   return (GT1)this.get_Renamed("GT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of GT1 
	 */ 
	public int GT1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GT1").Length; 
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
	 * Returns  first repetition of REF_I15_INSURANCE (a Group object) - creates it if necessary
	 */
	public REF_I15_INSURANCE  getINSURANCE() { 
	   REF_I15_INSURANCE ret = null;
	   try {
	      ret = (REF_I15_INSURANCE)this.get_Renamed("INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of REF_I15_INSURANCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public REF_I15_INSURANCE getINSURANCE(int rep) { 
	   return (REF_I15_INSURANCE)this.get_Renamed("INSURANCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of REF_I15_INSURANCE 
	 */ 
	public int INSURANCEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("INSURANCE").Length; 
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
	 * Returns ACC (Accident) - creates it if necessary
	 */
	public ACC ACC { 
get{
	   ACC ret = null;
	   try {
	      ret = (ACC)this.get_Renamed("ACC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of DG1 (Diagnosis) - creates it if necessary
	 */
	public DG1  getDG1() { 
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.get_Renamed("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DG1
	 * (Diagnosis) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DG1 getDG1(int rep) { 
	   return (DG1)this.get_Renamed("DG1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DG1 
	 */ 
	public int DG1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("DG1").Length; 
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
	 * Returns  first repetition of DRG (Diagnosis Related Group) - creates it if necessary
	 */
	public DRG  getDRG() { 
	   DRG ret = null;
	   try {
	      ret = (DRG)this.get_Renamed("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DRG
	 * (Diagnosis Related Group) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DRG getDRG(int rep) { 
	   return (DRG)this.get_Renamed("DRG", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DRG 
	 */ 
	public int DRGReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("DRG").Length; 
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
	 * Returns  first repetition of AL1 (Patient allergy information) - creates it if necessary
	 */
	public AL1  getAL1() { 
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.get_Renamed("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of AL1
	 * (Patient allergy information) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public AL1 getAL1(int rep) { 
	   return (AL1)this.get_Renamed("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("AL1").Length; 
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
	 * Returns  first repetition of REF_I15_PROCEDURE (a Group object) - creates it if necessary
	 */
	public REF_I15_PROCEDURE  getPROCEDURE() { 
	   REF_I15_PROCEDURE ret = null;
	   try {
	      ret = (REF_I15_PROCEDURE)this.get_Renamed("PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of REF_I15_PROCEDURE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public REF_I15_PROCEDURE getPROCEDURE(int rep) { 
	   return (REF_I15_PROCEDURE)this.get_Renamed("PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of REF_I15_PROCEDURE 
	 */ 
	public int PROCEDUREReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROCEDURE").Length; 
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
	 * Returns  first repetition of REF_I15_RESULTS (a Group object) - creates it if necessary
	 */
	public REF_I15_RESULTS  getRESULTS() { 
	   REF_I15_RESULTS ret = null;
	   try {
	      ret = (REF_I15_RESULTS)this.get_Renamed("RESULTS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of REF_I15_RESULTS
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public REF_I15_RESULTS getRESULTS(int rep) { 
	   return (REF_I15_RESULTS)this.get_Renamed("RESULTS", rep);
	}

	/** 
	 * Returns the number of existing repetitions of REF_I15_RESULTS 
	 */ 
	public int RESULTSReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RESULTS").Length; 
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
	 * Returns REF_I15_VISIT (a Group object) - creates it if necessary
	 */
	public REF_I15_VISIT VISIT { 
get{
	   REF_I15_VISIT ret = null;
	   try {
	      ret = (REF_I15_VISIT)this.get_Renamed("VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
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

}
}
