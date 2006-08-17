using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;

using NHapi.Base.Model;
/**
 * <p>Represents the ORR_O02_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (OBSERVATION REQUEST) <b></b><br>
 * 1: RQD (REQUISITION DETAIL) <b></b><br>
 * 2: RQ1 (REQUISITION DETAIL-!) <b></b><br>
 * 3: RXO (PHARMACY PRESCRIPTION ORDER) <b></b><br>
 * 4: ODS (DIETARY ORDERS, SUPPLEMENTS, and PREFERENCES) <b></b><br>
 * 5: ODT (DIET TRAY INSTRUCTION) <b></b><br>
 */
namespace NHapi.Model.V22.Group
{
[Serializable]
public class ORR_O02_ORDER_DETAIL : AbstractGroup {

	/** 
	 * Creates a new ORR_O02_ORDER_DETAIL Group.
	 */
	public ORR_O02_ORDER_DETAIL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(OBR), true, false);
	      this.add(typeof(RQD), true, false);
	      this.add(typeof(RQ1), true, false);
	      this.add(typeof(RXO), true, false);
	      this.add(typeof(ODS), true, false);
	      this.add(typeof(ODT), true, false);
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORR_O02_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
	   }
	}

	/**
	 * Returns OBR (OBSERVATION REQUEST) - creates it if necessary
	 */
	public OBR OBR { 
get{
	   OBR ret = null;
	   try {
	      ret = (OBR)this.getStructure("OBR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RQD (REQUISITION DETAIL) - creates it if necessary
	 */
	public RQD RQD { 
get{
	   RQD ret = null;
	   try {
	      ret = (RQD)this.getStructure("RQD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RQ1 (REQUISITION DETAIL-!) - creates it if necessary
	 */
	public RQ1 RQ1 { 
get{
	   RQ1 ret = null;
	   try {
	      ret = (RQ1)this.getStructure("RQ1");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns RXO (PHARMACY PRESCRIPTION ORDER) - creates it if necessary
	 */
	public RXO RXO { 
get{
	   RXO ret = null;
	   try {
	      ret = (RXO)this.getStructure("RXO");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ODS (DIETARY ORDERS, SUPPLEMENTS, and PREFERENCES) - creates it if necessary
	 */
	public ODS ODS { 
get{
	   ODS ret = null;
	   try {
	      ret = (ODS)this.getStructure("ODS");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	/**
	 * Returns ODT (DIET TRAY INSTRUCTION) - creates it if necessary
	 */
	public ODT ODT { 
get{
	   ODT ret = null;
	   try {
	      ret = (ODT)this.getStructure("ODT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

}
}
