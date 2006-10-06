using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 PR1 message segment. 
 * This segment has the following fields:</p><p>
 * PR1-1: SET ID - PROCEDURE (SI)<br> 
 * PR1-2: PROCEDURE CODING METHOD. (ID)<br> 
 * PR1-3: PROCEDURE CODE (ID)<br> 
 * PR1-4: PROCEDURE DESCRIPTION (ST)<br> 
 * PR1-5: PROCEDURE DATE/TIME (TS)<br> 
 * PR1-6: PROCEDURE TYPE (ID)<br> 
 * PR1-7: PROCEDURE MINUTES (NM)<br> 
 * PR1-8: ANESTHESIOLOGIST (CN)<br> 
 * PR1-9: ANESTHESIA CODE (ID)<br> 
 * PR1-10: ANESTHESIA MINUTES (NM)<br> 
 * PR1-11: SURGEON (CN)<br> 
 * PR1-12: RESIDENT CODE (CN)<br> 
 * PR1-13: CONSENT CODE (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class PR1 : AbstractSegment  {

  /**
   * Creates a PR1 (PROCEDURES) segment object that belongs to the given 
   * message.  
   */
  public PR1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 0, 4, new System.Object[]{message}, "SET ID - PROCEDURE");
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 89}, "PROCEDURE CODING METHOD.");
       this.add(typeof(ID), true, 1, 10, new System.Object[]{message, 88}, "PROCEDURE CODE");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "PROCEDURE DESCRIPTION");
       this.add(typeof(TS), true, 1, 19, new System.Object[]{message}, "PROCEDURE DATE/TIME");
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 90}, "PROCEDURE TYPE");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "PROCEDURE MINUTES");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "ANESTHESIOLOGIST");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 19}, "ANESTHESIA CODE");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "ANESTHESIA MINUTES");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "SURGEON");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "RESIDENT CODE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 59}, "CONSENT CODE");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns a single repetition of SET ID - PROCEDURE(PR1-1).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public SI getSETIDPROCEDURE(int rep)
	{
			SI ret = null;
			try
			{
			Type t = this.getField(1, rep);
				ret = (SI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of SET ID - PROCEDURE (PR1-1).
   */
  public SI[] getSETIDPROCEDURE() {
     SI[] ret = null;
    try {
        Type[] t = this.getField(1);  
        ret = new SI[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (SI)t[i];
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
	* Returns PROCEDURE CODING METHOD.(PR1-2).
	*/
	public ID PROCEDURECODINGMETHOD
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
	* Returns PROCEDURE CODE(PR1-3).
	*/
	public ID PROCEDURECODE
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
	* Returns PROCEDURE DESCRIPTION(PR1-4).
	*/
	public ST PROCEDUREDESCRIPTION
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
	* Returns PROCEDURE DATE/TIME(PR1-5).
	*/
	public TS PROCEDUREDATETIME
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns PROCEDURE TYPE(PR1-6).
	*/
	public ID PROCEDURETYPE
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
	* Returns PROCEDURE MINUTES(PR1-7).
	*/
	public NM PROCEDUREMINUTES
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns ANESTHESIOLOGIST(PR1-8).
	*/
	public CN ANESTHESIOLOGIST
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CN)t;
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
	* Returns ANESTHESIA CODE(PR1-9).
	*/
	public ID ANESTHESIACODE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns ANESTHESIA MINUTES(PR1-10).
	*/
	public NM ANESTHESIAMINUTES
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns SURGEON(PR1-11).
	*/
	public CN SURGEON
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CN)t;
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
	* Returns RESIDENT CODE(PR1-12).
	*/
	public CN RESIDENTCODE
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (CN)t;
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
	* Returns CONSENT CODE(PR1-13).
	*/
	public ID CONSENTCODE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(13, 0);
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