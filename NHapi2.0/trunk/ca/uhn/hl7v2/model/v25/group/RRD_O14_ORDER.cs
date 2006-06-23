using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRD_O14_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RRD_O14_TIMING (a Group object) <b></b><br>
 * 2: RRD_O14_DISPENSE (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RRD_O14_ORDER : AbstractGroup {

	/** 
	 * Creates a new RRD_O14_ORDER Group.
	 */
	public RRD_O14_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), true, false);
	      this.add(factory.getGroupClass("RRD_O14_TIMING", "2.5"), true, false);
	      this.add(factory.getGroupClass("RRD_O14_DISPENSE", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRD_O14_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns RRD_O14_TIMING (a Group object) - creates it if necessary
	 */
	public RRD_O14_TIMING TIMING { 
get{
	   RRD_O14_TIMING ret = null;
	   try {
	      ret = (RRD_O14_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RRD_O14_DISPENSE (a Group object) - creates it if necessary
	 */
	public RRD_O14_DISPENSE DISPENSE { 
get{
	   RRD_O14_DISPENSE ret = null;
	   try {
	      ret = (RRD_O14_DISPENSE)this.get_Renamed("DISPENSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
