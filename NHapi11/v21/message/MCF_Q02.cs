using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v21.group;
using ca.uhn.hl7v2.model.v21.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a MCF_Q02 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: MSA (MESSAGE ACKNOWLEDGMENT) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v21.message

{
[Serializable]
public class MCF_Q02 : AbstractMessage  {

	/** 
	 * Creates a new MCF_Q02 Group with custom ModelClassFactory.
	 */
	public MCF_Q02(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new MCF_Q02 Group with DefaultModelClassFactory. 
	 */ 
	public MCF_Q02() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(MSA), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MCF_Q02 - this is probably a bug in the source code generator.", e);
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

}
}
