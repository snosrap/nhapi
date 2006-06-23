using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RER_RER_DEFINITION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: QRD (QRD - original-style query definition segment) <b></b><br>
 * 1: QRF (QRF - original style query filter segment) <b>optional </b><br>
 * 2: RER_RER_PATIENT (a Group object) <b>optional </b><br>
 * 3: RER_RER_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
[Serializable]
public class RER_RER_DEFINITION : AbstractGroup {

	/** 
	 * Creates a new RER_RER_DEFINITION Group.
	 */
	public RER_RER_DEFINITION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(factory.getSegmentClass("QRD", "2.3.1"), true, false);
	      this.add(factory.getSegmentClass("QRF", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("RER_RER_PATIENT", "2.3.1"), false, false);
	      this.add(factory.getGroupClass("RER_RER_ORDER", "2.3.1"), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RER_RER_DEFINITION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns QRD (QRD - original-style query definition segment) - creates it if necessary
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
	 * Returns QRF (QRF - original style query filter segment) - creates it if necessary
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
	 * Returns RER_RER_PATIENT (a Group object) - creates it if necessary
	 */
	public RER_RER_PATIENT PATIENT { 
get{
	   RER_RER_PATIENT ret = null;
	   try {
	      ret = (RER_RER_PATIENT)this.get_Renamed("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RER_RER_ORDER (a Group object) - creates it if necessary
	 */
	public RER_RER_ORDER  getORDER() { 
	   RER_RER_ORDER ret = null;
	   try {
	      ret = (RER_RER_ORDER)this.get_Renamed("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RER_RER_ORDER
	 * (a Group object) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RER_RER_ORDER getORDER(int rep) { 
	   return (RER_RER_ORDER)this.get_Renamed("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RER_RER_ORDER 
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
