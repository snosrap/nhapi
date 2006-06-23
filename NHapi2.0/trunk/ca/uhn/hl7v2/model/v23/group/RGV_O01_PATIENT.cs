using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RGV_O01_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient Identification) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 2: RGV_O01_EMC_TEMP_GROUP (a Group object) <b>optional </b><br>
 * 3: RGV_O01_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class RGV_O01_PATIENT : AbstractGroup {

	/** 
	 * Creates a new RGV_O01_PATIENT Group.
	 */
	public RGV_O01_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PID", "2.3"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	      this.add(factory.getGroupClass("RGV_O01_EMC_TEMP_GROUP", "2.3"), false, false);
	      this.add(factory.getGroupClass("RGV_O01_ORDER", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGV_O01_PATIENT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PID (Patient Identification) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
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

	/**
	 * Returns RGV_O01_EMC_TEMP_GROUP (a Group object) - creates it if necessary
	 */
	public RGV_O01_EMC_TEMP_GROUP EMC_TEMP_GROUP { 
get{
	   RGV_O01_EMC_TEMP_GROUP ret = null;
	   try {
	      ret = (RGV_O01_EMC_TEMP_GROUP)this.get_Renamed("EMC_TEMP_GROUP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RGV_O01_ORDER (a Group object) - creates it if necessary
	 */
	public RGV_O01_ORDER  getORDER() { 
	   RGV_O01_ORDER ret = null;
	   try {
	      ret = (RGV_O01_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RGV_O01_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RGV_O01_ORDER getORDER(int rep) { 
	   return (RGV_O01_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RGV_O01_ORDER 
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
