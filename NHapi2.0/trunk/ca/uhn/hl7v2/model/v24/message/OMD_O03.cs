using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a OMD_O03 message structure (see chapter 4). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 2: OMD_O03_PATIENT (a Group object) <b>optional </b><br>
 * 3: OMD_O03_ORDER_DIET (a Group object) <b>repeating</b><br>
 * 4: OMD_O03_ORDER_TRAY (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class OMD_O03 : AbstractMessage  {

	/** 
	 * Creates a new OMD_O03 Group with custom ModelClassFactory.
	 */
	public OMD_O03(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new OMD_O03 Group with DefaultModelClassFactory. 
	 */ 
	public OMD_O03() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("NTE", "2.4"), false, true);
	      this.add(factory.getGroupClass("OMD_O03_PATIENT", "2.4"), false, false);
	      this.add(factory.getGroupClass("OMD_O03_ORDER_DIET", "2.4"), true, true);
	      this.add(factory.getGroupClass("OMD_O03_ORDER_TRAY", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMD_O03 - this is probably a bug in the source code generator.", e);
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
	 * Returns OMD_O03_PATIENT (a Group object) - creates it if necessary
	 */
	public OMD_O03_PATIENT PATIENT { 
get{
	   OMD_O03_PATIENT ret = null;
	   try {
	      ret = (OMD_O03_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of OMD_O03_ORDER_DIET (a Group object) - creates it if necessary
	 */
	public OMD_O03_ORDER_DIET  getORDER_DIET() { 
	   OMD_O03_ORDER_DIET ret = null;
	   try {
	      ret = (OMD_O03_ORDER_DIET)this.get_Renamed("ORDER_DIET");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OMD_O03_ORDER_DIET
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OMD_O03_ORDER_DIET getORDER_DIET(int rep) { 
	   return (OMD_O03_ORDER_DIET)this.get_Renamed("ORDER_DIET", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OMD_O03_ORDER_DIET 
	 */ 
	public int ORDER_DIETReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER_DIET").Length; 
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
	 * Returns  first repetition of OMD_O03_ORDER_TRAY (a Group object) - creates it if necessary
	 */
	public OMD_O03_ORDER_TRAY  getORDER_TRAY() { 
	   OMD_O03_ORDER_TRAY ret = null;
	   try {
	      ret = (OMD_O03_ORDER_TRAY)this.get_Renamed("ORDER_TRAY");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of OMD_O03_ORDER_TRAY
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public OMD_O03_ORDER_TRAY getORDER_TRAY(int rep) { 
	   return (OMD_O03_ORDER_TRAY)this.get_Renamed("ORDER_TRAY", rep);
	}

	/** 
	 * Returns the number of existing repetitions of OMD_O03_ORDER_TRAY 
	 */ 
	public int ORDER_TRAYReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER_TRAY").Length; 
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
