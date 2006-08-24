using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 OM2 message segment. 
 * This segment has the following fields:</p><p>
 * OM2-1: Segment Type ID (ST)<br> 
 * OM2-2: Sequence Number - Test/ Observation Master File (NM)<br> 
 * OM2-3: Units of Measure (CE)<br> 
 * OM2-4: Range of Decimal Precision (NM)<br> 
 * OM2-5: Corresponding SI Units of Measure (CE)<br> 
 * OM2-6: SI Conversion Factor (TX)<br> 
 * OM2-7: Reference (normal) range - ordinal & continuous observations (CM_RFR)<br> 
 * OM2-8: Critical range for ordinal and continuous observations (CM_RANGE)<br> 
 * OM2-9: Absolute range for ordinal and continuous observations (CM_ABS_RANGE)<br> 
 * OM2-10: Delta Check Criteria (CM_DLT)<br> 
 * OM2-11: Minimum Meaningful Increments (NM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OM2 : AbstractSegment  {

  /**
   * Creates a OM2 (NUMERIC OBSERVATION) segment object that belongs to the given 
   * message.  
   */
	public OM2(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "Segment Type ID");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Sequence Number - Test/ Observation Master File");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Units of Measure");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Range of Decimal Precision");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Corresponding SI Units of Measure");
       this.add(typeof(TX), true, 0, 20, new System.Object[]{message}, "SI Conversion Factor");
       this.add(typeof(CM_RFR), false, 0, 200, new System.Object[]{message}, "Reference (normal) range - ordinal & continuous observations");
       this.add(typeof(CM_RANGE), false, 1, 200, new System.Object[]{message}, "Critical range for ordinal and continuous observations");
       this.add(typeof(CM_ABS_RANGE), false, 1, 200, new System.Object[]{message}, "Absolute range for ordinal and continuous observations");
       this.add(typeof(CM_DLT), false, 0, 200, new System.Object[]{message}, "Delta Check Criteria");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Minimum Meaningful Increments");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Segment Type ID(OM2-1).
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
	* Returns Sequence Number - Test/ Observation Master File(OM2-2).
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
	* Returns Units of Measure(OM2-3).
	*/
	public CE UnitsOfMeasure
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns Range of Decimal Precision(OM2-4).
	*/
	public NM RangeOfDecimalPrecision
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns Corresponding SI Units of Measure(OM2-5).
	*/
	public CE CorrespondingSIUnitsOfMeasure
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns a single repetition of SI Conversion Factor(OM2-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TX getSIConversionFactor(int rep)
	{
			TX ret = null;
			try
			{
			IType t = this.getField(6, rep);
				ret = (TX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of SI Conversion Factor (OM2-6).
   */
  public TX[] getSIConversionFactor() {
     TX[] ret = null;
    try {
        IType[] t = this.getField(6);  
        ret = new TX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TX)t[i];
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
	* Returns a single repetition of Reference (normal) range - ordinal & continuous observations(OM2-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_RFR getReferenceNormalRangeOrdinalContinuousObservations(int rep)
	{
			CM_RFR ret = null;
			try
			{
			IType t = this.getField(7, rep);
				ret = (CM_RFR)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Reference (normal) range - ordinal & continuous observations (OM2-7).
   */
  public CM_RFR[] getReferenceNormalRangeOrdinalContinuousObservations() {
     CM_RFR[] ret = null;
    try {
        IType[] t = this.getField(7);  
        ret = new CM_RFR[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_RFR)t[i];
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
	* Returns Critical range for ordinal and continuous observations(OM2-8).
	*/
	public CM_RANGE CriticalRangeForOrdinalAndContinuousObservations
	{
		get{
			CM_RANGE ret = null;
			try
			{
			IType t = this.getField(8, 0);
				ret = (CM_RANGE)t;
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
	* Returns Absolute range for ordinal and continuous observations(OM2-9).
	*/
	public CM_ABS_RANGE AbsoluteRangeForOrdinalAndContinuousObservations
	{
		get{
			CM_ABS_RANGE ret = null;
			try
			{
			IType t = this.getField(9, 0);
				ret = (CM_ABS_RANGE)t;
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
	* Returns a single repetition of Delta Check Criteria(OM2-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_DLT getDeltaCheckCriteria(int rep)
	{
			CM_DLT ret = null;
			try
			{
			IType t = this.getField(10, rep);
				ret = (CM_DLT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Delta Check Criteria (OM2-10).
   */
  public CM_DLT[] getDeltaCheckCriteria() {
     CM_DLT[] ret = null;
    try {
        IType[] t = this.getField(10);  
        ret = new CM_DLT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_DLT)t[i];
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
	* Returns Minimum Meaningful Increments(OM2-11).
	*/
	public NM MinimumMeaningfulIncrements
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(11, 0);
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