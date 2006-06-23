using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORM_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (Observation Request) <b></b><br>
 * 1: RQD (Requisition Detail) <b></b><br>
 * 2: RQ1 (Requisition Detail-1) <b></b><br>
 * 3: RXO (Pharmacy/Treatment Order) <b></b><br>
 * 4: ODS (Dietary Orders, Supplements, and Preferences) <b></b><br>
 * 5: ODT (Diet Tray Instructions) <b></b><br>
 * 6: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 7: CTD (Contact Data) <b>optional </b><br>
 * 8: DG1 (Diagnosis) <b>optional repeating</b><br>
 * 9: ORM_O01_OBSERVATION (a Group object) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class ORM_O01_ORDER_DETAIL : AbstractGroup {

	/** 
	 * Creates a new ORM_O01_ORDER_DETAIL Group.
	 */
	public ORM_O01_ORDER_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("OBR", "2.5"), true, false);
	      this.add(factory.getSegmentClass("RQD", "2.5"), true, false);
	      this.add(factory.getSegmentClass("RQ1", "2.5"), true, false);
	      this.add(factory.getSegmentClass("RXO", "2.5"), true, false);
	      this.add(factory.getSegmentClass("ODS", "2.5"), true, false);
	      this.add(factory.getSegmentClass("ODT", "2.5"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.5"), false, true);
	      this.add(factory.getSegmentClass("CTD", "2.5"), false, false);
	      this.add(factory.getSegmentClass("DG1", "2.5"), false, true);
	      this.add(factory.getGroupClass("ORM_O01_OBSERVATION", "2.5"), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBR (Observation Request) - creates it if necessary
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
	 * Returns RQD (Requisition Detail) - creates it if necessary
	 */
	public RQD RQD { 
get{
	   RQD ret = null;
	   try {
	      ret = (RQD)this.get_Renamed("RQD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RQ1 (Requisition Detail-1) - creates it if necessary
	 */
	public RQ1 RQ1 { 
get{
	   RQ1 ret = null;
	   try {
	      ret = (RQ1)this.get_Renamed("RQ1");
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
	 * Returns ODS (Dietary Orders, Supplements, and Preferences) - creates it if necessary
	 */
	public ODS ODS { 
get{
	   ODS ret = null;
	   try {
	      ret = (ODS)this.get_Renamed("ODS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ODT (Diet Tray Instructions) - creates it if necessary
	 */
	public ODT ODT { 
get{
	   ODT ret = null;
	   try {
	      ret = (ODT)this.get_Renamed("ODT");
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
	 * Returns CTD (Contact Data) - creates it if necessary
	 */
	public CTD CTD { 
get{
	   CTD ret = null;
	   try {
	      ret = (CTD)this.get_Renamed("CTD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of DG1 (Diagnosis) - creates it if necessary
	 */
	public DG1  getDG1() { 
	   DG1 ret = null;
	   try {
	      ret = (DG1)this.get_Renamed("DG1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DG1
	 * (Diagnosis) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DG1 getDG1(int rep) { 
	   return (DG1)this.get_Renamed("DG1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DG1 
	 */ 
	public int DG1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("DG1").Length; 
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
	 * Returns ORM_O01_OBSERVATION (a Group object) - creates it if necessary
	 */
	public ORM_O01_OBSERVATION OBSERVATION { 
get{
	   ORM_O01_OBSERVATION ret = null;
	   try {
	      ret = (ORM_O01_OBSERVATION)this.get_Renamed("OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
