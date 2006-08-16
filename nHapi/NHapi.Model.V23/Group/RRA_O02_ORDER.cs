using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the RRA_O02_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common order segment) <b></b><br>
 * 1: RRA_O02_ADMINISTRATION (a Group object) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class RRA_O02_ORDER : AbstractGroup {

	/** 
	 * Creates a new RRA_O02_ORDER Group.
	 */
	public RRA_O02_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.3"), true, false);
	      this.add(factory.getGroupClass("RRA_O02_ADMINISTRATION", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRA_O02_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common order segment) - creates it if necessary
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
	 * Returns  first repetition of RRA_O02_ADMINISTRATION (a Group object) - creates it if necessary
	 */
	public RRA_O02_ADMINISTRATION  getADMINISTRATION() { 
	   RRA_O02_ADMINISTRATION ret = null;
	   try {
	      ret = (RRA_O02_ADMINISTRATION)this.get_Renamed("ADMINISTRATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RRA_O02_ADMINISTRATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RRA_O02_ADMINISTRATION getADMINISTRATION(int rep) { 
	   return (RRA_O02_ADMINISTRATION)this.get_Renamed("ADMINISTRATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RRA_O02_ADMINISTRATION 
	 */ 
	public int ADMINISTRATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ADMINISTRATION").Length; 
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
