using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M08_MF_TEST_NUMERIC Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: OM1 (General Segment) <b></b><br>
 * 2: OM2 (Numeric Observation) <b>optional </b><br>
 * 3: OM3 (Categorical Service/Test/Observation) <b>optional </b><br>
 * 4: OM4 (Observations that Require Specimens) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class MFN_M08_MF_TEST_NUMERIC : AbstractGroup {

	/** 
	 * Creates a new MFN_M08_MF_TEST_NUMERIC Group.
	 */
	public MFN_M08_MF_TEST_NUMERIC(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.4"), true, false);
	      this.add(factory.getSegmentClass("OM1", "2.4"), true, false);
	      this.add(factory.getSegmentClass("OM2", "2.4"), false, false);
	      this.add(factory.getSegmentClass("OM3", "2.4"), false, false);
	      this.add(factory.getSegmentClass("OM4", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M08_MF_TEST_NUMERIC - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (Master File Entry) - creates it if necessary
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
	 * Returns OM1 (General Segment) - creates it if necessary
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
	 * Returns OM2 (Numeric Observation) - creates it if necessary
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

	/**
	 * Returns OM3 (Categorical Service/Test/Observation) - creates it if necessary
	 */
	public OM3 OM3 { 
get{
	   OM3 ret = null;
	   try {
	      ret = (OM3)this.get_Renamed("OM3");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns OM4 (Observations that Require Specimens) - creates it if necessary
	 */
	public OM4 OM4 { 
get{
	   OM4 ret = null;
	   try {
	      ret = (OM4)this.get_Renamed("OM4");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
