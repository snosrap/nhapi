using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the SIU_S13_PERSONNEL_RESOURCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: AIP (Appointment Information - Personnel Resource) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class SIU_S13_PERSONNEL_RESOURCE : AbstractGroup {

	/** 
	 * Creates a new SIU_S13_PERSONNEL_RESOURCE Group.
	 */
	public SIU_S13_PERSONNEL_RESOURCE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("AIP", "2.3"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SIU_S13_PERSONNEL_RESOURCE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns AIP (Appointment Information - Personnel Resource) - creates it if necessary
	 */
	public AIP AIP { 
get{
	   AIP ret = null;
	   try {
	      ret = (AIP)this.get_Renamed("AIP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
	 */
	public NTE  getNTE() { 
	   NTE ret = null;
	   try {
	      ret = (NTE)this.get_Renamed("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NTE
	 * (Notes and comments segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NTE getNTE(int rep) { 
	   return (NTE)this.get_Renamed("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NTE").Length; 
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
