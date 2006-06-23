using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M01_MF Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (MFE - master file entry segment) <b></b><br>
 * 1: Zxx (any Z segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class MFN_M01_MF : AbstractGroup {

	/** 
	 * Creates a new MFN_M01_MF Group.
	 */
	public MFN_M01_MF(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("Zxx", "2.3.1"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M01_MF - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (MFE - master file entry segment) - creates it if necessary
	 */
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.get_Renamed("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns Zxx (any Z segment) - creates it if necessary
	 */
	public Zxx Zxx { 
get{
	   Zxx ret = null;
	   try {
	      ret = (Zxx)this.get_Renamed("Zxx");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
