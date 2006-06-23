using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a BAR_P05 message structure (see chapter 6). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: EVN (Event Type) <b></b><br>
 * 2: PID (Patient identification) <b></b><br>
 * 3: PD1 (patient additional demographic) <b>optional </b><br>
 * 4: ROL (Role) <b>optional repeating</b><br>
 * 5: BAR_P05_VISIT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class BAR_P05 : AbstractMessage  {

	/** 
	 * Creates a new BAR_P05 Group with custom ModelClassFactory.
	 */
	public BAR_P05(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new BAR_P05 Group with DefaultModelClassFactory. 
	 */ 
	public BAR_P05() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("EVN", "2.4"), true, false);
	      this.add(factory.getSegmentClass("PID", "2.4"), true, false);
	      this.add(factory.getSegmentClass("PD1", "2.4"), false, false);
	      this.add(factory.getSegmentClass("ROL", "2.4"), false, true);
	      this.add(factory.getGroupClass("BAR_P05_VISIT", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P05 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message Header) - creates it if necessary
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
	 * Returns EVN (Event Type) - creates it if necessary
	 */
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.get_Renamed("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PID (Patient identification) - creates it if necessary
	 */
	public PID PID { 
get{
	   PID ret = null;
	   try {
	      ret = (PID)this.get_Renamed("PID");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns PD1 (patient additional demographic) - creates it if necessary
	 */
	public PD1 PD1 { 
get{
	   PD1 ret = null;
	   try {
	      ret = (PD1)this.get_Renamed("PD1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ROL (Role) - creates it if necessary
	 */
	public ROL  getROL() { 
	   ROL ret = null;
	   try {
	      ret = (ROL)this.get_Renamed("ROL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ROL
	 * (Role) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ROL getROL(int rep) { 
	   return (ROL)this.get_Renamed("ROL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ROL 
	 */ 
	public int ROLReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ROL").Length; 
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
	 * Returns  first repetition of BAR_P05_VISIT (a Group object) - creates it if necessary
	 */
	public BAR_P05_VISIT  getVISIT() { 
	   BAR_P05_VISIT ret = null;
	   try {
	      ret = (BAR_P05_VISIT)this.get_Renamed("VISIT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of BAR_P05_VISIT
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public BAR_P05_VISIT getVISIT(int rep) { 
	   return (BAR_P05_VISIT)this.get_Renamed("VISIT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of BAR_P05_VISIT 
	 */ 
	public int VISITReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("VISIT").Length; 
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
