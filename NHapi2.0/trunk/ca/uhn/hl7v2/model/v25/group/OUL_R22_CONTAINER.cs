using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OUL_R22_CONTAINER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SAC (Specimen Container detail) <b></b><br>
 * 1: INV (Inventory Detail) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class OUL_R22_CONTAINER : AbstractGroup {

	/** 
	 * Creates a new OUL_R22_CONTAINER Group.
	 */
	public OUL_R22_CONTAINER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("SAC", "2.5"), true, false);
	      this.add(factory.getSegmentClass("INV", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OUL_R22_CONTAINER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns SAC (Specimen Container detail) - creates it if necessary
	 */
	public SAC SAC { 
get{
	   SAC ret = null;
	   try {
	      ret = (SAC)this.get_Renamed("SAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns INV (Inventory Detail) - creates it if necessary
	 */
	public INV INV { 
get{
	   INV ret = null;
	   try {
	      ret = (INV)this.get_Renamed("INV");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
