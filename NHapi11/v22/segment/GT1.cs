using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 GT1 message segment. 
 * This segment has the following fields:</p><p>
 * GT1-1: Set ID - guarantor (SI)<br> 
 * GT1-2: Guarantor number (CK)<br> 
 * GT1-3: Guarantor name (PN)<br> 
 * GT1-4: Guarantor spouse name (PN)<br> 
 * GT1-5: Guarantor address (AD)<br> 
 * GT1-6: Guarantor phone number - home (TN)<br> 
 * GT1-7: Guarantor phone number - business (TN)<br> 
 * GT1-8: Guarantor date of birth (DT)<br> 
 * GT1-9: Guarantor sex (ID)<br> 
 * GT1-10: Guarantor type (ID)<br> 
 * GT1-11: Guarantor relationship (ID)<br> 
 * GT1-12: Guarantor social security number (ST)<br> 
 * GT1-13: Guarantor date - begin (DT)<br> 
 * GT1-14: Guarantor date - end (DT)<br> 
 * GT1-15: Guarantor priority (NM)<br> 
 * GT1-16: Guarantor employer name (ST)<br> 
 * GT1-17: Guarantor employer address (AD)<br> 
 * GT1-18: Guarantor employ phone number (TN)<br> 
 * GT1-19: Guarantor employee ID number (ST)<br> 
 * GT1-20: Guarantor employment status (ID)<br> 
 * GT1-21: Guarantor organization (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class GT1 : AbstractSegment  {

  /**
   * Creates a GT1 (GUARANTOR) segment object that belongs to the given 
   * message.  
   */
  public GT1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - guarantor");
       this.add(typeof(CK), false, 1, 20, new System.Object[]{message}, "Guarantor number");
       this.add(typeof(PN), true, 1, 48, new System.Object[]{message}, "Guarantor name");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Guarantor spouse name");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "Guarantor address");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Guarantor phone number - home");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Guarantor phone number - business");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Guarantor date of birth");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1}, "Guarantor sex");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 68}, "Guarantor type");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 63}, "Guarantor relationship");
       this.add(typeof(ST), false, 1, 11, new System.Object[]{message}, "Guarantor social security number");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Guarantor date - begin");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Guarantor date - end");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Guarantor priority");
       this.add(typeof(ST), false, 1, 45, new System.Object[]{message}, "Guarantor employer name");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "Guarantor employer address");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Guarantor employ phone number");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Guarantor employee ID number");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 66}, "Guarantor employment status");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Guarantor organization");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - guarantor(GT1-1).
	*/
	public SI SetIDGuarantor
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
	* Returns Guarantor number(GT1-2).
	*/
	public CK GuarantorNumber
	{
		get{
			CK ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (CK)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Guarantor name(GT1-3).
	*/
	public PN GuarantorName
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Guarantor spouse name(GT1-4).
	*/
	public PN GuarantorSpouseName
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Guarantor address(GT1-5).
	*/
	public AD GuarantorAddress
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
	* Returns a single repetition of Guarantor phone number - home(GT1-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getGuarantorPhoneNumberHome(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Guarantor phone number - home (GT1-6).
   */
  public TN[] getGuarantorPhoneNumberHome() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(6);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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
	* Returns a single repetition of Guarantor phone number - business(GT1-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getGuarantorPhoneNumberBusiness(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Guarantor phone number - business (GT1-7).
   */
  public TN[] getGuarantorPhoneNumberBusiness() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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
	* Returns Guarantor date of birth(GT1-8).
	*/
	public DT GuarantorDateOfBirth
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Guarantor sex(GT1-9).
	*/
	public ID GuarantorSex
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Guarantor type(GT1-10).
	*/
	public ID GuarantorType
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
	* Returns Guarantor relationship(GT1-11).
	*/
	public ID GuarantorRelationship
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
	* Returns Guarantor social security number(GT1-12).
	*/
	public ST GuarantorSocialSecurityNumber
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
	* Returns Guarantor date - begin(GT1-13).
	*/
	public DT GuarantorDateBegin
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
	* Returns Guarantor date - end(GT1-14).
	*/
	public DT GuarantorDateEnd
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
	* Returns Guarantor priority(GT1-15).
	*/
	public NM GuarantorPriority
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns Guarantor employer name(GT1-16).
	*/
	public ST GuarantorEmployerName
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns Guarantor employer address(GT1-17).
	*/
	public AD GuarantorEmployerAddress
	{
		get{
			AD ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns a single repetition of Guarantor employ phone number(GT1-18).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getGuarantorEmployPhoneNumber(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(18, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Guarantor employ phone number (GT1-18).
   */
  public TN[] getGuarantorEmployPhoneNumber() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(18);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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
	* Returns Guarantor employee ID number(GT1-19).
	*/
	public ST GuarantorEmployeeIDNumber
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Guarantor employment status(GT1-20).
	*/
	public ID GuarantorEmploymentStatus
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
	* Returns Guarantor organization(GT1-21).
	*/
	public ST GuarantorOrganization
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


}}