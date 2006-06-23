using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PPG_PCG_GOAL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: GOL (Goal Detail) <b></b><br>
 * 1: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 2: VAR (Variance) <b>optional repeating</b><br>
 * 3: PPG_PCG_GOAL_ROLE (a Group object) <b>optional repeating</b><br>
 * 4: PPG_PCG_GOAL_OBSERVATION (a Group object) <b>optional repeating</b><br>
 * 5: PPG_PCG_PROBLEM (a Group object) <b>optional repeating</b><br>
 * 6: PPG_PCG_ORDER (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class PPG_PCG_GOAL : AbstractGroup {

	/** 
	 * Creates a new PPG_PCG_GOAL Group.
	 */
	public PPG_PCG_GOAL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("GOL", "2.4"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.4"), false, true);
	      this.add(factory.getSegmentClass("VAR", "2.4"), false, true);
	      this.add(factory.getGroupClass("PPG_PCG_GOAL_ROLE", "2.4"), false, true);
	      this.add(factory.getGroupClass("PPG_PCG_GOAL_OBSERVATION", "2.4"), false, true);
	      this.add(factory.getGroupClass("PPG_PCG_PROBLEM", "2.4"), false, true);
	      this.add(factory.getGroupClass("PPG_PCG_ORDER", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPG_PCG_GOAL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns GOL (Goal Detail) - creates it if necessary
	 */
	public GOL GOL { 
get{
	   GOL ret = null;
	   try {
	      ret = (GOL)this.get_Renamed("GOL");
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
	 * Returns  first repetition of PPG_PCG_GOAL_ROLE (a Group object) - creates it if necessary
	 */
	public PPG_PCG_GOAL_ROLE  getGOAL_ROLE() { 
	   PPG_PCG_GOAL_ROLE ret = null;
	   try {
	      ret = (PPG_PCG_GOAL_ROLE)this.get_Renamed("GOAL_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPG_PCG_GOAL_ROLE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPG_PCG_GOAL_ROLE getGOAL_ROLE(int rep) { 
	   return (PPG_PCG_GOAL_ROLE)this.get_Renamed("GOAL_ROLE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPG_PCG_GOAL_ROLE 
	 */ 
	public int GOAL_ROLEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GOAL_ROLE").Length; 
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
	 * Returns  first repetition of PPG_PCG_GOAL_OBSERVATION (a Group object) - creates it if necessary
	 */
	public PPG_PCG_GOAL_OBSERVATION  getGOAL_OBSERVATION() { 
	   PPG_PCG_GOAL_OBSERVATION ret = null;
	   try {
	      ret = (PPG_PCG_GOAL_OBSERVATION)this.get_Renamed("GOAL_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPG_PCG_GOAL_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPG_PCG_GOAL_OBSERVATION getGOAL_OBSERVATION(int rep) { 
	   return (PPG_PCG_GOAL_OBSERVATION)this.get_Renamed("GOAL_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPG_PCG_GOAL_OBSERVATION 
	 */ 
	public int GOAL_OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GOAL_OBSERVATION").Length; 
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
	 * Returns  first repetition of PPG_PCG_PROBLEM (a Group object) - creates it if necessary
	 */
	public PPG_PCG_PROBLEM  getPROBLEM() { 
	   PPG_PCG_PROBLEM ret = null;
	   try {
	      ret = (PPG_PCG_PROBLEM)this.get_Renamed("PROBLEM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPG_PCG_PROBLEM
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPG_PCG_PROBLEM getPROBLEM(int rep) { 
	   return (PPG_PCG_PROBLEM)this.get_Renamed("PROBLEM", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPG_PCG_PROBLEM 
	 */ 
	public int PROBLEMReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROBLEM").Length; 
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
	 * Returns  first repetition of PPG_PCG_ORDER (a Group object) - creates it if necessary
	 */
	public PPG_PCG_ORDER  getORDER() { 
	   PPG_PCG_ORDER ret = null;
	   try {
	      ret = (PPG_PCG_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPG_PCG_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPG_PCG_ORDER getORDER(int rep) { 
	   return (PPG_PCG_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPG_PCG_ORDER 
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
