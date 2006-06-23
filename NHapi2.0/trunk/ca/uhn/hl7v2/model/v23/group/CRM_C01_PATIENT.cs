using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the CRM_C01_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient Identification) <b></b><br>
 * 1: PV1 (Patient visit) <b>optional </b><br>
 * 2: CSR (Clinical Study Registration) <b></b><br>
 * 3: CSP (Clinical Study Phase) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class CRM_C01_PATIENT : AbstractGroup {

	/** 
	 * Creates a new CRM_C01_PATIENT Group.
	 */
	public CRM_C01_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.3"), true, false);
	      this.add(factory.getSegmentClass("PV1", "2.3"), false, false);
	      this.add(factory.getSegmentClass("CSR", "2.3"), true, false);
	      this.add(factory.getSegmentClass("CSP", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CRM_C01_PATIENT - this is probably a bug in the source code generator.", e);
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
	 * Returns PV1 (Patient visit) - creates it if necessary
	 */
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.get_Renamed("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns CSR (Clinical Study Registration) - creates it if necessary
	 */
	public CSR CSR { 
get{
	   CSR ret = null;
	   try {
	      ret = (CSR)this.get_Renamed("CSR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of CSP (Clinical Study Phase) - creates it if necessary
	 */
	public CSP  getCSP() { 
	   CSP ret = null;
	   try {
	      ret = (CSP)this.get_Renamed("CSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of CSP
	 * (Clinical Study Phase) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public CSP getCSP(int rep) { 
	   return (CSP)this.get_Renamed("CSP", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CSP 
	 */ 
	public int CSPReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("CSP").Length; 
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
