using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the ADT_A45_MERGE_INFO Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MRG (Merge patient information) <b></b><br>
 * 1: PV1 (Patient visit) <b></b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class ADT_A45_MERGE_INFO : AbstractGroup {

	/** 
	 * Creates a new ADT_A45_MERGE_INFO Group.
	 */
	public ADT_A45_MERGE_INFO(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("MRG", "2.3"), true, false);
	      this.add(factory.getSegmentClass("PV1", "2.3"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A45_MERGE_INFO - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MRG (Merge patient information) - creates it if necessary
	 */
	public MRG MRG { 
get{
	   MRG ret = null;
	   try {
	      ret = (MRG)this.get_Renamed("MRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PV1 (Patient visit) - creates it if necessary
	 */
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.get_Renamed("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
