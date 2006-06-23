using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SRR_S01_SCHEDULE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SCH (Scheduling Activity Information) <b></b><br>
 * 1: TQ1 (Timing/Quantity) <b>optional repeating</b><br>
 * 2: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 3: SRR_S01_PATIENT (a Group object) <b></b><br>
 * 4: SRR_S01_RESOURCES (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class SRR_S01_SCHEDULE : AbstractGroup {

	/** 
	 * Creates a new SRR_S01_SCHEDULE Group.
	 */
	public SRR_S01_SCHEDULE(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("SCH", "2.5"), true, false);
	      this.add(factory.getSegmentClass("TQ1", "2.5"), false, true);
	      this.add(factory.getSegmentClass("NTE", "2.5"), false, true);
	      this.add(factory.getGroupClass("SRR_S01_PATIENT", "2.5"), true, false);
	      this.add(factory.getGroupClass("SRR_S01_RESOURCES", "2.5"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SRR_S01_SCHEDULE - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns SCH (Scheduling Activity Information) - creates it if necessary
	 */
	public SCH SCH { 
get{
	   SCH ret = null;
	   try {
	      ret = (SCH)this.get_Renamed("SCH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of TQ1 (Timing/Quantity) - creates it if necessary
	 */
	public TQ1  getTQ1() { 
	   TQ1 ret = null;
	   try {
	      ret = (TQ1)this.get_Renamed("TQ1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of TQ1
	 * (Timing/Quantity) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public TQ1 getTQ1(int rep) { 
	   return (TQ1)this.get_Renamed("TQ1", rep);
	}

	/** 
	 * Returns the number of existing repetitions of TQ1 
	 */ 
	public int TQ1Reps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("TQ1").Length; 
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
	 * Returns SRR_S01_PATIENT (a Group object) - creates it if necessary
	 */
	public SRR_S01_PATIENT PATIENT { 
get{
	   SRR_S01_PATIENT ret = null;
	   try {
	      ret = (SRR_S01_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of SRR_S01_RESOURCES (a Group object) - creates it if necessary
	 */
	public SRR_S01_RESOURCES  getRESOURCES() { 
	   SRR_S01_RESOURCES ret = null;
	   try {
	      ret = (SRR_S01_RESOURCES)this.get_Renamed("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SRR_S01_RESOURCES
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SRR_S01_RESOURCES getRESOURCES(int rep) { 
	   return (SRR_S01_RESOURCES)this.get_Renamed("RESOURCES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRR_S01_RESOURCES 
	 */ 
	public int RESOURCESReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("RESOURCES").Length; 
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
