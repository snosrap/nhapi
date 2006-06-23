using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the DFT_P11_FINANCIAL_COMMON_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b>optional </b><br>
 * 1: DFT_P11_FINANCIAL_ORDER (a Group object) <b>optional </b><br>
 * 2: DFT_P11_FINANCIAL_OBSERVATION (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class DFT_P11_FINANCIAL_COMMON_ORDER : AbstractGroup {

	/** 
	 * Creates a new DFT_P11_FINANCIAL_COMMON_ORDER Group.
	 */
	public DFT_P11_FINANCIAL_COMMON_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.4"), false, false);
	      this.add(factory.getGroupClass("DFT_P11_FINANCIAL_ORDER", "2.4"), false, false);
	      this.add(factory.getGroupClass("DFT_P11_FINANCIAL_OBSERVATION", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DFT_P11_FINANCIAL_COMMON_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common Order) - creates it if necessary
	 */
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.get_Renamed("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DFT_P11_FINANCIAL_ORDER (a Group object) - creates it if necessary
	 */
	public DFT_P11_FINANCIAL_ORDER FINANCIAL_ORDER { 
get{
	   DFT_P11_FINANCIAL_ORDER ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_ORDER)this.get_Renamed("FINANCIAL_ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of DFT_P11_FINANCIAL_OBSERVATION (a Group object) - creates it if necessary
	 */
	public DFT_P11_FINANCIAL_OBSERVATION  getFINANCIAL_OBSERVATION() { 
	   DFT_P11_FINANCIAL_OBSERVATION ret = null;
	   try {
	      ret = (DFT_P11_FINANCIAL_OBSERVATION)this.get_Renamed("FINANCIAL_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DFT_P11_FINANCIAL_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DFT_P11_FINANCIAL_OBSERVATION getFINANCIAL_OBSERVATION(int rep) { 
	   return (DFT_P11_FINANCIAL_OBSERVATION)this.get_Renamed("FINANCIAL_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DFT_P11_FINANCIAL_OBSERVATION 
	 */ 
	public int FINANCIAL_OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("FINANCIAL_OBSERVATION").Length; 
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
