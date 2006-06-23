using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the EAR_U08_COMMAND_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ECD (Equipment Command) <b></b><br>
 * 1: SAC (Specimen and container detail) <b>optional </b><br>
 * 2: ECR (Equipment Command Response) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class EAR_U08_COMMAND_RESPONSE : AbstractGroup {

	/** 
	 * Creates a new EAR_U08_COMMAND_RESPONSE Group.
	 */
	public EAR_U08_COMMAND_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ECD", "2.4"), true, false);
	      this.add(factory.getSegmentClass("SAC", "2.4"), false, false);
	      this.add(factory.getSegmentClass("ECR", "2.4"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating EAR_U08_COMMAND_RESPONSE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ECD (Equipment Command) - creates it if necessary
	 */
	public ECD ECD { 
get{
	   ECD ret = null;
	   try {
	      ret = (ECD)this.get_Renamed("ECD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns SAC (Specimen and container detail) - creates it if necessary
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
	 * Returns ECR (Equipment Command Response) - creates it if necessary
	 */
	public ECR ECR { 
get{
	   ECR ret = null;
	   try {
	      ret = (ECR)this.get_Renamed("ECR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
