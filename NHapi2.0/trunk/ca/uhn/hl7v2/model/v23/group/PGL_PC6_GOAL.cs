using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PGL_PC6_GOAL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: GOL (Goal Detail) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 2: VAR (Variance) <b>optional repeating</b><br>
 * 3: PGL_PC6_GOAL_ROLE (a Group object) <b>optional repeating</b><br>
 * 4: PGL_PC6_PATHWAY (a Group object) <b>optional repeating</b><br>
 * 5: PGL_PC6_OBSERVATION (a Group object) <b>optional repeating</b><br>
 * 6: PGL_PC6_PROBLEM (a Group object) <b>optional repeating</b><br>
 * 7: PGL_PC6_ORDER (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class PGL_PC6_GOAL : AbstractGroup {

	/** 
	 * Creates a new PGL_PC6_GOAL Group.
	 */
	public PGL_PC6_GOAL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("GOL", "2.3"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	      this.add(factory.getSegmentClass("VAR", "2.3"), false, true);
	      this.add(factory.getGroupClass("PGL_PC6_GOAL_ROLE", "2.3"), false, true);
	      this.add(factory.getGroupClass("PGL_PC6_PATHWAY", "2.3"), false, true);
	      this.add(factory.getGroupClass("PGL_PC6_OBSERVATION", "2.3"), false, true);
	      this.add(factory.getGroupClass("PGL_PC6_PROBLEM", "2.3"), false, true);
	      this.add(factory.getGroupClass("PGL_PC6_ORDER", "2.3"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PGL_PC6_GOAL - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of PGL_PC6_GOAL_ROLE (a Group object) - creates it if necessary
	 */
	public PGL_PC6_GOAL_ROLE  getGOAL_ROLE() { 
	   PGL_PC6_GOAL_ROLE ret = null;
	   try {
	      ret = (PGL_PC6_GOAL_ROLE)this.get_Renamed("GOAL_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC6_GOAL_ROLE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC6_GOAL_ROLE getGOAL_ROLE(int rep) { 
	   return (PGL_PC6_GOAL_ROLE)this.get_Renamed("GOAL_ROLE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC6_GOAL_ROLE 
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
	 * Returns  first repetition of PGL_PC6_PATHWAY (a Group object) - creates it if necessary
	 */
	public PGL_PC6_PATHWAY  getPATHWAY() { 
	   PGL_PC6_PATHWAY ret = null;
	   try {
	      ret = (PGL_PC6_PATHWAY)this.get_Renamed("PATHWAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC6_PATHWAY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC6_PATHWAY getPATHWAY(int rep) { 
	   return (PGL_PC6_PATHWAY)this.get_Renamed("PATHWAY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC6_PATHWAY 
	 */ 
	public int PATHWAYReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PATHWAY").Length; 
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
	 * Returns  first repetition of PGL_PC6_OBSERVATION (a Group object) - creates it if necessary
	 */
	public PGL_PC6_OBSERVATION  getOBSERVATION() { 
	   PGL_PC6_OBSERVATION ret = null;
	   try {
	      ret = (PGL_PC6_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC6_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC6_OBSERVATION getOBSERVATION(int rep) { 
	   return (PGL_PC6_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC6_OBSERVATION 
	 */ 
	public int OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("OBSERVATION").Length; 
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
	 * Returns  first repetition of PGL_PC6_PROBLEM (a Group object) - creates it if necessary
	 */
	public PGL_PC6_PROBLEM  getPROBLEM() { 
	   PGL_PC6_PROBLEM ret = null;
	   try {
	      ret = (PGL_PC6_PROBLEM)this.get_Renamed("PROBLEM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC6_PROBLEM
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC6_PROBLEM getPROBLEM(int rep) { 
	   return (PGL_PC6_PROBLEM)this.get_Renamed("PROBLEM", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC6_PROBLEM 
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
	 * Returns  first repetition of PGL_PC6_ORDER (a Group object) - creates it if necessary
	 */
	public PGL_PC6_ORDER  getORDER() { 
	   PGL_PC6_ORDER ret = null;
	   try {
	      ret = (PGL_PC6_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PGL_PC6_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PGL_PC6_ORDER getORDER(int rep) { 
	   return (PGL_PC6_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PGL_PC6_ORDER 
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
