using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 IN1 message segment. 
 * This segment has the following fields:</p><p>
 * IN1-1: SET ID - INSURANCE (SI)<br> 
 * IN1-2: INSURANCE PLAN ID (ID)<br> 
 * IN1-3: INSURANCE COMPANY ID (ST)<br> 
 * IN1-4: INSURANCE COMPANY NAME (ST)<br> 
 * IN1-5: INSURANCE COMPANY ADDRESS (AD)<br> 
 * IN1-6: INSURANCE CO. CONTACT PERS (PN)<br> 
 * IN1-7: INSURANCE CO PHONE NUMBER (TN)<br> 
 * IN1-8: GROUP NUMBER (ST)<br> 
 * IN1-9: GROUP NAME (ST)<br> 
 * IN1-10: INSURED'S GROUP EMP. ID (ST)<br> 
 * IN1-11: INSURED'S GROUP EMP. NAME (ST)<br> 
 * IN1-12: PLAN EFFECTIVE DATE (DT)<br> 
 * IN1-13: PLAN EXPIRATION DATE (DT)<br> 
 * IN1-14: AUTHORIZATION INFORMATION (ST)<br> 
 * IN1-15: PLAN TYPE (ID)<br> 
 * IN1-16: NAME OF INSURED (PN)<br> 
 * IN1-17: INSURED'S RELATIONSHIP TO PATIENT (ID)<br> 
 * IN1-18: INSURED'S DATE OF BIRTH (DT)<br> 
 * IN1-19: INSURED'S ADDRESS (AD)<br> 
 * IN1-20: ASSIGNMENT OF BENEFITS (ID)<br> 
 * IN1-21: COORDINATION OF BENEFITS (ID)<br> 
 * IN1-22: COORD OF BEN. PRIORITY (ST)<br> 
 * IN1-23: NOTICE OF ADMISSION CODE (ID)<br> 
 * IN1-24: NOTICE OF ADMISSION DATE (DT)<br> 
 * IN1-25: RPT OF ELIGIBILITY CODE (ID)<br> 
 * IN1-26: RPT OF ELIGIBILITY DATE (DT)<br> 
 * IN1-27: RELEASE INFORMATION CODE (ID)<br> 
 * IN1-28: PRE-ADMIT CERT. (PAC) (ST)<br> 
 * IN1-29: VERIFICATION DATE (DT)<br> 
 * IN1-30: VERIFICATION BY (CM)<br> 
 * IN1-31: TYPE OF AGREEMENT CODE (ID)<br> 
 * IN1-32: BILLING STATUS (ID)<br> 
 * IN1-33: LIFETIME RESERVE DAYS (NM)<br> 
 * IN1-34: DELAY BEFORE L. R. DAY (NM)<br> 
 * IN1-35: COMPANY PLAN CODE (ST)<br> 
 * IN1-36: POLICY NUMBER (ST)<br> 
 * IN1-37: POLICY DEDUCTIBLE (NM)<br> 
 * IN1-38: POLICY LIMIT - AMOUNT (NM)<br> 
 * IN1-39: POLICY LIMIT - DAYS (NM)<br> 
 * IN1-40: ROOM RATE - SEMI-PRIVATE (NM)<br> 
 * IN1-41: ROOM RATE - PRIVATE (NM)<br> 
 * IN1-42: INSURED'S EMPLOYMENT STATUS (ID)<br> 
 * IN1-43: INSURED'S SEX (ID)<br> 
 * IN1-44: INSURED'S EMPLOYER ADDRESS (AD)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IN1 : AbstractSegment  {

  /**
   * Creates a IN1 (INSURANCE) segment object that belongs to the given 
   * message.  
   */
  public IN1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "SET ID - INSURANCE");
       this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 72}, "INSURANCE PLAN ID");
       this.add(typeof(ST), true, 1, 6, new System.Object[]{message}, "INSURANCE COMPANY ID");
       this.add(typeof(ST), false, 1, 45, new System.Object[]{message}, "INSURANCE COMPANY NAME");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "INSURANCE COMPANY ADDRESS");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "INSURANCE CO. CONTACT PERS");
       this.add(typeof(TN), false, 1, 40, new System.Object[]{message}, "INSURANCE CO PHONE NUMBER");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "GROUP NUMBER");
       this.add(typeof(ST), false, 1, 35, new System.Object[]{message}, "GROUP NAME");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "INSURED'S GROUP EMP. ID");
       this.add(typeof(ST), false, 1, 45, new System.Object[]{message}, "INSURED'S GROUP EMP. NAME");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PLAN EFFECTIVE DATE");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "PLAN EXPIRATION DATE");
       this.add(typeof(ST), false, 1, 55, new System.Object[]{message}, "AUTHORIZATION INFORMATION");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 86}, "PLAN TYPE");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "NAME OF INSURED");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 63}, "INSURED'S RELATIONSHIP TO PATIENT");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "INSURED'S DATE OF BIRTH");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "INSURED'S ADDRESS");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "ASSIGNMENT OF BENEFITS");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "COORDINATION OF BENEFITS");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "COORD OF BEN. PRIORITY");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 81}, "NOTICE OF ADMISSION CODE");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "NOTICE OF ADMISSION DATE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 94}, "RPT OF ELIGIBILITY CODE");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "RPT OF ELIGIBILITY DATE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 93}, "RELEASE INFORMATION CODE");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "PRE-ADMIT CERT. (PAC)");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "VERIFICATION DATE");
       this.add(typeof(CM), false, 1, 60, new System.Object[]{message}, "VERIFICATION BY");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 98}, "TYPE OF AGREEMENT CODE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 22}, "BILLING STATUS");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "LIFETIME RESERVE DAYS");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "DELAY BEFORE L. R. DAY");
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message}, "COMPANY PLAN CODE");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "POLICY NUMBER");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "POLICY DEDUCTIBLE");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "POLICY LIMIT - AMOUNT");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "POLICY LIMIT - DAYS");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "ROOM RATE - SEMI-PRIVATE");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "ROOM RATE - PRIVATE");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 66}, "INSURED'S EMPLOYMENT STATUS");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1}, "INSURED'S SEX");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "INSURED'S EMPLOYER ADDRESS");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns SET ID - INSURANCE(IN1-1).
	*/
	public SI SETIDINSURANCE
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
	* Returns INSURANCE PLAN ID(IN1-2).
	*/
	public ID INSURANCEPLANID
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
	* Returns INSURANCE COMPANY ID(IN1-3).
	*/
	public ST INSURANCECOMPANYID
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
	* Returns INSURANCE COMPANY NAME(IN1-4).
	*/
	public ST INSURANCECOMPANYNAME
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
	* Returns INSURANCE COMPANY ADDRESS(IN1-5).
	*/
	public AD INSURANCECOMPANYADDRESS
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (AD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns INSURANCE CO. CONTACT PERS(IN1-6).
	*/
	public PN INSURANCECOCONTACTPERS
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns INSURANCE CO PHONE NUMBER(IN1-7).
	*/
	public TN INSURANCECOPHONENUMBER
	{
		get{
			TN ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (TN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns GROUP NUMBER(IN1-8).
	*/
	public ST GROUPNUMBER
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
	* Returns GROUP NAME(IN1-9).
	*/
	public ST GROUPNAME
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
	* Returns INSURED'S GROUP EMP. ID(IN1-10).
	*/
	public ST INSUREDSGROUPEMPID
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
	* Returns INSURED'S GROUP EMP. NAME(IN1-11).
	*/
	public ST INSUREDSGROUPEMPNAME
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
	* Returns PLAN EFFECTIVE DATE(IN1-12).
	*/
	public DT PLANEFFECTIVEDATE
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
	* Returns PLAN EXPIRATION DATE(IN1-13).
	*/
	public DT PLANEXPIRATIONDATE
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
	* Returns AUTHORIZATION INFORMATION(IN1-14).
	*/
	public ST AUTHORIZATIONINFORMATION
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns PLAN TYPE(IN1-15).
	*/
	public ID PLANTYPE
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
	* Returns NAME OF INSURED(IN1-16).
	*/
	public PN NAMEOFINSURED
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns INSURED'S RELATIONSHIP TO PATIENT(IN1-17).
	*/
	public ID INSUREDSRELATIONSHIPTOPATIENT
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
	* Returns INSURED'S DATE OF BIRTH(IN1-18).
	*/
	public DT INSUREDSDATEOFBIRTH
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
	* Returns INSURED'S ADDRESS(IN1-19).
	*/
	public AD INSUREDSADDRESS
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (AD)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns ASSIGNMENT OF BENEFITS(IN1-20).
	*/
	public ID ASSIGNMENTOFBENEFITS
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
	* Returns COORDINATION OF BENEFITS(IN1-21).
	*/
	public ID COORDINATIONOFBENEFITS
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
	* Returns COORD OF BEN. PRIORITY(IN1-22).
	*/
	public ST COORDOFBENPRIORITY
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
	* Returns NOTICE OF ADMISSION CODE(IN1-23).
	*/
	public ID NOTICEOFADMISSIONCODE
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
	* Returns NOTICE OF ADMISSION DATE(IN1-24).
	*/
	public DT NOTICEOFADMISSIONDATE
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
	* Returns RPT OF ELIGIBILITY CODE(IN1-25).
	*/
	public ID RPTOFELIGIBILITYCODE
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
	* Returns RPT OF ELIGIBILITY DATE(IN1-26).
	*/
	public DT RPTOFELIGIBILITYDATE
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
	* Returns RELEASE INFORMATION CODE(IN1-27).
	*/
	public ID RELEASEINFORMATIONCODE
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
	* Returns PRE-ADMIT CERT. (PAC)(IN1-28).
	*/
	public ST PREADMITCERT
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
	* Returns VERIFICATION DATE(IN1-29).
	*/
	public DT VERIFICATIONDATE
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(29, 0);
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
	* Returns VERIFICATION BY(IN1-30).
	*/
	public CM VERIFICATIONBY
	{
		get{
			CM ret = null;
			try
			{
			Type t = this.getField(30, 0);
				ret = (CM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns TYPE OF AGREEMENT CODE(IN1-31).
	*/
	public ID TYPEOFAGREEMENTCODE
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
	* Returns BILLING STATUS(IN1-32).
	*/
	public ID BILLINGSTATUS
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(32, 0);
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
	* Returns LIFETIME RESERVE DAYS(IN1-33).
	*/
	public NM LIFETIMERESERVEDAYS
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
	* Returns DELAY BEFORE L. R. DAY(IN1-34).
	*/
	public NM DELAYBEFORELRDAY
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
	* Returns COMPANY PLAN CODE(IN1-35).
	*/
	public ST COMPANYPLANCODE
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(35, 0);
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
	* Returns POLICY NUMBER(IN1-36).
	*/
	public ST POLICYNUMBER
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
	* Returns POLICY DEDUCTIBLE(IN1-37).
	*/
	public NM POLICYDEDUCTIBLE
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(37, 0);
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
	* Returns POLICY LIMIT - AMOUNT(IN1-38).
	*/
	public NM POLICYLIMITAMOUNT
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(38, 0);
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
	* Returns POLICY LIMIT - DAYS(IN1-39).
	*/
	public NM POLICYLIMITDAYS
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
	* Returns ROOM RATE - SEMI-PRIVATE(IN1-40).
	*/
	public NM ROOMRATESEMIPRIVATE
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns ROOM RATE - PRIVATE(IN1-41).
	*/
	public NM ROOMRATEPRIVATE
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns INSURED'S EMPLOYMENT STATUS(IN1-42).
	*/
	public ID INSUREDSEMPLOYMENTSTATUS
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
	* Returns INSURED'S SEX(IN1-43).
	*/
	public ID INSUREDSSEX
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
	* Returns INSURED'S EMPLOYER ADDRESS(IN1-44).
	*/
	public AD INSUREDSEMPLOYERADDRESS
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(44, 0);
				ret = (AD)t;
			}
			 catch (HL7Exception he) {
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