using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RGV_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXO (Pharmacy prescription order segment) <b></b><br>
 * 1: RGV_O01_ORDER_DETAIL_SUPPLEMENT (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class RGV_O01_ORDER_DETAIL : AbstractGroup {

	/** 
	 * Creates a new RGV_O01_ORDER_DETAIL Group.
	 */
	public RGV_O01_ORDER_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("RXO", "2.3"), true, false);
	      this.add(factory.getGroupClass("RGV_O01_ORDER_DETAIL_SUPPLEMENT", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGV_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RXO (Pharmacy prescription order segment) - creates it if necessary
	 */
	public RXO RXO { 
get{
	   RXO ret = null;
	   try {
	      ret = (RXO)this.get_Renamed("RXO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RGV_O01_ORDER_DETAIL_SUPPLEMENT (a Group object) - creates it if necessary
	 */
	public RGV_O01_ORDER_DETAIL_SUPPLEMENT ORDER_DETAIL_SUPPLEMENT { 
get{
	   RGV_O01_ORDER_DETAIL_SUPPLEMENT ret = null;
	   try {
	      ret = (RGV_O01_ORDER_DETAIL_SUPPLEMENT)this.get_Renamed("ORDER_DETAIL_SUPPLEMENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
