using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 LOC message segment. 
 * This segment has the following fields:</p><p>
 * LOC-1: Primary Key Value - LOC (PL)<br> 
 * LOC-2: Location Description (ST)<br> 
 * LOC-3: Location Type - LOC (IS)<br> 
 * LOC-4: Organization Name - LOC (XON)<br> 
 * LOC-5: Location Address (XAD)<br> 
 * LOC-6: Location Phone (XTN)<br> 
 * LOC-7: License Number (CE)<br> 
 * LOC-8: Location Equipment (IS)<br> 
 * LOC-9: Location Service Code (IS)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class LOC : AbstractSegment  {

  /**
   * Creates a LOC (Location Identification) segment object that belongs to the given 
   * message.  
   */
  public LOC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(PL), true, 1, 200, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 48, new System.Object[]{message});
       this.add(typeof(IS), true, 0, 2, new System.Object[]{message, 260});
       this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 261});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 442});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Primary Key Value - LOC (LOC-1).
	*/
	public PL PrimaryKeyValueLOC
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (PL)t;
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
	* Returns Location Description (LOC-2).
	*/
	public ST LocationDescription
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
	* Returns a single repetition of Location Type - LOC (LOC-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getLocationTypeLOC(int rep)
	{
			IS ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Location Type - LOC (LOC-3).
   */
  public IS[] getLocationTypeLOC() {
     IS[] ret = null;
    try {
        Type[] t = this.getField(3);  
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
	* Returns a single repetition of Organization Name - LOC (LOC-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XON getOrganizationNameLOC(int rep)
	{
			XON ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (XON)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Organization Name - LOC (LOC-4).
   */
  public XON[] getOrganizationNameLOC() {
     XON[] ret = null;
    try {
        Type[] t = this.getField(4);  
        ret = new XON[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XON)t[i];
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
	* Returns a single repetition of Location Address (LOC-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getLocationAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Location Address (LOC-5).
   */
  public XAD[] getLocationAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(5);  
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
	* Returns a single repetition of Location Phone (LOC-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getLocationPhone(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Location Phone (LOC-6).
   */
  public XTN[] getLocationPhone() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(6);  
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
	* Returns a single repetition of License Number (LOC-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getLicenseNumber(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of License Number (LOC-7).
   */
  public CE[] getLicenseNumber() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(7);  
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
	* Returns a single repetition of Location Equipment (LOC-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public IS getLocationEquipment(int rep)
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
   * Returns all repetitions of Location Equipment (LOC-8).
   */
  public IS[] getLocationEquipment() {
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
	* Returns Location Service Code (LOC-9).
	*/
	public IS LocationServiceCode
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


}}