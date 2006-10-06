using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v21.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORR_O02_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (OBSERVATION REQUEST) <b></b><br>
 * 1: ORO (ORDER OTHER) <b></b><br>
 * 2: RX1 (PHARMACY ORDER) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v21.group
{
[Serializable]
public class ORR_O02_ORDER_DETAIL : AbstractGroup {

	/** 
	 * Creates a new ORR_O02_ORDER_DETAIL Group.
	 */
	public ORR_O02_ORDER_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OBR), true, false);
	      this.add(typeof(ORO), true, false);
	      this.add(typeof(RX1), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORR_O02_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBR (OBSERVATION REQUEST) - creates it if necessary
	 */
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.get_Renamed("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ORO (ORDER OTHER) - creates it if necessary
	 */
	public ORO ORO { 
get{
	   ORO ret = null;
	   try {
	      ret = (ORO)this.get_Renamed("ORO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RX1 (PHARMACY ORDER) - creates it if necessary
	 */
	public RX1 RX1 { 
get{
	   RX1 ret = null;
	   try {
	      ret = (RX1)this.get_Renamed("RX1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
