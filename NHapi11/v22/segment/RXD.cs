using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 RXD message segment. 
 * This segment has the following fields:</p><p>
 * RXD-1: Dispense Sub-ID Counter (NM)<br> 
 * RXD-2: Dispense / give code (CE)<br> 
 * RXD-3: Date / time dispensed (TS)<br> 
 * RXD-4: Actual Dispense Amount (NM)<br> 
 * RXD-5: Actual Dispense Units (CE)<br> 
 * RXD-6: Actual Dosage Form (CE)<br> 
 * RXD-7: Prescription Number (ST)<br> 
 * RXD-8: Number of Refills Remaining (NM)<br> 
 * RXD-9: Dispense Notes (ST)<br> 
 * RXD-10: Dispensing Provider (CN_PERSON)<br> 
 * RXD-11: Substitution Status (ID)<br> 
 * RXD-12: Total Daily Dose (CQ_QUANTITY)<br> 
 * RXD-13: Deliver-to location (CM_LA1)<br> 
 * RXD-14: Needs Human Review (ID)<br> 
 * RXD-15: Pharmacy Special Dispensing Instructions (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RXD : AbstractSegment  {

  /**
   * Creates a RXD (PHARMACY DISPENSE) segment object that belongs to the given 
   * message.  
   */
  public RXD(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Dispense Sub-ID Counter");
       this.add(typeof(CE), true, 1, 100, new System.Object[]{message}, "Dispense / give code");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date / time dispensed");
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message}, "Actual Dispense Amount");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Actual Dispense Units");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Actual Dosage Form");
       this.add(typeof(ST), true, 1, 20, new System.Object[]{message}, "Prescription Number");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Number of Refills Remaining");
       this.add(typeof(ST), false, 0, 200, new System.Object[]{message}, "Dispense Notes");
       this.add(typeof(CN_PERSON), false, 1, 200, new System.Object[]{message}, "Dispensing Provider");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 167}, "Substitution Status");
       this.add(typeof(CQ_QUANTITY), false, 1, 10, new System.Object[]{message}, "Total Daily Dose");
       this.add(typeof(CM_LA1), false, 1, 12, new System.Object[]{message}, "Deliver-to location");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "Needs Human Review");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Pharmacy Special Dispensing Instructions");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Dispense Sub-ID Counter(RXD-1).
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
	* Returns Dispense / give code(RXD-2).
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
	* Returns Date / time dispensed(RXD-3).
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
	* Returns Actual Dispense Amount(RXD-4).
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
	* Returns Actual Dispense Units(RXD-5).
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
	* Returns Actual Dosage Form(RXD-6).
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
	* Returns Prescription Number(RXD-7).
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
	* Returns Number of Refills Remaining(RXD-8).
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
	* Returns a single repetition of Dispense Notes(RXD-9).
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
	* Returns Dispensing Provider(RXD-10).
	*/
	public CN_PERSON DispensingProvider
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (CN_PERSON)t;
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
	* Returns Substitution Status(RXD-11).
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
	* Returns Total Daily Dose(RXD-12).
	*/
	public CQ_QUANTITY TotalDailyDose
	{
		get{
			CQ_QUANTITY ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (CQ_QUANTITY)t;
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
	* Returns Deliver-to location(RXD-13).
	*/
	public CM_LA1 DeliverToLocation
	{
		get{
			CM_LA1 ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Needs Human Review(RXD-14).
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
	* Returns Pharmacy Special Dispensing Instructions(RXD-15).
	*/
	public CE PharmacySpecialDispensingInstructions
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(15, 0);
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


}}