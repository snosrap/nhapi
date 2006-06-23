using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RPA_I09_AUTHORIZATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: AUT (Authorization Information) <b></b><br>
 * 1: CTD (Contact Data) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class RPA_I09_AUTHORIZATION : AbstractGroup {

	/** 
	 * Creates a new RPA_I09_AUTHORIZATION Group.
	 */
	public RPA_I09_AUTHORIZATION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("AUT", "2.3"), true, false);
	      this.add(factory.getSegmentClass("CTD", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RPA_I09_AUTHORIZATION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns AUT (Authorization Information) - creates it if necessary
	 */
	public AUT AUT { 
get{
	   AUT ret = null;
	   try {
	      ret = (AUT)this.get_Renamed("AUT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns CTD (Contact Data) - creates it if necessary
	 */
	public CTD CTD { 
get{
	   CTD ret = null;
	   try {
	      ret = (CTD)this.get_Renamed("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
