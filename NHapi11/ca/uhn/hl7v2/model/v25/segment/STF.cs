using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 STF message segment. 
 * This segment has the following fields:</p><p>
 * STF-1: Primary Key Value - STF (CE)<br> 
 * STF-2: Staff Identifier List (CX)<br> 
 * STF-3: Staff Name (XPN)<br> 
 * STF-4: Staff Type (IS)<br> 
 * STF-5: Administrative Sex (IS)<br> 
 * STF-6: Date/Time of Birth (TS)<br> 
 * STF-7: Active/Inactive Flag (ID)<br> 
 * STF-8: Department (CE)<br> 
 * STF-9: Hospital Service - STF (CE)<br> 
 * STF-10: Phone (XTN)<br> 
 * STF-11: Office/Home Address/Birthplace (XAD)<br> 
 * STF-12: Institution Activation Date (DIN)<br> 
 * STF-13: Institution Inactivation Date (DIN)<br> 
 * STF-14: Backup Person ID (CE)<br> 
 * STF-15: E-Mail Address (ST)<br> 
 * STF-16: Preferred Method of Contact (CE)<br> 
 * STF-17: Marital Status (CE)<br> 
 * STF-18: Job Title (ST)<br> 
 * STF-19: Job Code/Class (JCC)<br> 
 * STF-20: Employment Status Code (CE)<br> 
 * STF-21: Additional Insured on Auto (ID)<br> 
 * STF-22: Driver's License Number - Staff (DLN)<br> 
 * STF-23: Copy Auto Ins (ID)<br> 
 * STF-24: Auto Ins. Expires (DT)<br> 
 * STF-25: Date Last DMV Review (DT)<br> 
 * STF-26: Date Next DMV Review (DT)<br> 
 * STF-27: Race (CE)<br> 
 * STF-28: Ethnic Group (CE)<br> 
 * STF-29: Re-activation Approval Indicator (ID)<br> 
 * STF-30: Citizenship (CE)<br> 
 * STF-31: Death Date and Time (TS)<br> 
 * STF-32: Death Indicator (ID)<br> 
 * STF-33: Institution Relationship Type Code (CWE)<br> 
 * STF-34: Institution Relationship Period (DR)<br> 
 * STF-35: Expected Return Date (DT)<br> 
 * STF-36: Cost Center Code (CWE)<br> 
 * STF-37: Generic Classification Indicator (ID)<br> 
 * STF-38: Inactive Reason Code (CWE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class STF : AbstractSegment  {

  /**
   * Creates a STF (Staff Identification) segment object that belongs to the given 
   * message.  
   */
  public STF(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Primary Key Value - STF");
       this.add(typeof(CX), false, 0, 250, new System.Object[]{message}, "Staff Identifier List");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Staff Name");
       this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 182}, "Staff Type");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1}, "Administrative Sex");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date/Time of Birth");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 183}, "Active/Inactive Flag");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Department");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Hospital Service - STF");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Phone");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Office/Home Address/Birthplace");
       this.add(typeof(DIN), false, 0, 276, new System.Object[]{message}, "Institution Activation Date");
       this.add(typeof(DIN), false, 0, 276, new System.Object[]{message}, "Institution Inactivation Date");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Backup Person ID");
       this.add(typeof(ST), false, 0, 40, new System.Object[]{message}, "E-Mail Address");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Preferred Method of Contact");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Marital Status");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Job Title");
       this.add(typeof(JCC), false, 1, 20, new System.Object[]{message}, "Job Code/Class");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Employment Status Code");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Additional Insured on Auto");
       this.add(typeof(DLN), false, 1, 25, new System.Object[]{message}, "Driver's License Number - Staff");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Copy Auto Ins");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Auto Ins. Expires");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Date Last DMV Review");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Date Next DMV Review");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Race");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Ethnic Group");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Re-activation Approval Indicator");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Citizenship");
       this.add(typeof(TS), false, 1, 8, new System.Object[]{message}, "Death Date and Time");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Death Indicator");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Institution Relationship Type Code");
       this.add(typeof(DR), false, 1, 52, new System.Object[]{message}, "Institution Relationship Period");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Expected Return Date");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Cost Center Code");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Generic Classification Indicator");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Inactive Reason Code");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Primary Key Value - STF(STF-1).
	*/
	public CE PrimaryKeyValueSTF
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns a single repetition of Staff Identifier List(STF-2).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CX getStaffIdentifierList(int rep)
	{
			CX ret = null;
			try
			{
			Type t = this.getField(2, rep);
				ret = (CX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Staff Identifier List (STF-2).
   */
  public CX[] getStaffIdentifierList() {
     CX[] ret = null;
    try {
        Type[] t = this.getField(2);  
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
	* Returns a single repetition of Staff Name(STF-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XPN getStaffName(int rep)
	{
			XPN ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Staff Name (STF-3).
   */
  public XPN[] getStaffName() {
     XPN[] ret = null;
    try {
        Type[] t = this.getField(3);  
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
	* Returns a single repetition of Staff Type(STF-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getStaffType(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Staff Type (STF-4).
   */
  public IS[] getStaffType() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(4);  
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
	* Returns Administrative Sex(STF-5).
	*/
	public IS AdministrativeSex
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
	* Returns Date/Time of Birth(STF-6).
	*/
	public TS DateTimeOfBirth
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
	* Returns Active/Inactive Flag(STF-7).
	*/
	public ID ActiveInactiveFlag
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
	* Returns a single repetition of Department(STF-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getDepartment(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Department (STF-8).
   */
  public CE[] getDepartment() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(8);  
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
	* Returns a single repetition of Hospital Service - STF(STF-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getHospitalServiceSTF(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Hospital Service - STF (STF-9).
   */
  public CE[] getHospitalServiceSTF() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(9);  
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
	* Returns a single repetition of Phone(STF-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getPhone(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Phone (STF-10).
   */
  public XTN[] getPhone() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(10);  
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
	* Returns a single repetition of Office/Home Address/Birthplace(STF-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getOfficeHomeAddressBirthplace(int rep)
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
   * Returns all repetitions of Office/Home Address/Birthplace (STF-11).
   */
  public XAD[] getOfficeHomeAddressBirthplace() {
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
	* Returns a single repetition of Institution Activation Date(STF-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public DIN getInstitutionActivationDate(int rep)
	{
			DIN ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (DIN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Institution Activation Date (STF-12).
   */
  public DIN[] getInstitutionActivationDate() {
     DIN[] ret = null;
    try {
        Type[] t = this.getField(12);  
        ret = new DIN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (DIN)t[i];
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
	* Returns a single repetition of Institution Inactivation Date(STF-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public DIN getInstitutionInactivationDate(int rep)
	{
			DIN ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (DIN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Institution Inactivation Date (STF-13).
   */
  public DIN[] getInstitutionInactivationDate() {
     DIN[] ret = null;
    try {
        Type[] t = this.getField(13);  
        ret = new DIN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (DIN)t[i];
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
	* Returns a single repetition of Backup Person ID(STF-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getBackupPersonID(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Backup Person ID (STF-14).
   */
  public CE[] getBackupPersonID() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(14);  
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
	* Returns a single repetition of E-Mail Address(STF-15).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getEMailAddress(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(15, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of E-Mail Address (STF-15).
   */
  public ST[] getEMailAddress() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(15);  
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
	* Returns Preferred Method of Contact(STF-16).
	*/
	public CE PreferredMethodOfContact
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

	/**
	* Returns Marital Status(STF-17).
	*/
	public CE MaritalStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Job Title(STF-18).
	*/
	public ST JobTitle
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Job Code/Class(STF-19).
	*/
	public JCC JobCodeClass
	{
		get{
			JCC ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Employment Status Code(STF-20).
	*/
	public CE EmploymentStatusCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Additional Insured on Auto(STF-21).
	*/
	public ID AdditionalInsuredOnAuto
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
	* Returns Driver's License Number - Staff(STF-22).
	*/
	public DLN DriverSLicenseNumberStaff
	{
		get{
			DLN ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns Copy Auto Ins(STF-23).
	*/
	public ID CopyAutoIns
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
	* Returns Auto Ins. Expires(STF-24).
	*/
	public DT AutoInsExpires
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
	* Returns Date Last DMV Review(STF-25).
	*/
	public DT DateLastDMVReview
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Date Next DMV Review(STF-26).
	*/
	public DT DateNextDMVReview
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
	* Returns Race(STF-27).
	*/
	public CE Race
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
	* Returns Ethnic Group(STF-28).
	*/
	public CE EthnicGroup
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
	* Returns Re-activation Approval Indicator(STF-29).
	*/
	public ID ReActivationApprovalIndicator
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(29, 0);
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
	* Returns a single repetition of Citizenship(STF-30).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getCitizenship(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(30, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Citizenship (STF-30).
   */
  public CE[] getCitizenship() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(30);  
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
	* Returns Death Date and Time(STF-31).
	*/
	public TS DeathDateAndTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(31, 0);
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
	* Returns Death Indicator(STF-32).
	*/
	public ID DeathIndicator
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
	* Returns Institution Relationship Type Code(STF-33).
	*/
	public CWE InstitutionRelationshipTypeCode
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(33, 0);
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
	* Returns Institution Relationship Period(STF-34).
	*/
	public DR InstitutionRelationshipPeriod
	{
		get{
			DR ret = null;
			try
			{
			Type t = this.getField(34, 0);
				ret = (DR)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	/**
	* Returns Expected Return Date(STF-35).
	*/
	public DT ExpectedReturnDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(35, 0);
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
	* Returns a single repetition of Cost Center Code(STF-36).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getCostCenterCode(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(36, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Cost Center Code (STF-36).
   */
  public CWE[] getCostCenterCode() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(36);  
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
	* Returns Generic Classification Indicator(STF-37).
	*/
	public ID GenericClassificationIndicator
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
	* Returns Inactive Reason Code(STF-38).
	*/
	public CWE InactiveReasonCode
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(38, 0);
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