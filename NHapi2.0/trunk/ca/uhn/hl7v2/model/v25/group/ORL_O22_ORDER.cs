using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORL_O22_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: ORL_O22_TIMING (a Group object) <b></b><br>
 * 2: ORL_O22_OBSERVATION_REQUEST (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class ORL_O22_ORDER : AbstractGroup {

	/** 
	 * Creates a new ORL_O22_ORDER Group.
	 */
	public ORL_O22_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), true, false);
	      this.add(factory.getGroupClass("ORL_O22_TIMING", "2.5"), true, false);
	      this.add(factory.getGroupClass("ORL_O22_OBSERVATION_REQUEST", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORL_O22_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns ORL_O22_TIMING (a Group object) - creates it if necessary
	 */
	public ORL_O22_TIMING TIMING { 
get{
	   ORL_O22_TIMING ret = null;
	   try {
	      ret = (ORL_O22_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ORL_O22_OBSERVATION_REQUEST (a Group object) - creates it if necessary
	 */
	public ORL_O22_OBSERVATION_REQUEST OBSERVATION_REQUEST { 
get{
	   ORL_O22_OBSERVATION_REQUEST ret = null;
	   try {
	      ret = (ORL_O22_OBSERVATION_REQUEST)this.get_Renamed("OBSERVATION_REQUEST");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
