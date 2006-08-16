using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v24.segment;

using NHapi.Base.model;
/**
 * <p>Represents the ORL_O22_GENERAL_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORL_O22_CONTAINER (a Group object) <b>optional </b><br>
 * 1: ORL_O22_ORDER (a Group object) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v24.group
{
[Serializable]
public class ORL_O22_GENERAL_ORDER : AbstractGroup {

	/** 
	 * Creates a new ORL_O22_GENERAL_ORDER Group.
	 */
	public ORL_O22_GENERAL_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getGroupClass("ORL_O22_CONTAINER", "2.4"), false, false);
	      this.add(factory.getGroupClass("ORL_O22_ORDER", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORL_O22_GENERAL_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORL_O22_CONTAINER (a Group object) - creates it if necessary
	 */
	public ORL_O22_CONTAINER CONTAINER { 
get{
	   ORL_O22_CONTAINER ret = null;
	   try {
	      ret = (ORL_O22_CONTAINER)this.get_Renamed("CONTAINER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ORL_O22_ORDER (a Group object) - creates it if necessary
	 */
	public ORL_O22_ORDER  getORDER() { 
	   ORL_O22_ORDER ret = null;
	   try {
	      ret = (ORL_O22_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORL_O22_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORL_O22_ORDER getORDER(int rep) { 
	   return (ORL_O22_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORL_O22_ORDER 
	 */ 
	public int ORDERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER").Length; 
	    }
 catch (HL7Exception e) 
{ 
	        String message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
