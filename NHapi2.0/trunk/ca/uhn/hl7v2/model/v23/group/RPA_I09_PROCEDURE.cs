using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RPA_I09_PROCEDURE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PR1 (Procedures) <b></b><br>
 * 1: RPA_I09_AUTHORIZATION (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class RPA_I09_PROCEDURE : AbstractGroup {

	/** 
	 * Creates a new RPA_I09_PROCEDURE Group.
	 */
	public RPA_I09_PROCEDURE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PR1", "2.3"), true, false);
	      this.add(factory.getGroupClass("RPA_I09_AUTHORIZATION", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RPA_I09_PROCEDURE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PR1 (Procedures) - creates it if necessary
	 */
	public PR1 PR1 { 
get{
	   PR1 ret = null;
	   try {
	      ret = (PR1)this.get_Renamed("PR1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RPA_I09_AUTHORIZATION (a Group object) - creates it if necessary
	 */
	public RPA_I09_AUTHORIZATION AUTHORIZATION { 
get{
	   RPA_I09_AUTHORIZATION ret = null;
	   try {
	      ret = (RPA_I09_AUTHORIZATION)this.get_Renamed("AUTHORIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
