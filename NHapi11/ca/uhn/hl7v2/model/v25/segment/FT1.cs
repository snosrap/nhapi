using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 FT1 message segment. 
 * This segment has the following fields:</p><p>
 * FT1-1: Set ID - FT1 (SI)<br> 
 * FT1-2: Transaction ID (ST)<br> 
 * FT1-3: Transaction Batch ID (ST)<br> 
 * FT1-4: Transaction Date (DR)<br> 
 * FT1-5: Transaction Posting Date (TS)<br> 
 * FT1-6: Transaction Type (IS)<br> 
 * FT1-7: Transaction Code (CE)<br> 
 * FT1-8: Transaction Description (ST)<br> 
 * FT1-9: Transaction Description - Alt (ST)<br> 
 * FT1-10: Transaction Quantity (NM)<br> 
 * FT1-11: Transaction Amount - Extended (CP)<br> 
 * FT1-12: Transaction Amount - Unit (CP)<br> 
 * FT1-13: Department Code (CE)<br> 
 * FT1-14: Insurance Plan ID (CE)<br> 
 * FT1-15: Insurance Amount (CP)<br> 
 * FT1-16: Assigned Patient Location (PL)<br> 
 * FT1-17: Fee Schedule (IS)<br> 
 * FT1-18: Patient Type (IS)<br> 
 * FT1-19: Diagnosis Code - FT1 (CE)<br> 
 * FT1-20: Performed By Code (XCN)<br> 
 * FT1-21: Ordered By Code (XCN)<br> 
 * FT1-22: Unit Cost (CP)<br> 
 * FT1-23: Filler Order Number (EI)<br> 
 * FT1-24: Entered By Code (XCN)<br> 
 * FT1-25: Procedure Code (CE)<br> 
 * FT1-26: Procedure Code Modifier (CE)<br> 
 * FT1-27: Advanced Beneficiary Notice Code (CE)<br> 
 * FT1-28: Medically Necessary Duplicate Procedure Reason. (CWE)<br> 
 * FT1-29: NDC Code (CNE)<br> 
 * FT1-30: Payment Reference ID (CX)<br> 
 * FT1-31: Transaction Reference Key (SI)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class FT1 : AbstractSegment  {

  /**
   * Creates a FT1 (Financial Transaction) segment object that belongs to the given 
   * message.  
   */
  public FT1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - FT1");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Transaction ID");
       this.add(typeof(ST), false, 1, 10, new System.Object[]{message}, "Transaction Batch ID");
       this.add(typeof(DR), true, 1, 53, new System.Object[]{message}, "Transaction Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Transaction Posting Date");
       this.add(typeof(IS), true, 1, 8, new System.Object[]{message, 17}, "Transaction Type");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Transaction Code");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Transaction Description");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Transaction Description - Alt");
       this.add(typeof(NM), false, 1, 6, new System.Object[]{message}, "Transaction Quantity");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Transaction Amount - Extended");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Transaction Amount - Unit");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Department Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Insurance Plan ID");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Insurance Amount");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Assigned Patient Location");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 24}, "Fee Schedule");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 18}, "Patient Type");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Diagnosis Code - FT1");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Performed By Code");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Ordered By Code");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Unit Cost");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Filler Order Number");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Entered By Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Procedure Code");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Procedure Code Modifier");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Advanced Beneficiary Notice Code");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Medically Necessary Duplicate Procedure Reason.");
       this.add(typeof(CNE), false, 1, 250, new System.Object[]{message}, "NDC Code");
       this.add(typeof(CX), false, 1, 250, new System.Object[]{message}, "Payment Reference ID");
       this.add(typeof(SI), false, 0, 4, new System.Object[]{message}, "Transaction Reference Key");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - FT1(FT1-1).
	*/
	public SI SetIDFT1
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
	* Returns Transaction ID(FT1-2).
	*/
	public ST TransactionID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Transaction Batch ID(FT1-3).
	*/
	public ST TransactionBatchID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Transaction Date(FT1-4).
	*/
	public DR TransactionDate
	{
		get{
			DR ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (DR)t;
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
	* Returns Transaction Posting Date(FT1-5).
	*/
	public TS TransactionPostingDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Transaction Type(FT1-6).
	*/
	public IS TransactionType
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (IS)t;
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
	* Returns Transaction Code(FT1-7).
	*/
	public CE TransactionCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Transaction Description(FT1-8).
	*/
	public ST TransactionDescription
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Transaction Description - Alt(FT1-9).
	*/
	public ST TransactionDescriptionAlt
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Transaction Quantity(FT1-10).
	*/
	public NM TransactionQuantity
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
	* Returns Transaction Amount - Extended(FT1-11).
	*/
	public CP TransactionAmountExtended
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CP)t;
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
	* Returns Transaction Amount - Unit(FT1-12).
	*/
	public CP TransactionAmountUnit
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (CP)t;
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
	* Returns Department Code(FT1-13).
	*/
	public CE DepartmentCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Insurance Plan ID(FT1-14).
	*/
	public CE InsurancePlanID
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns Insurance Amount(FT1-15).
	*/
	public CP InsuranceAmount
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (CP)t;
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
	* Returns Assigned Patient Location(FT1-16).
	*/
	public PL AssignedPatientLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns Fee Schedule(FT1-17).
	*/
	public IS FeeSchedule
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (IS)t;
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
	* Returns Patient Type(FT1-18).
	*/
	public IS PatientType
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (IS)t;
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
	* Returns a single repetition of Diagnosis Code - FT1(FT1-19).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getDiagnosisCodeFT1(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(19, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Diagnosis Code - FT1 (FT1-19).
   */
  public CE[] getDiagnosisCodeFT1() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(19);  
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
	* Returns a single repetition of Performed By Code(FT1-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getPerformedByCode(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(20, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Performed By Code (FT1-20).
   */
  public XCN[] getPerformedByCode() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(20);  
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
	* Returns a single repetition of Ordered By Code(FT1-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getOrderedByCode(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(21, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ordered By Code (FT1-21).
   */
  public XCN[] getOrderedByCode() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(21);  
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
	* Returns Unit Cost(FT1-22).
	*/
	public CP UnitCost
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(22, 0);
				ret = (CP)t;
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
	* Returns Filler Order Number(FT1-23).
	*/
	public EI FillerOrderNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns a single repetition of Entered By Code(FT1-24).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getEnteredByCode(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(24, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Entered By Code (FT1-24).
   */
  public XCN[] getEnteredByCode() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(24);  
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
	* Returns Procedure Code(FT1-25).
	*/
	public CE ProcedureCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns a single repetition of Procedure Code Modifier(FT1-26).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getProcedureCodeModifier(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(26, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Procedure Code Modifier (FT1-26).
   */
  public CE[] getProcedureCodeModifier() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(26);  
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
	* Returns Advanced Beneficiary Notice Code(FT1-27).
	*/
	public CE AdvancedBeneficiaryNoticeCode
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
	* Returns Medically Necessary Duplicate Procedure Reason.(FT1-28).
	*/
	public CWE MedicallyNecessaryDuplicateProcedureReason
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(28, 0);
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
	* Returns NDC Code(FT1-29).
	*/
	public CNE NDCCode
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(29, 0);
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
	* Returns Payment Reference ID(FT1-30).
	*/
	public CX PaymentReferenceID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(30, 0);
				ret = (CX)t;
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
	* Returns a single repetition of Transaction Reference Key(FT1-31).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public SI getTransactionReferenceKey(int rep)
	{
			SI ret = null;
			try
			{
			Type t = this.getField(31, rep);
				ret = (SI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Transaction Reference Key (FT1-31).
   */
  public SI[] getTransactionReferenceKey() {
     SI[] ret = null;
    try {
        Type[] t = this.getField(31);  
        ret = new SI[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (SI)t[i];
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


}}