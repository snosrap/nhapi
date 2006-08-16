using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v24.segment;

using NHapi.Base.model;
/**
 * <p>Represents the EAN_U09_NOTIFICATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: NDS (Notification Detail) <b></b><br>
 * 1: NTE (Notes and Comments) <b>optional </b><br>
 */
namespace NHapi.Base.model.v24.group
{
[Serializable]
public class EAN_U09_NOTIFICATION : AbstractGroup {

	/** 
	 * Creates a new EAN_U09_NOTIFICATION Group.
	 */
	public EAN_U09_NOTIFICATION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("NDS", "2.4"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating EAN_U09_NOTIFICATION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns NDS (Notification Detail) - creates it if necessary
	 */
	public NDS NDS { 
get{
	   NDS ret = null;
	   try {
	      ret = (NDS)this.get_Renamed("NDS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns NTE (Notes and Comments) - creates it if necessary
	 */
	public NTE NTE { 
get{
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
