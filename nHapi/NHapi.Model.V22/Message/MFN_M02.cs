using System;
using NHapi.Base.Log;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

/**
 * <p>Represents a MFN_M02 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: MFI (MASTER FILE IDENTIFICATION) <b></b><br>
 * 2: MFN_M02_MF_STAFF (a Group object) <b>repeating</b><br>
 */
namespace NHapi.Model.V22.Message

{
[Serializable]
public class MFN_M02 : AbstractMessage  {

	/** 
	 * Creates a new MFN_M02 Group with custom IModelClassFactory.
	 */
	public MFN_M02(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new MFN_M02 Group with DefaultModelClassFactory. 
	 */ 
	public MFN_M02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MFI), true, false);
	      this.add(typeof(MFN_M02_MF_STAFF), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M02 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MESSAGE HEADER) - creates it if necessary
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
	 * Returns MFI (MASTER FILE IDENTIFICATION) - creates it if necessary
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
	 * Returns  first repetition of MFN_M02_MF_STAFF (a Group object) - creates it if necessary
	 */
	public MFN_M02_MF_STAFF getMF_STAFF() {
	   MFN_M02_MF_STAFF ret = null;
	   try {
	      ret = (MFN_M02_MF_STAFF)this.get_Renamed("MF_STAFF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of MFN_M02_MF_STAFF
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public MFN_M02_MF_STAFF getMF_STAFF(int rep) { 
	   return (MFN_M02_MF_STAFF)this.get_Renamed("MF_STAFF", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFN_M02_MF_STAFF 
	 */ 
	public int MF_STAFFReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("MF_STAFF").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

}
}
