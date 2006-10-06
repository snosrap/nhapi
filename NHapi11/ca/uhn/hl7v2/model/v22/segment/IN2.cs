using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 IN2 message segment. 
 * This segment has the following fields:</p><p>
 * IN2-1: Insured's employee ID (ST)<br> 
 * IN2-2: Insured's social security number (ST)<br> 
 * IN2-3: Insured's employer name (CN_PERSON)<br> 
 * IN2-4: Employer information data (ID)<br> 
 * IN2-5: Mail claim party (ID)<br> 
 * IN2-6: Medicare health insurance card number (NM)<br> 
 * IN2-7: Medicaid case name (PN)<br> 
 * IN2-8: Medicaid case number (NM)<br> 
 * IN2-9: Champus sponsor name (PN)<br> 
 * IN2-10: Champus ID number (NM)<br> 
 * IN2-11: Dependent of champus recipient (ID)<br> 
 * IN2-12: Champus organization (ST)<br> 
 * IN2-13: Champus station (ST)<br> 
 * IN2-14: Champus service (ID)<br> 
 * IN2-15: Champus rank / grade (ID)<br> 
 * IN2-16: Champus status (ID)<br> 
 * IN2-17: Champus retire date (DT)<br> 
 * IN2-18: Champus non-availability certification on file (ID)<br> 
 * IN2-19: Baby coverage (ID)<br> 
 * IN2-20: Combine baby bill (ID)<br> 
 * IN2-21: Blood deductible (NM)<br> 
 * IN2-22: Special coverage approval name (PN)<br> 
 * IN2-23: Special coverage approval title (ST)<br> 
 * IN2-24: Non-covered insurance code (ID)<br> 
 * IN2-25: Payor ID (ST)<br> 
 * IN2-26: Payor subscriber ID (ST)<br> 
 * IN2-27: Eligibility source (ID)<br> 
 * IN2-28: Room coverage type / amount (CM_RMC)<br> 
 * IN2-29: Policy type / amount (CM_PTA)<br> 
 * IN2-30: Daily deductible (CM_DDI)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IN2 : AbstractSegment  {

  /**
   * Creates a IN2 (INSURANCE ADDITIONAL INFO) segment object that belongs to the given 
   * message.  
   */
  public IN2(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Insured's employee ID");
       this.add(typeof(ST), false, 1, 9, new System.Object[]{message}, "Insured's social security number");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Insured's employer name");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 139}, "Employer information data");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 137}, "Mail claim party");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "Medicare health insurance card number");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Medicaid case name");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "Medicaid case number");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Champus sponsor name");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Champus ID number");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "Dependent of champus recipient");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Champus organization");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Champus station");
       this.add(typeof(ID), false, 1, 14, new System.Object[]{message, 140}, "Champus service");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 141}, "Champus rank / grade");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 142}, "Champus status");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Champus retire date");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Champus non-availability certification on file");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Baby coverage");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Combine baby bill");
       this.add(typeof(NM), false, 1, 1, new System.Object[]{message}, "Blood deductible");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Special coverage approval name");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Special coverage approval title");
       this.add(typeof(ID), false, 0, 8, new System.Object[]{message, 143}, "Non-covered insurance code");
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message}, "Payor ID");
       this.add(typeof(ST), false, 1, 6, new System.Object[]{message}, "Payor subscriber ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 144}, "Eligibility source");
       this.add(typeof(CM_RMC), false, 0, 25, new System.Object[]{message}, "Room coverage type / amount");
       this.add(typeof(CM_PTA), false, 0, 25, new System.Object[]{message}, "Policy type / amount");
       this.add(typeof(CM_DDI), false, 1, 25, new System.Object[]{message}, "Daily deductible");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Insured's employee ID(IN2-1).
	*/
	public ST InsuredSEmployeeID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Insured's social security number(IN2-2).
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
	* Returns Insured's employer name(IN2-3).
	*/
	public CN_PERSON InsuredSEmployerName
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Employer information data(IN2-4).
	*/
	public ID EmployerInformationData
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
	* Returns Mail claim party(IN2-5).
	*/
	public ID MailClaimParty
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Medicare health insurance card number(IN2-6).
	*/
	public NM MedicareHealthInsuranceCardNumber
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
	* Returns Medicaid case name(IN2-7).
	*/
	public PN MedicaidCaseName
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (PN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Medicaid case number(IN2-8).
	*/
	public NM MedicaidCaseNumber
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
	* Returns Champus sponsor name(IN2-9).
	*/
	public PN ChampusSponsorName
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (PN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Champus ID number(IN2-10).
	*/
	public NM ChampusIDNumber
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
	* Returns Dependent of champus recipient(IN2-11).
	*/
	public ID DependentOfChampusRecipient
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
	* Returns Champus organization(IN2-12).
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
	* Returns Champus station(IN2-13).
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
	* Returns Champus service(IN2-14).
	*/
	public ID ChampusService
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
	* Returns Champus rank / grade(IN2-15).
	*/
	public ID ChampusRankGrade
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
	* Returns Champus status(IN2-16).
	*/
	public ID ChampusStatus
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
	* Returns Champus retire date(IN2-17).
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
	* Returns Champus non-availability certification on file(IN2-18).
	*/
	public ID ChampusNonAvailabilityCertificationOnFile
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
	* Returns Baby coverage(IN2-19).
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
	* Returns Combine baby bill(IN2-20).
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
	* Returns Blood deductible(IN2-21).
	*/
	public NM BloodDeductible
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns Special coverage approval name(IN2-22).
	*/
	public PN SpecialCoverageApprovalName
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(22, 0);
				ret = (PN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Special coverage approval title(IN2-23).
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
	* Returns a single repetition of Non-covered insurance code(IN2-24).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getNonCoveredInsuranceCode(int rep)
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
   * Returns all repetitions of Non-covered insurance code (IN2-24).
   */
  public ID[] getNonCoveredInsuranceCode() {
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
	* Returns Payor ID(IN2-25).
	*/
	public ST PayorID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Payor subscriber ID(IN2-26).
	*/
	public ST PayorSubscriberID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(26, 0);
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
	* Returns Eligibility source(IN2-27).
	*/
	public ID EligibilitySource
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(27, 0);
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
	* Returns a single repetition of Room coverage type / amount(IN2-28).
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
   * Returns all repetitions of Room coverage type / amount (IN2-28).
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
	* Returns a single repetition of Policy type / amount(IN2-29).
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
   * Returns all repetitions of Policy type / amount (IN2-29).
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
	* Returns Daily deductible(IN2-30).
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


}}