using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v231.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v231.segment{

/**
 * <p>Represents an HL7 QRF message segment. 
 * This segment has the following fields:</p><p>
 * QRF-1: Where Subject Filter (ST)<br> 
 * QRF-2: When Data Start Date/Time (TS)<br> 
 * QRF-3: When Data End Date/Time (TS)<br> 
 * QRF-4: What User Qualifier (ST)<br> 
 * QRF-5: Other QRY Subject Filter (ST)<br> 
 * QRF-6: Which Date/Time Qualifier (ID)<br> 
 * QRF-7: Which Date/Time Status Qualifier (ID)<br> 
 * QRF-8: Date/Time Selection Qualifier (ID)<br> 
 * QRF-9: When Quantity/Timing Qualifier (TQ)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class QRF : AbstractSegment  {

  /**
   * Creates a QRF (QRF - original style query filter segment) segment object that belongs to the given 
   * message.  
   */
  public QRF(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ST), true, 0, 20, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
       this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
       this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 156});
       this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 157});
       this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 158});
       this.add(typeof(TQ), false, 1, 60, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns a single repetition of Where Subject Filter (QRF-1).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getWhereSubjectFilter(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(1, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Where Subject Filter (QRF-1).
   */
  public ST[] getWhereSubjectFilter() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(1);  
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
	* Returns When Data Start Date/Time (QRF-2).
	*/
	public TS WhenDataStartDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns When Data End Date/Time (QRF-3).
	*/
	public TS WhenDataEndDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns a single repetition of What User Qualifier (QRF-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getWhatUserQualifier(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of What User Qualifier (QRF-4).
   */
  public ST[] getWhatUserQualifier() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(4);  
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
	* Returns a single repetition of Other QRY Subject Filter (QRF-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getOtherQRYSubjectFilter(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Other QRY Subject Filter (QRF-5).
   */
  public ST[] getOtherQRYSubjectFilter() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(5);  
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
	* Returns a single repetition of Which Date/Time Qualifier (QRF-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getWhichDateTimeQualifier(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Which Date/Time Qualifier (QRF-6).
   */
  public ID[] getWhichDateTimeQualifier() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(6);  
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
	* Returns a single repetition of Which Date/Time Status Qualifier (QRF-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getWhichDateTimeStatusQualifier(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Which Date/Time Status Qualifier (QRF-7).
   */
  public ID[] getWhichDateTimeStatusQualifier() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(7);  
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
	* Returns a single repetition of Date/Time Selection Qualifier (QRF-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getDateTimeSelectionQualifier(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Date/Time Selection Qualifier (QRF-8).
   */
  public ID[] getDateTimeSelectionQualifier() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(8);  
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
	* Returns When Quantity/Timing Qualifier (QRF-9).
	*/
	public TQ WhenQuantityTimingQualifier
	{
		get{
			TQ ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (TQ)t;
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