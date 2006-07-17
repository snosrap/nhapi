using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the DFT_P11_FINANCIAL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: FT1 (Financial Transaction) <b></b><br>
 * 1: DFT_P11_FINANCIAL_PROCEDURE (a Group object) <b></b><br>
 * 2: DFT_P11_FINANCIAL_COMMON_ORDER (a Group object) <b></b><br>
 * 3: DG1 (Diagnosis) <b>optional repeating</b><br>
 * 4: DRG (Diagnosis Related Group) <b>optional </b><br>
 * 5: GT1 (Guarantor) <b>optional repeating</b><br>
 * 6: DFT_P11_FINANCIAL_INSURANCE (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class DFT_P11_FINANCIAL : AbstractGroup {

	/** 
	 * Creates a new DFT_P11_FINANCIAL Group.
	 */
	public DFT_P11_FINANCIAL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(FT1), true, false);
	      this.add(typeof(DFT_P11_FINANCIAL_PROCEDURE), true, false);
	      this.add(typeof(DFT_P11_FINANCIAL_COMMON_ORDER), true, false);
	      this.add(typeof(DG1), false, true);
	      this.add(typeof(DRG), false, false);
	      this.add(typeof(GT1), false, true);
	      this.add(typeof(DFT_P11_FINANCIAL_INSURANCE), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DFT_P11_FINANCIAL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns FT1 (Financial Transaction) - creates it if necessary
	 */
	public FT1 FT1 { 
get{
	   FT1 ret = null;
	   try {
	      ret = (FT1)this.get_Renamed("FT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DFT_P11_FINANCIAL_PROCEDURE (a Group object) - creates it if necessary
	 */
	public DFT_P11_FINANCIAL_PROCEDURE FINANCIAL_PROCEDURE { 
get{
	   DFT_P11_FINANCIAL_PROCEDURE ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_PROCEDURE)this.get_Renamed("FINANCIAL_PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DFT_P11_FINANCIAL_COMMON_ORDER (a Group object) - creates it if necessary
	 */
	public DFT_P11_FINANCIAL_COMMON_ORDER FINANCIAL_COMMON_ORDER { 
get{
	   DFT_P11_FINANCIAL_COMMON_ORDER ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_COMMON_ORDER)this.get_Renamed("FINANCIAL_COMMON_ORDER");
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
	public DG1 getDG1() {
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
	public int DG1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("DG1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns DRG (Diagnosis Related Group) - creates it if necessary
	 */
	public DRG DRG { 
get{
	   DRG ret = null;
	   try {
	      ret = (DRG)this.get_Renamed("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of GT1 (Guarantor) - creates it if necessary
	 */
	public GT1 getGT1() {
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
	public int GT1Reps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("GT1").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns DFT_P11_FINANCIAL_INSURANCE (a Group object) - creates it if necessary
	 */
	public DFT_P11_FINANCIAL_INSURANCE FINANCIAL_INSURANCE { 
get{
	   DFT_P11_FINANCIAL_INSURANCE ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_INSURANCE)this.get_Renamed("FINANCIAL_INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
