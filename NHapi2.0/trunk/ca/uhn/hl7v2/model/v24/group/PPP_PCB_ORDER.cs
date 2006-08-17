using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPP_PCB_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: PPP_PCB_ORDER_DETAIL (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class PPP_PCB_ORDER : AbstractGroup {

	/** 
	 * Creates a new PPP_PCB_ORDER Group.
	 */
	public PPP_PCB_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.4"), true, false);
	      this.add(factory.getGroupClass("PPP_PCB_ORDER_DETAIL", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPP_PCB_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns PPP_PCB_ORDER_DETAIL (a Group object) - creates it if necessary
	 */
	public PPP_PCB_ORDER_DETAIL ORDER_DETAIL { 
get{
	   PPP_PCB_ORDER_DETAIL ret = null;
	   try {
	      ret = (PPP_PCB_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}