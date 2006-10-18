using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 UB1 message segment. 
 * This segment has the following fields:</p><p>
 * UB1-1: SET ID - UB82 (SI)<br> 
 * UB1-2: BLOOD DEDUCTIBLE (ST)<br> 
 * UB1-3: BLOOD FURN.-PINTS OF (40) (ST)<br> 
 * UB1-4: BLOOD REPLACED-PINTS (41) (ST)<br> 
 * UB1-5: BLOOD NOT RPLCD-PINTS(42) (ST)<br> 
 * UB1-6: CO-INSURANCE DAYS (25) (ST)<br> 
 * UB1-7: CONDITION CODE (ID)<br> 
 * UB1-8: COVERED DAYS - (23) (ST)<br> 
 * UB1-9: NON COVERED DAYS - (24) (ST)<br> 
 * UB1-10: VALUE AMOUNT & CODE (CM)<br> 
 * UB1-11: NUMBER OF GRACE DAYS (90) (ST)<br> 
 * UB1-12: SPEC. PROG. INDICATOR(44) (ID)<br> 
 * UB1-13: PSRO/UR APPROVAL IND. (87) (ID)<br> 
 * UB1-14: PSRO/UR APRVD STAY-FM(88) (DT)<br> 
 * UB1-15: PSRO/UR APRVD STAY-TO(89) (DT)<br> 
 * UB1-16: OCCURRENCE (28-32) (ID)<br> 
 * UB1-17: OCCURRENCE SPAN (33) (ID)<br> 
 * UB1-18: OCCURRENCE SPAN START DATE(33) (DT)<br> 
 * UB1-19: OCCUR. SPAN END DATE (33) (DT)<br> 
 * UB1-20: UB-82 LOCATOR 2 (ST)<br> 
 * UB1-21: UB-82 LOCATOR 9 (ST)<br> 
 * UB1-22: UB-82 LOCATOR 27 (ST)<br> 
 * UB1-23: UB-82 LOCATOR 45 (ST)<br> 
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
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - UB82");
       this.add(typeof(ST), false, 1, 1, new System.Object[]{message}, "BLOOD DEDUCTIBLE");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "BLOOD FURN.-PINTS OF (40)");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "BLOOD REPLACED-PINTS (41)");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "BLOOD NOT RPLCD-PINTS(42)");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "CO-INSURANCE DAYS (25)");
       this.add(typeof(ID), false, 5, 2, new System.Object[]{message, 43}, "CONDITION CODE");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "COVERED DAYS - (23)");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "NON COVERED DAYS - (24)");
       this.add(typeof(CM), false, 8, 12, new System.Object[]{message}, "VALUE AMOUNT & CODE");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "NUMBER OF GRACE DAYS (90)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "SPEC. PROG. INDICATOR(44)");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "PSRO/UR APPROVAL IND. (87)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO/UR APRVD STAY-FM(88)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PSRO/UR APRVD STAY-TO(89)");
       this.add(typeof(ID), false, 5, 20, new System.Object[]{message, 0}, "OCCURRENCE (28-32)");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "OCCURRENCE SPAN (33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "OCCURRENCE SPAN START DATE(33)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "OCCUR. SPAN END DATE (33)");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "UB-82 LOCATOR 2");
       this.add(typeof(ST), false, 1, 7, new System.Object[]{message}, "UB-82 LOCATOR 9");
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message}, "UB-82 LOCATOR 27");
       this.add(typeof(ST), false, 1, 17, new System.Object[]{message}, "UB-82 LOCATOR 45");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns SET ID - UB82(UB1-1).
	*/
	public SI SETIDUB82
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
	* Returns BLOOD DEDUCTIBLE(UB1-2).
	*/
	public ST BLOODDEDUCTIBLE
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
	* Returns BLOOD FURN.-PINTS OF (40)(UB1-3).
	*/
	public ST BLOODFURNPINTSOF
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
	* Returns BLOOD REPLACED-PINTS (41)(UB1-4).
	*/
	public ST BLOODREPLACEDPINTS
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns BLOOD NOT RPLCD-PINTS(42)(UB1-5).
	*/
	public ST BLOODNOTRPLCDPINTS
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns CO-INSURANCE DAYS (25)(UB1-6).
	*/
	public ST COINSURANCEDAYS
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns a single repetition of CONDITION CODE(UB1-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getCONDITIONCODE(int rep)
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
   * Returns all repetitions of CONDITION CODE (UB1-7).
   */
  public ID[] getCONDITIONCODE() {
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
	* Returns COVERED DAYS - (23)(UB1-8).
	*/
	public ST COVEREDDAYS
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
	* Returns NON COVERED DAYS - (24)(UB1-9).
	*/
	public ST NONCOVEREDDAYS
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
	* Returns a single repetition of VALUE AMOUNT & CODE(UB1-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM getVALUEAMOUNTCODE(int rep)
	{
			CM ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (CM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of VALUE AMOUNT & CODE (UB1-10).
   */
  public CM[] getVALUEAMOUNTCODE() {
     CM[] ret = null;
    try {
        Type[] t = this.getField(10);  
        ret = new CM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM)t[i];
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
	* Returns NUMBER OF GRACE DAYS (90)(UB1-11).
	*/
	public ST NUMBEROFGRACEDAYS
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns SPEC. PROG. INDICATOR(44)(UB1-12).
	*/
	public ID SPECPROGINDICATOR
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
	* Returns PSRO/UR APPROVAL IND. (87)(UB1-13).
	*/
	public ID PSROURAPPROVALIND
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
	* Returns PSRO/UR APRVD STAY-FM(88)(UB1-14).
	*/
	public DT PSROURAPRVDSTAYFM
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
	* Returns PSRO/UR APRVD STAY-TO(89)(UB1-15).
	*/
	public DT PSROURAPRVDSTAYTO
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
	* Returns a single repetition of OCCURRENCE (28-32)(UB1-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getOCCURRENCE2832(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of OCCURRENCE (28-32) (UB1-16).
   */
  public ID[] getOCCURRENCE2832() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(16);  
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
	* Returns OCCURRENCE SPAN (33)(UB1-17).
	*/
	public ID OCCURRENCESPAN
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
	* Returns OCCURRENCE SPAN START DATE(33)(UB1-18).
	*/
	public DT OCCURRENCESPANSTARTDATE
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
	* Returns OCCUR. SPAN END DATE (33)(UB1-19).
	*/
	public DT OCCURSPANENDDATE
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
	* Returns UB-82 LOCATOR 2(UB1-20).
	*/
	public ST UB82LOCATOR2
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
	* Returns UB-82 LOCATOR 9(UB1-21).
	*/
	public ST UB82LOCATOR9
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
	* Returns UB-82 LOCATOR 27(UB1-22).
	*/
	public ST UB82LOCATOR27
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
	* Returns UB-82 LOCATOR 45(UB1-23).
	*/
	public ST UB82LOCATOR45
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