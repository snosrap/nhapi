using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 URS message segment. 
 * This segment has the following fields:</p><p>
 * URS-1: R/U Where Subject Definition (ST)<br> 
 * URS-2: R/U when data start date / time (TS)<br> 
 * URS-3: R/U when data end date / time (TS)<br> 
 * URS-4: R/U What User Qualifier (ST)<br> 
 * URS-5: R/U Other Results Subject Definition (ST)<br> 
 * URS-6: R/U which date / time qualifier (ID)<br> 
 * URS-7: R/U which date / time status qualifier (ID)<br> 
 * URS-8: R/U date / time selection qualifier (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class URS : AbstractSegment  {

  /**
   * Creates a URS (UNSOLICITED SELECTION) segment object that belongs to the given 
   * message.  
   */
	public URS(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), true, 0, 20, new System.Object[]{message}, "R/U Where Subject Definition");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "R/U when data start date / time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "R/U when data end date / time");
       this.add(typeof(ST), false, 0, 20, new System.Object[]{message}, "R/U What User Qualifier");
       this.add(typeof(ST), false, 0, 20, new System.Object[]{message}, "R/U Other Results Subject Definition");
       this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 156}, "R/U which date / time qualifier");
       this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 157}, "R/U which date / time status qualifier");
       this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 158}, "R/U date / time selection qualifier");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns a single repetition of R/U Where Subject Definition(URS-1).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getRUWhereSubjectDefinition(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.getField(1, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of R/U Where Subject Definition (URS-1).
   */
  public ST[] getRUWhereSubjectDefinition() {
     ST[] ret = null;
    try {
        IType[] t = this.getField(1);  
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
	* Returns R/U when data start date / time(URS-2).
	*/
	public TS RUWhenDataStartDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns R/U when data end date / time(URS-3).
	*/
	public TS RUWhenDataEndDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns a single repetition of R/U What User Qualifier(URS-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getRUWhatUserQualifier(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.getField(4, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of R/U What User Qualifier (URS-4).
   */
  public ST[] getRUWhatUserQualifier() {
     ST[] ret = null;
    try {
        IType[] t = this.getField(4);  
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
	* Returns a single repetition of R/U Other Results Subject Definition(URS-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getRUOtherResultsSubjectDefinition(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.getField(5, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of R/U Other Results Subject Definition (URS-5).
   */
  public ST[] getRUOtherResultsSubjectDefinition() {
     ST[] ret = null;
    try {
        IType[] t = this.getField(5);  
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
	* Returns a single repetition of R/U which date / time qualifier(URS-6).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getRUWhichDateTimeQualifier(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.getField(6, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of R/U which date / time qualifier (URS-6).
   */
  public ID[] getRUWhichDateTimeQualifier() {
     ID[] ret = null;
    try {
        IType[] t = this.getField(6);  
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
	* Returns a single repetition of R/U which date / time status qualifier(URS-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getRUWhichDateTimeStatusQualifier(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.getField(7, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of R/U which date / time status qualifier (URS-7).
   */
  public ID[] getRUWhichDateTimeStatusQualifier() {
     ID[] ret = null;
    try {
        IType[] t = this.getField(7);  
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
	* Returns a single repetition of R/U date / time selection qualifier(URS-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getRUDateTimeSelectionQualifier(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.getField(8, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of R/U date / time selection qualifier (URS-8).
   */
  public ID[] getRUDateTimeSelectionQualifier() {
     ID[] ret = null;
    try {
        IType[] t = this.getField(8);  
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


}}