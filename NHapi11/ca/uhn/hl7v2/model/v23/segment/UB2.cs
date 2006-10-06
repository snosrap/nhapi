using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment{

/**
 * <p>Represents an HL7 UB2 message segment. 
 * This segment has the following fields:</p><p>
 * UB2-1: Set ID - UB2 (SI)<br> 
 * UB2-2: Co-Insurance Days (9) (ST)<br> 
 * UB2-3: Condition Code (24-30) (ID)<br> 
 * UB2-4: Covered Days (7) (ST)<br> 
 * UB2-5: Non-Covered Days (8) (ST)<br> 
 * UB2-6: Value Amount & Code (CM_UVC)<br> 
 * UB2-7: Occurrence Code & Date (32-35) (CM_OCD)<br> 
 * UB2-8: Occurrence Span Code/Dates (36) (CM_OSP)<br> 
 * UB2-9: UB92 Locator 2 (State) (ST)<br> 
 * UB2-10: UB92 Locator 11 (State) (ST)<br> 
 * UB2-11: UB92 Locator 31 (National) (ST)<br> 
 * UB2-12: Document Control Number (ST)<br> 
 * UB2-13: UB92 Locator 49 (National) (ST)<br> 
 * UB2-14: UB92 Locator 56 (State) (ST)<br> 
 * UB2-15: UB92 Locator 57 (National) (ST)<br> 
 * UB2-16: UB92 Locator 78 (State) (ST)<br> 
 * UB2-17: Special Visit Count (NM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class UB2 : AbstractSegment  {

  /**
   * Creates a UB2 (UB92 data) segment object that belongs to the given 
   * message.  
   */
  public UB2(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - UB2");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "Co-Insurance Days (9)");
       this.add(typeof(ID), false, 7, 2, new System.Object[]{message, 43}, "Condition Code (24-30)");
       this.add(typeof(ST), false, 1, 3, new System.Object[]{message}, "Covered Days (7)");
       this.add(typeof(ST), false, 1, 4, new System.Object[]{message}, "Non-Covered Days (8)");
       this.add(typeof(CM_UVC), false, 12, 11, new System.Object[]{message}, "Value Amount & Code");
       this.add(typeof(CM_OCD), false, 8, 11, new System.Object[]{message}, "Occurrence Code & Date (32-35)");
       this.add(typeof(CM_OSP), false, 2, 28, new System.Object[]{message}, "Occurrence Span Code/Dates (36)");
       this.add(typeof(ST), false, 2, 29, new System.Object[]{message}, "UB92 Locator 2 (State)");
       this.add(typeof(ST), false, 2, 12, new System.Object[]{message}, "UB92 Locator 11 (State)");
       this.add(typeof(ST), false, 1, 5, new System.Object[]{message}, "UB92 Locator 31 (National)");
       this.add(typeof(ST), false, 3, 23, new System.Object[]{message}, "Document Control Number");
       this.add(typeof(ST), false, 23, 4, new System.Object[]{message}, "UB92 Locator 49 (National)");
       this.add(typeof(ST), false, 5, 14, new System.Object[]{message}, "UB92 Locator 56 (State)");
       this.add(typeof(ST), false, 1, 27, new System.Object[]{message}, "UB92 Locator 57 (National)");
       this.add(typeof(ST), false, 2, 2, new System.Object[]{message}, "UB92 Locator 78 (State)");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Special Visit Count");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - UB2(UB2-1).
	*/
	public SI SetIDUB2
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
	* Returns Co-Insurance Days (9)(UB2-2).
	*/
	public ST CoInsuranceDays9
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
	* Returns a single repetition of Condition Code (24-30)(UB2-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getConditionCode2430(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Condition Code (24-30) (UB2-3).
   */
  public ID[] getConditionCode2430() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(3);  
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
	* Returns Covered Days (7)(UB2-4).
	*/
	public ST CoveredDays7
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
	* Returns Non-Covered Days (8)(UB2-5).
	*/
	public ST NonCoveredDays8
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns a single repetition of Value Amount & Code(UB2-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_UVC getValueAmountCode(int rep)
	{
			CM_UVC ret = null;
			try
			{
			Type t = this.getField(6, rep);
				ret = (CM_UVC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Value Amount & Code (UB2-6).
   */
  public CM_UVC[] getValueAmountCode() {
     CM_UVC[] ret = null;
    try {
        Type[] t = this.getField(6);  
        ret = new CM_UVC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_UVC)t[i];
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
	* Returns a single repetition of Occurrence Code & Date (32-35)(UB2-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_OCD getOccurrenceCodeDate3235(int rep)
	{
			CM_OCD ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (CM_OCD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Occurrence Code & Date (32-35) (UB2-7).
   */
  public CM_OCD[] getOccurrenceCodeDate3235() {
     CM_OCD[] ret = null;
    try {
        Type[] t = this.getField(7);  
        ret = new CM_OCD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_OCD)t[i];
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
	* Returns a single repetition of Occurrence Span Code/Dates (36)(UB2-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM_OSP getOccurrenceSpanCodeDates(int rep)
	{
			CM_OSP ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (CM_OSP)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Occurrence Span Code/Dates (36) (UB2-8).
   */
  public CM_OSP[] getOccurrenceSpanCodeDates() {
     CM_OSP[] ret = null;
    try {
        Type[] t = this.getField(8);  
        ret = new CM_OSP[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM_OSP)t[i];
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
	* Returns a single repetition of UB92 Locator 2 (State)(UB2-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getUB92Locator2State(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of UB92 Locator 2 (State) (UB2-9).
   */
  public ST[] getUB92Locator2State() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(9);  
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
	* Returns a single repetition of UB92 Locator 11 (State)(UB2-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getUB92Locator11State(int rep)
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
   * Returns all repetitions of UB92 Locator 11 (State) (UB2-10).
   */
  public ST[] getUB92Locator11State() {
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
	* Returns UB92 Locator 31 (National)(UB2-11).
	*/
	public ST UB92Locator31National
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns a single repetition of Document Control Number(UB2-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getDocumentControlNumber(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Document Control Number (UB2-12).
   */
  public ST[] getDocumentControlNumber() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(12);  
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
	* Returns a single repetition of UB92 Locator 49 (National)(UB2-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getUB92Locator49National(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of UB92 Locator 49 (National) (UB2-13).
   */
  public ST[] getUB92Locator49National() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(13);  
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
	* Returns a single repetition of UB92 Locator 56 (State)(UB2-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getUB92Locator56State(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of UB92 Locator 56 (State) (UB2-14).
   */
  public ST[] getUB92Locator56State() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(14);  
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
	* Returns UB92 Locator 57 (National)(UB2-15).
	*/
	public ST UB92Locator57National
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns a single repetition of UB92 Locator 78 (State)(UB2-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getUB92Locator78State(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of UB92 Locator 78 (State) (UB2-16).
   */
  public ST[] getUB92Locator78State() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(16);  
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
	* Returns Special Visit Count(UB2-17).
	*/
	public NM SpecialVisitCount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(17, 0);
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