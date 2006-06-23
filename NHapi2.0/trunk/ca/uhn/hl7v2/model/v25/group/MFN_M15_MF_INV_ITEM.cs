using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M15_MF_INV_ITEM Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master File Entry) <b></b><br>
 * 1: IIM (Inventory Item Master) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class MFN_M15_MF_INV_ITEM : AbstractGroup {

	/** 
	 * Creates a new MFN_M15_MF_INV_ITEM Group.
	 */
	public MFN_M15_MF_INV_ITEM(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MFE", "2.5"), true, false);
	      this.add(factory.getSegmentClass("IIM", "2.5"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M15_MF_INV_ITEM - this is probably a bug in the source code generator.", e);
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
	 * Returns IIM (Inventory Item Master) - creates it if necessary
	 */
	public IIM IIM { 
get{
	   IIM ret = null;
	   try {
	      ret = (IIM)this.get_Renamed("IIM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
