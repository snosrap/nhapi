using System;
using ca.uhn.log;
using NHapi.Base.model.v24.group;
using NHapi.Base.model.v24.segment;
using NHapi.Base;
using NHapi.Base.parser;
using NHapi.Base.model;

/**
 * <p>Represents a QBP_Q11 message structure (see chapter 5). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: QPD (Query Parameter Definition) <b></b><br>
 * 2: RCP (Response Control Parameter) <b></b><br>
 * 3: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace NHapi.Base.model.v24.message

{
[Serializable]
public class QBP_Q11 : AbstractMessage  {

	/** 
	 * Creates a new QBP_Q11 Group with custom ModelClassFactory.
	 */
	public QBP_Q11(ModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new QBP_Q11 Group with DefaultModelClassFactory. 
	 */ 
	public QBP_Q11() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(ModelClassFactory factory) {
	   try {
	      this.add(factory.getSegmentClass("MSH", "2.4"), true, false);
	      this.add(factory.getSegmentClass("QPD", "2.4"), true, false);
	      this.add(factory.getSegmentClass("RCP", "2.4"), true, false);
	      this.add(factory.getSegmentClass("DSC", "2.4"), false, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating QBP_Q11 - this is probably a bug in the source code generator.", e);
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
	 * Returns QPD (Query Parameter Definition) - creates it if necessary
	 */
	public QPD QPD { 
get{
	   QPD ret = null;
	   try {
	      ret = (QPD)this.get_Renamed("QPD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RCP (Response Control Parameter) - creates it if necessary
	 */
	public RCP RCP { 
get{
	   RCP ret = null;
	   try {
	      ret = (RCP)this.get_Renamed("RCP");
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
