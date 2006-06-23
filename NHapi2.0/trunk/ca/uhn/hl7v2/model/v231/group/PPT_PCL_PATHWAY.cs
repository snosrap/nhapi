using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPT_PCL_PATHWAY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PTH (Pathway) <b></b><br>
 * 1: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
 * 2: VAR (Variance) <b>optional repeating</b><br>
 * 3: PPT_PCL_PATHWAY_ROLE (a Group object) <b>optional repeating</b><br>
 * 4: PPT_PCL_GOAL (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class PPT_PCL_PATHWAY : AbstractGroup {

	/** 
	 * Creates a new PPT_PCL_PATHWAY Group.
	 */
	public PPT_PCL_PATHWAY(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PTH", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("VAR", "2.3.1"), false, true);
	      this.add(factory.getGroupClass("PPT_PCL_PATHWAY_ROLE", "2.3.1"), false, true);
	      this.add(factory.getGroupClass("PPT_PCL_GOAL", "2.3.1"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPT_PCL_PATHWAY - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
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
	 * (NTE - notes and comments segment) - creates it if necessary
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
	 * Returns  first repetition of PPT_PCL_PATHWAY_ROLE (a Group object) - creates it if necessary
	 */
	public PPT_PCL_PATHWAY_ROLE  getPATHWAY_ROLE() { 
	   PPT_PCL_PATHWAY_ROLE ret = null;
	   try {
	      ret = (PPT_PCL_PATHWAY_ROLE)this.get_Renamed("PATHWAY_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPT_PCL_PATHWAY_ROLE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPT_PCL_PATHWAY_ROLE getPATHWAY_ROLE(int rep) { 
	   return (PPT_PCL_PATHWAY_ROLE)this.get_Renamed("PATHWAY_ROLE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPT_PCL_PATHWAY_ROLE 
	 */ 
	public int PATHWAY_ROLEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PATHWAY_ROLE").Length; 
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
	 * Returns  first repetition of PPT_PCL_GOAL (a Group object) - creates it if necessary
	 */
	public PPT_PCL_GOAL  getGOAL() { 
	   PPT_PCL_GOAL ret = null;
	   try {
	      ret = (PPT_PCL_GOAL)this.get_Renamed("GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPT_PCL_GOAL
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPT_PCL_GOAL getGOAL(int rep) { 
	   return (PPT_PCL_GOAL)this.get_Renamed("GOAL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPT_PCL_GOAL 
	 */ 
	public int GOALReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GOAL").Length; 
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
