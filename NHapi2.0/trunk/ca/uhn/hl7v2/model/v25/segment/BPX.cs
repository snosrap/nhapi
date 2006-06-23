using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 BPX message segment. 
 * This segment has the following fields:</p><p>
 * BPX-1: Set ID _ BPX (SI)<br> 
 * BPX-2: BP Dispense Status (CWE)<br> 
 * BPX-3: BP Status (ID)<br> 
 * BPX-4: BP Date/Time of Status (TS)<br> 
 * BPX-5: BC Donation ID (EI)<br> 
 * BPX-6: BC Component (CNE)<br> 
 * BPX-7: BC Donation Type / Intended Use (CNE)<br> 
 * BPX-8: CP Commercial Product (CWE)<br> 
 * BPX-9: CP Manufacturer (XON)<br> 
 * BPX-10: CP Lot Number (EI)<br> 
 * BPX-11: BP Blood Group (CNE)<br> 
 * BPX-12: BC Special Testing (CNE)<br> 
 * BPX-13: BP Expiration Date/Time (TS)<br> 
 * BPX-14: BP Quantity (NM)<br> 
 * BPX-15: BP Amount (NM)<br> 
 * BPX-16: BP Units (CE)<br> 
 * BPX-17: BP Unique ID (EI)<br> 
 * BPX-18: BP Actual Dispensed To Location (PL)<br> 
 * BPX-19: BP Actual Dispensed To Address (XAD)<br> 
 * BPX-20: BP Dispensed to Receiver (XCN)<br> 
 * BPX-21: BP Dispensing Individual (XCN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class BPX : AbstractSegment  {

  /**
   * Creates a BPX (Blood product dispense status) segment object that belongs to the given 
   * message.  
   */
  public BPX(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
       this.add(typeof(CWE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 511});
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(XON), false, 1, 250, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CNE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(NM), true, 1, 5, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message});
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Set ID _ BPX (BPX-1).
	*/
	public SI SetIDBPX
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
	* Returns BP Dispense Status (BPX-2).
	*/
	public CWE BPDispenseStatus
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
	* Returns BP Status (BPX-3).
	*/
	public ID BPStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns BP Date/Time of Status (BPX-4).
	*/
	public TS BPDateTimeOfStatus
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns BC Donation ID (BPX-5).
	*/
	public EI BCDonationID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns BC Component (BPX-6).
	*/
	public CNE BCComponent
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns BC Donation Type / Intended Use (BPX-7).
	*/
	public CNE BCDonationTypeIntendedUse
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns CP Commercial Product (BPX-8).
	*/
	public CWE CPCommercialProduct
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns CP Manufacturer (BPX-9).
	*/
	public XON CPManufacturer
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns CP Lot Number (BPX-10).
	*/
	public EI CPLotNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns BP Blood Group (BPX-11).
	*/
	public CNE BPBloodGroup
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns a single repetition of BC Special Testing (BPX-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CNE getBCSpecialTesting(int rep)
	{
			CNE ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (CNE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of BC Special Testing (BPX-12).
   */
  public CNE[] getBCSpecialTesting() {
     CNE[] ret = null;
    try {
        Type[] t = this.getField(12);  
        ret = new CNE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CNE)t[i];
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
	* Returns BP Expiration Date/Time (BPX-13).
	*/
	public TS BPExpirationDateTime
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
	* Returns BP Quantity (BPX-14).
	*/
	public NM BPQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns BP Amount (BPX-15).
	*/
	public NM BPAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns BP Units (BPX-16).
	*/
	public CE BPUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns BP Unique ID (BPX-17).
	*/
	public EI BPUniqueID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns BP Actual Dispensed To Location (BPX-18).
	*/
	public PL BPActualDispensedToLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns BP Actual Dispensed To Address (BPX-19).
	*/
	public XAD BPActualDispensedToAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns BP Dispensed to Receiver (BPX-20).
	*/
	public XCN BPDispensedToReceiver
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns BP Dispensing Individual (BPX-21).
	*/
	public XCN BPDispensingIndividual
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(21, 0);
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


}}