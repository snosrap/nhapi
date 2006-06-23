using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RSP_Z88_ORDER_ENCODED Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXE (Pharmacy/Treatment Encoded Order) <b></b><br>
 * 1: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
 * 2: RXC (Pharmacy/Treatment Component Order) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class RSP_Z88_ORDER_ENCODED : AbstractGroup {

	/** 
	 * Creates a new RSP_Z88_ORDER_ENCODED Group.
	 */
	public RSP_Z88_ORDER_ENCODED(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("RXE", "2.4"), true, false);
	      this.add(factory.getSegmentClass("RXR", "2.4"), true, true);
	      this.add(factory.getSegmentClass("RXC", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_Z88_ORDER_ENCODED - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RXE (Pharmacy/Treatment Encoded Order) - creates it if necessary
	 */
	public RXE RXE { 
get{
	   RXE ret = null;
	   try {
	      ret = (RXE)this.get_Renamed("RXE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
	 */
	public RXR  getRXR() { 
	   RXR ret = null;
	   try {
	      ret = (RXR)this.get_Renamed("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXR
	 * (Pharmacy/Treatment Route) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXR getRXR(int rep) { 
	   return (RXR)this.get_Renamed("RXR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXR 
	 */ 
	public int RXRReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RXR").Length; 
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
	 * Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary
	 */
	public RXC  getRXC() { 
	   RXC ret = null;
	   try {
	      ret = (RXC)this.get_Renamed("RXC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXC
	 * (Pharmacy/Treatment Component Order) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXC getRXC(int rep) { 
	   return (RXC)this.get_Renamed("RXC", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXC 
	 */ 
	public int RXCReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RXC").Length; 
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
