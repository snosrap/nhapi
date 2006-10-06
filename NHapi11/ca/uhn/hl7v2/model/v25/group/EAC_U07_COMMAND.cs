using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the EAC_U07_COMMAND Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ECD (Equipment Command) <b></b><br>
 * 1: TQ1 (Timing/Quantity) <b>optional </b><br>
 * 2: EAC_U07_SPECIMEN_CONTAINER (a Group object) <b>optional </b><br>
 * 3: CNS (Clear Notification) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class EAC_U07_COMMAND : AbstractGroup {

	/** 
	 * Creates a new EAC_U07_COMMAND Group.
	 */
	public EAC_U07_COMMAND(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(ECD), true, false);
	      this.add(typeof(TQ1), false, false);
	      this.add(typeof(EAC_U07_SPECIMEN_CONTAINER), false, false);
	      this.add(typeof(CNS), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating EAC_U07_COMMAND - this is probably a bug in the source code generator.", e);
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
	 * Returns TQ1 (Timing/Quantity) - creates it if necessary
	 */
	public TQ1 TQ1 { 
get{
	   TQ1 ret = null;
	   try {
	      ret = (TQ1)this.get_Renamed("TQ1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns EAC_U07_SPECIMEN_CONTAINER (a Group object) - creates it if necessary
	 */
	public EAC_U07_SPECIMEN_CONTAINER SPECIMEN_CONTAINER { 
get{
	   EAC_U07_SPECIMEN_CONTAINER ret = null;
	   try {
	      ret = (EAC_U07_SPECIMEN_CONTAINER)this.get_Renamed("SPECIMEN_CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns CNS (Clear Notification) - creates it if necessary
	 */
	public CNS CNS { 
get{
	   CNS ret = null;
	   try {
	      ret = (CNS)this.get_Renamed("CNS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
