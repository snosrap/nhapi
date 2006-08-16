using System;
using ca.uhn.log;
using NHapi.Base.model.v24.group;
using NHapi.Base.model.v24.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a EAC_U07 message structure (see chapter 13). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: EQU (Equipment Detail) <b></b><br>
 * 2: ECD (Equipment Command) <b>repeating</b><br>
 * 3: SAC (Specimen and container detail) <b>optional </b><br>
 * 4: CNS (Clear Notification) <b>optional </b><br>
 * 5: ROL (Role) <b>optional </b><br>
 */
namespace NHapi.Base.model.v24.message

{
[Serializable]
public class EAC_U07 : AbstractMessage  {

	/** 
	 * Creates a new EAC_U07 Group with custom ModelClassFactory.
	 */
	public EAC_U07(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new EAC_U07 Group with DefaultModelClassFactory. 
	 */ 
	public EAC_U07() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("EQU", "2.4"), true, false);
	      this.add(factory.getSegmentClass("ECD", "2.4"), true, true);
	      this.add(factory.getSegmentClass("SAC", "2.4"), false, false);
	      this.add(factory.getSegmentClass("CNS", "2.4"), false, false);
	      this.add(factory.getSegmentClass("ROL", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating EAC_U07 - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of ECD (Equipment Command) - creates it if necessary
	 */
	public ECD  getECD() { 
	   ECD ret = null;
	   try {
	      ret = (ECD)this.get_Renamed("ECD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ECD
	 * (Equipment Command) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ECD getECD(int rep) { 
	   return (ECD)this.get_Renamed("ECD", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ECD 
	 */ 
	public int ECDReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ECD").Length; 
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
	 * Returns SAC (Specimen and container detail) - creates it if necessary
	 */
	public SAC SAC { 
get{
	   SAC ret = null;
	   try {
	      ret = (SAC)this.get_Renamed("SAC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns CNS (Clear Notification) - creates it if necessary
	 */
	public CNS CNS { 
get{
	   CNS ret = null;
	   try {
	      ret = (CNS)this.get_Renamed("CNS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
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
