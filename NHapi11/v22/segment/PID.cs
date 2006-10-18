using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 PID message segment. 
 * This segment has the following fields:</p><p>
 * PID-1: Set ID - Patient ID (SI)<br> 
 * PID-2: Patient ID (External ID) (CK_PAT_ID)<br> 
 * PID-3: Patient ID (Internal ID) (CM_PAT_ID)<br> 
 * PID-4: Alternate Patient ID (ST)<br> 
 * PID-5: Patient Name (PN)<br> 
 * PID-6: Mother's Maiden Name (ST)<br> 
 * PID-7: Date of Birth (TS)<br> 
 * PID-8: Sex (ID)<br> 
 * PID-9: Patient Alias (PN)<br> 
 * PID-10: Race (ID)<br> 
 * PID-11: Patient Address (AD)<br> 
 * PID-12: County code (ID)<br> 
 * PID-13: Phone Number - Home (TN)<br> 
 * PID-14: Phone Number - Business (TN)<br> 
 * PID-15: Language - Patient (ST)<br> 
 * PID-16: Marital Status (ID)<br> 
 * PID-17: Religion (ID)<br> 
 * PID-18: Patient Account Number (CK_PAT_ID)<br> 
 * PID-19: Social security number - patient (ST)<br> 
 * PID-20: Driver's license number - patient (CM_LICENSE_NO)<br> 
 * PID-21: Mother's Identifier (CK_PAT_ID)<br> 
 * PID-22: Ethnic Group (ID)<br> 
 * PID-23: Birth Place (ST)<br> 
 * PID-24: Multiple Birth Indicator (ID)<br> 
 * PID-25: Birth Order (NM)<br> 
 * PID-26: Citizenship (ID)<br> 
 * PID-27: Veterans Military Status (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class PID : AbstractSegment  {

  /**
   * Creates a PID (PATIENT IDENTIFICATION) segment object that belongs to the given 
   * message.  
   */
  public PID(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - Patient ID");
       this.add(typeof(CK_PAT_ID), false, 1, 16, new System.Object[]{message}, "Patient ID (External ID)");
       this.add(typeof(CM_PAT_ID), true, 0, 20, new System.Object[]{message}, "Patient ID (Internal ID)");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "Alternate Patient ID");
       this.add(typeof(PN), true, 1, 48, new System.Object[]{message}, "Patient Name");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Mother's Maiden Name");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date of Birth");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1}, "Sex");
       this.add(typeof(PN), false, 0, 48, new System.Object[]{message}, "Patient Alias");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 5}, "Race");
       this.add(typeof(AD), false, 3, 106, new System.Object[]{message}, "Patient Address");
       this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 0}, "County code");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Phone Number - Home");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Phone Number - Business");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Language - Patient");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 2}, "Marital Status");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 6}, "Religion");
       this.add(typeof(CK_PAT_ID), false, 1, 20, new System.Object[]{message}, "Patient Account Number");
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message}, "Social security number - patient");
       this.add(typeof(CM_LICENSE_NO), false, 1, 25, new System.Object[]{message}, "Driver's license number - patient");
       this.add(typeof(CK_PAT_ID), false, 1, 20, new System.Object[]{message}, "Mother's Identifier");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 189}, "Ethnic Group");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "Birth Place");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Multiple Birth Indicator");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Birth Order");
       this.add(typeof(ID), false, 0, 3, new System.Object[]{message, 171}, "Citizenship");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Veterans Military Status");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - Patient ID(PID-1).
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
	* Returns Patient ID (External ID)(PID-2).
	*/
	public CK_PAT_ID PatientIDExternalID
	{
		get{
			CK_PAT_ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (CK_PAT_ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Patient ID (Internal ID)(PID-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_PAT_ID getPatientIDInternalID(int rep)
	{
			CM_PAT_ID ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (CM_PAT_ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Patient ID (Internal ID) (PID-3).
   */
  public CM_PAT_ID[] getPatientIDInternalID() {
     CM_PAT_ID[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new CM_PAT_ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_PAT_ID)t[i];
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
	* Returns Alternate Patient ID(PID-4).
	*/
	public ST AlternatePatientID
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
	* Returns Patient Name(PID-5).
	*/
	public PN PatientName
	{
		get{
			PN ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Mother's Maiden Name(PID-6).
	*/
	public ST MotherSMaidenName
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
	* Returns Date of Birth(PID-7).
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
	* Returns Sex(PID-8).
	*/
	public ID Sex
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns a single repetition of Patient Alias(PID-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public PN getPatientAlias(int rep)
	{
			PN ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (PN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Patient Alias (PID-9).
   */
  public PN[] getPatientAlias() {
     PN[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new PN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PN)t[i];
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
	* Returns Race(PID-10).
	*/
	public ID Race
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
	* Returns a single repetition of Patient Address(PID-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public AD getPatientAddress(int rep)
	{
			AD ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (AD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Patient Address (PID-11).
   */
  public AD[] getPatientAddress() {
     AD[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new AD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (AD)t[i];
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
	* Returns County code(PID-12).
	*/
	public ID CountyCode
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
	* Returns a single repetition of Phone Number - Home(PID-13).
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
	* Returns a single repetition of Phone Number - Business(PID-14).
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
	* Returns Language - Patient(PID-15).
	*/
	public ST LanguagePatient
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns Marital Status(PID-16).
	*/
	public ID MaritalStatus
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
	* Returns Religion(PID-17).
	*/
	public ID Religion
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
	* Returns Patient Account Number(PID-18).
	*/
	public CK_PAT_ID PatientAccountNumber
	{
		get{
			CK_PAT_ID ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (CK_PAT_ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Social security number - patient(PID-19).
	*/
	public ST SocialSecurityNumberPatient
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
	* Returns Driver's license number - patient(PID-20).
	*/
	public CM_LICENSE_NO DriverSLicenseNumberPatient
	{
		get{
			CM_LICENSE_NO ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (CM_LICENSE_NO)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Mother's Identifier(PID-21).
	*/
	public CK_PAT_ID MotherSIdentifier
	{
		get{
			CK_PAT_ID ret = null;
			try
			{
			Type t = this.getField(21, 0);
				ret = (CK_PAT_ID)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Ethnic Group(PID-22).
	*/
	public ID EthnicGroup
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
	* Returns Birth Place(PID-23).
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
	* Returns Multiple Birth Indicator(PID-24).
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
	* Returns Birth Order(PID-25).
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
	* Returns a single repetition of Citizenship(PID-26).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getCitizenship(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(26, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Citizenship (PID-26).
   */
  public ID[] getCitizenship() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(26);  
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
	* Returns Veterans Military Status(PID-27).
	*/
	public ST VeteransMilitaryStatus
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(27, 0);
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