using NHapi.Base.parser;
using NHapi.Base;
using ca.uhn.log;
using System;
using NHapi.Base.model.v23.segment;

using NHapi.Base.model;
/**
 * <p>Represents the BAR_P05_VISIT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PV1 (Patient visit) <b>optional </b><br>
 * 1: PV2 (Patient visit - additional information) <b>optional </b><br>
 * 2: DB1 (Disability Segment) <b>optional repeating</b><br>
 * 3: OBX (Observation segment) <b>optional repeating</b><br>
 * 4: AL1 (Patient allergy information) <b>optional repeating</b><br>
 * 5: DG1 (Diagnosis) <b>optional repeating</b><br>
 * 6: DRG (Diagnosis Related Group) <b>optional </b><br>
 * 7: BAR_P05_PROCEDURE (a Group object) <b>optional repeating</b><br>
 * 8: GT1 (Guarantor) <b>optional repeating</b><br>
 * 9: NK1 (Next of kin) <b>optional repeating</b><br>
 * 10: BAR_P05_INSURANCE (a Group object) <b>optional repeating</b><br>
 * 11: ACC (Accident) <b>optional </b><br>
 * 12: UB1 (UB82  data) <b>optional </b><br>
 * 13: UB2 (UB92 data) <b>optional </b><br>
 */
namespace NHapi.Base.model.v23.group
{
[Serializable]
public class BAR_P05_VISIT : AbstractGroup {

	/** 
	 * Creates a new BAR_P05_VISIT Group.
	 */
	public BAR_P05_VISIT(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("PV1", "2.3"), false, false);
	      this.add(factory.getSegmentClass("PV2", "2.3"), false, false);
	      this.add(factory.getSegmentClass("DB1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("OBX", "2.3"), false, true);
	      this.add(factory.getSegmentClass("AL1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("DG1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("DRG", "2.3"), false, false);
	      this.add(factory.getGroupClass("BAR_P05_PROCEDURE", "2.3"), false, true);
	      this.add(factory.getSegmentClass("GT1", "2.3"), false, true);
	      this.add(factory.getSegmentClass("NK1", "2.3"), false, true);
	      this.add(factory.getGroupClass("BAR_P05_INSURANCE", "2.3"), false, true);
	      this.add(factory.getSegmentClass("ACC", "2.3"), false, false);
	      this.add(factory.getSegmentClass("UB1", "2.3"), false, false);
	      this.add(factory.getSegmentClass("UB2", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P05_VISIT - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns PV1 (Patient visit) - creates it if necessary
	 */
	public PV1 PV1 { 
get{
	   PV1 ret = null;
	   try {
	      ret = (PV1)this.get_Renamed("PV1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PV2 (Patient visit - additional information) - creates it if necessary
	 */
	public PV2 PV2 { 
get{
	   PV2 ret = null;
	   try {
	      ret = (PV2)this.get_Renamed("PV2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of DB1 (Disability Segment) - creates it if necessary
	 */
	public DB1  getDB1() { 
	   DB1 ret = null;
	   try {
	      ret = (DB1)this.get_Renamed("DB1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DB1
	 * (Disability Segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DB1 getDB1(int rep) { 
	   return (DB1)this.get_Renamed("DB1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DB1 
	 */ 
	public int DB1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("DB1").Length; 
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
	 * Returns  first repetition of OBX (Observation segment) - creates it if necessary
	 */
	public OBX  getOBX() { 
	   OBX ret = null;
	   try {
	      ret = (OBX)this.get_Renamed("OBX");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OBX
	 * (Observation segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OBX getOBX(int rep) { 
	   return (OBX)this.get_Renamed("OBX", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OBX 
	 */ 
	public int OBXReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("OBX").Length; 
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
	 * Returns  first repetition of AL1 (Patient allergy information) - creates it if necessary
	 */
	public AL1  getAL1() { 
	   AL1 ret = null;
	   try {
	      ret = (AL1)this.get_Renamed("AL1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of AL1
	 * (Patient allergy information) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public AL1 getAL1(int rep) { 
	   return (AL1)this.get_Renamed("AL1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of AL1 
	 */ 
	public int AL1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("AL1").Length; 
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
	 * Returns DRG (Diagnosis Related Group) - creates it if necessary
	 */
	public DRG DRG { 
get{
	   DRG ret = null;
	   try {
	      ret = (DRG)this.get_Renamed("DRG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of BAR_P05_PROCEDURE (a Group object) - creates it if necessary
	 */
	public BAR_P05_PROCEDURE  getPROCEDURE() { 
	   BAR_P05_PROCEDURE ret = null;
	   try {
	      ret = (BAR_P05_PROCEDURE)this.get_Renamed("PROCEDURE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of BAR_P05_PROCEDURE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public BAR_P05_PROCEDURE getPROCEDURE(int rep) { 
	   return (BAR_P05_PROCEDURE)this.get_Renamed("PROCEDURE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BAR_P05_PROCEDURE 
	 */ 
	public int PROCEDUREReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PROCEDURE").Length; 
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
	 * Returns  first repetition of GT1 (Guarantor) - creates it if necessary
	 */
	public GT1  getGT1() { 
	   GT1 ret = null;
	   try {
	      ret = (GT1)this.get_Renamed("GT1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of GT1
	 * (Guarantor) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public GT1 getGT1(int rep) { 
	   return (GT1)this.get_Renamed("GT1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of GT1 
	 */ 
	public int GT1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("GT1").Length; 
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
	 * Returns  first repetition of NK1 (Next of kin) - creates it if necessary
	 */
	public NK1  getNK1() { 
	   NK1 ret = null;
	   try {
	      ret = (NK1)this.get_Renamed("NK1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of NK1
	 * (Next of kin) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public NK1 getNK1(int rep) { 
	   return (NK1)this.get_Renamed("NK1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NK1 
	 */ 
	public int NK1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("NK1").Length; 
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
	 * Returns  first repetition of BAR_P05_INSURANCE (a Group object) - creates it if necessary
	 */
	public BAR_P05_INSURANCE  getINSURANCE() { 
	   BAR_P05_INSURANCE ret = null;
	   try {
	      ret = (BAR_P05_INSURANCE)this.get_Renamed("INSURANCE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of BAR_P05_INSURANCE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public BAR_P05_INSURANCE getINSURANCE(int rep) { 
	   return (BAR_P05_INSURANCE)this.get_Renamed("INSURANCE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BAR_P05_INSURANCE 
	 */ 
	public int INSURANCEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("INSURANCE").Length; 
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
	 * Returns ACC (Accident) - creates it if necessary
	 */
	public ACC ACC { 
get{
	   ACC ret = null;
	   try {
	      ret = (ACC)this.get_Renamed("ACC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns UB1 (UB82  data) - creates it if necessary
	 */
	public UB1 UB1 { 
get{
	   UB1 ret = null;
	   try {
	      ret = (UB1)this.get_Renamed("UB1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns UB2 (UB92 data) - creates it if necessary
	 */
	public UB2 UB2 { 
get{
	   UB2 ret = null;
	   try {
	      ret = (UB2)this.get_Renamed("UB2");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
