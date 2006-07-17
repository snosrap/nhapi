using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 TQ2 message segment. 
 * This segment has the following fields:</p><p>
 * TQ2-1: Set ID - TQ2 (SI)<br> 
 * TQ2-2: Sequence/Results Flag (ID)<br> 
 * TQ2-3: Related Placer Number (EI)<br> 
 * TQ2-4: Related Filler Number (EI)<br> 
 * TQ2-5: Related Placer Group Number (EI)<br> 
 * TQ2-6: Sequence Condition Code (ID)<br> 
 * TQ2-7: Cyclic Entry/Exit Indicator (ID)<br> 
 * TQ2-8: Sequence Condition Time Interval (CQ)<br> 
 * TQ2-9: Cyclic Group Maximum Number of Repeats (NM)<br> 
 * TQ2-10: Special Service Request Relationship (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class TQ2 : AbstractSegment  {

  /**
   * Creates a TQ2 (Timing/Quantity Relationship) segment object that belongs to the given 
   * message.  
   */
  public TQ2(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - TQ2");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 503}, "Sequence/Results Flag");
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message}, "Related Placer Number");
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message}, "Related Filler Number");
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message}, "Related Placer Group Number");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 504}, "Sequence Condition Code");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 505}, "Cyclic Entry/Exit Indicator");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Sequence Condition Time Interval");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "Cyclic Group Maximum Number of Repeats");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 506}, "Special Service Request Relationship");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - TQ2(TQ2-1).
	*/
	public SI SetIDTQ2
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
	* Returns Sequence/Results Flag(TQ2-2).
	*/
	public ID SequenceResultsFlag
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
	* Returns a single repetition of Related Placer Number(TQ2-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EI getRelatedPlacerNumber(int rep)
	{
			EI ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Related Placer Number (TQ2-3).
   */
  public EI[] getRelatedPlacerNumber() {
     EI[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new EI[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (EI)t[i];
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
	* Returns a single repetition of Related Filler Number(TQ2-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EI getRelatedFillerNumber(int rep)
	{
			EI ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Related Filler Number (TQ2-4).
   */
  public EI[] getRelatedFillerNumber() {
     EI[] ret = null;
    try {
        Type[] t = this.getField(4);  
        ret = new EI[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (EI)t[i];
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
	* Returns a single repetition of Related Placer Group Number(TQ2-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EI getRelatedPlacerGroupNumber(int rep)
	{
			EI ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Related Placer Group Number (TQ2-5).
   */
  public EI[] getRelatedPlacerGroupNumber() {
     EI[] ret = null;
    try {
        Type[] t = this.getField(5);  
        ret = new EI[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (EI)t[i];
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
	* Returns Sequence Condition Code(TQ2-6).
	*/
	public ID SequenceConditionCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Cyclic Entry/Exit Indicator(TQ2-7).
	*/
	public ID CyclicEntryExitIndicator
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
	* Returns Sequence Condition Time Interval(TQ2-8).
	*/
	public CQ SequenceConditionTimeInterval
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CQ)t;
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
	* Returns Cyclic Group Maximum Number of Repeats(TQ2-9).
	*/
	public NM CyclicGroupMaximumNumberOfRepeats
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Special Service Request Relationship(TQ2-10).
	*/
	public ID SpecialServiceRequestRelationship
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(10, 0);
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