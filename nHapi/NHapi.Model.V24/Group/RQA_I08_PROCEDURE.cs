using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v24.segment;

using NHapi.Base.model;
/**
 * <p>Represents the RQA_I08_PROCEDURE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PR1 (Procedures) <b></b><br>
 * 1: RQA_I08_AUTHORIZATION (a Group object) <b>optional </b><br>
 */
namespace NHapi.Base.model.v24.group
{
[Serializable]
public class RQA_I08_PROCEDURE : AbstractGroup {

	/** 
	 * Creates a new RQA_I08_PROCEDURE Group.
	 */
	public RQA_I08_PROCEDURE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PR1", "2.4"), true, false);
	      this.add(factory.getGroupClass("RQA_I08_AUTHORIZATION", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RQA_I08_PROCEDURE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PR1 (Procedures) - creates it if necessary
	 */
	public PR1 PR1 { 
get{
	   PR1 ret = null;
	   try {
	      ret = (PR1)this.get_Renamed("PR1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RQA_I08_AUTHORIZATION (a Group object) - creates it if necessary
	 */
	public RQA_I08_AUTHORIZATION AUTHORIZATION { 
get{
	   RQA_I08_AUTHORIZATION ret = null;
	   try {
	      ret = (RQA_I08_AUTHORIZATION)this.get_Renamed("AUTHORIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}