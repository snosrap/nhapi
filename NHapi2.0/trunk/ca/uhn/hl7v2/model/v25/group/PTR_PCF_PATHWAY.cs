using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PTR_PCF_PATHWAY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PTH (Pathway) <b></b><br>
 * 1: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 2: VAR (Variance) <b>optional repeating</b><br>
 * 3: PTR_PCF_PATHWAY_ROLE (a Group object) <b></b><br>
 * 4: PTR_PCF_PROBLEM (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class PTR_PCF_PATHWAY : AbstractGroup {

	/** 
	 * Creates a new PTR_PCF_PATHWAY Group.
	 */
	public PTR_PCF_PATHWAY(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PTH", "2.5"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.5"), false, true);
	      this.add(factory.getSegmentClass("VAR", "2.5"), false, true);
	      this.add(factory.getGroupClass("PTR_PCF_PATHWAY_ROLE", "2.5"), true, false);
	      this.add(factory.getGroupClass("PTR_PCF_PROBLEM", "2.5"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PTR_PCF_PATHWAY - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PTH (Pathway) - creates it if necessary
	 */
	public PTH PTH { 
get{
	   PTH ret = null;
	   try {
	      ret = (PTH)this.get_Renamed("PTH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
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
	 * (Notes and Comments) - creates it if necessary
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
	 * Returns  first repetition of VAR (Variance) - creates it if necessary
	 */
	public VAR  getVAR() { 
	   VAR ret = null;
	   try {
	      ret = (VAR)this.get_Renamed("VAR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of VAR
	 * (Variance) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public VAR getVAR(int rep) { 
	   return (VAR)this.get_Renamed("VAR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of VAR 
	 */ 
	public int VARReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("VAR").Length; 
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
	 * Returns PTR_PCF_PATHWAY_ROLE (a Group object) - creates it if necessary
	 */
	public PTR_PCF_PATHWAY_ROLE PATHWAY_ROLE { 
get{
	   PTR_PCF_PATHWAY_ROLE ret = null;
	   try {
	      ret = (PTR_PCF_PATHWAY_ROLE)this.get_Renamed("PATHWAY_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PTR_PCF_PROBLEM (a Group object) - creates it if necessary
	 */
	public PTR_PCF_PROBLEM PROBLEM { 
get{
	   PTR_PCF_PROBLEM ret = null;
	   try {
	      ret = (PTR_PCF_PROBLEM)this.get_Renamed("PROBLEM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
