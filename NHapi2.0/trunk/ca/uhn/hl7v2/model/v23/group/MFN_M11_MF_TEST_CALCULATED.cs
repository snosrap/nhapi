using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M11_MF_TEST_CALCULATED Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master file entry segment) <b></b><br>
 * 1: OM1 (General - fields that apply to most observations) <b></b><br>
 * 2: MFN_M11_MF_TEST_CALC_DETAIL (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class MFN_M11_MF_TEST_CALCULATED : AbstractGroup {

	/** 
	 * Creates a new MFN_M11_MF_TEST_CALCULATED Group.
	 */
	public MFN_M11_MF_TEST_CALCULATED(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.3"), true, false);
	      this.add(factory.getSegmentClass("OM1", "2.3"), true, false);
	      this.add(factory.getGroupClass("MFN_M11_MF_TEST_CALC_DETAIL", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M11_MF_TEST_CALCULATED - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (Master file entry segment) - creates it if necessary
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
	 * Returns OM1 (General - fields that apply to most observations) - creates it if necessary
	 */
	public OM1 OM1 { 
get{
	   OM1 ret = null;
	   try {
	      ret = (OM1)this.get_Renamed("OM1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns MFN_M11_MF_TEST_CALC_DETAIL (a Group object) - creates it if necessary
	 */
	public MFN_M11_MF_TEST_CALC_DETAIL MF_TEST_CALC_DETAIL { 
get{
	   MFN_M11_MF_TEST_CALC_DETAIL ret = null;
	   try {
	      ret = (MFN_M11_MF_TEST_CALC_DETAIL)this.get_Renamed("MF_TEST_CALC_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
