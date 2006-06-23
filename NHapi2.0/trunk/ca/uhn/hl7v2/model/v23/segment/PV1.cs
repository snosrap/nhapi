using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 PV1 message segment. 
 * This segment has the following fields:</p><p>
 * PV1-1: Set ID - Patient Visit (SI)<br> 
 * PV1-2: Patient Class (ID)<br> 
 * PV1-3: Assigned Patient Location (PL)<br> 
 * PV1-4: Admission Type (ID)<br> 
 * PV1-5: Preadmit Number (CX)<br> 
 * PV1-6: Prior Patient Location (PL)<br> 
 * PV1-7: Attending Doctor (XCN)<br> 
 * PV1-8: Referring Doctor (XCN)<br> 
 * PV1-9: Consulting Doctor (XCN)<br> 
 * PV1-10: Hospital Service (ID)<br> 
 * PV1-11: Temporary Location (PL)<br> 
 * PV1-12: Preadmit Test Indicator (ID)<br> 
 * PV1-13: Readmission Indicator (ID)<br> 
 * PV1-14: Admit Source (ID)<br> 
 * PV1-15: Ambulatory Status (IS)<br> 
 * PV1-16: VIP Indicator (ID)<br> 
 * PV1-17: Admitting Doctor (XCN)<br> 
 * PV1-18: Patient Type (ID)<br> 
 * PV1-19: Visit Number (CX)<br> 
 * PV1-20: Financial Class (FC)<br> 
 * PV1-21: Charge Price Indicator (ID)<br> 
 * PV1-22: Courtesy Code (ID)<br> 
 * PV1-23: Credit Rating (ID)<br> 
 * PV1-24: Contract Code (ID)<br> 
 * PV1-25: Contract Effective Date (DT)<br> 
 * PV1-26: Contract Amount (NM)<br> 
 * PV1-27: Contract Period (NM)<br> 
 * PV1-28: Interest Code (ID)<br> 
 * PV1-29: Transfer to Bad Debt Code (ID)<br> 
 * PV1-30: Transfer to Bad Debt Date (DT)<br> 
 * PV1-31: Bad Debt Agency Code (ID)<br> 
 * PV1-32: Bad Debt Transfer Amount (NM)<br> 
 * PV1-33: Bad Debt Recovery Amount (NM)<br> 
 * PV1-34: Delete Account Indicator (ID)<br> 
 * PV1-35: Delete Account Date (DT)<br> 
 * PV1-36: Discharge Disposition (ID)<br> 
 * PV1-37: Discharged to Location (CM_DLD)<br> 
 * PV1-38: Diet Type (ID)<br> 
 * PV1-39: Servicing Facility (ID)<br> 
 * PV1-40: Bed Status (IS)<br> 
 * PV1-41: Account Status (ID)<br> 
 * PV1-42: Pending Location (PL)<br> 
 * PV1-43: Prior Temporary Location (PL)<br> 
 * PV1-44: Admit Date/Time (TS)<br> 
 * PV1-45: Discharge Date/Time (TS)<br> 
 * PV1-46: Current Patient Balance (NM)<br> 
 * PV1-47: Total Charges (NM)<br> 
 * PV1-48: Total Adjustments (NM)<br> 
 * PV1-49: Total Payments (NM)<br> 
 * PV1-50: Alternate Visit ID (CX)<br> 
 * PV1-51: Visit Indicator (IS)<br> 
 * PV1-52: Other Healthcare Provider (XCN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class PV1 : AbstractSegment  {

  /**
   * Creates a PV1 (Patient visit) segment object that belongs to the given 
   * message.  
   */
  public PV1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 4});
       this.add(typeof(PL), false, 1, 12, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 7});
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
       this.add(typeof(PL), false, 1, 12, new System.Object[]{message});
       this.add(typeof(XCN), false, 1, 60, new System.Object[]{message});
       this.add(typeof(XCN), false, 1, 60, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 69});
       this.add(typeof(PL), false, 1, 12, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 87});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 92});
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 23});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 9});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 99});
       this.add(typeof(XCN), false, 1, 60, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18});
       this.add(typeof(CX), false, 1, 15, new System.Object[]{message});
       this.add(typeof(FC), false, 0, 50, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 32});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 45});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 46});
       this.add(typeof(ID), false, 0, 2, new System.Object[]{message, 44});
       this.add(typeof(DT), false, 0, 8, new System.Object[]{message});
       this.add(typeof(NM), false, 0, 12, new System.Object[]{message});
       this.add(typeof(NM), false, 0, 3, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 73});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 110});
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 21});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 111});
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 112});
       this.add(typeof(CM_DLD), false, 1, 25, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 114});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 115});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 116});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 117});
       this.add(typeof(PL), false, 1, 12, new System.Object[]{message});
       this.add(typeof(PL), false, 1, 12, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 326});
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Set ID - Patient Visit (PV1-1).
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
	* Returns Patient Class (PV1-2).
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
	* Returns Assigned Patient Location (PV1-3).
	*/
	public PL AssignedPatientLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Admission Type (PV1-4).
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
	* Returns Preadmit Number (PV1-5).
	*/
	public CX PreadmitNumber
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Prior Patient Location (PV1-6).
	*/
	public PL PriorPatientLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Attending Doctor (PV1-7).
	*/
	public XCN AttendingDoctor
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (XCN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Referring Doctor (PV1-8).
	*/
	public XCN ReferringDoctor
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (XCN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Consulting Doctor (PV1-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getConsultingDoctor(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Consulting Doctor (PV1-9).
   */
  public XCN[] getConsultingDoctor() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(9);  
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
	* Returns Hospital Service (PV1-10).
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
	* Returns Temporary Location (PV1-11).
	*/
	public PL TemporaryLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Preadmit Test Indicator (PV1-12).
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
	* Returns Readmission Indicator (PV1-13).
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
	* Returns Admit Source (PV1-14).
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
	* Returns Ambulatory Status (PV1-15).
	*/
	public IS AmbulatoryStatus
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns VIP Indicator (PV1-16).
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
	* Returns Admitting Doctor (PV1-17).
	*/
	public XCN AdmittingDoctor
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (XCN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Patient Type (PV1-18).
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
	* Returns Visit Number (PV1-19).
	*/
	public CX VisitNumber
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns a single repetition of Financial Class (PV1-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public FC getFinancialClass(int rep)
	{
			FC ret = null;
			try
			{
			Type t = this.getField(20, rep);
				ret = (FC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Financial Class (PV1-20).
   */
  public FC[] getFinancialClass() {
     FC[] ret = null;
    try {
        Type[] t = this.getField(20);  
        ret = new FC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (FC)t[i];
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
	* Returns Charge Price Indicator (PV1-21).
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
	* Returns Courtesy Code (PV1-22).
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
	* Returns Credit Rating (PV1-23).
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
	* Returns a single repetition of Contract Code (PV1-24).
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
	* Returns a single repetition of Contract Effective Date (PV1-25).
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
	* Returns a single repetition of Contract Amount (PV1-26).
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
	* Returns a single repetition of Contract Period (PV1-27).
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
	* Returns Interest Code (PV1-28).
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
	* Returns Transfer to Bad Debt Code (PV1-29).
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
	* Returns Transfer to Bad Debt Date (PV1-30).
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
	* Returns Bad Debt Agency Code (PV1-31).
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
	* Returns Bad Debt Transfer Amount (PV1-32).
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
	* Returns Bad Debt Recovery Amount (PV1-33).
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
	* Returns Delete Account Indicator (PV1-34).
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
	* Returns Delete Account Date (PV1-35).
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
	* Returns Discharge Disposition (PV1-36).
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
	* Returns Discharged to Location (PV1-37).
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
	* Returns Diet Type (PV1-38).
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
	* Returns Servicing Facility (PV1-39).
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
	* Returns Bed Status (PV1-40).
	*/
	public IS BedStatus
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns Account Status (PV1-41).
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
	* Returns Pending Location (PV1-42).
	*/
	public PL PendingLocation
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
	* Returns Prior Temporary Location (PV1-43).
	*/
	public PL PriorTemporaryLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(43, 0);
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
	* Returns Admit Date/Time (PV1-44).
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
	* Returns Discharge Date/Time (PV1-45).
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
	* Returns Current Patient Balance (PV1-46).
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
	* Returns Total Charges (PV1-47).
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
	* Returns Total Adjustments (PV1-48).
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
	* Returns Total Payments (PV1-49).
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
	* Returns Alternate Visit ID (PV1-50).
	*/
	public CX AlternateVisitID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(50, 0);
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
	* Returns Visit Indicator (PV1-51).
	*/
	public IS VisitIndicator
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(51, 0);
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
	* Returns a single repetition of Other Healthcare Provider (PV1-52).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getOtherHealthcareProvider(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(52, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Other Healthcare Provider (PV1-52).
   */
  public XCN[] getOtherHealthcareProvider() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(52);  
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


}}