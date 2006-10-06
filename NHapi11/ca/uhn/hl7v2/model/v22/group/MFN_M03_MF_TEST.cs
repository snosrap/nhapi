using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v22.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M03_MF_TEST Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (MASTER FILE ENTRY) <b></b><br>
 * 1: Zxx (any Z segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v22.group
{
[Serializable]
public class MFN_M03_MF_TEST : AbstractGroup {

	/** 
	 * Creates a new MFN_M03_MF_TEST Group.
	 */
	public MFN_M03_MF_TEST(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(Zxx), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M03_MF_TEST - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MFE (MASTER FILE ENTRY) - creates it if necessary
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
