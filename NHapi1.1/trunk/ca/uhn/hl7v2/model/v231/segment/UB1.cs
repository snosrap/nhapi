using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v231.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v231.segment{

/**
 * <p>Represents an HL7 UB1 message segment. 
 * This segment has the following fields:</p><p>
 * UB1-1: Set ID - UB1 (SI)<br> 
 * UB1-2: Blood Deductible  (43) (NM)<br> 
 * UB1-3: Blood Furnished-Pints Of (40) (NM)<br> 
 * UB1-4: Blood Replaced-Pints (41) (NM)<br> 
 * UB1-5: Blood Not Replaced-Pints(42) (NM)<br> 
 * UB1-6: Co-Insurance Days (25) (NM)<br> 
 * UB1-7: Condition Code (35-39) (IS)<br> 
 * UB1-8: Covered Days - (23) (NM)<br> 
 * UB1-9: Non Covered Days - (24) (NM)<br> 
 * UB1-10: Value Amount & Code (46-49) (UVC)<br> 
 * UB1-11: Number Of Grace Days (90) (NM)<br> 
 * UB1-12: Special Program Indicator (44) (CE)<br> 
 * UB1-13: PSRO/UR Approval Indicator (87) (CE)<br> 
 * UB1-14: PSRO/UR Approved Stay-Fm (88) (DT)<br> 
 * UB1-15: PSRO/UR Approved Stay-To (89) (DT)<br> 
 * UB1-16: Occurrence (28-32) (OCD)<br> 
 * UB1-17: Occurrence Span (33) (CE)<br> 
 * UB1-18: Occur Span Start Date(33) (DT)<br> 
 * UB1-19: Occur Span End Date (33) (DT)<br> 
 * UB1-20: UB-82 Locator 2 (ST)<br> 
 * UB1-21: UB-82 Locator 9 (ST)<br> 
 * UB1-22: UB-82 Locator 27 (ST)<br> 
 * UB1-23: UB-82 Locator 45 (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class UB1 : AbstractSegment  {

  /**
   * Creates a UB1 (UB1 - UB82 data segment) segment object that belongs to the given 
   * message.  
   */
  public UB1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - UB1");
       this.add(typeof(NM), false, 1, 1, new System.Object[]{message}, "Blood Deductible  (43)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood Furnished-Pints Of (40)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood Replaced-Pints (41)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Blood Not Replaced-Pints(42)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Co-Insurance Days (25)");
       this.add(typeof(IS), false, 5, 14, new System.Object[]{message, 43}, "Condition Code (35-39)");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Covered Days - (23)");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Non Covered Days - (24)");
       this.add(typeof(UVC), false, 8, 12, new System.Object[]{message}, "Value Amount & Code (46-49)");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Number Of Grace Days (90)");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Special Program Indicator (44)");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "PSRO/UR Approval Indicator (87)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO/UR Approved Stay-Fm (88)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO/UR Approved Stay-To (89)");
       this.add(typeof(OCD), false, 5, 20, new System.Object[]{message}, "Occurrence (28-32)");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Occurrence Span (33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Occur Span Start Date(33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Occur Span End Date (33)");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "UB-82 Locator 2");
       this.add(typeof(ST), false, 1, 7, new System.Object[]{message}, "UB-82 Locator 9");
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message}, "UB-82 Locator 27");
       this.add(typeof(ST), false, 1, 17, new System.Object[]{message}, "UB-82 Locator 45");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - UB1(UB1-1).
	*/
	public SI SetIDUB1
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
	* Returns Blood Deductible  (43)(UB1-2).
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
	* Returns Blood Furnished-Pints Of (40)(UB1-3).
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
	* Returns Blood Replaced-Pints (41)(UB1-4).
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
	* Returns Blood Not Replaced-Pints(42)(UB1-5).
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
	* Returns Co-Insurance Days (25)(UB1-6).
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
	* Returns a single repetition of Condition Code (35-39)(UB1-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getConditionCode3539(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Condition Code (35-39) (UB1-7).
   */
  public IS[] getConditionCode3539() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new IS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (IS)t[i];
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
	* Returns Covered Days - (23)(UB1-8).
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
	* Returns Non Covered Days - (24)(UB1-9).
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
	* Returns a single repetition of Value Amount & Code (46-49)(UB1-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public UVC getValueAmountCode4649(int rep)
	{
			UVC ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (UVC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Value Amount & Code (46-49) (UB1-10).
   */
  public UVC[] getValueAmountCode4649() {
     UVC[] ret = null;
    try {
        Type[] t = this.getField(10);  
        ret = new UVC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (UVC)t[i];
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
	* Returns Number Of Grace Days (90)(UB1-11).
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
	* Returns Special Program Indicator (44)(UB1-12).
	*/
	public CE SpecialProgramIndicator
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns PSRO/UR Approval Indicator (87)(UB1-13).
	*/
	public CE PSROURApprovalIndicator
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
	* Returns PSRO/UR Approved Stay-Fm (88)(UB1-14).
	*/
	public DT PSROURApprovedStayFm
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
	* Returns PSRO/UR Approved Stay-To (89)(UB1-15).
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
	public OCD getOccurrence2832(int rep)
	{
			OCD ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (OCD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Occurrence (28-32) (UB1-16).
   */
  public OCD[] getOccurrence2832() {
     OCD[] ret = null;
    try {
        Type[] t = this.getField(16);  
        ret = new OCD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (OCD)t[i];
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
	* Returns Occurrence Span (33)(UB1-17).
	*/
	public CE OccurrenceSpan
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
	* Returns Occur Span Start Date(33)(UB1-18).
	*/
	public DT OccurSpanStartDate
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
	* Returns Occur Span End Date (33)(UB1-19).
	*/
	public DT OccurSpanEndDate
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
	* Returns UB-82 Locator 2(UB1-20).
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
	* Returns UB-82 Locator 9(UB1-21).
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
	* Returns UB-82 Locator 27(UB1-22).
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
	* Returns UB-82 Locator 45(UB1-23).
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