using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RRG_O02_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common order segment) <b></b><br>
 * 1: RRG_O02_GIVE (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class RRG_O02_ORDER : AbstractGroup {

	/** 
	 * Creates a new RRG_O02_ORDER Group.
	 */
	public RRG_O02_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.3"), true, false);
	      this.add(factory.getGroupClass("RRG_O02_GIVE", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRG_O02_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns RRG_O02_GIVE (a Group object) - creates it if necessary
	 */
	public RRG_O02_GIVE GIVE { 
get{
	   RRG_O02_GIVE ret = null;
	   try {
	      ret = (RRG_O02_GIVE)this.get_Renamed("GIVE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
