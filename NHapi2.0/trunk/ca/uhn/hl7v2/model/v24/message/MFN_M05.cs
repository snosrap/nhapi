using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a MFN_M05 message structure (see chapter 8). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MFI (Master File Identification) <b></b><br>
 * 2: MFN_M05_MF_LOCATION (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class MFN_M05 : AbstractMessage  {

	/** 
	 * Creates a new MFN_M05 Group with custom ModelClassFactory.
	 */
	public MFN_M05(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new MFN_M05 Group with DefaultModelClassFactory. 
	 */ 
	public MFN_M05() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("MFI", "2.4"), true, false);
	      this.add(factory.getGroupClass("MFN_M05_MF_LOCATION", "2.4"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M05 - this is probably a bug in the source code generator.", e);
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
	 * Returns MFI (Master File Identification) - creates it if necessary
	 */
	public MFI MFI { 
get{
	   MFI ret = null;
	   try {
	      ret = (MFI)this.get_Renamed("MFI");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of MFN_M05_MF_LOCATION (a Group object) - creates it if necessary
	 */
	public MFN_M05_MF_LOCATION  getMF_LOCATION() { 
	   MFN_M05_MF_LOCATION ret = null;
	   try {
	      ret = (MFN_M05_MF_LOCATION)this.get_Renamed("MF_LOCATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of MFN_M05_MF_LOCATION
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public MFN_M05_MF_LOCATION getMF_LOCATION(int rep) { 
	   return (MFN_M05_MF_LOCATION)this.get_Renamed("MF_LOCATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFN_M05_MF_LOCATION 
	 */ 
	public int MF_LOCATIONReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("MF_LOCATION").Length; 
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
