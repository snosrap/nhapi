using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a SRM_S02 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: ARQ (Appointment Request) <b></b><br>
 * 2: APR (Appointment Preferences) <b>optional </b><br>
 * 3: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 4: SRM_S02_PATIENT (a Group object) <b>optional repeating</b><br>
 * 5: SRM_S02_RESOURCES (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
[Serializable]
public class SRM_S02 : AbstractMessage  {

	/** 
	 * Creates a new SRM_S02 Group with custom ModelClassFactory.
	 */
	public SRM_S02(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new SRM_S02 Group with DefaultModelClassFactory. 
	 */ 
	public SRM_S02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3"), true, false);
	      this.add(factory.getSegmentClass("ARQ", "2.3"), true, false);
	      this.add(factory.getSegmentClass("APR", "2.3"), false, false);
	      this.add(factory.getSegmentClass("NTE", "2.3"), false, true);
	      this.add(factory.getGroupClass("SRM_S02_PATIENT", "2.3"), false, true);
	      this.add(factory.getGroupClass("SRM_S02_RESOURCES", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SRM_S02 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message header segment) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.get_Renamed("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ARQ (Appointment Request) - creates it if necessary
	 */
	public ARQ ARQ { 
get{
	   ARQ ret = null;
	   try {
	      ret = (ARQ)this.get_Renamed("ARQ");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns APR (Appointment Preferences) - creates it if necessary
	 */
	public APR APR { 
get{
	   APR ret = null;
	   try {
	      ret = (APR)this.get_Renamed("APR");
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
	 * Returns  first repetition of SRM_S02_PATIENT (a Group object) - creates it if necessary
	 */
	public SRM_S02_PATIENT  getPATIENT() { 
	   SRM_S02_PATIENT ret = null;
	   try {
	      ret = (SRM_S02_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SRM_S02_PATIENT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SRM_S02_PATIENT getPATIENT(int rep) { 
	   return (SRM_S02_PATIENT)this.get_Renamed("PATIENT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRM_S02_PATIENT 
	 */ 
	public int PATIENTReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PATIENT").Length; 
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
	 * Returns  first repetition of SRM_S02_RESOURCES (a Group object) - creates it if necessary
	 */
	public SRM_S02_RESOURCES  getRESOURCES() { 
	   SRM_S02_RESOURCES ret = null;
	   try {
	      ret = (SRM_S02_RESOURCES)this.get_Renamed("RESOURCES");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SRM_S02_RESOURCES
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SRM_S02_RESOURCES getRESOURCES(int rep) { 
	   return (SRM_S02_RESOURCES)this.get_Renamed("RESOURCES", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SRM_S02_RESOURCES 
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
