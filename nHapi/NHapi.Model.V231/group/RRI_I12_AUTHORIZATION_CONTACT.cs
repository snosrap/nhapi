using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the RRI_I12_AUTHORIZATION_CONTACT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: AUT (Authorization Information) <b></b><br>
 * 1: CTD (Contact Data) <b>optional </b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class RRI_I12_AUTHORIZATION_CONTACT : AbstractGroup {

	/** 
	 * Creates a new RRI_I12_AUTHORIZATION_CONTACT Group.
	 */
	public RRI_I12_AUTHORIZATION_CONTACT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("AUT", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("CTD", "2.3.1"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRI_I12_AUTHORIZATION_CONTACT - this is probably a bug in the source code generator.", e);
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
