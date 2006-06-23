using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 IN2 message segment. 
 * This segment has the following fields:</p><p>
 * IN2-1: Insured's Employee ID (CX)<br> 
 * IN2-2: Insured's Social Security Number (ST)<br> 
 * IN2-3: Insured's Employer Name (XCN)<br> 
 * IN2-4: Employer Information Data (IS)<br> 
 * IN2-5: Mail Claim Party (IS)<br> 
 * IN2-6: Medicare Health Ins Card Number (ST)<br> 
 * IN2-7: Medicaid Case Name (XPN)<br> 
 * IN2-8: Medicaid Case Number (ST)<br> 
 * IN2-9: Champus Sponsor Name (XPN)<br> 
 * IN2-10: Champus ID Number (ST)<br> 
 * IN2-11: Dependent of Champus Recipient (CE)<br> 
 * IN2-12: Champus Organization (ST)<br> 
 * IN2-13: Champus Station (ST)<br> 
 * IN2-14: Champus Service (IS)<br> 
 * IN2-15: Champus Rank/Grade (IS)<br> 
 * IN2-16: Champus Status (IS)<br> 
 * IN2-17: Champus Retire Date (DT)<br> 
 * IN2-18: Champus Non-Avail Cert on File (ID)<br> 
 * IN2-19: Baby Coverage (ID)<br> 
 * IN2-20: Combine Baby Bill (ID)<br> 
 * IN2-21: Blood Deductible (ST)<br> 
 * IN2-22: Special Coverage Approval Name (XPN)<br> 
 * IN2-23: Special Coverage Approval Title (ST)<br> 
 * IN2-24: Non-Covered Insurance Code (ST)<br> 
 * IN2-25: Payor ID (CX)<br> 
 * IN2-26: Payor Subscriber ID (CX)<br> 
 * IN2-27: Eligibility Source (IS)<br> 
 * IN2-28: Room Coverage Type/Amount (CM_RMC)<br> 
 * IN2-29: Policy Type/Amount (CM_PTA)<br> 
 * IN2-30: Daily Deductible (CM_DDI)<br> 
 * IN2-31: Living Dependency (IS)<br> 
 * IN2-32: Ambulatory Status (IS)<br> 
 * IN2-33: Citizenship (IS)<br> 
 * IN2-34: Primary Language (CE)<br> 
 * IN2-35: Living Arrangement (IS)<br> 
 * IN2-36: Publicity Indicator (CE)<br> 
 * IN2-37: Protection Indicator (ID)<br> 
 * IN2-38: Student Indicator (IS)<br> 
 * IN2-39: Religion (IS)<br> 
 * IN2-40: Mother’s Maiden Name (XPN)<br> 
 * IN2-41: Nationality Code (CE)<br> 
 * IN2-42: Ethnic Group (IS)<br> 
 * IN2-43: Marital Status (IS)<br> 
 * IN2-44: Employment Start Date (DT)<br> 
 * IN2-45: Employment Stop Date (DT)<br> 
 * IN2-46: Job Title (ST)<br> 
 * IN2-47: Job Code/Class (JCC)<br> 
 * IN2-48: Job Status (IS)<br> 
 * IN2-49: Employer Contact Person Name (XPN)<br> 
 * IN2-50: Employer Contact Person Phone Number (XTN)<br> 
 * IN2-51: Employer Contact Reason (IS)<br> 
 * IN2-52: Insured’s Contact Person’s Name (XPN)<br> 
 * IN2-53: Insured’s Contact Person Telephone Number (XTN)<br> 
 * IN2-54: Insured’s Contact Person Reason (IS)<br> 
 * IN2-55: Relationship To The Patient Start Date (DT)<br> 
 * IN2-56: Relationship To The Patient Stop Date (DT)<br> 
 * IN2-57: Insurance Co. Contact Reason (IS)<br> 
 * IN2-58: Insurance Co. Contact Phone Number (XTN)<br> 
 * IN2-59: Policy Scope (IS)<br> 
 * IN2-60: Policy Source (IS)<br> 
 * IN2-61: Patient Member Number (CX)<br> 
 * IN2-62: Guarantor’s Relationship To Insured (IS)<br> 
 * IN2-63: Insured’s Telephone Number - Home (XTN)<br> 
 * IN2-64: Insured’s Employer Telephone Number (XTN)<br> 
 * IN2-65: Military Handicapped Program (CE)<br> 
 * IN2-66: Suspend Flag (ID)<br> 
 * IN2-67: Co-pay Limit Flag (ID)<br> 
 * IN2-68: Stoploss Limit Flag (ID)<br> 
 * IN2-69: Insured Organization Name And ID (XON)<br> 
 * IN2-70: Insured Employer Organization Name And ID (XON)<br> 
 * IN2-71: Race (IS)<br> 
 * IN2-72: Patient Relationship to Insured (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IN2 : AbstractSegment  {

  /**
   * Creates a IN2 (Insurance additional info) segment object that belongs to the given 
   * message.  
   */
  public IN2(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CX), false, 1, 59, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 11, new System.Object[]{message});
       this.add(typeof(XCN), false, 1, 130, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 139});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 137});
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message});
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 14, new System.Object[]{message, 140});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 141});
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 142});
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(ST), false, 1, 1, new System.Object[]{message});
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
       this.add(typeof(ST), false, 0, 8, new System.Object[]{message});
       this.add(typeof(CX), false, 1, 59, new System.Object[]{message});
       this.add(typeof(CX), false, 1, 59, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 144});
       this.add(typeof(CM_RMC), false, 0, 25, new System.Object[]{message});
       this.add(typeof(CM_PTA), false, 0, 25, new System.Object[]{message});
       this.add(typeof(CM_DDI), false, 1, 25, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 223});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 9});
       this.add(typeof(IS), false, 1, 4, new System.Object[]{message, 171});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220});
       this.add(typeof(CE), false, 1, 1, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231});
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 6});
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 189});
       this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 2});
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
       this.add(typeof(JCC), false, 1, 20, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 311});
       this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 222});
       this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 222});
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
       this.add(typeof(DT), false, 0, 8, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 232});
       this.add(typeof(XTN), false, 1, 40, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 312});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 313});
       this.add(typeof(CX), false, 1, 60, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 63});
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
       this.add(typeof(XTN), false, 0, 40, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 2, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136});
       this.add(typeof(XON), false, 0, 130, new System.Object[]{message});
       this.add(typeof(XON), false, 0, 130, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 5});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Insured's Employee ID (IN2-1).
	*/
	public CX InsuredSEmployeeID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Insured's Social Security Number (IN2-2).
	*/
	public ST InsuredSSocialSecurityNumber
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
	* Returns Insured's Employer Name (IN2-3).
	*/
	public XCN InsuredSEmployerName
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Employer Information Data (IN2-4).
	*/
	public IS EmployerInformationData
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Mail Claim Party (IN2-5).
	*/
	public IS MailClaimParty
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Medicare Health Ins Card Number (IN2-6).
	*/
	public ST MedicareHealthInsCardNumber
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
	* Returns Medicaid Case Name (IN2-7).
	*/
	public XPN MedicaidCaseName
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Medicaid Case Number (IN2-8).
	*/
	public ST MedicaidCaseNumber
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
	* Returns Champus Sponsor Name (IN2-9).
	*/
	public XPN ChampusSponsorName
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Champus ID Number (IN2-10).
	*/
	public ST ChampusIDNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Dependent of Champus Recipient (IN2-11).
	*/
	public CE DependentOfChampusRecipient
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Champus Organization (IN2-12).
	*/
	public ST ChampusOrganization
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Champus Station (IN2-13).
	*/
	public ST ChampusStation
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Champus Service (IN2-14).
	*/
	public IS ChampusService
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns Champus Rank/Grade (IN2-15).
	*/
	public IS ChampusRankGrade
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
	* Returns Champus Status (IN2-16).
	*/
	public IS ChampusStatus
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns Champus Retire Date (IN2-17).
	*/
	public DT ChampusRetireDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Champus Non-Avail Cert on File (IN2-18).
	*/
	public ID ChampusNonAvailCertOnFile
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
	* Returns Baby Coverage (IN2-19).
	*/
	public ID BabyCoverage
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Combine Baby Bill (IN2-20).
	*/
	public ID CombineBabyBill
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Blood Deductible (IN2-21).
	*/
	public ST BloodDeductible
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
	* Returns Special Coverage Approval Name (IN2-22).
	*/
	public XPN SpecialCoverageApprovalName
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns Special Coverage Approval Title (IN2-23).
	*/
	public ST SpecialCoverageApprovalTitle
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

	/**
	* Returns a single repetition of Non-Covered Insurance Code (IN2-24).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getNonCoveredInsuranceCode(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(24, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Non-Covered Insurance Code (IN2-24).
   */
  public ST[] getNonCoveredInsuranceCode() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(24);  
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
	* Returns Payor ID (IN2-25).
	*/
	public CX PayorID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Payor Subscriber ID (IN2-26).
	*/
	public CX PayorSubscriberID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(26, 0);
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
	* Returns Eligibility Source (IN2-27).
	*/
	public IS EligibilitySource
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
	* Returns a single repetition of Room Coverage Type/Amount (IN2-28).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_RMC getRoomCoverageTypeAmount(int rep)
	{
			CM_RMC ret = null;
			try
			{
			Type t = this.getField(28, rep);
				ret = (CM_RMC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Room Coverage Type/Amount (IN2-28).
   */
  public CM_RMC[] getRoomCoverageTypeAmount() {
     CM_RMC[] ret = null;
    try {
        Type[] t = this.getField(28);  
        ret = new CM_RMC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_RMC)t[i];
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
	* Returns a single repetition of Policy Type/Amount (IN2-29).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_PTA getPolicyTypeAmount(int rep)
	{
			CM_PTA ret = null;
			try
			{
			Type t = this.getField(29, rep);
				ret = (CM_PTA)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Policy Type/Amount (IN2-29).
   */
  public CM_PTA[] getPolicyTypeAmount() {
     CM_PTA[] ret = null;
    try {
        Type[] t = this.getField(29);  
        ret = new CM_PTA[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_PTA)t[i];
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
	* Returns Daily Deductible (IN2-30).
	*/
	public CM_DDI DailyDeductible
	{
		get{
			CM_DDI ret = null;
			try
			{
			Type t = this.getField(30, 0);
				ret = (CM_DDI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Living Dependency (IN2-31).
	*/
	public IS LivingDependency
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
	* Returns Ambulatory Status (IN2-32).
	*/
	public IS AmbulatoryStatus
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
	* Returns Citizenship (IN2-33).
	*/
	public IS Citizenship
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(33, 0);
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
	* Returns Primary Language (IN2-34).
	*/
	public CE PrimaryLanguage
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(34, 0);
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
	* Returns Living Arrangement (IN2-35).
	*/
	public IS LivingArrangement
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
	* Returns Publicity Indicator (IN2-36).
	*/
	public CE PublicityIndicator
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(36, 0);
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
	* Returns Protection Indicator (IN2-37).
	*/
	public ID ProtectionIndicator
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
	* Returns Student Indicator (IN2-38).
	*/
	public IS StudentIndicator
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(38, 0);
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
	* Returns Religion (IN2-39).
	*/
	public IS Religion
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(39, 0);
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
	* Returns Mother’s Maiden Name (IN2-40).
	*/
	public XPN MotherSMaidenName
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns Nationality Code (IN2-41).
	*/
	public CE NationalityCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns Ethnic Group (IN2-42).
	*/
	public IS EthnicGroup
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(42, 0);
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
	* Returns a single repetition of Marital Status (IN2-43).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getMaritalStatus(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(43, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Marital Status (IN2-43).
   */
  public IS[] getMaritalStatus() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(43);  
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
	* Returns Employment Start Date (IN2-44).
	*/
	public DT EmploymentStartDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(44, 0);
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
	* Returns Employment Stop Date (IN2-45).
	*/
	public DT EmploymentStopDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(45, 0);
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
	* Returns Job Title (IN2-46).
	*/
	public ST JobTitle
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(46, 0);
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
	* Returns Job Code/Class (IN2-47).
	*/
	public JCC JobCodeClass
	{
		get{
			JCC ret = null;
			try
			{
			Type t = this.getField(47, 0);
				ret = (JCC)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Job Status (IN2-48).
	*/
	public IS JobStatus
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
	* Returns a single repetition of Employer Contact Person Name (IN2-49).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XPN getEmployerContactPersonName(int rep)
	{
			XPN ret = null;
			try
			{
			Type t = this.getField(49, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Employer Contact Person Name (IN2-49).
   */
  public XPN[] getEmployerContactPersonName() {
     XPN[] ret = null;
    try {
        Type[] t = this.getField(49);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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
	* Returns a single repetition of Employer Contact Person Phone Number (IN2-50).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getEmployerContactPersonPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(50, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Employer Contact Person Phone Number (IN2-50).
   */
  public XTN[] getEmployerContactPersonPhoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(50);  
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
	* Returns Employer Contact Reason (IN2-51).
	*/
	public IS EmployerContactReason
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
	* Returns a single repetition of Insured’s Contact Person’s Name (IN2-52).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XPN getInsuredSContactPersonSName(int rep)
	{
			XPN ret = null;
			try
			{
			Type t = this.getField(52, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured’s Contact Person’s Name (IN2-52).
   */
  public XPN[] getInsuredSContactPersonSName() {
     XPN[] ret = null;
    try {
        Type[] t = this.getField(52);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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
	* Returns a single repetition of Insured’s Contact Person Telephone Number (IN2-53).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getInsuredSContactPersonTelephoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(53, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured’s Contact Person Telephone Number (IN2-53).
   */
  public XTN[] getInsuredSContactPersonTelephoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(53);  
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
	* Returns a single repetition of Insured’s Contact Person Reason (IN2-54).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getInsuredSContactPersonReason(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(54, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured’s Contact Person Reason (IN2-54).
   */
  public IS[] getInsuredSContactPersonReason() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(54);  
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
	* Returns Relationship To The Patient Start Date (IN2-55).
	*/
	public DT RelationshipToThePatientStartDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(55, 0);
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
	* Returns a single repetition of Relationship To The Patient Stop Date (IN2-56).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public DT getRelationshipToThePatientStopDate(int rep)
	{
			DT ret = null;
			try
			{
			Type t = this.getField(56, rep);
				ret = (DT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Relationship To The Patient Stop Date (IN2-56).
   */
  public DT[] getRelationshipToThePatientStopDate() {
     DT[] ret = null;
    try {
        Type[] t = this.getField(56);  
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
	* Returns Insurance Co. Contact Reason (IN2-57).
	*/
	public IS InsuranceCoContactReason
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(57, 0);
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
	* Returns Insurance Co. Contact Phone Number (IN2-58).
	*/
	public XTN InsuranceCoContactPhoneNumber
	{
		get{
			XTN ret = null;
			try
			{
			Type t = this.getField(58, 0);
				ret = (XTN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Policy Scope (IN2-59).
	*/
	public IS PolicyScope
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(59, 0);
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
	* Returns Policy Source (IN2-60).
	*/
	public IS PolicySource
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(60, 0);
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
	* Returns Patient Member Number (IN2-61).
	*/
	public CX PatientMemberNumber
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(61, 0);
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
	* Returns Guarantor’s Relationship To Insured (IN2-62).
	*/
	public IS GuarantorSRelationshipToInsured
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(62, 0);
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
	* Returns a single repetition of Insured’s Telephone Number - Home (IN2-63).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getInsuredSTelephoneNumberHome(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(63, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured’s Telephone Number - Home (IN2-63).
   */
  public XTN[] getInsuredSTelephoneNumberHome() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(63);  
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
	* Returns a single repetition of Insured’s Employer Telephone Number (IN2-64).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getInsuredSEmployerTelephoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(64, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured’s Employer Telephone Number (IN2-64).
   */
  public XTN[] getInsuredSEmployerTelephoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(64);  
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
	* Returns Military Handicapped Program (IN2-65).
	*/
	public CE MilitaryHandicappedProgram
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(65, 0);
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
	* Returns Suspend Flag (IN2-66).
	*/
	public ID SuspendFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(66, 0);
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
	* Returns Co-pay Limit Flag (IN2-67).
	*/
	public ID CoPayLimitFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(67, 0);
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
	* Returns Stoploss Limit Flag (IN2-68).
	*/
	public ID StoplossLimitFlag
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(68, 0);
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
	* Returns a single repetition of Insured Organization Name And ID (IN2-69).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XON getInsuredOrganizationNameAndID(int rep)
	{
			XON ret = null;
			try
			{
			Type t = this.getField(69, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured Organization Name And ID (IN2-69).
   */
  public XON[] getInsuredOrganizationNameAndID() {
     XON[] ret = null;
    try {
        Type[] t = this.getField(69);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
	* Returns a single repetition of Insured Employer Organization Name And ID (IN2-70).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XON getInsuredEmployerOrganizationNameAndID(int rep)
	{
			XON ret = null;
			try
			{
			Type t = this.getField(70, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Insured Employer Organization Name And ID (IN2-70).
   */
  public XON[] getInsuredEmployerOrganizationNameAndID() {
     XON[] ret = null;
    try {
        Type[] t = this.getField(70);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
	* Returns Race (IN2-71).
	*/
	public IS Race
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(71, 0);
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
	* Returns Patient Relationship to Insured (IN2-72).
	*/
	public ID PatientRelationshipToInsured
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(72, 0);
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


}}