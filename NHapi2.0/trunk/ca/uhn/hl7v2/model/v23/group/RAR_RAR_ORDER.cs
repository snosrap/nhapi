using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RAR_RAR_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common order segment) <b></b><br>
 * 1: RAR_RAR_ENCODING (a Group object) <b>optional </b><br>
 * 2: RXA (Pharmacy administration segment) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class RAR_RAR_ORDER : AbstractGroup {

	/** 
	 * Creates a new RAR_RAR_ORDER Group.
	 */
	public RAR_RAR_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.3"), true, false);
	      this.add(factory.getGroupClass("RAR_RAR_ENCODING", "2.3"), false, false);
	      this.add(factory.getSegmentClass("RXA", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RAR_RAR_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common order segment) - creates it if necessary
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
	 * Returns RAR_RAR_ENCODING (a Group object) - creates it if necessary
	 */
	public RAR_RAR_ENCODING ENCODING { 
get{
	   RAR_RAR_ENCODING ret = null;
	   try {
	      ret = (RAR_RAR_ENCODING)this.get_Renamed("ENCODING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RXA (Pharmacy administration segment) - creates it if necessary
	 */
	public RXA  getRXA() { 
	   RXA ret = null;
	   try {
	      ret = (RXA)this.get_Renamed("RXA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXA
	 * (Pharmacy administration segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXA getRXA(int rep) { 
	   return (RXA)this.get_Renamed("RXA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXA 
	 */ 
	public int RXAReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RXA").Length; 
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
