using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the REF_I12_PROCEDURE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PR1 (PR1 - procedures segment) <b></b><br>
 * 1: REF_I12_AUTHORIZATION_CONTACT (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class REF_I12_PROCEDURE : AbstractGroup {

	/** 
	 * Creates a new REF_I12_PROCEDURE Group.
	 */
	public REF_I12_PROCEDURE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PR1", "2.3.1"), true, false);
	      this.add(factory.getGroupClass("REF_I12_AUTHORIZATION_CONTACT", "2.3.1"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating REF_I12_PROCEDURE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PR1 (PR1 - procedures segment) - creates it if necessary
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
	 * Returns REF_I12_AUTHORIZATION_CONTACT (a Group object) - creates it if necessary
	 */
	public REF_I12_AUTHORIZATION_CONTACT AUTHORIZATION_CONTACT { 
get{
	   REF_I12_AUTHORIZATION_CONTACT ret = null;
	   try {
	      ret = (REF_I12_AUTHORIZATION_CONTACT)this.get_Renamed("AUTHORIZATION_CONTACT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
