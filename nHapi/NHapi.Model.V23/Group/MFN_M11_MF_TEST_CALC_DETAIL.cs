using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M11_MF_TEST_CALC_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OM6 (Observations that are calculated from other observations) <b></b><br>
 * 1: OM2 (Numeric observation) <b></b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class MFN_M11_MF_TEST_CALC_DETAIL : AbstractGroup {

	/** 
	 * Creates a new MFN_M11_MF_TEST_CALC_DETAIL Group.
	 */
	public MFN_M11_MF_TEST_CALC_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OM6", "2.3"), true, false);
	      this.add(factory.getSegmentClass("OM2", "2.3"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M11_MF_TEST_CALC_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OM6 (Observations that are calculated from other observations) - creates it if necessary
	 */
	public OM6 OM6 { 
get{
	   OM6 ret = null;
	   try {
	      ret = (OM6)this.get_Renamed("OM6");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns OM2 (Numeric observation) - creates it if necessary
	 */
	public OM2 OM2 { 
get{
	   OM2 ret = null;
	   try {
	      ret = (OM2)this.get_Renamed("OM2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
