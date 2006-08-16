using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v24.segment;

using NHapi.Base.model;
/**
 * <p>Represents the SQM_S25_SERVICE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: AIS (Appointment Information - Service) <b></b><br>
 * 1: APR (Appointment Preferences) <b>optional </b><br>
 */
namespace NHapi.Base.model.v24.group
{
[Serializable]
public class SQM_S25_SERVICE : AbstractGroup {

	/** 
	 * Creates a new SQM_S25_SERVICE Group.
	 */
	public SQM_S25_SERVICE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("AIS", "2.4"), true, false);
	      this.add(factory.getSegmentClass("APR", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SQM_S25_SERVICE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns AIS (Appointment Information - Service) - creates it if necessary
	 */
	public AIS AIS { 
get{
	   AIS ret = null;
	   try {
	      ret = (AIS)this.get_Renamed("AIS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns APR (Appointment Preferences) - creates it if necessary
	 */
	public APR APR { 
get{
	   APR ret = null;
	   try {
	      ret = (APR)this.get_Renamed("APR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
