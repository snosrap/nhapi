using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 IN3 message segment. 
 * This segment has the following fields:</p><p>
 * IN3-1: Set ID - insurance certification (SI)<br> 
 * IN3-2: Certification number (ST)<br> 
 * IN3-3: Certified by (CN_PERSON)<br> 
 * IN3-4: Certification required (ID)<br> 
 * IN3-5: Penalty (CM_PEN)<br> 
 * IN3-6: Certification date / time (TS)<br> 
 * IN3-7: Certification modify date / time (TS)<br> 
 * IN3-8: Operator (CN_PERSON)<br> 
 * IN3-9: Certification begin date (DT)<br> 
 * IN3-10: Certification end date (DT)<br> 
 * IN3-11: Days (CM_DTN)<br> 
 * IN3-12: Non-concur code / description (CE)<br> 
 * IN3-13: Non-concur effective date / time (TS)<br> 
 * IN3-14: Physician reviewer (CN_PERSON)<br> 
 * IN3-15: Certification contact (ST)<br> 
 * IN3-16: Certification contact phone number (TN)<br> 
 * IN3-17: Appeal reason (CE)<br> 
 * IN3-18: Certification agency (CE)<br> 
 * IN3-19: Certification agency phone number (TN)<br> 
 * IN3-20: Pre-certification required / window (CM_PCF)<br> 
 * IN3-21: Case manager (ST)<br> 
 * IN3-22: Second opinion date (DT)<br> 
 * IN3-23: Second opinion status (ID)<br> 
 * IN3-24: Second opinion documentation received (ID)<br> 
 * IN3-25: Second opinion practitioner (CN_PERSON)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IN3 : AbstractSegment  {

  /**
   * Creates a IN3 (INSURANCE ADDITIONAL INFO-CERTIFICATION) segment object that belongs to the given 
   * message.  
   */
	public IN3(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - insurance certification");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Certification number");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Certified by");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Certification required");
       this.add(typeof(CM_PEN), false, 1, 10, new System.Object[]{message}, "Penalty");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Certification date / time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Certification modify date / time");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Operator");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Certification begin date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Certification end date");
       this.add(typeof(CM_DTN), false, 1, 3, new System.Object[]{message}, "Days");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Non-concur code / description");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Non-concur effective date / time");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Physician reviewer");
       this.add(typeof(ST), false, 1, 48, new System.Object[]{message}, "Certification contact");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Certification contact phone number");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Appeal reason");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Certification agency");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Certification agency phone number");
       this.add(typeof(CM_PCF), false, 0, 40, new System.Object[]{message}, "Pre-certification required / window");
       this.add(typeof(ST), false, 1, 48, new System.Object[]{message}, "Case manager");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Second opinion date");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 151}, "Second opinion status");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 152}, "Second opinion documentation received");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Second opinion practitioner");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Set ID - insurance certification(IN3-1).
	*/
	public SI SetIDInsuranceCertification
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns Certification number(IN3-2).
	*/
	public ST CertificationNumber
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns Certified by(IN3-3).
	*/
	public CN_PERSON CertifiedBy
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns Certification required(IN3-4).
	*/
	public ID CertificationRequired
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns Penalty(IN3-5).
	*/
	public CM_PEN Penalty
	{
		get{
			CM_PEN ret = null;
			try
			{
			IType t = this.getField(5, 0);
				ret = (CM_PEN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Certification date / time(IN3-6).
	*/
	public TS CertificationDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns Certification modify date / time(IN3-7).
	*/
	public TS CertificationModifyDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns Operator(IN3-8).
	*/
	public CN_PERSON Operator
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns Certification begin date(IN3-9).
	*/
	public DT CertificationBeginDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns Certification end date(IN3-10).
	*/
	public DT CertificationEndDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(10, 0);
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
	* Returns Days(IN3-11).
	*/
	public CM_DTN Days
	{
		get{
			CM_DTN ret = null;
			try
			{
			IType t = this.getField(11, 0);
				ret = (CM_DTN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Non-concur code / description(IN3-12).
	*/
	public CE NonConcurCodeDescription
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns Non-concur effective date / time(IN3-13).
	*/
	public TS NonConcurEffectiveDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(13, 0);
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
	* Returns Physician reviewer(IN3-14).
	*/
	public CN_PERSON PhysicianReviewer
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.getField(14, 0);
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
	* Returns Certification contact(IN3-15).
	*/
	public ST CertificationContact
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(15, 0);
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
	* Returns a single repetition of Certification contact phone number(IN3-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getCertificationContactPhoneNumber(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.getField(16, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Certification contact phone number (IN3-16).
   */
  public TN[] getCertificationContactPhoneNumber() {
     TN[] ret = null;
    try {
        IType[] t = this.getField(16);  
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
	* Returns Appeal reason(IN3-17).
	*/
	public CE AppealReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(17, 0);
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
	* Returns Certification agency(IN3-18).
	*/
	public CE CertificationAgency
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(18, 0);
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
	* Returns a single repetition of Certification agency phone number(IN3-19).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getCertificationAgencyPhoneNumber(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.getField(19, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Certification agency phone number (IN3-19).
   */
  public TN[] getCertificationAgencyPhoneNumber() {
     TN[] ret = null;
    try {
        IType[] t = this.getField(19);  
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
	* Returns a single repetition of Pre-certification required / window(IN3-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_PCF getPreCertificationRequiredWindow(int rep)
	{
			CM_PCF ret = null;
			try
			{
			IType t = this.getField(20, rep);
				ret = (CM_PCF)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Pre-certification required / window (IN3-20).
   */
  public CM_PCF[] getPreCertificationRequiredWindow() {
     CM_PCF[] ret = null;
    try {
        IType[] t = this.getField(20);  
        ret = new CM_PCF[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_PCF)t[i];
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
	* Returns Case manager(IN3-21).
	*/
	public ST CaseManager
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(21, 0);
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
	* Returns Second opinion date(IN3-22).
	*/
	public DT SecondOpinionDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(22, 0);
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
	* Returns Second opinion status(IN3-23).
	*/
	public ID SecondOpinionStatus
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(23, 0);
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
	* Returns Second opinion documentation received(IN3-24).
	*/
	public ID SecondOpinionDocumentationReceived
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(24, 0);
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
	* Returns Second opinion practitioner(IN3-25).
	*/
	public CN_PERSON SecondOpinionPractitioner
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.getField(25, 0);
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


}}