using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the DFT_P11_COMMON_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b>optional </b><br>
 * 1: DFT_P11_TIMING_QUANTITY (a Group object) <b></b><br>
 * 2: DFT_P11_ORDER (a Group object) <b>optional </b><br>
 * 3: DFT_P11_OBSERVATION (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class DFT_P11_COMMON_ORDER : AbstractGroup {

	/** 
	 * Creates a new DFT_P11_COMMON_ORDER Group.
	 */
	public DFT_P11_COMMON_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.5"), false, false);
	      this.add(factory.getGroupClass("DFT_P11_TIMING_QUANTITY", "2.5"), true, false);
	      this.add(factory.getGroupClass("DFT_P11_ORDER", "2.5"), false, false);
	      this.add(factory.getGroupClass("DFT_P11_OBSERVATION", "2.5"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DFT_P11_COMMON_ORDER - this is probably a bug in the source code generator.", e);
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
	 * Returns DFT_P11_TIMING_QUANTITY (a Group object) - creates it if necessary
	 */
	public DFT_P11_TIMING_QUANTITY TIMING_QUANTITY { 
get{
	   DFT_P11_TIMING_QUANTITY ret = null;
	   try {
	      ret = (DFT_P11_TIMING_QUANTITY)this.get_Renamed("TIMING_QUANTITY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DFT_P11_ORDER (a Group object) - creates it if necessary
	 */
	public DFT_P11_ORDER ORDER { 
get{
	   DFT_P11_ORDER ret = null;
	   try {
	      ret = (DFT_P11_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DFT_P11_OBSERVATION (a Group object) - creates it if necessary
	 */
	public DFT_P11_OBSERVATION OBSERVATION { 
get{
	   DFT_P11_OBSERVATION ret = null;
	   try {
	      ret = (DFT_P11_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
