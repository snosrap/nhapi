using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 UB1 message segment. 
 * This segment has the following fields:</p><p>
 * UB1-1: Set ID - UB82 (SI)<br> 
 * UB1-2: Blood deductible (43) (NM)<br> 
 * UB1-3: Blood furnished pints of (40) (NM)<br> 
 * UB1-4: Blood replaced pints (41) (NM)<br> 
 * UB1-5: Blood not replaced pints (42) (NM)<br> 
 * UB1-6: Co-insurance days (25) (NM)<br> 
 * UB1-7: Condition code (35-39) (ID)<br> 
 * UB1-8: Covered days (23) (NM)<br> 
 * UB1-9: Non-covered days (24) (NM)<br> 
 * UB1-10: Value amount and code (46-49) (CM_UVC)<br> 
 * UB1-11: Number of grace days (90) (NM)<br> 
 * UB1-12: Special program indicator (44) (ID)<br> 
 * UB1-13: PSRO / UR approval indicator (87) (ID)<br> 
 * UB1-14: PSRO / UR approved stay - from (88) (DT)<br> 
 * UB1-15: PSRO / UR approved stay - to (89) (DT)<br> 
 * UB1-16: Occurrence (28-32) (CM_OCD)<br> 
 * UB1-17: Occurrence span (33) (ID)<br> 
 * UB1-18: Occurrence span start date (33) (DT)<br> 
 * UB1-19: Occurrence span end date (33) (DT)<br> 
 * UB1-20: UB-82 locator 2 (ST)<br> 
 * UB1-21: UB-82 locator 9 (ST)<br> 
 * UB1-22: UB-82 locator 27 (ST)<br> 
 * UB1-23: UB-82 locator 45 (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class UB1 : AbstractSegment  {

  /**
   * Creates a UB1 (UB82 DATA) segment object that belongs to the given 
   * message.  
   */
  public UB1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - UB82");
       this.add(typeof(NM), false, 1, 1, new System.Object[]{message}, "Blood deductible (43)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood furnished pints of (40)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood replaced pints (41)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood not replaced pints (42)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Co-insurance days (25)");
       this.add(typeof(ID), false, 5, 2, new System.Object[]{message, 43}, "Condition code (35-39)");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Covered days (23)");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Non-covered days (24)");
       this.add(typeof(CM_UVC), false, 8, 12, new System.Object[]{message}, "Value amount and code (46-49)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Number of grace days (90)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Special program indicator (44)");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "PSRO / UR approval indicator (87)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO / UR approved stay - from (88)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO / UR approved stay - to (89)");
       this.add(typeof(CM_OCD), false, 5, 20, new System.Object[]{message}, "Occurrence (28-32)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Occurrence span (33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Occurrence span start date (33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Occurrence span end date (33)");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "UB-82 locator 2");
       this.add(typeof(ST), false, 1, 7, new System.Object[]{message}, "UB-82 locator 9");
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message}, "UB-82 locator 27");
       this.add(typeof(ST), false, 1, 17, new System.Object[]{message}, "UB-82 locator 45");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - UB82(UB1-1).
	*/
	public SI SetIDUB82
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
	* Returns Blood deductible (43)(UB1-2).
	*/
	public NM BloodDeductible
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Blood furnished pints of (40)(UB1-3).
	*/
	public NM BloodFurnishedPintsOf
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
	* Returns Blood replaced pints (41)(UB1-4).
	*/
	public NM BloodReplacedPints
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
	* Returns Blood not replaced pints (42)(UB1-5).
	*/
	public NM BloodNotReplacedPints
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
	* Returns Co-insurance days (25)(UB1-6).
	*/
	public NM CoInsuranceDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns a single repetition of Condition code (35-39)(UB1-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getConditionCode3539(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Condition code (35-39) (UB1-7).
   */
  public ID[] getConditionCode3539() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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
	* Returns Covered days (23)(UB1-8).
	*/
	public NM CoveredDays
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
	* Returns Non-covered days (24)(UB1-9).
	*/
	public NM NonCoveredDays
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
	* Returns a single repetition of Value amount and code (46-49)(UB1-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_UVC getValueAmountAndCode4649(int rep)
	{
			CM_UVC ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (CM_UVC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Value amount and code (46-49) (UB1-10).
   */
  public CM_UVC[] getValueAmountAndCode4649() {
     CM_UVC[] ret = null;
    try {
        Type[] t = this.getField(10);  
        ret = new CM_UVC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_UVC)t[i];
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
	* Returns Number of grace days (90)(UB1-11).
	*/
	public NM NumberOfGraceDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Special program indicator (44)(UB1-12).
	*/
	public ID SpecialProgramIndicator
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
	* Returns PSRO / UR approval indicator (87)(UB1-13).
	*/
	public ID PSROURApprovalIndicator
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns PSRO / UR approved stay - from (88)(UB1-14).
	*/
	public DT PSROURApprovedStayFrom
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (DT)t;
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
	* Returns PSRO / UR approved stay - to (89)(UB1-15).
	*/
	public DT PSROURApprovedStayTo
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (DT)t;
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
	* Returns a single repetition of Occurrence (28-32)(UB1-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_OCD getOccurrence2832(int rep)
	{
			CM_OCD ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (CM_OCD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Occurrence (28-32) (UB1-16).
   */
  public CM_OCD[] getOccurrence2832() {
     CM_OCD[] ret = null;
    try {
        Type[] t = this.getField(16);  
        ret = new CM_OCD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_OCD)t[i];
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
	* Returns Occurrence span (33)(UB1-17).
	*/
	public ID OccurrenceSpan
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Occurrence span start date (33)(UB1-18).
	*/
	public DT OccurrenceSpanStartDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (DT)t;
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
	* Returns Occurrence span end date (33)(UB1-19).
	*/
	public DT OccurrenceSpanEndDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (DT)t;
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
	* Returns UB-82 locator 2(UB1-20).
	*/
	public ST UB82Locator2
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns UB-82 locator 9(UB1-21).
	*/
	public ST UB82Locator9
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns UB-82 locator 27(UB1-22).
	*/
	public ST UB82Locator27
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
	* Returns UB-82 locator 45(UB1-23).
	*/
	public ST UB82Locator45
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


}}