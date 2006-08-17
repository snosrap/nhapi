using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 RX1 message segment. 
 * This segment has the following fields:</p><p>
 * RX1-1: UNUSED (ST)<br> 
 * RX1-2: UNUSED (ST)<br> 
 * RX1-3: ROUTE (ST)<br> 
 * RX1-4: SITE ADMINISTERED (ST)<br> 
 * RX1-5: IV SOLUTION RATE (CQ)<br> 
 * RX1-6: DRUG STRENGTH (CQ)<br> 
 * RX1-7: FINAL CONCENTRATION (NM)<br> 
 * RX1-8: FINAL VOLUME IN ML. (NM)<br> 
 * RX1-9: DRUG DOSE (CM)<br> 
 * RX1-10: DRUG ROLE (ID)<br> 
 * RX1-11: PRESCRIPTION SEQUENCE # (NM)<br> 
 * RX1-12: QUANTITY DISPENSED (CQ)<br> 
 * RX1-13: UNUSED (ST)<br> 
 * RX1-14: DRUG ID (CE)<br> 
 * RX1-15: COMPONENT DRUG IDS (ID)<br> 
 * RX1-16: PRESCRIPTION TYPE (ID)<br> 
 * RX1-17: SUBSTITUTION STATUS (ID)<br> 
 * RX1-18: RX ORDER STATUS (ID)<br> 
 * RX1-19: NUMBER OF REFILLS (NM)<br> 
 * RX1-20: UNUSED (ST)<br> 
 * RX1-21: REFILLS REMAINING (NM)<br> 
 * RX1-22: DEA CLASS (ID)<br> 
 * RX1-23: ORDERING MD'S DEA NUMBER (NM)<br> 
 * RX1-24: UNUSED (ST)<br> 
 * RX1-25: LAST REFILL DATE/TIME (TS)<br> 
 * RX1-26: RX NUMBER (ST)<br> 
 * RX1-27: PRN STATUS (ID)<br> 
 * RX1-28: PHARMACY INSTRUCTIONS (TX)<br> 
 * RX1-29: PATIENT INSTRUCTIONS (TX)<br> 
 * RX1-30: INSTRUCTIONS (SIG) (TX)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RX1 : AbstractSegment  {

  /**
   * Creates a RX1 (PHARMACY ORDER) segment object that belongs to the given 
   * message.  
   */
	public RX1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UNUSED");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UNUSED");
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message}, "ROUTE");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "SITE ADMINISTERED");
       this.add(typeof(CQ), false, 1, 10, new System.Object[]{message}, "IV SOLUTION RATE");
       this.add(typeof(CQ), false, 1, 14, new System.Object[]{message}, "DRUG STRENGTH");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "FINAL CONCENTRATION");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "FINAL VOLUME IN ML.");
       this.add(typeof(CM), false, 1, 10, new System.Object[]{message}, "DRUG DOSE");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "DRUG ROLE");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "PRESCRIPTION SEQUENCE #");
       this.add(typeof(CQ), false, 1, 4, new System.Object[]{message}, "QUANTITY DISPENSED");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UNUSED");
       this.add(typeof(CE), false, 1, 5, new System.Object[]{message}, "DRUG ID");
       this.add(typeof(ID), false, 5, 5, new System.Object[]{message, 0}, "COMPONENT DRUG IDS");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "PRESCRIPTION TYPE");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "SUBSTITUTION STATUS");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 38}, "RX ORDER STATUS");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "NUMBER OF REFILLS");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UNUSED");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "REFILLS REMAINING");
       this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 0}, "DEA CLASS");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "ORDERING MD'S DEA NUMBER");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UNUSED");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "LAST REFILL DATE/TIME");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "RX NUMBER");
       this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 0}, "PRN STATUS");
       this.add(typeof(TX), false, 5, 80, new System.Object[]{message}, "PHARMACY INSTRUCTIONS");
       this.add(typeof(TX), false, 5, 80, new System.Object[]{message}, "PATIENT INSTRUCTIONS");
       this.add(typeof(TX), false, 0, 500, new System.Object[]{message}, "INSTRUCTIONS (SIG)");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns ROUTE(RX1-3).
	*/
	public ST ROUTE
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns SITE ADMINISTERED(RX1-4).
	*/
	public ST SITEADMINISTERED
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns IV SOLUTION RATE(RX1-5).
	*/
	public CQ IVSOLUTIONRATE
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns DRUG STRENGTH(RX1-6).
	*/
	public CQ DRUGSTRENGTH
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns FINAL CONCENTRATION(RX1-7).
	*/
	public NM FINALCONCENTRATION
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns FINAL VOLUME IN ML.(RX1-8).
	*/
	public NM FINALVOLUMEINML
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns DRUG DOSE(RX1-9).
	*/
	public CM DRUGDOSE
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(9, 0);
				ret = (CM)t;
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
	* Returns DRUG ROLE(RX1-10).
	*/
	public ID DRUGROLE
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
	* Returns PRESCRIPTION SEQUENCE #(RX1-11).
	*/
	public NM PRESCRIPTIONSEQUENCE
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

	/**
	* Returns QUANTITY DISPENSED(RX1-12).
	*/
	public CQ QUANTITYDISPENSED
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns DRUG ID(RX1-14).
	*/
	public CE DRUGID
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(14, 0);
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
	* Returns a single repetition of COMPONENT DRUG IDS(RX1-15).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getCOMPONENTDRUGIDS(int rep)
	{
			ID ret = null;
			try
			{
			IType t = this.getField(15, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of COMPONENT DRUG IDS (RX1-15).
   */
  public ID[] getCOMPONENTDRUGIDS() {
     ID[] ret = null;
    try {
        IType[] t = this.getField(15);  
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
	* Returns PRESCRIPTION TYPE(RX1-16).
	*/
	public ID PRESCRIPTIONTYPE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(16, 0);
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
	* Returns SUBSTITUTION STATUS(RX1-17).
	*/
	public ID SUBSTITUTIONSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(17, 0);
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
	* Returns RX ORDER STATUS(RX1-18).
	*/
	public ID RXORDERSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(18, 0);
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
	* Returns NUMBER OF REFILLS(RX1-19).
	*/
	public NM NUMBEROFREFILLS
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(19, 0);
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
	* Returns REFILLS REMAINING(RX1-21).
	*/
	public NM REFILLSREMAINING
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(21, 0);
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
	* Returns DEA CLASS(RX1-22).
	*/
	public ID DEACLASS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(22, 0);
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
	* Returns ORDERING MD'S DEA NUMBER(RX1-23).
	*/
	public NM ORDERINGMDSDEANUMBER
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(23, 0);
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
	* Returns LAST REFILL DATE/TIME(RX1-25).
	*/
	public TS LASTREFILLDATETIME
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(25, 0);
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
	* Returns RX NUMBER(RX1-26).
	*/
	public ST RXNUMBER
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(26, 0);
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
	* Returns PRN STATUS(RX1-27).
	*/
	public ID PRNSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(27, 0);
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
	* Returns a single repetition of PHARMACY INSTRUCTIONS(RX1-28).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TX getPHARMACYINSTRUCTIONS(int rep)
	{
			TX ret = null;
			try
			{
			IType t = this.getField(28, rep);
				ret = (TX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of PHARMACY INSTRUCTIONS (RX1-28).
   */
  public TX[] getPHARMACYINSTRUCTIONS() {
     TX[] ret = null;
    try {
        IType[] t = this.getField(28);  
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
	* Returns a single repetition of PATIENT INSTRUCTIONS(RX1-29).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TX getPATIENTINSTRUCTIONS(int rep)
	{
			TX ret = null;
			try
			{
			IType t = this.getField(29, rep);
				ret = (TX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of PATIENT INSTRUCTIONS (RX1-29).
   */
  public TX[] getPATIENTINSTRUCTIONS() {
     TX[] ret = null;
    try {
        IType[] t = this.getField(29);  
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
	* Returns a single repetition of INSTRUCTIONS (SIG)(RX1-30).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TX getINSTRUCTIONS(int rep)
	{
			TX ret = null;
			try
			{
			IType t = this.getField(30, rep);
				ret = (TX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of INSTRUCTIONS (SIG) (RX1-30).
   */
  public TX[] getINSTRUCTIONS() {
     TX[] ret = null;
    try {
        IType[] t = this.getField(30);  
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


}}