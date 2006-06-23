using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v231.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v231.segment{

/**
 * <p>Represents an HL7 CSR message segment. 
 * This segment has the following fields:</p><p>
 * CSR-1: Sponsor Study ID (EI)<br> 
 * CSR-2: Alternate Study ID (EI)<br> 
 * CSR-3: Institution Registering the Patient (CE)<br> 
 * CSR-4: Sponsor Patient ID (CX)<br> 
 * CSR-5: Alternate Patient ID - CSR (CX)<br> 
 * CSR-6: Date/Time Of Patient Study Registration (TS)<br> 
 * CSR-7: Person Performing Study Registration (XCN)<br> 
 * CSR-8: Study Authorizing Provider (XCN)<br> 
 * CSR-9: Date/time Patient Study Consent Signed (TS)<br> 
 * CSR-10: Patient Study Eligibility Status (CE)<br> 
 * CSR-11: Study Randomization Date/time (TS)<br> 
 * CSR-12: Randomized Study Arm (CE)<br> 
 * CSR-13: Stratum for Study Randomization (CE)<br> 
 * CSR-14: Patient Evaluability Status (CE)<br> 
 * CSR-15: Date/time Ended Study (TS)<br> 
 * CSR-16: Reason Ended Study (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class CSR : AbstractSegment  {

  /**
   * Creates a CSR (CSR - clinical study registration segment) segment object that belongs to the given 
   * message.  
   */
  public CSR(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(EI), true, 1, 60, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CX), true, 1, 30, new System.Object[]{message});
       this.add(typeof(CX), false, 1, 30, new System.Object[]{message});
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 60, new System.Object[]{message});
       this.add(typeof(XCN), true, 0, 60, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(TS), false, 3, 26, new System.Object[]{message});
       this.add(typeof(CE), false, 3, 200, new System.Object[]{message});
       this.add(typeof(CE), false, 3, 200, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Sponsor Study ID (CSR-1).
	*/
	public EI SponsorStudyID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Alternate Study ID (CSR-2).
	*/
	public EI AlternateStudyID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (EI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Institution Registering the Patient (CSR-3).
	*/
	public CE InstitutionRegisteringThePatient
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Sponsor Patient ID (CSR-4).
	*/
	public CX SponsorPatientID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Alternate Patient ID - CSR (CSR-5).
	*/
	public CX AlternatePatientIDCSR
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
	* Returns Date/Time Of Patient Study Registration (CSR-6).
	*/
	public TS DateTimeOfPatientStudyRegistration
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns a single repetition of Person Performing Study Registration (CSR-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getPersonPerformingStudyRegistration(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Person Performing Study Registration (CSR-7).
   */
  public XCN[] getPersonPerformingStudyRegistration() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(7);  
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
	* Returns a single repetition of Study Authorizing Provider (CSR-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getStudyAuthorizingProvider(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Study Authorizing Provider (CSR-8).
   */
  public XCN[] getStudyAuthorizingProvider() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(8);  
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
	* Returns Date/time Patient Study Consent Signed (CSR-9).
	*/
	public TS DateTimePatientStudyConsentSigned
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Patient Study Eligibility Status (CSR-10).
	*/
	public CE PatientStudyEligibilityStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns a single repetition of Study Randomization Date/time (CSR-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TS getStudyRandomizationDateTime(int rep)
	{
			TS ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (TS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Study Randomization Date/time (CSR-11).
   */
  public TS[] getStudyRandomizationDateTime() {
     TS[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new TS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TS)t[i];
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
	* Returns a single repetition of Randomized Study Arm (CSR-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getRandomizedStudyArm(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Randomized Study Arm (CSR-12).
   */
  public CE[] getRandomizedStudyArm() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(12);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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
	* Returns a single repetition of Stratum for Study Randomization (CSR-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getStratumForStudyRandomization(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Stratum for Study Randomization (CSR-13).
   */
  public CE[] getStratumForStudyRandomization() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(13);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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
	* Returns Patient Evaluability Status (CSR-14).
	*/
	public CE PatientEvaluabilityStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns Date/time Ended Study (CSR-15).
	*/
	public TS DateTimeEndedStudy
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns Reason Ended Study (CSR-16).
	*/
	public CE ReasonEndedStudy
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(16, 0);
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


}}