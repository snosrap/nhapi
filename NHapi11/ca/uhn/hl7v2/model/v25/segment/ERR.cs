using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 ERR message segment. 
 * This segment has the following fields:</p><p>
 * ERR-1: Error Code and Location (ELD)<br> 
 * ERR-2: Error Location (ERL)<br> 
 * ERR-3: HL7 Error Code (CWE)<br> 
 * ERR-4: Severity (ID)<br> 
 * ERR-5: Application Error Code (CWE)<br> 
 * ERR-6: Application Error Parameter (ST)<br> 
 * ERR-7: Diagnostic Information (TX)<br> 
 * ERR-8: User Message (TX)<br> 
 * ERR-9: Inform Person Indicator (IS)<br> 
 * ERR-10: Override Type (CWE)<br> 
 * ERR-11: Override Reason Code (CWE)<br> 
 * ERR-12: Help Desk Contact Point (XTN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ERR : AbstractSegment  {

  /**
   * Creates a ERR (Error) segment object that belongs to the given 
   * message.  
   */
  public ERR(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ELD), false, 0, 493, new System.Object[]{message}, "Error Code and Location");
       this.add(typeof(ERL), false, 0, 18, new System.Object[]{message}, "Error Location");
       this.add(typeof(CWE), true, 1, 705, new System.Object[]{message}, "HL7 Error Code");
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 516}, "Severity");
       this.add(typeof(CWE), false, 1, 705, new System.Object[]{message}, "Application Error Code");
       this.add(typeof(ST), false, 0, 80, new System.Object[]{message}, "Application Error Parameter");
       this.add(typeof(TX), false, 1, 2048, new System.Object[]{message}, "Diagnostic Information");
       this.add(typeof(TX), false, 1, 250, new System.Object[]{message}, "User Message");
       this.add(typeof(IS), false, 0, 20, new System.Object[]{message, 517}, "Inform Person Indicator");
       this.add(typeof(CWE), false, 1, 705, new System.Object[]{message}, "Override Type");
       this.add(typeof(CWE), false, 0, 705, new System.Object[]{message}, "Override Reason Code");
       this.add(typeof(XTN), false, 0, 652, new System.Object[]{message}, "Help Desk Contact Point");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns a single repetition of Error Code and Location(ERR-1).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ELD getErrorCodeAndLocation(int rep)
	{
			ELD ret = null;
			try
			{
			Type t = this.getField(1, rep);
				ret = (ELD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Error Code and Location (ERR-1).
   */
  public ELD[] getErrorCodeAndLocation() {
     ELD[] ret = null;
    try {
        Type[] t = this.getField(1);  
        ret = new ELD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ELD)t[i];
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
	* Returns a single repetition of Error Location(ERR-2).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ERL getErrorLocation(int rep)
	{
			ERL ret = null;
			try
			{
			Type t = this.getField(2, rep);
				ret = (ERL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Error Location (ERR-2).
   */
  public ERL[] getErrorLocation() {
     ERL[] ret = null;
    try {
        Type[] t = this.getField(2);  
        ret = new ERL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ERL)t[i];
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
	* Returns HL7 Error Code(ERR-3).
	*/
	public CWE HL7ErrorCode
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Severity(ERR-4).
	*/
	public ID Severity
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
	* Returns Application Error Code(ERR-5).
	*/
	public CWE ApplicationErrorCode
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns a single repetition of Application Error Parameter(ERR-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getApplicationErrorParameter(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Application Error Parameter (ERR-6).
   */
  public ST[] getApplicationErrorParameter() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(6);  
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
	* Returns Diagnostic Information(ERR-7).
	*/
	public TX DiagnosticInformation
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (TX)t;
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
	* Returns User Message(ERR-8).
	*/
	public TX UserMessage
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (TX)t;
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
	* Returns a single repetition of Inform Person Indicator(ERR-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getInformPersonIndicator(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Inform Person Indicator (ERR-9).
   */
  public IS[] getInformPersonIndicator() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(9);  
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
	* Returns Override Type(ERR-10).
	*/
	public CWE OverrideType
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
	* Returns a single repetition of Override Reason Code(ERR-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getOverrideReasonCode(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Override Reason Code (ERR-11).
   */
  public CWE[] getOverrideReasonCode() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(11);  
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
	* Returns a single repetition of Help Desk Contact Point(ERR-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getHelpDeskContactPoint(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Help Desk Contact Point (ERR-12).
   */
  public XTN[] getHelpDeskContactPoint() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(12);  
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


}}