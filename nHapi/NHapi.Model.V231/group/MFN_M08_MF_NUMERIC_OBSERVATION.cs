using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the MFN_M08_MF_NUMERIC_OBSERVATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OM2 (OM2 - numeric observation segment) <b>optional </b><br>
 * 1: OM3 (OM3 - categorical test/observation segment) <b>optional </b><br>
 * 2: OM4 (OM4 - observations that require specimens segment) <b>optional </b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class MFN_M08_MF_NUMERIC_OBSERVATION : AbstractGroup {

	/** 
	 * Creates a new MFN_M08_MF_NUMERIC_OBSERVATION Group.
	 */
	public MFN_M08_MF_NUMERIC_OBSERVATION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OM2", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("OM3", "2.3.1"), false, false);
	      this.add(factory.getSegmentClass("OM4", "2.3.1"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M08_MF_NUMERIC_OBSERVATION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OM2 (OM2 - numeric observation segment) - creates it if necessary
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
	 * Returns OM3 (OM3 - categorical test/observation segment) - creates it if necessary
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
	 * Returns OM4 (OM4 - observations that require specimens segment) - creates it if necessary
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
