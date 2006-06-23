using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the VXU_V04_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: VXU_V04_TIMING (a Group object) <b></b><br>
 * 2: RXA (Pharmacy/Treatment Administration) <b></b><br>
 * 3: RXR (Pharmacy/Treatment Route) <b>optional </b><br>
 * 4: VXU_V04_OBSERVATION (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class VXU_V04_ORDER : AbstractGroup {

	/** 
	 * Creates a new VXU_V04_ORDER Group.
	 */
	public VXU_V04_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), true, false);
	      this.add(factory.getGroupClass("VXU_V04_TIMING", "2.5"), true, false);
	      this.add(factory.getSegmentClass("RXA", "2.5"), true, false);
	      this.add(factory.getSegmentClass("RXR", "2.5"), false, false);
	      this.add(factory.getGroupClass("VXU_V04_OBSERVATION", "2.5"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating VXU_V04_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common Order) - creates it if necessary
	 */
	public ORC ORC { 
get{
	   ORC ret = null;
	   try {
	      ret = (ORC)this.get_Renamed("ORC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns VXU_V04_TIMING (a Group object) - creates it if necessary
	 */
	public VXU_V04_TIMING TIMING { 
get{
	   VXU_V04_TIMING ret = null;
	   try {
	      ret = (VXU_V04_TIMING)this.get_Renamed("TIMING");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RXA (Pharmacy/Treatment Administration) - creates it if necessary
	 */
	public RXA RXA { 
get{
	   RXA ret = null;
	   try {
	      ret = (RXA)this.get_Renamed("RXA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RXR (Pharmacy/Treatment Route) - creates it if necessary
	 */
	public RXR RXR { 
get{
	   RXR ret = null;
	   try {
	      ret = (RXR)this.get_Renamed("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns VXU_V04_OBSERVATION (a Group object) - creates it if necessary
	 */
	public VXU_V04_OBSERVATION OBSERVATION { 
get{
	   VXU_V04_OBSERVATION ret = null;
	   try {
	      ret = (VXU_V04_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
