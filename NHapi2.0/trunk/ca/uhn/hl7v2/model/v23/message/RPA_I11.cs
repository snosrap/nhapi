using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a RPA_I11 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: MSA (Message acknowledgement segment) <b></b><br>
 * 2: RF1 (Referral Information Segment) <b>optional </b><br>
 * 3: RPA_I11_AUTHORIZATION (a Group object) <b>optional </b><br>
 * 4: RPA_I11_PROVIDER (a Group object) <b>repeating</b><br>
 * 5: PID (Patient Identification) <b></b><br>
 * 6: NK1 (Next of kin) <b>optional repeating</b><br>
 * 7: GT1 (Guarantor) <b>optional repeating</b><br>
 * 8: RPA_I11_INSURANCE (a Group object) <b>optional repeating</b><br>
 * 9: ACC (Accident) <b>optional </b><br>
 * 10: DG1 (Diagnosis) <b>optional repeating</b><br>
 * 11: DRG (Diagnosis Related Group) <b>optional repeating</b><br>
 * 12: AL1 (Patient allergy information) <b>optional repeating</b><br>
 * 13: RPA_I11_PROCEDURE (a Group object) <b>repeating</b><br>
 * 14: RPA_I11_RESULTS (a Group object) <b>optional repeating</b><br>
 * 15: RPA_I11_VISIT (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
[Serializable]
public class RPA_I11 : AbstractMessage  {

	/** 
	 * Creates a new RPA_I11 Group with custom ModelClassFactory.
	 */
	public RPA_I11(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new RPA_I11 Group with DefaultModelClassFactory. 
	 */ 
	public RPA_I11() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3"), true, false);
	      this.add(factory.getSegmentClass("MSA", "2.3"), true, false);
	      this.add(factory.getSegmentClass("RF1", "2.3"), false, false);
	      this.add(factory.getGroupClass("RPA_I11_AUTHORIZATION", "2.3"), false, false);
	      this.add(factory.getGroupClass("RPA_I11_PROVIDER", "2.3"), true, true);
	      this.add(factory.getSegmentClass("PID", "2.3"), true, false);
	      this.add(factory.getSegmentClass("NK1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("GT1", "2.3"), false, true);
	      this.add(factory.getGroupClass("RPA_I11_INSURANCE", "2.3"), false, true);
	      this.add(factory.getSegmentClass("ACC", "2.3"), false, false);
	      this.add(factory.getSegmentClass("DG1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("DRG", "2.3"), false, true);
	      this.add(factory.getSegmentClass("AL1", "2.3"), false, true);
	      this.add(factory.getGroupClass("RPA_I11_PROCEDURE", "2.3"), true, true);
	      this.add(factory.getGroupClass("RPA_I11_RESULTS", "2.3"), false, true);
	      this.add(factory.getGroupClass("RPA_I11_VISIT", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RPA_I11 - this is probably a bug in the source code generator.", e);
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
	 * Returns MSA (Message acknowledgement segment) - creates it if necessary
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
	 * Returns RPA_I11_AUTHORIZATION (a Group object) - creates it if necessary
	 */
	public RPA_I11_AUTHORIZATION AUTHORIZATION { 
get{
	   RPA_I11_AUTHORIZATION ret = null;
	   try {
	      ret = (RPA_I11_AUTHORIZATION)this.get_Renamed("AUTHORIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RPA_I11_PROVIDER (a Group object) - creates it if necessary
	 */
	public RPA_I11_PROVIDER  getPROVIDER() { 
	   RPA_I11_PROVIDER ret = null;
	   try {
	      ret = (RPA_I11_PROVIDER)this.get_Renamed("PROVIDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RPA_I11_PROVIDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RPA_I11_PROVIDER getPROVIDER(int rep) { 
	   return (RPA_I11_PROVIDER)this.get_Renamed("PROVIDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RPA_I11_PROVIDER 
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
	 * Returns  first repetition of RPA_I11_INSURANCE (a Group object) - creates it if necessary
	 */
	public RPA_I11_INSURANCE  getINSURANCE() { 
	   RPA_I11_INSURANCE ret = null;
	   try {
	      ret = (RPA_I11_INSURANCE)this.get_Renamed("INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RPA_I11_INSURANCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RPA_I11_INSURANCE getINSURANCE(int rep) { 
	   return (RPA_I11_INSURANCE)this.get_Renamed("INSURANCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RPA_I11_INSURANCE 
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
	 * Returns  first repetition of RPA_I11_PROCEDURE (a Group object) - creates it if necessary
	 */
	public RPA_I11_PROCEDURE  getPROCEDURE() { 
	   RPA_I11_PROCEDURE ret = null;
	   try {
	      ret = (RPA_I11_PROCEDURE)this.get_Renamed("PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RPA_I11_PROCEDURE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RPA_I11_PROCEDURE getPROCEDURE(int rep) { 
	   return (RPA_I11_PROCEDURE)this.get_Renamed("PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RPA_I11_PROCEDURE 
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
	 * Returns  first repetition of RPA_I11_RESULTS (a Group object) - creates it if necessary
	 */
	public RPA_I11_RESULTS  getRESULTS() { 
	   RPA_I11_RESULTS ret = null;
	   try {
	      ret = (RPA_I11_RESULTS)this.get_Renamed("RESULTS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RPA_I11_RESULTS
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RPA_I11_RESULTS getRESULTS(int rep) { 
	   return (RPA_I11_RESULTS)this.get_Renamed("RESULTS", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RPA_I11_RESULTS 
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
	 * Returns RPA_I11_VISIT (a Group object) - creates it if necessary
	 */
	public RPA_I11_VISIT VISIT { 
get{
	   RPA_I11_VISIT ret = null;
	   try {
	      ret = (RPA_I11_VISIT)this.get_Renamed("VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
