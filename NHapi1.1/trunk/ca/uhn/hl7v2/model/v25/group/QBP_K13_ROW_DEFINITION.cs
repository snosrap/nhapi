using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v25.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the QBP_K13_ROW_DEFINITION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RDF (Table Row Definition) <b></b><br>
 * 1: RDT (Table Row Data) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v25.group
{
[Serializable]
public class QBP_K13_ROW_DEFINITION : AbstractGroup {

	/** 
	 * Creates a new QBP_K13_ROW_DEFINITION Group.
	 */
	public QBP_K13_ROW_DEFINITION(Group parent, ModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(RDF), true, false);
	      this.add(typeof(RDT), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating QBP_K13_ROW_DEFINITION - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns RDF (Table Row Definition) - creates it if necessary
	 */
	public RDF RDF { 
get{
	   RDF ret = null;
	   try {
	      ret = (RDF)this.get_Renamed("RDF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of RDT (Table Row Data) - creates it if necessary
	 */
	public RDT getRDT() {
	   RDT ret = null;
	   try {
	      ret = (RDT)this.get_Renamed("RDT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of RDT
	 * (Table Row Data) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public RDT getRDT(int rep) { 
	   return (RDT)this.get_Renamed("RDT", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RDT 
	 */ 
	public int RDTReps { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.getAll("RDT").Length; 
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
