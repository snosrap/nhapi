using System;
using ca.uhn.log;
using NHapi.Base.model.v24.group;
using NHapi.Base.model.v24.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a SPQ_Q08 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: SPR (Stored Procedure Request Definition) <b></b><br>
 * 2: RDF (Table Row Definition) <b>optional </b><br>
 * 3: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace NHapi.Base.model.v24.message

{
[Serializable]
public class SPQ_Q08 : AbstractMessage  {

	/** 
	 * Creates a new SPQ_Q08 Group with custom ModelClassFactory.
	 */
	public SPQ_Q08(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new SPQ_Q08 Group with DefaultModelClassFactory. 
	 */ 
	public SPQ_Q08() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("SPR", "2.4"), true, false);
	      this.add(factory.getSegmentClass("RDF", "2.4"), false, false);
	      this.add(factory.getSegmentClass("DSC", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SPQ_Q08 - this is probably a bug in the source code generator.", e);
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
	 * Returns SPR (Stored Procedure Request Definition) - creates it if necessary
	 */
	public SPR SPR { 
get{
	   SPR ret = null;
	   try {
	      ret = (SPR)this.get_Renamed("SPR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
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
	 * Returns DSC (Continuation Pointer) - creates it if necessary
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
