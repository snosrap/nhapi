using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 BTX message segment. 
 * This segment has the following fields:</p><p>
 * BTX-1: Set ID _ BTX (SI)<br> 
 * BTX-2: BC Donation ID (EI)<br> 
 * BTX-3: BC Component (CNE)<br> 
 * BTX-4: BC Blood Group (CNE)<br> 
 * BTX-5: CP Commercial Product (CWE)<br> 
 * BTX-6: CP Manufacturer (XON)<br> 
 * BTX-7: CP Lot Number (EI)<br> 
 * BTX-8: BP Quantity (NM)<br> 
 * BTX-9: BP Amount (NM)<br> 
 * BTX-10: BP Units (CE)<br> 
 * BTX-11: BP Transfusion/Disposition Status (CWE)<br> 
 * BTX-12: BP Message Status (ID)<br> 
 * BTX-13: BP Date/Time of Status (TS)<br> 
 * BTX-14: BP Administrator (XCN)<br> 
 * BTX-15: BP Verifier (XCN)<br> 
 * BTX-16: BP Transfusion Start Date/Time of Status (TS)<br> 
 * BTX-17: BP Transfusion End Date/Time of Status (TS)<br> 
 * BTX-18: BP Adverse Reaction Type (CWE)<br> 
 * BTX-19: BP Transfusion Interrupted Reason (CWE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class BTX : AbstractSegment  {

  /**
   * Creates a BTX (Blood Product Transfusion/Disposition) segment object that belongs to the given 
   * message.  
   */
  public BTX(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(XON), false, 1, 250, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
       this.add(typeof(NM), true, 1, 5, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CWE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 511});
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Set ID _ BTX (BTX-1).
	*/
	public SI SetIDBTX
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
	* Returns BC Donation ID (BTX-2).
	*/
	public EI BCDonationID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (EI)t;
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
	* Returns BC Component (BTX-3).
	*/
	public CNE BCComponent
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (CNE)t;
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
	* Returns BC Blood Group (BTX-4).
	*/
	public CNE BCBloodGroup
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (CNE)t;
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
	* Returns CP Commercial Product (BTX-5).
	*/
	public CWE CPCommercialProduct
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns CP Manufacturer (BTX-6).
	*/
	public XON CPManufacturer
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (XON)t;
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
	* Returns CP Lot Number (BTX-7).
	*/
	public EI CPLotNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (EI)t;
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
	* Returns BP Quantity (BTX-8).
	*/
	public NM BPQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns BP Amount (BTX-9).
	*/
	public NM BPAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns BP Units (BTX-10).
	*/
	public CE BPUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns BP Transfusion/Disposition Status (BTX-11).
	*/
	public CWE BPTransfusionDispositionStatus
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns BP Message Status (BTX-12).
	*/
	public ID BPMessageStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(12, 0);
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

	/**
	* Returns BP Date/Time of Status (BTX-13).
	*/
	public TS BPDateTimeOfStatus
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns BP Administrator (BTX-14).
	*/
	public XCN BPAdministrator
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (XCN)t;
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
	* Returns BP Verifier (BTX-15).
	*/
	public XCN BPVerifier
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (XCN)t;
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
	* Returns BP Transfusion Start Date/Time of Status (BTX-16).
	*/
	public TS BPTransfusionStartDateTimeOfStatus
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns BP Transfusion End Date/Time of Status (BTX-17).
	*/
	public TS BPTransfusionEndDateTimeOfStatus
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns a single repetition of BP Adverse Reaction Type (BTX-18).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getBPAdverseReactionType(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(18, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of BP Adverse Reaction Type (BTX-18).
   */
  public CWE[] getBPAdverseReactionType() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(18);  
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
	* Returns BP Transfusion Interrupted Reason (BTX-19).
	*/
	public CWE BPTransfusionInterruptedReason
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(19, 0);
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


}}