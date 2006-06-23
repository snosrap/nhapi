using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ROR_ROR_DEFINITION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: QRD (Query definition segment) <b></b><br>
 * 1: QRF (Query filter segment) <b>optional </b><br>
 * 2: ROR_ROR_PATIENT (a Group object) <b>optional </b><br>
 * 3: ROR_ROR_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
[Serializable]
public class ROR_ROR_DEFINITION : AbstractGroup {

	/** 
	 * Creates a new ROR_ROR_DEFINITION Group.
	 */
	public ROR_ROR_DEFINITION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("QRD", "2.3"), true, false);
	      this.add(factory.getSegmentClass("QRF", "2.3"), false, false);
	      this.add(factory.getGroupClass("ROR_ROR_PATIENT", "2.3"), false, false);
	      this.add(factory.getGroupClass("ROR_ROR_ORDER", "2.3"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ROR_ROR_DEFINITION - this is probably a bug in the source code generator.", e);
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
	 * Returns ROR_ROR_PATIENT (a Group object) - creates it if necessary
	 */
	public ROR_ROR_PATIENT PATIENT { 
get{
	   ROR_ROR_PATIENT ret = null;
	   try {
	      ret = (ROR_ROR_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of ROR_ROR_ORDER (a Group object) - creates it if necessary
	 */
	public ROR_ROR_ORDER  getORDER() { 
	   ROR_ROR_ORDER ret = null;
	   try {
	      ret = (ROR_ROR_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of ROR_ROR_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public ROR_ROR_ORDER getORDER(int rep) { 
	   return (ROR_ROR_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of ROR_ROR_ORDER 
	 */ 
	public int ORDERReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("ORDER").Length; 
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
