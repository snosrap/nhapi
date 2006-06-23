using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORL_O34_OBSERVATION_REQUEST Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (Observation Request) <b></b><br>
 * 1: ORL_O34_SPECIMEN (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class ORL_O34_OBSERVATION_REQUEST : AbstractGroup {

	/** 
	 * Creates a new ORL_O34_OBSERVATION_REQUEST Group.
	 */
	public ORL_O34_OBSERVATION_REQUEST(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OBR", "2.5"), true, false);
	      this.add(factory.getGroupClass("ORL_O34_SPECIMEN", "2.5"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORL_O34_OBSERVATION_REQUEST - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBR (Observation Request) - creates it if necessary
	 */
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.get_Renamed("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ORL_O34_SPECIMEN (a Group object) - creates it if necessary
	 */
	public ORL_O34_SPECIMEN SPECIMEN { 
get{
	   ORL_O34_SPECIMEN ret = null;
	   try {
	      ret = (ORL_O34_SPECIMEN)this.get_Renamed("SPECIMEN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
