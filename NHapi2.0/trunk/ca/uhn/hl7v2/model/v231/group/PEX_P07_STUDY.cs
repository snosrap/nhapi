using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_STUDY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: CSR (CSR - clinical study registration segment) <b></b><br>
 * 1: CSP (CSP - clinical study phase segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class PEX_P07_STUDY : AbstractGroup {

	/** 
	 * Creates a new PEX_P07_STUDY Group.
	 */
	public PEX_P07_STUDY(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("CSR", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("CSP", "2.3.1"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_STUDY - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns CSR (CSR - clinical study registration segment) - creates it if necessary
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
	 * Returns  first repetition of CSP (CSP - clinical study phase segment) - creates it if necessary
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
	 * (CSP - clinical study phase segment) - creates it if necessary
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
