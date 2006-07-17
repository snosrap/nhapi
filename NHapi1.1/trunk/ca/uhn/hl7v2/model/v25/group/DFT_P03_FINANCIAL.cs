using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the DFT_P03_FINANCIAL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: FT1 (Financial Transaction) <b></b><br>
 * 1: NTE (Notes and Comments) <b>optional </b><br>
 * 2: DFT_P03_FINANCIAL_PROCEDURE (a Group object) <b></b><br>
 * 3: DFT_P03_FINANCIAL_COMMON_ORDER (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class DFT_P03_FINANCIAL : AbstractGroup {

	/** 
	 * Creates a new DFT_P03_FINANCIAL Group.
	 */
	public DFT_P03_FINANCIAL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(FT1), true, false);
	      this.add(typeof(NTE), false, false);
	      this.add(typeof(DFT_P03_FINANCIAL_PROCEDURE), true, false);
	      this.add(typeof(DFT_P03_FINANCIAL_COMMON_ORDER), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DFT_P03_FINANCIAL - this is probably a bug in the source code generator.", e);
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
	 * Returns NTE (Notes and Comments) - creates it if necessary
	 */
	public NTE NTE { 
get{
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DFT_P03_FINANCIAL_PROCEDURE (a Group object) - creates it if necessary
	 */
	public DFT_P03_FINANCIAL_PROCEDURE FINANCIAL_PROCEDURE { 
get{
	   DFT_P03_FINANCIAL_PROCEDURE ret = null;
	   try {
	      ret = (DFT_P03_FINANCIAL_PROCEDURE)this.get_Renamed("FINANCIAL_PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DFT_P03_FINANCIAL_COMMON_ORDER (a Group object) - creates it if necessary
	 */
	public DFT_P03_FINANCIAL_COMMON_ORDER FINANCIAL_COMMON_ORDER { 
get{
	   DFT_P03_FINANCIAL_COMMON_ORDER ret = null;
	   try {
	      ret = (DFT_P03_FINANCIAL_COMMON_ORDER)this.get_Renamed("FINANCIAL_COMMON_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
