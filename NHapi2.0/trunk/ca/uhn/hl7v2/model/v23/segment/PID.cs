using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 PID message segment. 
 * This segment has the following fields:</p><p>
 * PID-1: Set ID - Patient ID (SI)<br> 
 * PID-2: Patient ID (External ID) (CX)<br> 
 * PID-3: Patient ID (Internal ID) (CX)<br> 
 * PID-4: Alternate Patient ID (CX)<br> 
 * PID-5: Patient Name (XPN)<br> 
 * PID-6: Mother's Maiden Name (XPN)<br> 
 * PID-7: Date of Birth (TS)<br> 
 * PID-8: Sex (IS)<br> 
 * PID-9: Patient Alias (XPN)<br> 
 * PID-10: Race (IS)<br> 
 * PID-11: Patient Address (XAD)<br> 
 * PID-12: County Code (IS)<br> 
 * PID-13: Phone Number - Home (TN)<br> 
 * PID-14: Phone Number - Business (TN)<br> 
 * PID-15: Primary Language (CE)<br> 
 * PID-16: Marital Status (IS)<br> 
 * PID-17: Religion (IS)<br> 
 * PID-18: Patient Account Number (CX)<br> 
 * PID-19: SSN Number - Patient (ST)<br> 
 * PID-20: Driver's License Number (DLN)<br> 
 * PID-21: Mother's Identifier (CX)<br> 
 * PID-22: Ethnic Group (IS)<br> 
 * PID-23: Birth Place (ST)<br> 
 * PID-24: Multiple Birth Indicator (ID)<br> 
 * PID-25: Birth Order (NM)<br> 
 * PID-26: Citizenship (IS)<br> 
 * PID-27: Veterans Military Status (CE)<br> 
 * PID-28: Nationality Code (CE)<br> 
 * PID-29: Patient Death Date and Time (TS)<br> 
 * PID-30: Patient Death Indicator (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class PID : AbstractSegment  {

  /**
   * Creates a PID (Patient Identification) segment object that belongs to the given 
   * message.  
   */
  public PID(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
       this.add(typeof(CX), false, 1, 16, new System.Object[]{message});
       this.add(typeof(CX), true, 0, 20, new System.Object[]{message});
       this.add(typeof(CX), false, 1, 12, new System.Object[]{message});
       this.add(typeof(XPN), true, 1, 48, new System.Object[]{message});
       this.add(typeof(XPN), false, 1, 48, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1});
       this.add(typeof(XPN), false, 0, 48, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 5});
       this.add(typeof(XAD), false, 0, 106, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 4, new System.Object[]{message, 0});
       this.add(typeof(TN), false, 0, 40, new System.Object[]{message});
       this.add(typeof(TN), false, 0, 40, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 2});
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 6});
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
       this.add(typeof(DLN), false, 1, 25, new System.Object[]{message});
       this.add(typeof(CX), false, 1, 20, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 189});
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 136});
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 4, new System.Object[]{message, 171});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Set ID - Patient ID (PID-1).
	*/
	public SI SetIDPatientID
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
	* Returns Patient ID (External ID) (PID-2).
	*/
	public CX PatientIDExternalID
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns a single repetition of Patient ID (Internal ID) (PID-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CX getPatientIDInternalID(int rep)
	{
			CX ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Patient ID (Internal ID) (PID-3).
   */
  public CX[] getPatientIDInternalID() {
     CX[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new CX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CX)t[i];
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
	* Returns Alternate Patient ID (PID-4).
	*/
	public CX AlternatePatientID
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
	* Returns Patient Name (PID-5).
	*/
	public XPN PatientName
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Mother's Maiden Name (PID-6).
	*/
	public XPN MotherSMaidenName
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
	* Returns Date of Birth (PID-7).
	*/
	public TS DateOfBirth
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Sex (PID-8).
	*/
	public IS Sex
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns a single repetition of Patient Alias (PID-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XPN getPatientAlias(int rep)
	{
			XPN ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Patient Alias (PID-9).
   */
  public XPN[] getPatientAlias() {
     XPN[] ret = null;
    try {
        Type[] t = this.getField(9);  
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
	* Returns Race (PID-10).
	*/
	public IS Race
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns a single repetition of Patient Address (PID-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getPatientAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Patient Address (PID-11).
   */
  public XAD[] getPatientAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
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
	* Returns County Code (PID-12).
	*/
	public IS CountyCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns a single repetition of Phone Number - Home (PID-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getPhoneNumberHome(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Phone Number - Home (PID-13).
   */
  public TN[] getPhoneNumberHome() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(13);  
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
	* Returns a single repetition of Phone Number - Business (PID-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getPhoneNumberBusiness(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Phone Number - Business (PID-14).
   */
  public TN[] getPhoneNumberBusiness() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(14);  
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
	* Returns Primary Language (PID-15).
	*/
	public CE PrimaryLanguage
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns a single repetition of Marital Status (PID-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getMaritalStatus(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Marital Status (PID-16).
   */
  public IS[] getMaritalStatus() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(16);  
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
	* Returns Religion (PID-17).
	*/
	public IS Religion
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
	* Returns Patient Account Number (PID-18).
	*/
	public CX PatientAccountNumber
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns SSN Number - Patient (PID-19).
	*/
	public ST SSNNumberPatient
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
	* Returns Driver's License Number (PID-20).
	*/
	public DLN DriverSLicenseNumber
	{
		get{
			DLN ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (DLN)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Mother's Identifier (PID-21).
	*/
	public CX MotherSIdentifier
	{
		get{
			CX ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns Ethnic Group (PID-22).
	*/
	public IS EthnicGroup
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns Birth Place (PID-23).
	*/
	public ST BirthPlace
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
	* Returns Multiple Birth Indicator (PID-24).
	*/
	public ID MultipleBirthIndicator
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns Birth Order (PID-25).
	*/
	public NM BirthOrder
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Citizenship (PID-26).
	*/
	public IS Citizenship
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(26, 0);
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
	* Returns Veterans Military Status (PID-27).
	*/
	public CE VeteransMilitaryStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(27, 0);
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
	* Returns Nationality Code (PID-28).
	*/
	public CE NationalityCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(28, 0);
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
	* Returns Patient Death Date and Time (PID-29).
	*/
	public TS PatientDeathDateAndTime
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
	* Returns Patient Death Indicator (PID-30).
	*/
	public ID PatientDeathIndicator
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(30, 0);
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