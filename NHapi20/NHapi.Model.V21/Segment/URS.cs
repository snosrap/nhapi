using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 URS message segment. 
 * This segment has the following fields:</p><p>
 * URS-1: R/U WHERE SUBJECT DEFINITION (ST)<br> 
 * URS-2: R/U WHEN DATA START DATE/TIME (TS)<br> 
 * URS-3: R/U WHEN DATA END DATE/TIME (TS)<br> 
 * URS-4: R/U WHAT USER QUALIFIER (ST)<br> 
 * URS-5: R/U OTHER RESULTS SUBJECT DEFINI (ST)<br> 
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
       this.add(typeof(ST), true, 0, 20, new System.Object[]{message}, "R/U WHERE SUBJECT DEFINITION");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "R/U WHEN DATA START DATE/TIME");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "R/U WHEN DATA END DATE/TIME");
       this.add(typeof(ST), false, 0, 20, new System.Object[]{message}, "R/U WHAT USER QUALIFIER");
       this.add(typeof(ST), false, 0, 20, new System.Object[]{message}, "R/U OTHER RESULTS SUBJECT DEFINI");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns a single repetition of R/U WHERE SUBJECT DEFINITION(URS-1).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getRUWHERESUBJECTDEFINITION(int rep)
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
   * Returns all repetitions of R/U WHERE SUBJECT DEFINITION (URS-1).
   */
  public ST[] getRUWHERESUBJECTDEFINITION() {
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
	* Returns R/U WHEN DATA START DATE/TIME(URS-2).
	*/
	public TS RUWHENDATASTARTDATETIME
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
	* Returns R/U WHEN DATA END DATE/TIME(URS-3).
	*/
	public TS RUWHENDATAENDDATETIME
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
	* Returns a single repetition of R/U WHAT USER QUALIFIER(URS-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getRUWHATUSERQUALIFIER(int rep)
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
   * Returns all repetitions of R/U WHAT USER QUALIFIER (URS-4).
   */
  public ST[] getRUWHATUSERQUALIFIER() {
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
	* Returns a single repetition of R/U OTHER RESULTS SUBJECT DEFINI(URS-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getRUOTHERRESULTSSUBJECTDEFINI(int rep)
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
   * Returns all repetitions of R/U OTHER RESULTS SUBJECT DEFINI (URS-5).
   */
  public ST[] getRUOTHERRESULTSSUBJECTDEFINI() {
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


}}