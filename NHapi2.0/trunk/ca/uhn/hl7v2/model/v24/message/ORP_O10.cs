using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a ORP_O10 message structure (see chapter 4). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MSA (Message Acknowledgment) <b></b><br>
 * 2: ERR (Error) <b>optional </b><br>
 * 3: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 4: ORP_O10_RESPONSE (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class ORP_O10 : AbstractMessage  {

	/** 
	 * Creates a new ORP_O10 Group with custom ModelClassFactory.
	 */
	public ORP_O10(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new ORP_O10 Group with DefaultModelClassFactory. 
	 */ 
	public ORP_O10() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("MSA", "2.4"), true, false);
	      this.add(factory.getSegmentClass("ERR", "2.4"), false, false);
	      this.add(factory.getSegmentClass("NTE", "2.4"), false, true);
	      this.add(factory.getGroupClass("ORP_O10_RESPONSE", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORP_O10 - this is probably a bug in the source code generator.", e);
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
	 * Returns ORP_O10_RESPONSE (a Group object) - creates it if necessary
	 */
	public ORP_O10_RESPONSE RESPONSE { 
get{
	   ORP_O10_RESPONSE ret = null;
	   try {
	      ret = (ORP_O10_RESPONSE)this.get_Renamed("RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
