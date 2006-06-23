using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMP_O09_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RXO (Pharmacy/Treatment Order) <b></b><br>
 * 2: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 3: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
 * 4: OMP_O09_COMPONENT (a Group object) <b>optional </b><br>
 * 5: OMP_O09_OBSERVATION (a Group object) <b>optional repeating</b><br>
 * 6: FT1 (Financial Transaction) <b>optional repeating</b><br>
 * 7: BLG (Billing) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
[Serializable]
public class OMP_O09_ORDER : AbstractGroup {

	/** 
	 * Creates a new OMP_O09_ORDER Group.
	 */
	public OMP_O09_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("ORC", "2.4"), true, false);
	      this.add(factory.getSegmentClass("RXO", "2.4"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.4"), false, true);
	      this.add(factory.getSegmentClass("RXR", "2.4"), true, true);
	      this.add(factory.getGroupClass("OMP_O09_COMPONENT", "2.4"), false, false);
	      this.add(factory.getGroupClass("OMP_O09_OBSERVATION", "2.4"), false, true);
	      this.add(factory.getSegmentClass("FT1", "2.4"), false, true);
	      this.add(factory.getSegmentClass("BLG", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMP_O09_ORDER - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns ORC (Common Order) - creates it if necessary
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
	 * Returns RXO (Pharmacy/Treatment Order) - creates it if necessary
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
	 * Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
	 */
	public RXR  getRXR() { 
	   RXR ret = null;
	   try {
	      ret = (RXR)this.get_Renamed("RXR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RXR
	 * (Pharmacy/Treatment Route) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RXR getRXR(int rep) { 
	   return (RXR)this.get_Renamed("RXR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RXR 
	 */ 
	public int RXRReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RXR").Length; 
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
	 * Returns OMP_O09_COMPONENT (a Group object) - creates it if necessary
	 */
	public OMP_O09_COMPONENT COMPONENT { 
get{
	   OMP_O09_COMPONENT ret = null;
	   try {
	      ret = (OMP_O09_COMPONENT)this.get_Renamed("COMPONENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OMP_O09_OBSERVATION (a Group object) - creates it if necessary
	 */
	public OMP_O09_OBSERVATION  getOBSERVATION() { 
	   OMP_O09_OBSERVATION ret = null;
	   try {
	      ret = (OMP_O09_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OMP_O09_OBSERVATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OMP_O09_OBSERVATION getOBSERVATION(int rep) { 
	   return (OMP_O09_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OMP_O09_OBSERVATION 
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
	 * Returns  first repetition of FT1 (Financial Transaction) - creates it if necessary
	 */
	public FT1  getFT1() { 
	   FT1 ret = null;
	   try {
	      ret = (FT1)this.get_Renamed("FT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of FT1
	 * (Financial Transaction) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public FT1 getFT1(int rep) { 
	   return (FT1)this.get_Renamed("FT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of FT1 
	 */ 
	public int FT1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("FT1").Length; 
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
	 * Returns BLG (Billing) - creates it if necessary
	 */
	public BLG BLG { 
get{
	   BLG ret = null;
	   try {
	      ret = (BLG)this.get_Renamed("BLG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
