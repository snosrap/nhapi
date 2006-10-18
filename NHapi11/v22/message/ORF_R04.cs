using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v22.group;
using ca.uhn.hl7v2.model.v22.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a ORF_R04 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: MSA (MESSAGE ACKNOWLEDGMENT) <b></b><br>
 * 2: ORF_R04_QUERY_RESPONSE (a Group object) <b>repeating</b><br>
 * 3: ORF_R04_ORDER (a Group object) <b>repeating</b><br>
 * 4: DSC (CONTINUATION POINTER) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v22.message

{
[Serializable]
public class ORF_R04 : AbstractMessage  {

	/** 
	 * Creates a new ORF_R04 Group with custom ModelClassFactory.
	 */
	public ORF_R04(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new ORF_R04 Group with DefaultModelClassFactory. 
	 */ 
	public ORF_R04() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	      this.add(typeof(ORF_R04_QUERY_RESPONSE), true, true);
	      this.add(typeof(ORF_R04_ORDER), true, true);
	      this.add(typeof(DSC), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORF_R04 - this is probably a bug in the source code generator.", e);
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
	 * Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary
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
	 * Returns  first repetition of ORF_R04_QUERY_RESPONSE (a Group object) - creates it if necessary
	 */
	public ORF_R04_QUERY_RESPONSE getQUERY_RESPONSE() {
	   ORF_R04_QUERY_RESPONSE ret = null;
	   try {
	      ret = (ORF_R04_QUERY_RESPONSE)this.get_Renamed("QUERY_RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORF_R04_QUERY_RESPONSE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORF_R04_QUERY_RESPONSE getQUERY_RESPONSE(int rep) { 
	   return (ORF_R04_QUERY_RESPONSE)this.get_Renamed("QUERY_RESPONSE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORF_R04_QUERY_RESPONSE 
	 */ 
	public int QUERY_RESPONSEReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("QUERY_RESPONSE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns  first repetition of ORF_R04_ORDER (a Group object) - creates it if necessary
	 */
	public ORF_R04_ORDER getORDER() {
	   ORF_R04_ORDER ret = null;
	   try {
	      ret = (ORF_R04_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ORF_R04_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ORF_R04_ORDER getORDER(int rep) { 
	   return (ORF_R04_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ORF_R04_ORDER 
	 */ 
	public int ORDERReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.getHapiLog(GetType()).error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/**
	 * Returns DSC (CONTINUATION POINTER) - creates it if necessary
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
