using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 QRD message segment. 
 * This segment has the following fields:</p><p>
 * QRD-1: Query date / time (TS)<br> 
 * QRD-2: Query Format Code (ID)<br> 
 * QRD-3: Query Priority (ID)<br> 
 * QRD-4: Query ID (ST)<br> 
 * QRD-5: Deferred Response Type (ID)<br> 
 * QRD-6: Deferred response date / time (TS)<br> 
 * QRD-7: Quantity Limited Request (CQ_QUANTITY)<br> 
 * QRD-8: Who Subject Filter (ST)<br> 
 * QRD-9: What Subject Filter (ID)<br> 
 * QRD-10: What Department Data Code (ST)<br> 
 * QRD-11: What data code value qualifier (CM_VR)<br> 
 * QRD-12: Query Results Level (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class QRD : AbstractSegment  {

  /**
   * Creates a QRD (QUERY DEFINITION) segment object that belongs to the given 
   * message.  
   */
  public QRD(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Query date / time");
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 106}, "Query Format Code");
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 91}, "Query Priority");
       this.add(typeof(ST), true, 1, 10, new System.Object[]{message}, "Query ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 107}, "Deferred Response Type");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Deferred response date / time");
       this.add(typeof(CQ_QUANTITY), true, 1, 10, new System.Object[]{message}, "Quantity Limited Request");
       this.add(typeof(ST), true, 0, 20, new System.Object[]{message}, "Who Subject Filter");
       this.add(typeof(ID), true, 0, 3, new System.Object[]{message, 48}, "What Subject Filter");
       this.add(typeof(ST), true, 0, 20, new System.Object[]{message}, "What Department Data Code");
       this.add(typeof(CM_VR), false, 0, 20, new System.Object[]{message}, "What data code value qualifier");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 108}, "Query Results Level");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Query date / time(QRD-1).
	*/
	public TS QueryDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Query Format Code(QRD-2).
	*/
	public ID QueryFormatCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Query Priority(QRD-3).
	*/
	public ID QueryPriority
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Query ID(QRD-4).
	*/
	public ST QueryID
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
	* Returns Deferred Response Type(QRD-5).
	*/
	public ID DeferredResponseType
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Deferred response date / time(QRD-6).
	*/
	public TS DeferredResponseDateTime
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
	* Returns Quantity Limited Request(QRD-7).
	*/
	public CQ_QUANTITY QuantityLimitedRequest
	{
		get{
			CQ_QUANTITY ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (CQ_QUANTITY)t;
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
	* Returns a single repetition of Who Subject Filter(QRD-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getWhoSubjectFilter(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Who Subject Filter (QRD-8).
   */
  public ST[] getWhoSubjectFilter() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(8);  
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
	* Returns a single repetition of What Subject Filter(QRD-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getWhatSubjectFilter(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of What Subject Filter (QRD-9).
   */
  public ID[] getWhatSubjectFilter() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(9);  
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
	* Returns a single repetition of What Department Data Code(QRD-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getWhatDepartmentDataCode(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of What Department Data Code (QRD-10).
   */
  public ST[] getWhatDepartmentDataCode() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(10);  
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
	* Returns a single repetition of What data code value qualifier(QRD-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_VR getWhatDataCodeValueQualifier(int rep)
	{
			CM_VR ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (CM_VR)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of What data code value qualifier (QRD-11).
   */
  public CM_VR[] getWhatDataCodeValueQualifier() {
     CM_VR[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new CM_VR[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_VR)t[i];
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
	* Returns Query Results Level(QRD-12).
	*/
	public ID QueryResultsLevel
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


}}