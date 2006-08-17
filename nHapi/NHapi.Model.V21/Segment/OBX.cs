using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 OBX message segment. 
 * This segment has the following fields:</p><p>
 * OBX-1: SET ID - OBSERVATION SIMPLE (SI)<br> 
 * OBX-2: VALUE TYPE (ID)<br> 
 * OBX-3: OBSERVATION IDENTIFIER (CE)<br> 
 * OBX-4: OBSERVATION SUB-ID (NM)<br> 
 * OBX-5: OBSERVATION RESULTS (ST)<br> 
 * OBX-6: UNITS (ID)<br> 
 * OBX-7: REFERENCES RANGE (ST)<br> 
 * OBX-8: ABNORMAL FLAGS (ST)<br> 
 * OBX-9: PROBABILITY (NM)<br> 
 * OBX-10: NATURE OF ABNORMAL TEST (ID)<br> 
 * OBX-11: OBSERV RESULT STATUS (ID)<br> 
 * OBX-12: DATE LAST OBS NORMAL VALUES (TS)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OBX : AbstractSegment  {

  /**
   * Creates a OBX (RESULT) segment object that belongs to the given 
   * message.  
   */
	public OBX(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - OBSERVATION SIMPLE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 125}, "VALUE TYPE");
       this.add(typeof(CE), true, 1, 80, new System.Object[]{message}, "OBSERVATION IDENTIFIER");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "OBSERVATION SUB-ID");
       this.add(typeof(ST), true, 1, 65, new System.Object[]{message}, "OBSERVATION RESULTS");
       this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 0}, "UNITS");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "REFERENCES RANGE");
       this.add(typeof(ST), false, 5, 10, new System.Object[]{message}, "ABNORMAL FLAGS");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "PROBABILITY");
       this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 80}, "NATURE OF ABNORMAL TEST");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 85}, "OBSERV RESULT STATUS");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "DATE LAST OBS NORMAL VALUES");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns SET ID - OBSERVATION SIMPLE(OBX-1).
	*/
	public SI SETIDOBSERVATIONSIMPLE
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns VALUE TYPE(OBX-2).
	*/
	public ID VALUETYPE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns OBSERVATION IDENTIFIER(OBX-3).
	*/
	public CE OBSERVATIONIDENTIFIER
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
	* Returns OBSERVATION SUB-ID(OBX-4).
	*/
	public NM OBSERVATIONSUBID
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
	* Returns OBSERVATION RESULTS(OBX-5).
	*/
	public ST OBSERVATIONRESULTS
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns UNITS(OBX-6).
	*/
	public ID UNITS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns REFERENCES RANGE(OBX-7).
	*/
	public ST REFERENCESRANGE
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns a single repetition of ABNORMAL FLAGS(OBX-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getABNORMALFLAGS(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.getField(8, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of ABNORMAL FLAGS (OBX-8).
   */
  public ST[] getABNORMALFLAGS() {
     ST[] ret = null;
    try {
        IType[] t = this.getField(8);  
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
	* Returns PROBABILITY(OBX-9).
	*/
	public NM PROBABILITY
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns NATURE OF ABNORMAL TEST(OBX-10).
	*/
	public ID NATUREOFABNORMALTEST
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(10, 0);
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
	* Returns OBSERV RESULT STATUS(OBX-11).
	*/
	public ID OBSERVRESULTSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(11, 0);
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
	* Returns DATE LAST OBS NORMAL VALUES(OBX-12).
	*/
	public TS DATELASTOBSNORMALVALUES
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(12, 0);
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


}}