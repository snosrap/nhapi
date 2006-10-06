using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

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
 * RXE-8: Deliver-To Location (LA1)<br> 
 * RXE-9: Substitution Status (ID)<br> 
 * RXE-10: Dispense Amount (NM)<br> 
 * RXE-11: Dispense Units (CE)<br> 
 * RXE-12: Number Of Refills (NM)<br> 
 * RXE-13: Ordering Provider's DEA Number (XCN)<br> 
 * RXE-14: Pharmacist/Treatment Supplier's Verifier ID (XCN)<br> 
 * RXE-15: Prescription Number (ST)<br> 
 * RXE-16: Number of Refills Remaining (NM)<br> 
 * RXE-17: Number of Refills/Doses Dispensed (NM)<br> 
 * RXE-18: D/T of Most Recent Refill or Dose Dispensed (TS)<br> 
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
 * RXE-31: Supplementary Code (CE)<br> 
 * RXE-32: Original Order Date/Time (TS)<br> 
 * RXE-33: Give Drug Strength Volume (NM)<br> 
 * RXE-34: Give Drug Strength Volume Units (CWE)<br> 
 * RXE-35: Controlled Substance Schedule (CWE)<br> 
 * RXE-36: Formulary Status (ID)<br> 
 * RXE-37: Pharmaceutical Substance Alternative (CWE)<br> 
 * RXE-38: Pharmacy of Most Recent Fill (CWE)<br> 
 * RXE-39: Initial Dispense Amount (NM)<br> 
 * RXE-40: Dispensing Pharmacy (CWE)<br> 
 * RXE-41: Dispensing Pharmacy Address (XAD)<br> 
 * RXE-42: Deliver-to Patient Location (PL)<br> 
 * RXE-43: Deliver-to Address (XAD)<br> 
 * RXE-44: Pharmacy Order Type (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RXE : AbstractSegment  {

  /**
   * Creates a RXE (Pharmacy/Treatment Encoded Order) segment object that belongs to the given 
   * message.  
   */
  public RXE(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(TQ), false, 1, 200, new System.Object[]{message}, "Quantity/Timing");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Give Code");
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message}, "Give Amount - Minimum");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Give Amount - Maximum");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Give Units");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Give Dosage Form");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Provider's Administration Instructions");
       this.add(typeof(LA1), false, 1, 200, new System.Object[]{message}, "Deliver-To Location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167}, "Substitution Status");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Dispense Amount");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Dispense Units");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Number Of Refills");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Ordering Provider's DEA Number");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Pharmacist/Treatment Supplier's Verifier ID");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Prescription Number");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Number of Refills Remaining");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Number of Refills/Doses Dispensed");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "D/T of Most Recent Refill or Dose Dispensed");
       this.add(typeof(CQ), false, 1, 10, new System.Object[]{message}, "Total Daily Dose");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Needs Human Review");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Pharmacy/Treatment Supplier's Special Dispensing Instructions");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Give Per (Time Unit)");
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message}, "Give Rate Amount");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Give Rate Units");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Give Strength");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Give Strength Units");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Give Indication");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Dispense Package Size");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Dispense Package Size Unit");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 321}, "Dispense Package Method");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Supplementary Code");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Original Order Date/Time");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "Give Drug Strength Volume");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Give Drug Strength Volume Units");
       this.add(typeof(CWE), false, 1, 60, new System.Object[]{message}, "Controlled Substance Schedule");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 478}, "Formulary Status");
       this.add(typeof(CWE), false, 0, 60, new System.Object[]{message}, "Pharmaceutical Substance Alternative");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Pharmacy of Most Recent Fill");
       this.add(typeof(NM), false, 1, 250, new System.Object[]{message}, "Initial Dispense Amount");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Dispensing Pharmacy");
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message}, "Dispensing Pharmacy Address");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Deliver-to Patient Location");
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message}, "Deliver-to Address");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 480}, "Pharmacy Order Type");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Quantity/Timing(RXE-1).
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
	* Returns Give Code(RXE-2).
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
	* Returns Give Amount - Minimum(RXE-3).
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
	* Returns Give Amount - Maximum(RXE-4).
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
	* Returns Give Units(RXE-5).
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
	* Returns Give Dosage Form(RXE-6).
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
	* Returns a single repetition of Provider's Administration Instructions(RXE-7).
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
	* Returns Deliver-To Location(RXE-8).
	*/
	public LA1 DeliverToLocation
	{
		get{
			LA1 ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (LA1)t;
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
	* Returns Substitution Status(RXE-9).
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
	* Returns Dispense Amount(RXE-10).
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
	* Returns Dispense Units(RXE-11).
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
	* Returns Number Of Refills(RXE-12).
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
	* Returns a single repetition of Ordering Provider's DEA Number(RXE-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getOrderingProviderSDEANumber(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ordering Provider's DEA Number (RXE-13).
   */
  public XCN[] getOrderingProviderSDEANumber() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(13);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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
	* Returns a single repetition of Pharmacist/Treatment Supplier's Verifier ID(RXE-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getPharmacistTreatmentSupplierSVerifierID(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Pharmacist/Treatment Supplier's Verifier ID (RXE-14).
   */
  public XCN[] getPharmacistTreatmentSupplierSVerifierID() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(14);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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
	* Returns Prescription Number(RXE-15).
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
	* Returns Number of Refills Remaining(RXE-16).
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
	* Returns Number of Refills/Doses Dispensed(RXE-17).
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
	* Returns D/T of Most Recent Refill or Dose Dispensed(RXE-18).
	*/
	public TS DTOfMostRecentRefillOrDoseDispensed
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
	* Returns Total Daily Dose(RXE-19).
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
	* Returns Needs Human Review(RXE-20).
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
	* Returns a single repetition of Pharmacy/Treatment Supplier's Special Dispensing Instructions(RXE-21).
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
	* Returns Give Per (Time Unit)(RXE-22).
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
	* Returns Give Rate Amount(RXE-23).
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
	* Returns Give Rate Units(RXE-24).
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
	* Returns Give Strength(RXE-25).
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
	* Returns Give Strength Units(RXE-26).
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
	* Returns a single repetition of Give Indication(RXE-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getGiveIndication(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(27, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Give Indication (RXE-27).
   */
  public CE[] getGiveIndication() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(27);  
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
	* Returns Dispense Package Size(RXE-28).
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
	* Returns Dispense Package Size Unit(RXE-29).
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
	* Returns Dispense Package Method(RXE-30).
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

	/**
	* Returns a single repetition of Supplementary Code(RXE-31).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getSupplementaryCode(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(31, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Supplementary Code (RXE-31).
   */
  public CE[] getSupplementaryCode() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(31);  
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
	* Returns Original Order Date/Time(RXE-32).
	*/
	public TS OriginalOrderDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(32, 0);
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
	* Returns Give Drug Strength Volume(RXE-33).
	*/
	public NM GiveDrugStrengthVolume
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(33, 0);
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
	* Returns Give Drug Strength Volume Units(RXE-34).
	*/
	public CWE GiveDrugStrengthVolumeUnits
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(34, 0);
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
	* Returns Controlled Substance Schedule(RXE-35).
	*/
	public CWE ControlledSubstanceSchedule
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(35, 0);
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
	* Returns Formulary Status(RXE-36).
	*/
	public ID FormularyStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(36, 0);
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
	* Returns a single repetition of Pharmaceutical Substance Alternative(RXE-37).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getPharmaceuticalSubstanceAlternative(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(37, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Pharmaceutical Substance Alternative (RXE-37).
   */
  public CWE[] getPharmaceuticalSubstanceAlternative() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(37);  
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
	* Returns Pharmacy of Most Recent Fill(RXE-38).
	*/
	public CWE PharmacyOfMostRecentFill
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(38, 0);
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
	* Returns Initial Dispense Amount(RXE-39).
	*/
	public NM InitialDispenseAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(39, 0);
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
	* Returns Dispensing Pharmacy(RXE-40).
	*/
	public CWE DispensingPharmacy
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns Dispensing Pharmacy Address(RXE-41).
	*/
	public XAD DispensingPharmacyAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns Deliver-to Patient Location(RXE-42).
	*/
	public PL DeliverToPatientLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(42, 0);
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
	* Returns Deliver-to Address(RXE-43).
	*/
	public XAD DeliverToAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(43, 0);
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
	* Returns Pharmacy Order Type(RXE-44).
	*/
	public ID PharmacyOrderType
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(44, 0);
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