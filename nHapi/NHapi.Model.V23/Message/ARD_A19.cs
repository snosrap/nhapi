using System;
using ca.uhn.log;
using NHapi.Base.model.v23.group;
using NHapi.Base.model.v23.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a ARD_A19 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: MSA (Message acknowledgement segment) <b></b><br>
 * 2: ERR (Error segment) <b>optional </b><br>
 * 3: QRD (Query definition segment) <b></b><br>
 * 4: QRF (Query filter segment) <b>optional </b><br>
 * 5: ARD_A19_QUERY_RESPONSE (a Group object) <b>repeating</b><br>
 * 6: DSC (Continuation pointer segment) <b>optional </b><br>
 */
namespace NHapi.Base.model.v23.message

{
[Serializable]
public class ARD_A19 : AbstractMessage  {

	/** 
	 * Creates a new ARD_A19 Group with custom ModelClassFactory.
	 */
	public ARD_A19(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new ARD_A19 Group with DefaultModelClassFactory. 
	 */ 
	public ARD_A19() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.3"), true, false);
	      this.add(factory.getSegmentClass("MSA", "2.3"), true, false);
	      this.add(factory.getSegmentClass("ERR", "2.3"), false, false);
	      this.add(factory.getSegmentClass("QRD", "2.3"), true, false);
	      this.add(factory.getSegmentClass("QRF", "2.3"), false, false);
	      this.add(factory.getGroupClass("ARD_A19_QUERY_RESPONSE", "2.3"), true, true);
	      this.add(factory.getSegmentClass("DSC", "2.3"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ARD_A19 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (Message header segment) - creates it if necessary
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
	 * Returns MSA (Message acknowledgement segment) - creates it if necessary
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
	 * Returns ERR (Error segment) - creates it if necessary
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
	 * Returns QRD (Query definition segment) - creates it if necessary
	 */
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.get_Renamed("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QRF (Query filter segment) - creates it if necessary
	 */
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.get_Renamed("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ARD_A19_QUERY_RESPONSE (a Group object) - creates it if necessary
	 */
	public ARD_A19_QUERY_RESPONSE  getQUERY_RESPONSE() { 
	   ARD_A19_QUERY_RESPONSE ret = null;
	   try {
	      ret = (ARD_A19_QUERY_RESPONSE)this.get_Renamed("QUERY_RESPONSE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ARD_A19_QUERY_RESPONSE
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ARD_A19_QUERY_RESPONSE getQUERY_RESPONSE(int rep) { 
	   return (ARD_A19_QUERY_RESPONSE)this.get_Renamed("QUERY_RESPONSE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ARD_A19_QUERY_RESPONSE 
	 */ 
	public int QUERY_RESPONSEReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("QUERY_RESPONSE").Length; 
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
	 * Returns DSC (Continuation pointer segment) - creates it if necessary
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