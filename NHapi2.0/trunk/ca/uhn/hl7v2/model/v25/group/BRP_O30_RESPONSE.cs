using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the BRP_O30_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: BRP_O30_PATIENT (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class BRP_O30_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new BRP_O30_RESPONSE Group.
	 */
	public BRP_O30_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("BRP_O30_PATIENT", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BRP_O30_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns BRP_O30_PATIENT (a Group object) - creates it if necessary
	 */
	public BRP_O30_PATIENT PATIENT { 
get{
	   BRP_O30_PATIENT ret = null;
	   try {
	      ret = (BRP_O30_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
