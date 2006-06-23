using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v25.group;
using ca.uhn.hl7v2.model.v25.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a UDM_Q05 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: SFT (Software Segment) <b>optional repeating</b><br>
 * 2: URD (Results/update Definition) <b></b><br>
 * 3: URS (Unsolicited Selection) <b>optional </b><br>
 * 4: DSP (Display Data) <b>repeating</b><br>
 * 5: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v25.message

{
[Serializable]
public class UDM_Q05 : AbstractMessage  {

	/** 
	 * Creates a new UDM_Q05 Group with custom ModelClassFactory.
	 */
	public UDM_Q05(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new UDM_Q05 Group with DefaultModelClassFactory. 
	 */ 
	public UDM_Q05() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.5"), true, false);
	      this.add(factory.getSegmentClass("SFT", "2.5"), false, true);
	      this.add(factory.getSegmentClass("URD", "2.5"), true, false);
	      this.add(factory.getSegmentClass("URS", "2.5"), false, false);
	      this.add(factory.getSegmentClass("DSP", "2.5"), true, true);
	      this.add(factory.getSegmentClass("DSC", "2.5"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating UDM_Q05 - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of SFT (Software Segment) - creates it if necessary
	 */
	public SFT  getSFT() { 
	   SFT ret = null;
	   try {
	      ret = (SFT)this.get_Renamed("SFT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of SFT
	 * (Software Segment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public SFT getSFT(int rep) { 
	   return (SFT)this.get_Renamed("SFT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of SFT 
	 */ 
	public int SFTReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("SFT").Length; 
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
	 * Returns URD (Results/update Definition) - creates it if necessary
	 */
	public URD URD { 
get{
	   URD ret = null;
	   try {
	      ret = (URD)this.get_Renamed("URD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns URS (Unsolicited Selection) - creates it if necessary
	 */
	public URS URS { 
get{
	   URS ret = null;
	   try {
	      ret = (URS)this.get_Renamed("URS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of DSP (Display Data) - creates it if necessary
	 */
	public DSP  getDSP() { 
	   DSP ret = null;
	   try {
	      ret = (DSP)this.get_Renamed("DSP");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of DSP
	 * (Display Data) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public DSP getDSP(int rep) { 
	   return (DSP)this.get_Renamed("DSP", rep);
	}

	/** 
	 * Returns the number of existing repetitions of DSP 
	 */ 
	public int DSPReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("DSP").Length; 
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
	 * Returns DSC (Continuation Pointer) - creates it if necessary
	 */
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.get_Renamed("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
