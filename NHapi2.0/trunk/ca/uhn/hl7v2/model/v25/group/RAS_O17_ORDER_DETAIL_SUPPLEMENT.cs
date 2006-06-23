using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RAS_O17_ORDER_DETAIL_SUPPLEMENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NTE (Notes and Comments) <b>repeating</b><br>
 * 1: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
 * 2: RAS_O17_COMPONENTS (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RAS_O17_ORDER_DETAIL_SUPPLEMENT : AbstractGroup {

	/** 
	 * Creates a new RAS_O17_ORDER_DETAIL_SUPPLEMENT Group.
	 */
	public RAS_O17_ORDER_DETAIL_SUPPLEMENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("NTE", "2.5"), true, true);
	      this.add(factory.getSegmentClass("RXR", "2.5"), true, true);
	      this.add(factory.getGroupClass("RAS_O17_COMPONENTS", "2.5"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RAS_O17_ORDER_DETAIL_SUPPLEMENT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
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
	 * Returns RAS_O17_COMPONENTS (a Group object) - creates it if necessary
	 */
	public RAS_O17_COMPONENTS COMPONENTS { 
get{
	   RAS_O17_COMPONENTS ret = null;
	   try {
	      ret = (RAS_O17_COMPONENTS)this.get_Renamed("COMPONENTS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
