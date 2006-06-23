using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 RXD message segment. 
 * This segment has the following fields:</p><p>
 * RXD-1: Dispense Sub-ID Counter (NM)<br> 
 * RXD-2: Dispense/Give Code (CE)<br> 
 * RXD-3: Date/Time Dispensed (TS)<br> 
 * RXD-4: Actual Dispense Amount (NM)<br> 
 * RXD-5: Actual Dispense Units (CE)<br> 
 * RXD-6: Actual Dosage Form (CE)<br> 
 * RXD-7: Prescription Number (ST)<br> 
 * RXD-8: Number of Refills Remaining (NM)<br> 
 * RXD-9: Dispense Notes (ST)<br> 
 * RXD-10: Dispensing Provider (XCN)<br> 
 * RXD-11: Substitution Status (ID)<br> 
 * RXD-12: Total Daily Dose (CQ)<br> 
 * RXD-13: Dispense-to Location (LA2)<br> 
 * RXD-14: Needs Human Review (ID)<br> 
 * RXD-15: Pharmacy/Treatment Supplier's Special Dispensing Instructions (CE)<br> 
 * RXD-16: Actual Strength (NM)<br> 
 * RXD-17: Actual Strength Unit (CE)<br> 
 * RXD-18: Substance Lot Number (ST)<br> 
 * RXD-19: Substance Expiration Date (TS)<br> 
 * RXD-20: Substance Manufacturer Name (CE)<br> 
 * RXD-21: Indication (CE)<br> 
 * RXD-22: Dispense Package Size (NM)<br> 
 * RXD-23: Dispense Package Size Unit (CE)<br> 
 * RXD-24: Dispense Package Method (ID)<br> 
 * RXD-25: Supplementary Code (CE)<br> 
 * RXD-26: Initiating Location (CE)<br> 
 * RXD-27: Packaging/Assembly Location (CE)<br> 
 * RXD-28: Actual Drug Strength Volume (NM)<br> 
 * RXD-29: Actual Drug Strength Volume Units (CWE)<br> 
 * RXD-30: Dispense to Pharmacy (CWE)<br> 
 * RXD-31: Dispense to Pharmacy Address (XAD)<br> 
 * RXD-32: Pharmacy Order Type (ID)<br> 
 * RXD-33: Dispense Type (CWE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RXD : AbstractSegment  {

  /**
   * Creates a RXD (Pharmacy/Treatment Dispense) segment object that belongs to the given 
   * message.  
   */
  public RXD(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(ST), false, 0, 200, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 200, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167});
       this.add(typeof(CQ), false, 1, 10, new System.Object[]{message});
       this.add(typeof(LA2), false, 1, 200, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
       this.add(typeof(TS), false, 0, 26, new System.Object[]{message});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 321});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 180, new System.Object[]{message});
       this.add(typeof(XAD), false, 1, 106, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 480});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Dispense Sub-ID Counter (RXD-1).
	*/
	public NM DispenseSubIDCounter
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Dispense/Give Code (RXD-2).
	*/
	public CE DispenseGiveCode
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
	* Returns Date/Time Dispensed (RXD-3).
	*/
	public TS DateTimeDispensed
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Actual Dispense Amount (RXD-4).
	*/
	public NM ActualDispenseAmount
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
	* Returns Actual Dispense Units (RXD-5).
	*/
	public CE ActualDispenseUnits
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
	* Returns Actual Dosage Form (RXD-6).
	*/
	public CE ActualDosageForm
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
	* Returns Prescription Number (RXD-7).
	*/
	public ST PrescriptionNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Number of Refills Remaining (RXD-8).
	*/
	public NM NumberOfRefillsRemaining
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
	* Returns a single repetition of Dispense Notes (RXD-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getDispenseNotes(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Dispense Notes (RXD-9).
   */
  public ST[] getDispenseNotes() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
	* Returns a single repetition of Dispensing Provider (RXD-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getDispensingProvider(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Dispensing Provider (RXD-10).
   */
  public XCN[] getDispensingProvider() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(10);  
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
	* Returns Substitution Status (RXD-11).
	*/
	public ID SubstitutionStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Total Daily Dose (RXD-12).
	*/
	public CQ TotalDailyDose
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Dispense-to Location (RXD-13).
	*/
	public LA2 DispenseToLocation
	{
		get{
			LA2 ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (LA2)t;
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
	* Returns Needs Human Review (RXD-14).
	*/
	public ID NeedsHumanReview
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

	/**
	* Returns a single repetition of Pharmacy/Treatment Supplier's Special Dispensing Instructions (RXD-15).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getPharmacyTreatmentSupplierSSpecialDispensingInstructions(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(15, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Pharmacy/Treatment Supplier's Special Dispensing Instructions (RXD-15).
   */
  public CE[] getPharmacyTreatmentSupplierSSpecialDispensingInstructions() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(15);  
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
	* Returns Actual Strength (RXD-16).
	*/
	public NM ActualStrength
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
	* Returns Actual Strength Unit (RXD-17).
	*/
	public CE ActualStrengthUnit
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns a single repetition of Substance Lot Number (RXD-18).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getSubstanceLotNumber(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(18, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Substance Lot Number (RXD-18).
   */
  public ST[] getSubstanceLotNumber() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(18);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
	* Returns a single repetition of Substance Expiration Date (RXD-19).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TS getSubstanceExpirationDate(int rep)
	{
			TS ret = null;
			try
			{
			Type t = this.getField(19, rep);
				ret = (TS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Substance Expiration Date (RXD-19).
   */
  public TS[] getSubstanceExpirationDate() {
     TS[] ret = null;
    try {
        Type[] t = this.getField(19);  
        ret = new TS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TS)t[i];
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
	* Returns a single repetition of Substance Manufacturer Name (RXD-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getSubstanceManufacturerName(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(20, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Substance Manufacturer Name (RXD-20).
   */
  public CE[] getSubstanceManufacturerName() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(20);  
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
	* Returns a single repetition of Indication (RXD-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getIndication(int rep)
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
   * Returns all repetitions of Indication (RXD-21).
   */
  public CE[] getIndication() {
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
	* Returns Dispense Package Size (RXD-22).
	*/
	public NM DispensePackageSize
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns Dispense Package Size Unit (RXD-23).
	*/
	public CE DispensePackageSizeUnit
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns Dispense Package Method (RXD-24).
	*/
	public ID DispensePackageMethod
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns a single repetition of Supplementary Code (RXD-25).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getSupplementaryCode(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(25, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Supplementary Code (RXD-25).
   */
  public CE[] getSupplementaryCode() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(25);  
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
	* Returns Initiating Location (RXD-26).
	*/
	public CE InitiatingLocation
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
	* Returns Packaging/Assembly Location (RXD-27).
	*/
	public CE PackagingAssemblyLocation
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
	* Returns Actual Drug Strength Volume (RXD-28).
	*/
	public NM ActualDrugStrengthVolume
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
	* Returns Actual Drug Strength Volume Units (RXD-29).
	*/
	public CWE ActualDrugStrengthVolumeUnits
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(29, 0);
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
	* Returns Dispense to Pharmacy (RXD-30).
	*/
	public CWE DispenseToPharmacy
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(30, 0);
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
	* Returns Dispense to Pharmacy Address (RXD-31).
	*/
	public XAD DispenseToPharmacyAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(31, 0);
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
	* Returns Pharmacy Order Type (RXD-32).
	*/
	public ID PharmacyOrderType
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(32, 0);
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
	* Returns Dispense Type (RXD-33).
	*/
	public CWE DispenseType
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(33, 0);
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