using System;
using ca.uhn.log;
using NHapi.Base.model.v24.group;
using NHapi.Base.model.v24.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a MFK_M01 message structure (see chapter 8). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MSA (Message Acknowledgment) <b></b><br>
 * 2: ERR (Error) <b>optional </b><br>
 * 3: MFI (Master File Identification) <b></b><br>
 * 4: MFA (Master File Acknowledgment) <b>optional repeating</b><br>
 */
namespace NHapi.Base.model.v24.message

{
[Serializable]
public class MFK_M01 : AbstractMessage  {

	/** 
	 * Creates a new MFK_M01 Group with custom ModelClassFactory.
	 */
	public MFK_M01(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new MFK_M01 Group with DefaultModelClassFactory. 
	 */ 
	public MFK_M01() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("MSA", "2.4"), true, false);
	      this.add(factory.getSegmentClass("ERR", "2.4"), false, false);
	      this.add(factory.getSegmentClass("MFI", "2.4"), true, false);
	      this.add(factory.getSegmentClass("MFA", "2.4"), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFK_M01 - this is probably a bug in the source code generator.", e);
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
	 * Returns MSA (Message Acknowledgment) - creates it if necessary
	 */
	public MSA MSA { 
get{
	   MSA ret = null;
	   try {
	      ret = (MSA)this.get_Renamed("MSA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ERR (Error) - creates it if necessary
	 */
	public ERR ERR { 
get{
	   ERR ret = null;
	   try {
	      ret = (ERR)this.get_Renamed("ERR");
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
	 * Returns  first repetition of MFA (Master File Acknowledgment) - creates it if necessary
	 */
	public MFA  getMFA() { 
	   MFA ret = null;
	   try {
	      ret = (MFA)this.get_Renamed("MFA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of MFA
	 * (Master File Acknowledgment) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public MFA getMFA(int rep) { 
	   return (MFA)this.get_Renamed("MFA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFA 
	 */ 
	public int MFAReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("MFA").Length; 
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
