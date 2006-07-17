using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 PV1 message segment. 
 * This segment has the following fields:</p><p>
 * PV1-1: SET ID - PATIENT VISIT (SI)<br> 
 * PV1-2: PATIENT CLASS (ID)<br> 
 * PV1-3: ASSIGNED PATIENT LOCATION (ID)<br> 
 * PV1-4: ADMISSION TYPE (ID)<br> 
 * PV1-5: PRE-ADMIT NUMBER (ST)<br> 
 * PV1-6: PRIOR PATIENT LOCATION (ID)<br> 
 * PV1-7: ATTENDING DOCTOR (CN)<br> 
 * PV1-8: REFERRING DOCTOR (CN)<br> 
 * PV1-9: CONSULTING DOCTOR (CN)<br> 
 * PV1-10: HOSPITAL SERVICE (ID)<br> 
 * PV1-11: TEMPORARY LOCATION (ID)<br> 
 * PV1-12: PRE-ADMIT TEST INDICATOR (ID)<br> 
 * PV1-13: RE-ADMISSION INDICATOR (ID)<br> 
 * PV1-14: ADMIT SOURCE (ID)<br> 
 * PV1-15: AMBULATORY STATUS (ID)<br> 
 * PV1-16: VIP INDICATOR (ID)<br> 
 * PV1-17: ADMITTING DOCTOR (CN)<br> 
 * PV1-18: PATIENT TYPE (ID)<br> 
 * PV1-19: VISIT NUMBER (NM)<br> 
 * PV1-20: FINANCIAL CLASS (ID)<br> 
 * PV1-21: CHARGE PRICE INDICATOR (ID)<br> 
 * PV1-22: COURTESY CODE (ID)<br> 
 * PV1-23: CREDIT RATING (ID)<br> 
 * PV1-24: CONTRACT CODE (ID)<br> 
 * PV1-25: CONTRACT EFFECTIVE DATE (DT)<br> 
 * PV1-26: CONTRACT AMOUNT (NM)<br> 
 * PV1-27: CONTRACT PERIOD (NM)<br> 
 * PV1-28: INTEREST CODE (ID)<br> 
 * PV1-29: TRANSFER TO BAD DEBT CODE (ID)<br> 
 * PV1-30: TRANSFER TO BAD DEBT DATE (DT)<br> 
 * PV1-31: BAD DEBT AGENCY CODE (ST)<br> 
 * PV1-32: BAD DEBT TRANSFER AMOUNT (NM)<br> 
 * PV1-33: BAD DEBT RECOVERY AMOUNT (NM)<br> 
 * PV1-34: DELETE ACCOUNT INDICATOR (ID)<br> 
 * PV1-35: DELETE ACCOUNT DATE (DT)<br> 
 * PV1-36: DISCHARGE DISPOSITION (ID)<br> 
 * PV1-37: DISCHARGED TO LOCATION (ID)<br> 
 * PV1-38: DIET TYPE (ID)<br> 
 * PV1-39: SERVICING FACILITY (ID)<br> 
 * PV1-40: BED STATUS (ID)<br> 
 * PV1-41: ACCOUNT STATUS (ID)<br> 
 * PV1-42: PENDING LOCATION (ID)<br> 
 * PV1-43: PRIOR TEMPORARY LOCATION (ID)<br> 
 * PV1-44: ADMIT DATE/TIME (TS)<br> 
 * PV1-45: DISCHARGE DATE/TIME (TS)<br> 
 * PV1-46: CURRENT PATIENT BALANCE (NM)<br> 
 * PV1-47: TOTAL CHARGES (NM)<br> 
 * PV1-48: TOTAL ADJUSTMENTS (NM)<br> 
 * PV1-49: TOTAL PAYMENTS (NM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class PV1 : AbstractSegment  {

  /**
   * Creates a PV1 (PATIENT VISIT) segment object that belongs to the given 
   * message.  
   */
  public PV1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - PATIENT VISIT");
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 4}, "PATIENT CLASS");
       this.add(typeof(ID), true, 1, 12, new System.Object[]{message, 79}, "ASSIGNED PATIENT LOCATION");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 7}, "ADMISSION TYPE");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "PRE-ADMIT NUMBER");
       this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79}, "PRIOR PATIENT LOCATION");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "ATTENDING DOCTOR");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "REFERRING DOCTOR");
       this.add(typeof(CN), false, 0, 60, new System.Object[]{message}, "CONSULTING DOCTOR");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 69}, "HOSPITAL SERVICE");
       this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79}, "TEMPORARY LOCATION");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 87}, "PRE-ADMIT TEST INDICATOR");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 92}, "RE-ADMISSION INDICATOR");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 23}, "ADMIT SOURCE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 9}, "AMBULATORY STATUS");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 99}, "VIP INDICATOR");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "ADMITTING DOCTOR");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18}, "PATIENT TYPE");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "VISIT NUMBER");
       this.add(typeof(ID), false, 4, 11, new System.Object[]{message, 64}, "FINANCIAL CLASS");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 32}, "CHARGE PRICE INDICATOR");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 45}, "COURTESY CODE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 46}, "CREDIT RATING");
       this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 44}, "CONTRACT CODE");
       this.add(typeof(DT), false, 0, 8, new System.Object[]{message}, "CONTRACT EFFECTIVE DATE");
       this.add(typeof(NM), false, 0, 12, new System.Object[]{message}, "CONTRACT AMOUNT");
       this.add(typeof(NM), false, 0, 3, new System.Object[]{message}, "CONTRACT PERIOD");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 73}, "INTEREST CODE");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 110}, "TRANSFER TO BAD DEBT CODE");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "TRANSFER TO BAD DEBT DATE");
       this.add(typeof(ST), false, 1, 10, new System.Object[]{message}, "BAD DEBT AGENCY CODE");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "BAD DEBT TRANSFER AMOUNT");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "BAD DEBT RECOVERY AMOUNT");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 111}, "DELETE ACCOUNT INDICATOR");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "DELETE ACCOUNT DATE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 112}, "DISCHARGE DISPOSITION");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 113}, "DISCHARGED TO LOCATION");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 114}, "DIET TYPE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 115}, "SERVICING FACILITY");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 116}, "BED STATUS");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 117}, "ACCOUNT STATUS");
       this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79}, "PENDING LOCATION");
       this.add(typeof(ID), false, 1, 12, new System.Object[]{message, 79}, "PRIOR TEMPORARY LOCATION");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "ADMIT DATE/TIME");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "DISCHARGE DATE/TIME");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "CURRENT PATIENT BALANCE");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "TOTAL CHARGES");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "TOTAL ADJUSTMENTS");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "TOTAL PAYMENTS");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns SET ID - PATIENT VISIT(PV1-1).
	*/
	public SI SETIDPATIENTVISIT
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
	* Returns PATIENT CLASS(PV1-2).
	*/
	public ID PATIENTCLASS
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns ASSIGNED PATIENT LOCATION(PV1-3).
	*/
	public ID ASSIGNEDPATIENTLOCATION
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
	* Returns ADMISSION TYPE(PV1-4).
	*/
	public ID ADMISSIONTYPE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns PRE-ADMIT NUMBER(PV1-5).
	*/
	public ST PREADMITNUMBER
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
	* Returns PRIOR PATIENT LOCATION(PV1-6).
	*/
	public ID PRIORPATIENTLOCATION
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns ATTENDING DOCTOR(PV1-7).
	*/
	public CN ATTENDINGDOCTOR
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns REFERRING DOCTOR(PV1-8).
	*/
	public CN REFERRINGDOCTOR
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns a single repetition of CONSULTING DOCTOR(PV1-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CN getCONSULTINGDOCTOR(int rep)
	{
			CN ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (CN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of CONSULTING DOCTOR (PV1-9).
   */
  public CN[] getCONSULTINGDOCTOR() {
     CN[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new CN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
	* Returns HOSPITAL SERVICE(PV1-10).
	*/
	public ID HOSPITALSERVICE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns TEMPORARY LOCATION(PV1-11).
	*/
	public ID TEMPORARYLOCATION
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
	* Returns PRE-ADMIT TEST INDICATOR(PV1-12).
	*/
	public ID PREADMITTESTINDICATOR
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
	* Returns RE-ADMISSION INDICATOR(PV1-13).
	*/
	public ID READMISSIONINDICATOR
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
	* Returns ADMIT SOURCE(PV1-14).
	*/
	public ID ADMITSOURCE
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
	* Returns AMBULATORY STATUS(PV1-15).
	*/
	public ID AMBULATORYSTATUS
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns VIP INDICATOR(PV1-16).
	*/
	public ID VIPINDICATOR
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns ADMITTING DOCTOR(PV1-17).
	*/
	public CN ADMITTINGDOCTOR
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns PATIENT TYPE(PV1-18).
	*/
	public ID PATIENTTYPE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns VISIT NUMBER(PV1-19).
	*/
	public NM VISITNUMBER
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns a single repetition of FINANCIAL CLASS(PV1-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getFINANCIALCLASS(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(20, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of FINANCIAL CLASS (PV1-20).
   */
  public ID[] getFINANCIALCLASS() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(20);  
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
	* Returns CHARGE PRICE INDICATOR(PV1-21).
	*/
	public ID CHARGEPRICEINDICATOR
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns COURTESY CODE(PV1-22).
	*/
	public ID COURTESYCODE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns CREDIT RATING(PV1-23).
	*/
	public ID CREDITRATING
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns a single repetition of CONTRACT CODE(PV1-24).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getCONTRACTCODE(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(24, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of CONTRACT CODE (PV1-24).
   */
  public ID[] getCONTRACTCODE() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(24);  
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
	* Returns a single repetition of CONTRACT EFFECTIVE DATE(PV1-25).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public DT getCONTRACTEFFECTIVEDATE(int rep)
	{
			DT ret = null;
			try
			{
			Type t = this.getField(25, rep);
				ret = (DT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of CONTRACT EFFECTIVE DATE (PV1-25).
   */
  public DT[] getCONTRACTEFFECTIVEDATE() {
     DT[] ret = null;
    try {
        Type[] t = this.getField(25);  
        ret = new DT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (DT)t[i];
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
	* Returns a single repetition of CONTRACT AMOUNT(PV1-26).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public NM getCONTRACTAMOUNT(int rep)
	{
			NM ret = null;
			try
			{
			Type t = this.getField(26, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of CONTRACT AMOUNT (PV1-26).
   */
  public NM[] getCONTRACTAMOUNT() {
     NM[] ret = null;
    try {
        Type[] t = this.getField(26);  
        ret = new NM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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
	* Returns a single repetition of CONTRACT PERIOD(PV1-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public NM getCONTRACTPERIOD(int rep)
	{
			NM ret = null;
			try
			{
			Type t = this.getField(27, rep);
				ret = (NM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of CONTRACT PERIOD (PV1-27).
   */
  public NM[] getCONTRACTPERIOD() {
     NM[] ret = null;
    try {
        Type[] t = this.getField(27);  
        ret = new NM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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
	* Returns INTEREST CODE(PV1-28).
	*/
	public ID INTERESTCODE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(28, 0);
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
	* Returns TRANSFER TO BAD DEBT CODE(PV1-29).
	*/
	public ID TRANSFERTOBADDEBTCODE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(29, 0);
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
	* Returns TRANSFER TO BAD DEBT DATE(PV1-30).
	*/
	public DT TRANSFERTOBADDEBTDATE
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(30, 0);
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
	* Returns BAD DEBT AGENCY CODE(PV1-31).
	*/
	public ST BADDEBTAGENCYCODE
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(31, 0);
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
	* Returns BAD DEBT TRANSFER AMOUNT(PV1-32).
	*/
	public NM BADDEBTTRANSFERAMOUNT
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(32, 0);
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
	* Returns BAD DEBT RECOVERY AMOUNT(PV1-33).
	*/
	public NM BADDEBTRECOVERYAMOUNT
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
	* Returns DELETE ACCOUNT INDICATOR(PV1-34).
	*/
	public ID DELETEACCOUNTINDICATOR
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(34, 0);
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
	* Returns DELETE ACCOUNT DATE(PV1-35).
	*/
	public DT DELETEACCOUNTDATE
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(35, 0);
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
	* Returns DISCHARGE DISPOSITION(PV1-36).
	*/
	public ID DISCHARGEDISPOSITION
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
	* Returns DISCHARGED TO LOCATION(PV1-37).
	*/
	public ID DISCHARGEDTOLOCATION
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(37, 0);
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
	* Returns DIET TYPE(PV1-38).
	*/
	public ID DIETTYPE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(38, 0);
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
	* Returns SERVICING FACILITY(PV1-39).
	*/
	public ID SERVICINGFACILITY
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(39, 0);
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
	* Returns BED STATUS(PV1-40).
	*/
	public ID BEDSTATUS
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns ACCOUNT STATUS(PV1-41).
	*/
	public ID ACCOUNTSTATUS
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns PENDING LOCATION(PV1-42).
	*/
	public ID PENDINGLOCATION
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(42, 0);
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
	* Returns PRIOR TEMPORARY LOCATION(PV1-43).
	*/
	public ID PRIORTEMPORARYLOCATION
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(43, 0);
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
	* Returns ADMIT DATE/TIME(PV1-44).
	*/
	public TS ADMITDATETIME
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(44, 0);
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
	* Returns DISCHARGE DATE/TIME(PV1-45).
	*/
	public TS DISCHARGEDATETIME
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(45, 0);
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
	* Returns CURRENT PATIENT BALANCE(PV1-46).
	*/
	public NM CURRENTPATIENTBALANCE
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(46, 0);
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
	* Returns TOTAL CHARGES(PV1-47).
	*/
	public NM TOTALCHARGES
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(47, 0);
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
	* Returns TOTAL ADJUSTMENTS(PV1-48).
	*/
	public NM TOTALADJUSTMENTS
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(48, 0);
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
	* Returns TOTAL PAYMENTS(PV1-49).
	*/
	public NM TOTALPAYMENTS
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(49, 0);
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


}}