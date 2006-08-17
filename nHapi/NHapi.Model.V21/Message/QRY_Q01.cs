using System;
using NHapi.Base.Log;
using NHapi.Model.V21.Group;
using NHapi.Model.V21.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

/**
 * <p>Represents a QRY_Q01 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MESSAGE HEADER) <b></b><br>
 * 1: QRD (QUERY DEFINITION) <b></b><br>
 * 2: QRF (QUERY FILTER) <b>optional </b><br>
 * 3: DSC (CONTINUATION POINTER) <b></b><br>
 */
namespace NHapi.Model.V21.Message

{
[Serializable]
public class QRY_Q01 : AbstractMessage  {

	/** 
	 * Creates a new QRY_Q01 Group with custom IModelClassFactory.
	 */
	public QRY_Q01(IModelClassFactory factory) : base(factory){
	   init(factory);
	}

	/**
	 * Creates a new QRY_Q01 Group with DefaultModelClassFactory. 
	 */ 
	public QRY_Q01() : base(new DefaultModelClassFactory()) { 
	   init(new DefaultModelClassFactory());
	}

	private void init(IModelClassFactory factory) {
	   try {
	      this.add(typeof(MSH), true, false);
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	      this.add(typeof(DSC), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating QRY_Q01 - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns MSH (MESSAGE HEADER) - creates it if necessary
	 */
	public MSH MSH { 
get{
	   MSH ret = null;
	   try {
	      ret = (MSH)this.getStructure("MSH");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QRD (QUERY DEFINITION) - creates it if necessary
	 */
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.getStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns QRF (QUERY FILTER) - creates it if necessary
	 */
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.getStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns DSC (CONTINUATION POINTER) - creates it if necessary
	 */
	public DSC DSC { 
get{
	   DSC ret = null;
	   try {
	      ret = (DSC)this.getStructure("DSC");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
