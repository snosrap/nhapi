using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 PID message segment. 
 * This segment has the following fields:</p><p>
 * PID-1: SET ID - PATIENT ID (SI)<br> 
 * PID-2: PATIENT ID EXTERNAL (EXTERNAL ID) (CK)<br> 
 * PID-3: PATIENT ID INTERNAL (INTERNAL ID) (CK)<br> 
 * PID-4: ALTERNATE PATIENT ID (ST)<br> 
 * PID-5: PATIENT NAME (PN)<br> 
 * PID-6: MOTHER'S MAIDEN NAME (ST)<br> 
 * PID-7: DATE OF BIRTH (DT)<br> 
 * PID-8: SEX (ID)<br> 
 * PID-9: PATIENT ALIAS (PN)<br> 
 * PID-10: ETHNIC GROUP (ID)<br> 
 * PID-11: PATIENT ADDRESS (AD)<br> 
 * PID-12: COUNTY CODE (ID)<br> 
 * PID-13: PHONE NUMBER - HOME (TN)<br> 
 * PID-14: PHONE NUMBER - BUSINESS (TN)<br> 
 * PID-15: LANGUAGE - PATIENT (ST)<br> 
 * PID-16: MARITAL STATUS (ID)<br> 
 * PID-17: RELIGION (ID)<br> 
 * PID-18: PATIENT ACCOUNT NUMBER (CK)<br> 
 * PID-19: SSN NUMBER - PATIENT (ST)<br> 
 * PID-20: DRIVER'S LIC NUM - PATIENT (CM)<br> 
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
	public PID(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - PATIENT ID");
       this.add(typeof(CK), false, 1, 16, new System.Object[]{message}, "PATIENT ID EXTERNAL (EXTERNAL ID)");
       this.add(typeof(CK), true, 1, 16, new System.Object[]{message}, "PATIENT ID INTERNAL (INTERNAL ID)");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "ALTERNATE PATIENT ID");
       this.add(typeof(PN), true, 1, 48, new System.Object[]{message}, "PATIENT NAME");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "MOTHER'S MAIDEN NAME");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "DATE OF BIRTH");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1}, "SEX");
       this.add(typeof(PN), false, 0, 48, new System.Object[]{message}, "PATIENT ALIAS");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 5}, "ETHNIC GROUP");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "PATIENT ADDRESS");
       this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 0}, "COUNTY CODE");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "PHONE NUMBER - HOME");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "PHONE NUMBER - BUSINESS");
       this.add(typeof(ST), false, 1, 25, new System.Object[]{message}, "LANGUAGE - PATIENT");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 2}, "MARITAL STATUS");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 6}, "RELIGION");
       this.add(typeof(CK), false, 1, 20, new System.Object[]{message}, "PATIENT ACCOUNT NUMBER");
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message}, "SSN NUMBER - PATIENT");
       this.add(typeof(CM), false, 1, 25, new System.Object[]{message}, "DRIVER'S LIC NUM - PATIENT");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns SET ID - PATIENT ID(PID-1).
	*/
	public SI SETIDPATIENTID
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
	* Returns PATIENT ID EXTERNAL (EXTERNAL ID)(PID-2).
	*/
	public CK PATIENTIDEXTERNALEXTERNALID
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns PATIENT ID INTERNAL (INTERNAL ID)(PID-3).
	*/
	public CK PATIENTIDINTERNALINTERNALID
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns ALTERNATE PATIENT ID(PID-4).
	*/
	public ST ALTERNATEPATIENTID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns PATIENT NAME(PID-5).
	*/
	public PN PATIENTNAME
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns MOTHER'S MAIDEN NAME(PID-6).
	*/
	public ST MOTHERSMAIDENNAME
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns DATE OF BIRTH(PID-7).
	*/
	public DT DATEOFBIRTH
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns SEX(PID-8).
	*/
	public ID SEX
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns a single repetition of PATIENT ALIAS(PID-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public PN getPATIENTALIAS(int rep)
	{
			PN ret = null;
			try
			{
			IType t = this.getField(9, rep);
				ret = (PN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of PATIENT ALIAS (PID-9).
   */
  public PN[] getPATIENTALIAS() {
     PN[] ret = null;
    try {
        IType[] t = this.getField(9);  
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
	* Returns ETHNIC GROUP(PID-10).
	*/
	public ID ETHNICGROUP
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(10, 0);
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
	* Returns PATIENT ADDRESS(PID-11).
	*/
	public AD PATIENTADDRESS
	{
		get{
			AD ret = null;
			try
			{
			IType t = this.getField(11, 0);
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
	* Returns COUNTY CODE(PID-12).
	*/
	public ID COUNTYCODE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns a single repetition of PHONE NUMBER - HOME(PID-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getPHONENUMBERHOME(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.getField(13, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of PHONE NUMBER - HOME (PID-13).
   */
  public TN[] getPHONENUMBERHOME() {
     TN[] ret = null;
    try {
        IType[] t = this.getField(13);  
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
	* Returns a single repetition of PHONE NUMBER - BUSINESS(PID-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getPHONENUMBERBUSINESS(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.getField(14, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of PHONE NUMBER - BUSINESS (PID-14).
   */
  public TN[] getPHONENUMBERBUSINESS() {
     TN[] ret = null;
    try {
        IType[] t = this.getField(14);  
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
	* Returns LANGUAGE - PATIENT(PID-15).
	*/
	public ST LANGUAGEPATIENT
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
	* Returns MARITAL STATUS(PID-16).
	*/
	public ID MARITALSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(16, 0);
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
	* Returns RELIGION(PID-17).
	*/
	public ID RELIGION
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(17, 0);
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
	* Returns PATIENT ACCOUNT NUMBER(PID-18).
	*/
	public CK PATIENTACCOUNTNUMBER
	{
		get{
			CK ret = null;
			try
			{
			IType t = this.getField(18, 0);
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
	* Returns SSN NUMBER - PATIENT(PID-19).
	*/
	public ST SSNNUMBERPATIENT
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(19, 0);
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
	* Returns DRIVER'S LIC NUM - PATIENT(PID-20).
	*/
	public CM DRIVERSLICNUMPATIENT
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(20, 0);
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


}}