using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 TQ1 message segment. 
 * This segment has the following fields:</p><p>
 * TQ1-1: Set ID - TQ1 (SI)<br> 
 * TQ1-2: Quantity (CQ)<br> 
 * TQ1-3: Repeat Pattern (RPT)<br> 
 * TQ1-4: Explicit Time (TM)<br> 
 * TQ1-5: Relative Time and Units (CQ)<br> 
 * TQ1-6: Service Duration (CQ)<br> 
 * TQ1-7: Start date/time (TS)<br> 
 * TQ1-8: End date/time (TS)<br> 
 * TQ1-9: Priority (CWE)<br> 
 * TQ1-10: Condition text (TX)<br> 
 * TQ1-11: Text instruction (TX)<br> 
 * TQ1-12: Conjunction (ID)<br> 
 * TQ1-13: Occurrence duration (CQ)<br> 
 * TQ1-14: Total occurrence's (NM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class TQ1 : AbstractSegment  {

  /**
   * Creates a TQ1 (Timing/Quantity) segment object that belongs to the given 
   * message.  
   */
  public TQ1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
       this.add(typeof(RPT), false, 0, 540, new System.Object[]{message});
       this.add(typeof(TM), false, 0, 20, new System.Object[]{message});
       this.add(typeof(CQ), false, 0, 20, new System.Object[]{message});
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 250, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 427});
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Set ID - TQ1 (TQ1-1).
	*/
	public SI SetIDTQ1
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
	* Returns Quantity (TQ1-2).
	*/
	public CQ Quantity
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns a single repetition of Repeat Pattern (TQ1-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public RPT getRepeatPattern(int rep)
	{
			RPT ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (RPT)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Repeat Pattern (TQ1-3).
   */
  public RPT[] getRepeatPattern() {
     RPT[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new RPT[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (RPT)t[i];
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
	* Returns a single repetition of Explicit Time (TQ1-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TM getExplicitTime(int rep)
	{
			TM ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (TM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Explicit Time (TQ1-4).
   */
  public TM[] getExplicitTime() {
     TM[] ret = null;
    try {
        Type[] t = this.getField(4);  
        ret = new TM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TM)t[i];
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
	* Returns a single repetition of Relative Time and Units (TQ1-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CQ getRelativeTimeAndUnits(int rep)
	{
			CQ ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (CQ)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Relative Time and Units (TQ1-5).
   */
  public CQ[] getRelativeTimeAndUnits() {
     CQ[] ret = null;
    try {
        Type[] t = this.getField(5);  
        ret = new CQ[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CQ)t[i];
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
	* Returns Service Duration (TQ1-6).
	*/
	public CQ ServiceDuration
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Start date/time (TQ1-7).
	*/
	public TS StartDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns End date/time (TQ1-8).
	*/
	public TS EndDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns a single repetition of Priority (TQ1-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getPriority(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Priority (TQ1-9).
   */
  public CWE[] getPriority() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(9);  
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
	* Returns Condition text (TQ1-10).
	*/
	public TX ConditionText
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Text instruction (TQ1-11).
	*/
	public TX TextInstruction
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Conjunction (TQ1-12).
	*/
	public ID Conjunction
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

	/**
	* Returns Occurrence duration (TQ1-13).
	*/
	public CQ OccurrenceDuration
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Total occurrence's (TQ1-14).
	*/
	public NM TotalOccurrenceS
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