using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 BPO message segment. 
 * This segment has the following fields:</p><p>
 * BPO-1: Set ID _ BPO (SI)<br> 
 * BPO-2: BP Universal Service ID (CWE)<br> 
 * BPO-3: BP  Processing Requirements (CWE)<br> 
 * BPO-4: BP Quantity (NM)<br> 
 * BPO-5: BP Amount (NM)<br> 
 * BPO-6: BP Units (CE)<br> 
 * BPO-7: BP Intended Use Date/Time (TS)<br> 
 * BPO-8: BP Intended Dispense From Location (PL)<br> 
 * BPO-9: BP Intended Dispense From Address (XAD)<br> 
 * BPO-10: BP Requested Dispense Date/Time (TS)<br> 
 * BPO-11: BP Requested Dispense To Location (PL)<br> 
 * BPO-12: BP Requested Dispense To Address (XAD)<br> 
 * BPO-13: BP Indication for Use (CWE)<br> 
 * BPO-14: BP Informed Consent Indicator (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class BPO : AbstractSegment  {

  /**
   * Creates a BPO (Blood product order) segment object that belongs to the given 
   * message.  
   */
  public BPO(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID _ BPO");
       this.add(typeof(CWE), true, 1, 250, new System.Object[]{message}, "BP Universal Service ID");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "BP  Processing Requirements");
       this.add(typeof(NM), true, 1, 5, new System.Object[]{message}, "BP Quantity");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "BP Amount");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "BP Units");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "BP Intended Use Date/Time");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "BP Intended Dispense From Location");
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message}, "BP Intended Dispense From Address");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "BP Requested Dispense Date/Time");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "BP Requested Dispense To Location");
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message}, "BP Requested Dispense To Address");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "BP Indication for Use");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "BP Informed Consent Indicator");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID _ BPO(BPO-1).
	*/
	public SI SetIDBPO
	{
		get{
			SI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (SI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Universal Service ID(BPO-2).
	*/
	public CWE BPUniversalServiceID
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of BP  Processing Requirements(BPO-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getBPProcessingRequirements(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of BP  Processing Requirements (BPO-3).
   */
  public CWE[] getBPProcessingRequirements() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns BP Quantity(BPO-4).
	*/
	public NM BPQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Amount(BPO-5).
	*/
	public NM BPAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Units(BPO-6).
	*/
	public CE BPUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (CE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Intended Use Date/Time(BPO-7).
	*/
	public TS BPIntendedUseDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Intended Dispense From Location(BPO-8).
	*/
	public PL BPIntendedDispenseFromLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (PL)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Intended Dispense From Address(BPO-9).
	*/
	public XAD BPIntendedDispenseFromAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (XAD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Requested Dispense Date/Time(BPO-10).
	*/
	public TS BPRequestedDispenseDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (TS)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Requested Dispense To Location(BPO-11).
	*/
	public PL BPRequestedDispenseToLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (PL)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns BP Requested Dispense To Address(BPO-12).
	*/
	public XAD BPRequestedDispenseToAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (XAD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of BP Indication for Use(BPO-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getBPIndicationForUse(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of BP Indication for Use (BPO-13).
   */
  public CWE[] getBPIndicationForUse() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(13);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

	/**
	* Returns BP Informed Consent Indicator(BPO-14).
	*/
	public ID BPInformedConsentIndicator
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}