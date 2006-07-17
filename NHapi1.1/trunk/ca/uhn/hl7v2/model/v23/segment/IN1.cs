using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 IN1 message segment. 
 * This segment has the following fields:</p><p>
 * IN1-1: Set ID - Insurance (SI)<br> 
 * IN1-2: Insurance Plan ID (CE)<br> 
 * IN1-3: Insurance Company ID (CX)<br> 
 * IN1-4: Insurance Company Name (XON)<br> 
 * IN1-5: Insurance Company Address (XAD)<br> 
 * IN1-6: Insurance Co. Contact Ppers (XPN)<br> 
 * IN1-7: Insurance Co Phone Number (XTN)<br> 
 * IN1-8: Group Number (ST)<br> 
 * IN1-9: Group Name (XON)<br> 
 * IN1-10: Insured's group employer ID (CX)<br> 
 * IN1-11: Insured's Group Emp Name (XON)<br> 
 * IN1-12: Plan Effective Date (DT)<br> 
 * IN1-13: Plan Expiration Date (DT)<br> 
 * IN1-14: Authorization Information (CM_AUI)<br> 
 * IN1-15: Plan Type (IS)<br> 
 * IN1-16: Name of Insured (XPN)<br> 
 * IN1-17: Insured's Relationship to Patient (IS)<br> 
 * IN1-18: Insured's Date of Birth (TS)<br> 
 * IN1-19: Insured's Address (XAD)<br> 
 * IN1-20: Assignment of Benefits (IS)<br> 
 * IN1-21: Coordination of Benefits (IS)<br> 
 * IN1-22: Coord of Ben. Priority (ST)<br> 
 * IN1-23: Notice of Admission Code (ID)<br> 
 * IN1-24: Notice of Admission Date (DT)<br> 
 * IN1-25: Rpt of Eigibility Code (ID)<br> 
 * IN1-26: Rpt of Eligibility Date (DT)<br> 
 * IN1-27: Release Information Code (IS)<br> 
 * IN1-28: Pre-Admit Cert (PAC) (ST)<br> 
 * IN1-29: Verification Date/Time (TS)<br> 
 * IN1-30: Verification By (XPN)<br> 
 * IN1-31: Type of Agreement Code (IS)<br> 
 * IN1-32: Billing Status (IS)<br> 
 * IN1-33: Lifetime Reserve Days (NM)<br> 
 * IN1-34: Delay before lifetime reserve days (NM)<br> 
 * IN1-35: Company Plan Code (IS)<br> 
 * IN1-36: Policy Number (ST)<br> 
 * IN1-37: Policy Deductible (CP)<br> 
 * IN1-38: Policy Limit - Amount (CP)<br> 
 * IN1-39: Policy Limit - Days (NM)<br> 
 * IN1-40: Room Rate - Semi-Private (CP)<br> 
 * IN1-41: Room Rate - Private (CP)<br> 
 * IN1-42: Insured's Employment Status (CE)<br> 
 * IN1-43: Insured's Sex (IS)<br> 
 * IN1-44: Insured's Employer Address (XAD)<br> 
 * IN1-45: Verification Status (ST)<br> 
 * IN1-46: Prior Insurance Plan ID (IS)<br> 
 * IN1-47: Coverage Type (IS)<br> 
 * IN1-48: Handicap (IS)<br> 
 * IN1-49: Insured's ID Number (CX)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IN1 : AbstractSegment  {

  /**
   * Creates a IN1 (Insurance) segment object that belongs to the given 
   * message.  
   */
  public IN1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - Insurance");
       this.add(typeof(CE), false, 1, 8, new System.Object[]{message}, "Insurance Plan ID");
       this.add(typeof(CX), true, 1, 59, new System.Object[]{message}, "Insurance Company ID");
       this.add(typeof(XON), false, 1, 130, new System.Object[]{message}, "Insurance Company Name");
       this.add(typeof(XAD), false, 1, 106, new System.Object[]{message}, "Insurance Company Address");
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message}, "Insurance Co. Contact Ppers");
       this.add(typeof(XTN), false, 3, 40, new System.Object[]{message}, "Insurance Co Phone Number");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Group Number");
       this.add(typeof(XON), false, 1, 130, new System.Object[]{message}, "Group Name");
       this.add(typeof(CX), false, 1, 12, new System.Object[]{message}, "Insured's group employer ID");
       this.add(typeof(XON), false, 1, 130, new System.Object[]{message}, "Insured's Group Emp Name");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Plan Effective Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Plan Expiration Date");
       this.add(typeof(CM_AUI), false, 1, 55, new System.Object[]{message}, "Authorization Information");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 86}, "Plan Type");
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message}, "Name of Insured");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 63}, "Insured's Relationship to Patient");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Insured's Date of Birth");
       this.add(typeof(XAD), false, 1, 106, new System.Object[]{message}, "Insured's Address");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 135}, "Assignment of Benefits");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 173}, "Coordination of Benefits");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "Coord of Ben. Priority");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136}, "Notice of Admission Code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Notice of Admission Date");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136}, "Rpt of Eigibility Code");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Rpt of Eligibility Date");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 93}, "Release Information Code");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Pre-Admit Cert (PAC)");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Verification Date/Time");
       this.add(typeof(XPN), false, 1, 60, new System.Object[]{message}, "Verification By");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 98}, "Type of Agreement Code");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 22}, "Billing Status");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Lifetime Reserve Days");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Delay before lifetime reserve days");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 42}, "Company Plan Code");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Policy Number");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Policy Deductible");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Policy Limit - Amount");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Policy Limit - Days");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Room Rate - Semi-Private");
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message}, "Room Rate - Private");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Insured's Employment Status");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1}, "Insured's Sex");
       this.add(typeof(XAD), false, 1, 106, new System.Object[]{message}, "Insured's Employer Address");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "Verification Status");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 72}, "Prior Insurance Plan ID");
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 309}, "Coverage Type");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 310}, "Handicap");
       this.add(typeof(CX), false, 1, 12, new System.Object[]{message}, "Insured's ID Number");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - Insurance(IN1-1).
	*/
	public SI SetIDInsurance
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
	* Returns Insurance Plan ID(IN1-2).
	*/
	public CE InsurancePlanID
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
	* Returns Insurance Company ID(IN1-3).
	*/
	public CX InsuranceCompanyID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Insurance Company Name(IN1-4).
	*/
	public XON InsuranceCompanyName
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (XON)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Insurance Company Address(IN1-5).
	*/
	public XAD InsuranceCompanyAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Insurance Co. Contact Ppers(IN1-6).
	*/
	public XPN InsuranceCoContactPpers
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (XPN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Insurance Co Phone Number(IN1-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getInsuranceCoPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insurance Co Phone Number (IN1-7).
   */
  public XTN[] getInsuranceCoPhoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
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
	* Returns Group Number(IN1-8).
	*/
	public ST GroupNumber
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
	* Returns Group Name(IN1-9).
	*/
	public XON GroupName
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (XON)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Insured's group employer ID(IN1-10).
	*/
	public CX InsuredSGroupEmployerID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Insured's Group Emp Name(IN1-11).
	*/
	public XON InsuredSGroupEmpName
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (XON)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Plan Effective Date(IN1-12).
	*/
	public DT PlanEffectiveDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Plan Expiration Date(IN1-13).
	*/
	public DT PlanExpirationDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Authorization Information(IN1-14).
	*/
	public CM_AUI AuthorizationInformation
	{
		get{
			CM_AUI ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (CM_AUI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Plan Type(IN1-15).
	*/
	public IS PlanType
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
	* Returns Name of Insured(IN1-16).
	*/
	public XPN NameOfInsured
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(16, 0);
				ret = (XPN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Insured's Relationship to Patient(IN1-17).
	*/
	public IS InsuredSRelationshipToPatient
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
	* Returns Insured's Date of Birth(IN1-18).
	*/
	public TS InsuredSDateOfBirth
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
	* Returns Insured's Address(IN1-19).
	*/
	public XAD InsuredSAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Assignment of Benefits(IN1-20).
	*/
	public IS AssignmentOfBenefits
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Coordination of Benefits(IN1-21).
	*/
	public IS CoordinationOfBenefits
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns Coord of Ben. Priority(IN1-22).
	*/
	public ST CoordOfBenPriority
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
	* Returns Notice of Admission Code(IN1-23).
	*/
	public ID NoticeOfAdmissionCode
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
	* Returns Notice of Admission Date(IN1-24).
	*/
	public DT NoticeOfAdmissionDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns Rpt of Eigibility Code(IN1-25).
	*/
	public ID RptOfEigibilityCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Rpt of Eligibility Date(IN1-26).
	*/
	public DT RptOfEligibilityDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(26, 0);
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
	* Returns Release Information Code(IN1-27).
	*/
	public IS ReleaseInformationCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(27, 0);
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
	* Returns Pre-Admit Cert (PAC)(IN1-28).
	*/
	public ST PreAdmitCert
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(28, 0);
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
	* Returns Verification Date/Time(IN1-29).
	*/
	public TS VerificationDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(29, 0);
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
	* Returns Verification By(IN1-30).
	*/
	public XPN VerificationBy
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(30, 0);
				ret = (XPN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Type of Agreement Code(IN1-31).
	*/
	public IS TypeOfAgreementCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(31, 0);
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
	* Returns Billing Status(IN1-32).
	*/
	public IS BillingStatus
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(32, 0);
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
	* Returns Lifetime Reserve Days(IN1-33).
	*/
	public NM LifetimeReserveDays
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
	* Returns Delay before lifetime reserve days(IN1-34).
	*/
	public NM DelayBeforeLifetimeReserveDays
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(34, 0);
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
	* Returns Company Plan Code(IN1-35).
	*/
	public IS CompanyPlanCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(35, 0);
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
	* Returns Policy Number(IN1-36).
	*/
	public ST PolicyNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(36, 0);
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
	* Returns Policy Deductible(IN1-37).
	*/
	public CP PolicyDeductible
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(37, 0);
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
	* Returns Policy Limit - Amount(IN1-38).
	*/
	public CP PolicyLimitAmount
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(38, 0);
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
	* Returns Policy Limit - Days(IN1-39).
	*/
	public NM PolicyLimitDays
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
	* Returns Room Rate - Semi-Private(IN1-40).
	*/
	public CP RoomRateSemiPrivate
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns Room Rate - Private(IN1-41).
	*/
	public CP RoomRatePrivate
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns Insured's Employment Status(IN1-42).
	*/
	public CE InsuredSEmploymentStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(42, 0);
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
	* Returns Insured's Sex(IN1-43).
	*/
	public IS InsuredSSex
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(43, 0);
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
	* Returns Insured's Employer Address(IN1-44).
	*/
	public XAD InsuredSEmployerAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(44, 0);
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
	* Returns Verification Status(IN1-45).
	*/
	public ST VerificationStatus
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(45, 0);
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
	* Returns Prior Insurance Plan ID(IN1-46).
	*/
	public IS PriorInsurancePlanID
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(46, 0);
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
	* Returns Coverage Type(IN1-47).
	*/
	public IS CoverageType
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(47, 0);
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
	* Returns Handicap(IN1-48).
	*/
	public IS Handicap
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(48, 0);
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
	* Returns Insured's ID Number(IN1-49).
	*/
	public CX InsuredSIDNumber
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(49, 0);
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


}}