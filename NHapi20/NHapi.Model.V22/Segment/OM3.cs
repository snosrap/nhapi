using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 OM3 message segment. 
 * This segment has the following fields:</p><p>
 * OM3-1: Segment Type ID (ST)<br> 
 * OM3-2: Sequence Number - Test/ Observation Master File (NM)<br> 
 * OM3-3: Preferred Coding System (ID)<br> 
 * OM3-4: Valid coded answers (CE)<br> 
 * OM3-5: Normal test codes for categorical observations (CE)<br> 
 * OM3-6: Abnormal test codes for categorical observations (CE)<br> 
 * OM3-7: Critical test codes for categorical observations (CE)<br> 
 * OM3-8: Data Type (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OM3 : AbstractSegment  {

  /**
   * Creates a OM3 (CATEGORICAL TEST/OBSERVATION) segment object that belongs to the given 
   * message.  
   */
	public OM3(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "Segment Type ID");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Sequence Number - Test/ Observation Master File");
       this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 0}, "Preferred Coding System");
       this.add(typeof(CE), false, 0, 60, new System.Object[]{message}, "Valid coded answers");
       this.add(typeof(CE), false, 0, 200, new System.Object[]{message}, "Normal test codes for categorical observations");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Abnormal test codes for categorical observations");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Critical test codes for categorical observations");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Data Type");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Segment Type ID(OM3-1).
	*/
	public ST SegmentTypeID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns Sequence Number - Test/ Observation Master File(OM3-2).
	*/
	public NM SequenceNumberTestObservationMasterFile
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns Preferred Coding System(OM3-3).
	*/
	public ID PreferredCodingSystem
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns a single repetition of Valid coded answers(OM3-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getValidCodedAnswers(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.getField(4, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Valid coded answers (OM3-4).
   */
  public CE[] getValidCodedAnswers() {
     CE[] ret = null;
    try {
        IType[] t = this.getField(4);  
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
	* Returns a single repetition of Normal test codes for categorical observations(OM3-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getNormalTestCodesForCategoricalObservations(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.getField(5, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Normal test codes for categorical observations (OM3-5).
   */
  public CE[] getNormalTestCodesForCategoricalObservations() {
     CE[] ret = null;
    try {
        IType[] t = this.getField(5);  
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
	* Returns Abnormal test codes for categorical observations(OM3-6).
	*/
	public CE AbnormalTestCodesForCategoricalObservations
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns Critical test codes for categorical observations(OM3-7).
	*/
	public CE CriticalTestCodesForCategoricalObservations
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns Data Type(OM3-8).
	*/
	public ID DataType
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


}}