using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SUR_P09_PRODUCT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PSH (Product Summary Header) <b></b><br>
 * 1: PDC (Product Detail Country) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class SUR_P09_PRODUCT : AbstractGroup {

	/** 
	 * Creates a new SUR_P09_PRODUCT Group.
	 */
	public SUR_P09_PRODUCT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(PSH), true, false);
	      this.add(typeof(PDC), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SUR_P09_PRODUCT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PSH (Product Summary Header) - creates it if necessary
	 */
	public PSH PSH { 
get{
	   PSH ret = null;
	   try {
	      ret = (PSH)this.get_Renamed("PSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PDC (Product Detail Country) - creates it if necessary
	 */
	public PDC PDC { 
get{
	   PDC ret = null;
	   try {
	      ret = (PDC)this.get_Renamed("PDC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
