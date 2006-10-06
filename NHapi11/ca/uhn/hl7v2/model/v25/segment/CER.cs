using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 CER message segment. 
 * This segment has the following fields:</p><p>
 * CER-1: Set ID _ CER (SI)<br> 
 * CER-2: Serial Number (ST)<br> 
 * CER-3: Version (ST)<br> 
 * CER-4: Granting Authority (XON)<br> 
 * CER-5: Issuing Authority (XCN)<br> 
 * CER-6: Signature of Issuing Authority (ED)<br> 
 * CER-7: Granting Country (ID)<br> 
 * CER-8: Granting State/Province (CWE)<br> 
 * CER-9: Granting County/Parish (CWE)<br> 
 * CER-10: Certificate Type (CWE)<br> 
 * CER-11: Certificate Domain (CWE)<br> 
 * CER-12: Subject ID (ID)<br> 
 * CER-13: Subject Name (ST)<br> 
 * CER-14: Subject Directory Attribute Extension (Health Professional Data) (CWE)<br> 
 * CER-15: Subject Public Key Info (CWE)<br> 
 * CER-16: Authority Key Identifier (CWE)<br> 
 * CER-17: Basic Constraint (ID)<br> 
 * CER-18: CRL Distribution Point (CWE)<br> 
 * CER-19: Jurisdiction Country (ID)<br> 
 * CER-20: Jurisdiction State/Province (CWE)<br> 
 * CER-21: Jurisdiction County/Parish (CWE)<br> 
 * CER-22: Jurisdiction Breadth (CWE)<br> 
 * CER-23: Granting Date (TS)<br> 
 * CER-24: Issuing Date (TS)<br> 
 * CER-25: Activation Date (TS)<br> 
 * CER-26: Inactivation Date (TS)<br> 
 * CER-27: Expiration Date (TS)<br> 
 * CER-28: Renewal Date (TS)<br> 
 * CER-29: Revocation Date (TS)<br> 
 * CER-30: Revocation Reason Code (CE)<br> 
 * CER-31: Certificate Status (CWE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class CER : AbstractSegment  {

  /**
   * Creates a CER (Certificate Detail) segment object that belongs to the given 
   * message.  
   */
  public CER(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID _ CER");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "Serial Number");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "Version");
       this.add(typeof(XON), false, 1, 250, new System.Object[]{message}, "Granting Authority");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "Issuing Authority");
       this.add(typeof(ED), false, 1, 65536, new System.Object[]{message}, "Signature of Issuing Authority");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 399}, "Granting Country");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Granting State/Province");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Granting County/Parish");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Certificate Type");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Certificate Domain");
       this.add(typeof(ID), false, 1, 250, new System.Object[]{message, 0}, "Subject ID");
       this.add(typeof(ST), true, 1, 250, new System.Object[]{message}, "Subject Name");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Subject Directory Attribute Extension (Health Professional Data)");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Subject Public Key Info");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Authority Key Identifier");
       this.add(typeof(ID), false, 1, 250, new System.Object[]{message, 136}, "Basic Constraint");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "CRL Distribution Point");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 399}, "Jurisdiction Country");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Jurisdiction State/Province");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Jurisdiction County/Parish");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Jurisdiction Breadth");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Granting Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Issuing Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Activation Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Inactivation Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Expiration Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Renewal Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Revocation Date");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Revocation Reason Code");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Certificate Status");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID _ CER(CER-1).
	*/
	public SI SetIDCER
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
	* Returns Serial Number(CER-2).
	*/
	public ST SerialNumber
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
	* Returns Version(CER-3).
	*/
	public ST Version
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
	* Returns Granting Authority(CER-4).
	*/
	public XON GrantingAuthority
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
	* Returns Issuing Authority(CER-5).
	*/
	public XCN IssuingAuthority
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Signature of Issuing Authority(CER-6).
	*/
	public ED SignatureOfIssuingAuthority
	{
		get{
			ED ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (ED)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Granting Country(CER-7).
	*/
	public ID GrantingCountry
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Granting State/Province(CER-8).
	*/
	public CWE GrantingStateProvince
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Granting County/Parish(CER-9).
	*/
	public CWE GrantingCountyParish
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Certificate Type(CER-10).
	*/
	public CWE CertificateType
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Certificate Domain(CER-11).
	*/
	public CWE CertificateDomain
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Subject ID(CER-12).
	*/
	public ID SubjectID
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
	* Returns Subject Name(CER-13).
	*/
	public ST SubjectName
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
	* Returns a single repetition of Subject Directory Attribute Extension (Health Professional Data)(CER-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getSubjectDirectoryAttributeExtensionHealthProfessionalData(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Subject Directory Attribute Extension (Health Professional Data) (CER-14).
   */
  public CWE[] getSubjectDirectoryAttributeExtensionHealthProfessionalData() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(14);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
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
	* Returns Subject Public Key Info(CER-15).
	*/
	public CWE SubjectPublicKeyInfo
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Authority Key Identifier(CER-16).
	*/
	public CWE AuthorityKeyIdentifier
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(16, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Basic Constraint(CER-17).
	*/
	public ID BasicConstraint
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
	* Returns a single repetition of CRL Distribution Point(CER-18).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getCRLDistributionPoint(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(18, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of CRL Distribution Point (CER-18).
   */
  public CWE[] getCRLDistributionPoint() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(18);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
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
	* Returns Jurisdiction Country(CER-19).
	*/
	public ID JurisdictionCountry
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
	* Returns Jurisdiction State/Province(CER-20).
	*/
	public CWE JurisdictionStateProvince
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Jurisdiction County/Parish(CER-21).
	*/
	public CWE JurisdictionCountyParish
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(21, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns a single repetition of Jurisdiction Breadth(CER-22).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getJurisdictionBreadth(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(22, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Jurisdiction Breadth (CER-22).
   */
  public CWE[] getJurisdictionBreadth() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(22);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
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
	* Returns Granting Date(CER-23).
	*/
	public TS GrantingDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns Issuing Date(CER-24).
	*/
	public TS IssuingDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns Activation Date(CER-25).
	*/
	public TS ActivationDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Inactivation Date(CER-26).
	*/
	public TS InactivationDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(26, 0);
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
	* Returns Expiration Date(CER-27).
	*/
	public TS ExpirationDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(27, 0);
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
	* Returns Renewal Date(CER-28).
	*/
	public TS RenewalDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(28, 0);
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
	* Returns Revocation Date(CER-29).
	*/
	public TS RevocationDate
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
	* Returns Revocation Reason Code(CER-30).
	*/
	public CE RevocationReasonCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(30, 0);
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
	* Returns Certificate Status(CER-31).
	*/
	public CWE CertificateStatus
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(31, 0);
				ret = (CWE)t;
			}
			 catch (HL7Exception he) {
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