using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a PMU_B04 message structure (see chapter 15). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: EVN (Event Type) <b></b><br>
 * 2: STF (Staff Identification) <b></b><br>
 * 3: PRA (Practitioner Detail) <b>optional repeating</b><br>
 * 4: ORG (Practitioner Organization Unit) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
[Serializable]
public class PMU_B04 : AbstractMessage  {

	/** 
	 * Creates a new PMU_B04 Group with custom ModelClassFactory.
	 */
	public PMU_B04(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new PMU_B04 Group with DefaultModelClassFactory. 
	 */ 
	public PMU_B04() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("EVN", "2.4"), true, false);
	      this.add(factory.getSegmentClass("STF", "2.4"), true, false);
	      this.add(factory.getSegmentClass("PRA", "2.4"), false, true);
	      this.add(factory.getSegmentClass("ORG", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PMU_B04 - this is probably a bug in the source code generator.", e);
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
	 * Returns EVN (Event Type) - creates it if necessary
	 */
	public EVN EVN { 
get{
	   EVN ret = null;
	   try {
	      ret = (EVN)this.get_Renamed("EVN");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns STF (Staff Identification) - creates it if necessary
	 */
	public STF STF { 
get{
	   STF ret = null;
	   try {
	      ret = (STF)this.get_Renamed("STF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns  first repetition of PRA (Practitioner Detail) - creates it if necessary
	 */
	public PRA  getPRA() { 
	   PRA ret = null;
	   try {
	      ret = (PRA)this.get_Renamed("PRA");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	/**
	 * Returns a specific repetition of PRA
	 * (Practitioner Detail) - creates it if necessary
	 * throws HL7Exception if the repetition requested is more than one 
	 *     greater than the number of existing repetitions.
	 */
	public PRA getPRA(int rep) { 
	   return (PRA)this.get_Renamed("PRA", rep);
	}

	/** 
	 * Returns the number of existing repetitions of PRA 
	 */ 
	public int PRAReps 
{ 
get
{
	    int reps = -1; 
	    try 
{ 
	        reps = this.getAll("PRA").Length; 
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
	 * Returns ORG (Practitioner Organization Unit) - creates it if necessary
	 */
	public ORG ORG { 
get{
	   ORG ret = null;
	   try {
	      ret = (ORG)this.get_Renamed("ORG");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
