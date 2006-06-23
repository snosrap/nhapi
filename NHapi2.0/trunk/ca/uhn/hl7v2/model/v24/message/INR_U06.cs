using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a INR_U06 message structure (see chapter 13). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: EQU (Equipment Detail) <b></b><br>
 * 2: INV (Inventory Detail) <b>repeating</b><br>
 * 3: ROL (Role) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class INR_U06 : AbstractMessage  {

	/** 
	 * Creates a new INR_U06 Group with custom ModelClassFactory.
	 */
	public INR_U06(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new INR_U06 Group with DefaultModelClassFactory. 
	 */ 
	public INR_U06() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("EQU", "2.4"), true, false);
	      this.add(factory.getSegmentClass("INV", "2.4"), true, true);
	      this.add(factory.getSegmentClass("ROL", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating INR_U06 - this is probably a bug in the source code generator.", e);
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
	 * Returns EQU (Equipment Detail) - creates it if necessary
	 */
	public EQU EQU { 
get{
	   EQU ret = null;
	   try {
	      ret = (EQU)this.get_Renamed("EQU");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of INV (Inventory Detail) - creates it if necessary
	 */
	public INV  getINV() { 
	   INV ret = null;
	   try {
	      ret = (INV)this.get_Renamed("INV");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of INV
	 * (Inventory Detail) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public INV getINV(int rep) { 
	   return (INV)this.get_Renamed("INV", rep);
	}

	/** 
	 * Returns the number of existing repetitions of INV 
	 */ 
	public int INVReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("INV").Length; 
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
	 * Returns ROL (Role) - creates it if necessary
	 */
	public ROL ROL { 
get{
	   ROL ret = null;
	   try {
	      ret = (ROL)this.get_Renamed("ROL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
