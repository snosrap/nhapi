using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 GP2 message segment. 
 * This segment has the following fields:</p><p>
 * GP2-1: Revenue Code (IS)<br> 
 * GP2-2: Number of Service Units (NM)<br> 
 * GP2-3: Charge (CP)<br> 
 * GP2-4: Reimbursement Action Code (IS)<br> 
 * GP2-5: Denial or Rejection Code (IS)<br> 
 * GP2-6: OCE Edit Code (IS)<br> 
 * GP2-7: Ambulatory Payment Classification Code (CE)<br> 
 * GP2-8: Modifier Edit Code (IS)<br> 
 * GP2-9: Payment Adjustment Code (IS)<br> 
 * GP2-10: Packaging Status Code (IS)<br> 
 * GP2-11: Expected CMS Payment Amount (CP)<br> 
 * GP2-12: Reimbursement Type Code (IS)<br> 
 * GP2-13: Co-Pay Amount (CP)<br> 
 * GP2-14: Pay Rate per Service Unit (NM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class GP2 : AbstractSegment  {

  /**
   * Creates a GP2 (Grouping/Reimbursement - Procedure Line Item) segment object that belongs to the given 
   * message.  
   */
  public GP2(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(IS), false, 1, 3, new System.Object[]{message, 456});
       this.add(typeof(NM), false, 1, 7, new System.Object[]{message});
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 459});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 460});
       this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 458});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 467});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 468});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 469});
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 470});
       this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Revenue Code (GP2-1).
	*/
	public IS RevenueCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Number of Service Units (GP2-2).
	*/
	public NM NumberOfServiceUnits
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Charge (GP2-3).
	*/
	public CP Charge
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (CP)t;
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
	* Returns Reimbursement Action Code (GP2-4).
	*/
	public IS ReimbursementActionCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Denial or Rejection Code (GP2-5).
	*/
	public IS DenialOrRejectionCode
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
	* Returns a single repetition of OCE Edit Code (GP2-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getOCEEditCode(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of OCE Edit Code (GP2-6).
   */
  public IS[] getOCEEditCode() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(6);  
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
	* Returns Ambulatory Payment Classification Code (GP2-7).
	*/
	public CE AmbulatoryPaymentClassificationCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns a single repetition of Modifier Edit Code (GP2-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getModifierEditCode(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Modifier Edit Code (GP2-8).
   */
  public IS[] getModifierEditCode() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(8);  
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
	* Returns Payment Adjustment Code (GP2-9).
	*/
	public IS PaymentAdjustmentCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Packaging Status Code (GP2-10).
	*/
	public IS PackagingStatusCode
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
	* Returns Expected CMS Payment Amount (GP2-11).
	*/
	public CP ExpectedCMSPaymentAmount
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CP)t;
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
	* Returns Reimbursement Type Code (GP2-12).
	*/
	public IS ReimbursementTypeCode
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
	* Returns Co-Pay Amount (GP2-13).
	*/
	public CP CoPayAmount
	{
		get{
			CP ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (CP)t;
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
	* Returns Pay Rate per Service Unit (GP2-14).
	*/
	public NM PayRatePerServiceUnit
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(14, 0);
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


}}