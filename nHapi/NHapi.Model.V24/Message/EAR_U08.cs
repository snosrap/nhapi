using System;
using ca.uhn.log;
using NHapi.Base.model.v24.group;
using NHapi.Base.model.v24.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a EAR_U08 message structure (see chapter 13). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: EQU (Equipment Detail) <b></b><br>
 * 2: EAR_U08_COMMAND_RESPONSE (a Group object) <b>repeating</b><br>
 * 3: ROL (Role) <b>optional </b><br>
 */
namespace NHapi.Base.model.v24.message

{
[Serializable]
public class EAR_U08 : AbstractMessage  {

	/** 
	 * Creates a new EAR_U08 Group with custom ModelClassFactory.
	 */
	public EAR_U08(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new EAR_U08 Group with DefaultModelClassFactory. 
	 */ 
	public EAR_U08() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("EQU", "2.4"), true, false);
	      this.add(factory.getGroupClass("EAR_U08_COMMAND_RESPONSE", "2.4"), true, true);
	      this.add(factory.getSegmentClass("ROL", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating EAR_U08 - this is probably a bug in the source code generator.", e);
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
	 * Returns  first repetition of EAR_U08_COMMAND_RESPONSE (a Group object) - creates it if necessary
	 */
	public EAR_U08_COMMAND_RESPONSE  getCOMMAND_RESPONSE() { 
	   EAR_U08_COMMAND_RESPONSE ret = null;
	   try {
	      ret = (EAR_U08_COMMAND_RESPONSE)this.get_Renamed("COMMAND_RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of EAR_U08_COMMAND_RESPONSE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public EAR_U08_COMMAND_RESPONSE getCOMMAND_RESPONSE(int rep) { 
	   return (EAR_U08_COMMAND_RESPONSE)this.get_Renamed("COMMAND_RESPONSE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of EAR_U08_COMMAND_RESPONSE 
	 */ 
	public int COMMAND_RESPONSEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("COMMAND_RESPONSE").Length; 
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
