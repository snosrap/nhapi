using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v231.segment;

using NHapi.Base.model;
/**
 * <p>Represents the PPR_PC1_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (OBR - observation request segment) <b></b><br>
 * 1: RXO (RXO - pharmacy/treatment order segment) <b></b><br>
 * 2: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
 * 3: VAR (Variance) <b>optional repeating</b><br>
 * 4: PPR_PC1_ORDER_OBSERVATION (a Group object) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v231.group
{
[Serializable]
public class PPR_PC1_ORDER_DETAIL : AbstractGroup {

	/** 
	 * Creates a new PPR_PC1_ORDER_DETAIL Group.
	 */
	public PPR_PC1_ORDER_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OBR", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("RXO", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.3.1"), false, true);
	      this.add(factory.getSegmentClass("VAR", "2.3.1"), false, true);
	      this.add(factory.getGroupClass("PPR_PC1_ORDER_OBSERVATION", "2.3.1"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPR_PC1_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBR (OBR - observation request segment) - creates it if necessary
	 */
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.get_Renamed("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RXO (RXO - pharmacy/treatment order segment) - creates it if necessary
	 */
	public RXO RXO { 
get{
	   RXO ret = null;
	   try {
	      ret = (RXO)this.get_Renamed("RXO");
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
	 * Returns  first repetition of PPR_PC1_ORDER_OBSERVATION (a Group object) - creates it if necessary
	 */
	public PPR_PC1_ORDER_OBSERVATION  getORDER_OBSERVATION() { 
	   PPR_PC1_ORDER_OBSERVATION ret = null;
	   try {
	      ret = (PPR_PC1_ORDER_OBSERVATION)this.get_Renamed("ORDER_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PPR_PC1_ORDER_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PPR_PC1_ORDER_OBSERVATION getORDER_OBSERVATION(int rep) { 
	   return (PPR_PC1_ORDER_OBSERVATION)this.get_Renamed("ORDER_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PPR_PC1_ORDER_OBSERVATION 
	 */ 
	public int ORDER_OBSERVATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER_OBSERVATION").Length; 
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
