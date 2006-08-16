using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the PPG_PCG_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (ORC - common order segment) <b></b><br>
 * 1: PPG_PCG_ORDER_DETAIL (a Group object) <b>optional </b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class PPG_PCG_ORDER : AbstractGroup {

	/** 
	 * Creates a new PPG_PCG_ORDER Group.
	 */
	public PPG_PCG_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.3.1"), true, false);
	      this.add(factory.getGroupClass("PPG_PCG_ORDER_DETAIL", "2.3.1"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPG_PCG_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (ORC - common order segment) - creates it if necessary
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
	 * Returns PPG_PCG_ORDER_DETAIL (a Group object) - creates it if necessary
	 */
	public PPG_PCG_ORDER_DETAIL ORDER_DETAIL { 
get{
	   PPG_PCG_ORDER_DETAIL ret = null;
	   try {
	      ret = (PPG_PCG_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
