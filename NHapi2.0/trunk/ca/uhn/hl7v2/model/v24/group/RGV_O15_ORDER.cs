using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RGV_O15_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RGV_O15_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 2: RGV_O15_ENCODING (a Group object) <b>optional </b><br>
 * 3: RGV_O15_GIVE (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class RGV_O15_ORDER : AbstractGroup {

	/** 
	 * Creates a new RGV_O15_ORDER Group.
	 */
	public RGV_O15_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.4"), true, false);
	      this.add(factory.getGroupClass("RGV_O15_ORDER_DETAIL", "2.4"), false, false);
	      this.add(factory.getGroupClass("RGV_O15_ENCODING", "2.4"), false, false);
	      this.add(factory.getGroupClass("RGV_O15_GIVE", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGV_O15_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns RGV_O15_ORDER_DETAIL (a Group object) - creates it if necessary
	 */
	public RGV_O15_ORDER_DETAIL ORDER_DETAIL { 
get{
	   RGV_O15_ORDER_DETAIL ret = null;
	   try {
	      ret = (RGV_O15_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RGV_O15_ENCODING (a Group object) - creates it if necessary
	 */
	public RGV_O15_ENCODING ENCODING { 
get{
	   RGV_O15_ENCODING ret = null;
	   try {
	      ret = (RGV_O15_ENCODING)this.get_Renamed("ENCODING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RGV_O15_GIVE (a Group object) - creates it if necessary
	 */
	public RGV_O15_GIVE  getGIVE() { 
	   RGV_O15_GIVE ret = null;
	   try {
	      ret = (RGV_O15_GIVE)this.get_Renamed("GIVE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RGV_O15_GIVE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RGV_O15_GIVE getGIVE(int rep) { 
	   return (RGV_O15_GIVE)this.get_Renamed("GIVE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RGV_O15_GIVE 
	 */ 
	public int GIVEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GIVE").Length; 
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
