using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 RXE message segment. 
 * This segment has the following fields:</p><p>
 * RXE-1: Quantity/Timing (TQ)<br> 
 * RXE-2: Give Code (CE)<br> 
 * RXE-3: Give Amount - Minimum (NM)<br> 
 * RXE-4: Give Amount - Maximum (NM)<br> 
 * RXE-5: Give Units (CE)<br> 
 * RXE-6: Give Dosage Form (CE)<br> 
 * RXE-7: Provider's Administration Instructions (CE)<br> 
 * RXE-8: Deliver To Location (CM_LA1)<br> 
 * RXE-9: Substitution Status (ID)<br> 
 * RXE-10: Dispense Amount (NM)<br> 
 * RXE-11: Dispense Units (CE)<br> 
 * RXE-12: Number of Refills (NM)<br> 
 * RXE-13: Ordering Provider's DEA Number (CN)<br> 
 * RXE-14: Pharmacist/Treatment Supplier's Verifier ID (CN)<br> 
 * RXE-15: Prescription Number (ST)<br> 
 * RXE-16: Number of Refills Remaining (NM)<br> 
 * RXE-17: Number of Refills/Doses Dispensed (NM)<br> 
 * RXE-18: Date / time of most recent refill or dose dispensed (TS)<br> 
 * RXE-19: Total Daily Dose (CQ)<br> 
 * RXE-20: Needs Human Review (ID)<br> 
 * RXE-21: Pharmacy/Treatment Supplier's Special Dispensing Instructions (CE)<br> 
 * RXE-22: Give Per (Time Unit) (ST)<br> 
 * RXE-23: Give Rate Amount (ST)<br> 
 * RXE-24: Give Rate Units (CE)<br> 
 * RXE-25: Give Strength (NM)<br> 
 * RXE-26: Give Strength Units (CE)<br> 
 * RXE-27: Give Indication (CE)<br> 
 * RXE-28: Dispense Package Size (NM)<br> 
 * RXE-29: Dispense Package Size Unit (CE)<br> 
 * RXE-30: Dispense Package Method (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RXE : AbstractSegment  {

  /**
   * Creates a RXE (Pharmacy encoded order segment) segment object that belongs to the given 
   * message.  
   */
  public RXE(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(TQ), true, 1, 200, new System.Object[]{message});
       this.add(typeof(CE), true, 1, 100, new System.Object[]{message});
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), true, 1, 60, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
       this.add(typeof(CM_LA1), false, 1, 200, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message});
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(CQ), false, 1, 10, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 321});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Quantity/Timing (RXE-1).
	*/
	public TQ QuantityTiming
	{
		get{
			TQ ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (TQ)t;
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
	* Returns Give Code (RXE-2).
	*/
	public CE GiveCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Give Amount - Minimum (RXE-3).
	*/
	public NM GiveAmountMinimum
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Give Amount - Maximum (RXE-4).
	*/
	public NM GiveAmountMaximum
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
	* Returns Give Units (RXE-5).
	*/
	public CE GiveUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Give Dosage Form (RXE-6).
	*/
	public CE GiveDosageForm
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
	* Returns a single repetition of Provider's Administration Instructions (RXE-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getProviderSAdministrationInstructions(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Provider's Administration Instructions (RXE-7).
   */
  public CE[] getProviderSAdministrationInstructions() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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
	* Returns Deliver To Location (RXE-8).
	*/
	public CM_LA1 DeliverToLocation
	{
		get{
			CM_LA1 ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CM_LA1)t;
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
	* Returns Substitution Status (RXE-9).
	*/
	public ID SubstitutionStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Dispense Amount (RXE-10).
	*/
	public NM DispenseAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Dispense Units (RXE-11).
	*/
	public CE DispenseUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Number of Refills (RXE-12).
	*/
	public NM NumberOfRefills
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Ordering Provider's DEA Number (RXE-13).
	*/
	public CN OrderingProviderSDEANumber
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (CN)t;
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
	* Returns Pharmacist/Treatment Supplier's Verifier ID (RXE-14).
	*/
	public CN PharmacistTreatmentSupplierSVerifierID
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (CN)t;
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
	* Returns Prescription Number (RXE-15).
	*/
	public ST PrescriptionNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (ST)t;
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
	* Returns Number of Refills Remaining (RXE-16).
	*/
	public NM NumberOfRefillsRemaining
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns Number of Refills/Doses Dispensed (RXE-17).
	*/
	public NM NumberOfRefillsDosesDispensed
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Date / time of most recent refill or dose dispensed (RXE-18).
	*/
	public TS DateTimeOfMostRecentRefillOrDoseDispensed
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Total Daily Dose (RXE-19).
	*/
	public CQ TotalDailyDose
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (CQ)t;
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
	* Returns Needs Human Review (RXE-20).
	*/
	public ID NeedsHumanReview
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns a single repetition of Pharmacy/Treatment Supplier's Special Dispensing Instructions (RXE-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getPharmacyTreatmentSupplierSSpecialDispensingInstructions(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(21, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Pharmacy/Treatment Supplier's Special Dispensing Instructions (RXE-21).
   */
  public CE[] getPharmacyTreatmentSupplierSSpecialDispensingInstructions() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(21);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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
	* Returns Give Per (Time Unit) (RXE-22).
	*/
	public ST GivePerTimeUnit
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(22, 0);
				ret = (ST)t;
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
	* Returns Give Rate Amount (RXE-23).
	*/
	public ST GiveRateAmount
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(23, 0);
				ret = (ST)t;
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
	* Returns Give Rate Units (RXE-24).
	*/
	public CE GiveRateUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns Give Strength (RXE-25).
	*/
	public NM GiveStrength
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Give Strength Units (RXE-26).
	*/
	public CE GiveStrengthUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(26, 0);
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
	* Returns Give Indication (RXE-27).
	*/
	public CE GiveIndication
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(27, 0);
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
	* Returns Dispense Package Size (RXE-28).
	*/
	public NM DispensePackageSize
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(28, 0);
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
	* Returns Dispense Package Size Unit (RXE-29).
	*/
	public CE DispensePackageSizeUnit
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(29, 0);
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
	* Returns Dispense Package Method (RXE-30).
	*/
	public ID DispensePackageMethod
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(30, 0);
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