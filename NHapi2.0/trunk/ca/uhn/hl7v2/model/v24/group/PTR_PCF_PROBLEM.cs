using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PTR_PCF_PROBLEM Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PRB (Problem Details) <b></b><br>
 * 1: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 2: VAR (Variance) <b>optional repeating</b><br>
 * 3: PTR_PCF_PROBLEM_ROLE (a Group object) <b>optional repeating</b><br>
 * 4: PTR_PCF_PROBLEM_OBSERVATION (a Group object) <b>optional repeating</b><br>
 * 5: PTR_PCF_GOAL (a Group object) <b>optional repeating</b><br>
 * 6: PTR_PCF_ORDER (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class PTR_PCF_PROBLEM : AbstractGroup {

	/** 
	 * Creates a new PTR_PCF_PROBLEM Group.
	 */
	public PTR_PCF_PROBLEM(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PRB", "2.4"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.4"), false, true);
	      this.add(factory.getSegmentClass("VAR", "2.4"), false, true);
	      this.add(factory.getGroupClass("PTR_PCF_PROBLEM_ROLE", "2.4"), false, true);
	      this.add(factory.getGroupClass("PTR_PCF_PROBLEM_OBSERVATION", "2.4"), false, true);
	      this.add(factory.getGroupClass("PTR_PCF_GOAL", "2.4"), false, true);
	      this.add(factory.getGroupClass("PTR_PCF_ORDER", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PTR_PCF_PROBLEM - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PRB (Problem Details) - creates it if necessary
	 */
	public PRB PRB { 
get{
	   PRB ret = null;
	   try {
	      ret = (PRB)this.get_Renamed("PRB");
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
	 * Returns  first repetition of PTR_PCF_PROBLEM_ROLE (a Group object) - creates it if necessary
	 */
	public PTR_PCF_PROBLEM_ROLE  getPROBLEM_ROLE() { 
	   PTR_PCF_PROBLEM_ROLE ret = null;
	   try {
	      ret = (PTR_PCF_PROBLEM_ROLE)this.get_Renamed("PROBLEM_ROLE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PTR_PCF_PROBLEM_ROLE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PTR_PCF_PROBLEM_ROLE getPROBLEM_ROLE(int rep) { 
	   return (PTR_PCF_PROBLEM_ROLE)this.get_Renamed("PROBLEM_ROLE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PTR_PCF_PROBLEM_ROLE 
	 */ 
	public int PROBLEM_ROLEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROBLEM_ROLE").Length; 
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
	 * Returns  first repetition of PTR_PCF_PROBLEM_OBSERVATION (a Group object) - creates it if necessary
	 */
	public PTR_PCF_PROBLEM_OBSERVATION  getPROBLEM_OBSERVATION() { 
	   PTR_PCF_PROBLEM_OBSERVATION ret = null;
	   try {
	      ret = (PTR_PCF_PROBLEM_OBSERVATION)this.get_Renamed("PROBLEM_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PTR_PCF_PROBLEM_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PTR_PCF_PROBLEM_OBSERVATION getPROBLEM_OBSERVATION(int rep) { 
	   return (PTR_PCF_PROBLEM_OBSERVATION)this.get_Renamed("PROBLEM_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PTR_PCF_PROBLEM_OBSERVATION 
	 */ 
	public int PROBLEM_OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROBLEM_OBSERVATION").Length; 
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
	 * Returns  first repetition of PTR_PCF_GOAL (a Group object) - creates it if necessary
	 */
	public PTR_PCF_GOAL  getGOAL() { 
	   PTR_PCF_GOAL ret = null;
	   try {
	      ret = (PTR_PCF_GOAL)this.get_Renamed("GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PTR_PCF_GOAL
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PTR_PCF_GOAL getGOAL(int rep) { 
	   return (PTR_PCF_GOAL)this.get_Renamed("GOAL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PTR_PCF_GOAL 
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

	/**
	 * Returns  first repetition of PTR_PCF_ORDER (a Group object) - creates it if necessary
	 */
	public PTR_PCF_ORDER  getORDER() { 
	   PTR_PCF_ORDER ret = null;
	   try {
	      ret = (PTR_PCF_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PTR_PCF_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PTR_PCF_ORDER getORDER(int rep) { 
	   return (PTR_PCF_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PTR_PCF_ORDER 
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
