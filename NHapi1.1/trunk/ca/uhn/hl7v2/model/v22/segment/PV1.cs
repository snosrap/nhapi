using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 PV1 message segment. 
 * This segment has the following fields:</p><p>
 * PV1-1: Set ID - Patient Visit (SI)<br> 
 * PV1-2: Patient Class (ID)<br> 
 * PV1-3: Assigned Patient Location (CM_INTERNAL_LOCATION)<br> 
 * PV1-4: Admission Type (ID)<br> 
 * PV1-5: Preadmit Number (ST)<br> 
 * PV1-6: Prior Patient Location (CM_INTERNAL_LOCATION)<br> 
 * PV1-7: Attending Doctor (CN_PHYSICIAN)<br> 
 * PV1-8: Referring Doctor (CN_PHYSICIAN)<br> 
 * PV1-9: Consulting Doctor (CN_PHYSICIAN)<br> 
 * PV1-10: Hospital Service (ID)<br> 
 * PV1-11: Temporary Location (CM_INTERNAL_LOCATION)<br> 
 * PV1-12: Preadmit Test Indicator (ID)<br> 
 * PV1-13: Readmission indicator (ID)<br> 
 * PV1-14: Admit Source (ID)<br> 
 * PV1-15: Ambulatory Status (ID)<br> 
 * PV1-16: VIP Indicator (ID)<br> 
 * PV1-17: Admitting Doctor (CN_PHYSICIAN)<br> 
 * PV1-18: Patient type (ID)<br> 
 * PV1-19: Visit Number (CM_PAT_ID)<br> 
 * PV1-20: Financial Class (CM_FINANCE)<br> 
 * PV1-21: Charge Price Indicator (ID)<br> 
 * PV1-22: Courtesy Code (ID)<br> 
 * PV1-23: Credit Rating (ID)<br> 
 * PV1-24: Contract Code (ID)<br> 
 * PV1-25: Contract Effective Date (DT)<br> 
 * PV1-26: Contract Amount (NM)<br> 
 * PV1-27: Contract Period (NM)<br> 
 * PV1-28: Interest Code (ID)<br> 
 * PV1-29: Transfer to bad debt - code (ID)<br> 
 * PV1-30: Transfer to bad debt - date (DT)<br> 
 * PV1-31: Bad Debt Agency Code (ID)<br> 
 * PV1-32: Bad Debt Transfer Amount (NM)<br> 
 * PV1-33: Bad Debt Recovery Amount (NM)<br> 
 * PV1-34: Delete Account Indicator (ID)<br> 
 * PV1-35: Delete Account Date (DT)<br> 
 * PV1-36: Discharge Disposition (ID)<br> 
 * PV1-37: Discharged to Location (CM_DLD)<br> 
 * PV1-38: Diet Type (ID)<br> 
 * PV1-39: Servicing Facility (ID)<br> 
 * PV1-40: Bed Status (ID)<br> 
 * PV1-41: Account Status (ID)<br> 
 * PV1-42: Pending Location (CM_INTERNAL_LOCATION)<br> 
 * PV1-43: Prior Temporary Location (CM_INTERNAL_LOCATION)<br> 
 * PV1-44: Admit date / time (TS)<br> 
 * PV1-45: Discharge date / time (TS)<br> 
 * PV1-46: Current Patient Balance (NM)<br> 
 * PV1-47: Total Charges (NM)<br> 
 * PV1-48: Total Adjustments (NM)<br> 
 * PV1-49: Total Payments (NM)<br> 
 * PV1-50: Alternate Visit ID (CM_PAT_ID_0192)<br> 
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
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - Patient Visit");
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 4}, "Patient Class");
       this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message}, "Assigned Patient Location");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 7}, "Admission Type");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Preadmit Number");
       this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message}, "Prior Patient Location");
       this.add(typeof(CN_PHYSICIAN), false, 1, 60, new System.Object[]{message}, "Attending Doctor");
       this.add(typeof(CN_PHYSICIAN), false, 1, 60, new System.Object[]{message}, "Referring Doctor");
       this.add(typeof(CN_PHYSICIAN), false, 0, 60, new System.Object[]{message}, "Consulting Doctor");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 69}, "Hospital Service");
       this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message}, "Temporary Location");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 87}, "Preadmit Test Indicator");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 92}, "Readmission indicator");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 23}, "Admit Source");
       this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 9}, "Ambulatory Status");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 99}, "VIP Indicator");
       this.add(typeof(CN_PHYSICIAN), false, 1, 60, new System.Object[]{message}, "Admitting Doctor");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18}, "Patient type");
       this.add(typeof(CM_PAT_ID), false, 1, 15, new System.Object[]{message}, "Visit Number");
       this.add(typeof(CM_FINANCE), false, 4, 50, new System.Object[]{message}, "Financial Class");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 32}, "Charge Price Indicator");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 45}, "Courtesy Code");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 46}, "Credit Rating");
       this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 44}, "Contract Code");
       this.add(typeof(DT), false, 0, 8, new System.Object[]{message}, "Contract Effective Date");
       this.add(typeof(NM), false, 0, 12, new System.Object[]{message}, "Contract Amount");
       this.add(typeof(NM), false, 0, 3, new System.Object[]{message}, "Contract Period");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 73}, "Interest Code");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 110}, "Transfer to bad debt - code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Transfer to bad debt - date");
       this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 21}, "Bad Debt Agency Code");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Bad Debt Transfer Amount");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Bad Debt Recovery Amount");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 111}, "Delete Account Indicator");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Delete Account Date");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 112}, "Discharge Disposition");
       this.add(typeof(CM_DLD), false, 1, 25, new System.Object[]{message}, "Discharged to Location");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 114}, "Diet Type");
       this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 115}, "Servicing Facility");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 116}, "Bed Status");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 117}, "Account Status");
       this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message}, "Pending Location");
       this.add(typeof(CM_INTERNAL_LOCATION), false, 1, 12, new System.Object[]{message}, "Prior Temporary Location");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Admit date / time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Discharge date / time");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Current Patient Balance");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Total Charges");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Total Adjustments");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Total Payments");
       this.add(typeof(CM_PAT_ID_0192), false, 1, 20, new System.Object[]{message}, "Alternate Visit ID");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - Patient Visit(PV1-1).
	*/
	public SI SetIDPatientVisit
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
	* Returns Patient Class(PV1-2).
	*/
	public ID PatientClass
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
	* Returns Assigned Patient Location(PV1-3).
	*/
	public CM_INTERNAL_LOCATION AssignedPatientLocation
	{
		get{
			CM_INTERNAL_LOCATION ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (CM_INTERNAL_LOCATION)t;
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
	* Returns Admission Type(PV1-4).
	*/
	public ID AdmissionType
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
	* Returns Preadmit Number(PV1-5).
	*/
	public ST PreadmitNumber
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
	* Returns Prior Patient Location(PV1-6).
	*/
	public CM_INTERNAL_LOCATION PriorPatientLocation
	{
		get{
			CM_INTERNAL_LOCATION ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (CM_INTERNAL_LOCATION)t;
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
	* Returns Attending Doctor(PV1-7).
	*/
	public CN_PHYSICIAN AttendingDoctor
	{
		get{
			CN_PHYSICIAN ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (CN_PHYSICIAN)t;
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
	* Returns Referring Doctor(PV1-8).
	*/
	public CN_PHYSICIAN ReferringDoctor
	{
		get{
			CN_PHYSICIAN ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CN_PHYSICIAN)t;
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
	* Returns a single repetition of Consulting Doctor(PV1-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CN_PHYSICIAN getConsultingDoctor(int rep)
	{
			CN_PHYSICIAN ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (CN_PHYSICIAN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Consulting Doctor (PV1-9).
   */
  public CN_PHYSICIAN[] getConsultingDoctor() {
     CN_PHYSICIAN[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new CN_PHYSICIAN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CN_PHYSICIAN)t[i];
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
	* Returns Hospital Service(PV1-10).
	*/
	public ID HospitalService
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
	* Returns Temporary Location(PV1-11).
	*/
	public CM_INTERNAL_LOCATION TemporaryLocation
	{
		get{
			CM_INTERNAL_LOCATION ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CM_INTERNAL_LOCATION)t;
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
	* Returns Preadmit Test Indicator(PV1-12).
	*/
	public ID PreadmitTestIndicator
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
	* Returns Readmission indicator(PV1-13).
	*/
	public ID ReadmissionIndicator
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
	* Returns Admit Source(PV1-14).
	*/
	public ID AdmitSource
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
	* Returns a single repetition of Ambulatory Status(PV1-15).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getAmbulatoryStatus(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(15, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Ambulatory Status (PV1-15).
   */
  public ID[] getAmbulatoryStatus() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(15);  
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
	* Returns VIP Indicator(PV1-16).
	*/
	public ID VIPIndicator
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
	* Returns Admitting Doctor(PV1-17).
	*/
	public CN_PHYSICIAN AdmittingDoctor
	{
		get{
			CN_PHYSICIAN ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (CN_PHYSICIAN)t;
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
	* Returns Patient type(PV1-18).
	*/
	public ID PatientType
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
	* Returns Visit Number(PV1-19).
	*/
	public CM_PAT_ID VisitNumber
	{
		get{
			CM_PAT_ID ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (CM_PAT_ID)t;
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
	* Returns a single repetition of Financial Class(PV1-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_FINANCE getFinancialClass(int rep)
	{
			CM_FINANCE ret = null;
			try
			{
			Type t = this.getField(20, rep);
				ret = (CM_FINANCE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Financial Class (PV1-20).
   */
  public CM_FINANCE[] getFinancialClass() {
     CM_FINANCE[] ret = null;
    try {
        Type[] t = this.getField(20);  
        ret = new CM_FINANCE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_FINANCE)t[i];
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
	* Returns Charge Price Indicator(PV1-21).
	*/
	public ID ChargePriceIndicator
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
	* Returns Courtesy Code(PV1-22).
	*/
	public ID CourtesyCode
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
	* Returns Credit Rating(PV1-23).
	*/
	public ID CreditRating
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
	* Returns a single repetition of Contract Code(PV1-24).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getContractCode(int rep)
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
   * Returns all repetitions of Contract Code (PV1-24).
   */
  public ID[] getContractCode() {
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
	* Returns a single repetition of Contract Effective Date(PV1-25).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public DT getContractEffectiveDate(int rep)
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
   * Returns all repetitions of Contract Effective Date (PV1-25).
   */
  public DT[] getContractEffectiveDate() {
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
	* Returns a single repetition of Contract Amount(PV1-26).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public NM getContractAmount(int rep)
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
   * Returns all repetitions of Contract Amount (PV1-26).
   */
  public NM[] getContractAmount() {
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
	* Returns a single repetition of Contract Period(PV1-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public NM getContractPeriod(int rep)
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
   * Returns all repetitions of Contract Period (PV1-27).
   */
  public NM[] getContractPeriod() {
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
	* Returns Interest Code(PV1-28).
	*/
	public ID InterestCode
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
	* Returns Transfer to bad debt - code(PV1-29).
	*/
	public ID TransferToBadDebtCode
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
	* Returns Transfer to bad debt - date(PV1-30).
	*/
	public DT TransferToBadDebtDate
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
	* Returns Bad Debt Agency Code(PV1-31).
	*/
	public ID BadDebtAgencyCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(31, 0);
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
	* Returns Bad Debt Transfer Amount(PV1-32).
	*/
	public NM BadDebtTransferAmount
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
	* Returns Bad Debt Recovery Amount(PV1-33).
	*/
	public NM BadDebtRecoveryAmount
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
	* Returns Delete Account Indicator(PV1-34).
	*/
	public ID DeleteAccountIndicator
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
	* Returns Delete Account Date(PV1-35).
	*/
	public DT DeleteAccountDate
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
	* Returns Discharge Disposition(PV1-36).
	*/
	public ID DischargeDisposition
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
	* Returns Discharged to Location(PV1-37).
	*/
	public CM_DLD DischargedToLocation
	{
		get{
			CM_DLD ret = null;
			try
			{
			Type t = this.getField(37, 0);
				ret = (CM_DLD)t;
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
	* Returns Diet Type(PV1-38).
	*/
	public ID DietType
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
	* Returns Servicing Facility(PV1-39).
	*/
	public ID ServicingFacility
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
	* Returns Bed Status(PV1-40).
	*/
	public ID BedStatus
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
	* Returns Account Status(PV1-41).
	*/
	public ID AccountStatus
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
	* Returns Pending Location(PV1-42).
	*/
	public CM_INTERNAL_LOCATION PendingLocation
	{
		get{
			CM_INTERNAL_LOCATION ret = null;
			try
			{
			Type t = this.getField(42, 0);
				ret = (CM_INTERNAL_LOCATION)t;
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
	* Returns Prior Temporary Location(PV1-43).
	*/
	public CM_INTERNAL_LOCATION PriorTemporaryLocation
	{
		get{
			CM_INTERNAL_LOCATION ret = null;
			try
			{
			Type t = this.getField(43, 0);
				ret = (CM_INTERNAL_LOCATION)t;
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
	* Returns Admit date / time(PV1-44).
	*/
	public TS AdmitDateTime
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
	* Returns Discharge date / time(PV1-45).
	*/
	public TS DischargeDateTime
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
	* Returns Current Patient Balance(PV1-46).
	*/
	public NM CurrentPatientBalance
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
	* Returns Total Charges(PV1-47).
	*/
	public NM TotalCharges
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
	* Returns Total Adjustments(PV1-48).
	*/
	public NM TotalAdjustments
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
	* Returns Total Payments(PV1-49).
	*/
	public NM TotalPayments
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

	/**
	* Returns Alternate Visit ID(PV1-50).
	*/
	public CM_PAT_ID_0192 AlternateVisitID
	{
		get{
			CM_PAT_ID_0192 ret = null;
			try
			{
			Type t = this.getField(50, 0);
				ret = (CM_PAT_ID_0192)t;
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