using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRG_O16_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RRG_O16_TIMING (a Group object) <b></b><br>
 * 2: RRG_O16_GIVE (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class RRG_O16_ORDER : AbstractGroup {

	/** 
	 * Creates a new RRG_O16_ORDER Group.
	 */
	public RRG_O16_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), true, false);
	      this.add(factory.getGroupClass("RRG_O16_TIMING", "2.5"), true, false);
	      this.add(factory.getGroupClass("RRG_O16_GIVE", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRG_O16_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns RRG_O16_TIMING (a Group object) - creates it if necessary
	 */
	public RRG_O16_TIMING TIMING { 
get{
	   RRG_O16_TIMING ret = null;
	   try {
	      ret = (RRG_O16_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RRG_O16_GIVE (a Group object) - creates it if necessary
	 */
	public RRG_O16_GIVE GIVE { 
get{
	   RRG_O16_GIVE ret = null;
	   try {
	      ret = (RRG_O16_GIVE)this.get_Renamed("GIVE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
