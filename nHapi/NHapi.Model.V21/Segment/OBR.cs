using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 OBR message segment. 
 * This segment has the following fields:</p><p>
 * OBR-1: SET ID - OBSERVATION REQUEST (SI)<br> 
 * OBR-2: PLACER ORDER # (CM)<br> 
 * OBR-3: FILLER ORDER # (CM)<br> 
 * OBR-4: UNIVERSAL SERVICE IDENT. (CE)<br> 
 * OBR-5: PRIORITY (ST)<br> 
 * OBR-6: REQUESTED DATE-TIME (TS)<br> 
 * OBR-7: OBSERVATION DATE/TIME (TS)<br> 
 * OBR-8: OBSERVATION END DATE/TIME (TS)<br> 
 * OBR-9: COLLECTION VOLUME (CQ)<br> 
 * OBR-10: COLLECTOR IDENTIFIER (CN)<br> 
 * OBR-11: SPECIMEN ACTION CODE (ST)<br> 
 * OBR-12: DANGER CODE (CM)<br> 
 * OBR-13: RELEVANT CLINICAL INFO. (ST)<br> 
 * OBR-14: SPECIMEN RECEIVED DATE/TIME (TS)<br> 
 * OBR-15: SPECIMEN SOURCE (CM)<br> 
 * OBR-16: ORDERING PROVIDER (CN)<br> 
 * OBR-17: ORDER CALL-BACK PHONE NUM (TN)<br> 
 * OBR-18: PLACERS FIELD #1 (ST)<br> 
 * OBR-19: PLACERS FIELD #2 (ST)<br> 
 * OBR-20: FILLERS FIELD #1 (ST)<br> 
 * OBR-21: FILLERS FIELD #2 (ST)<br> 
 * OBR-22: RESULTS RPT/STATUS CHNG - DATE/T (TS)<br> 
 * OBR-23: CHARGE TO PRACTICE (CM)<br> 
 * OBR-24: DIAGNOSTIC SERV SECT ID (ID)<br> 
 * OBR-25: RESULT STATUS (ID)<br> 
 * OBR-26: LINKED RESULTS (CE)<br> 
 * OBR-27: QUANTITY/TIMING (CM)<br> 
 * OBR-28: RESULT COPIES TO (CN)<br> 
 * OBR-29: PARENT ACCESSION # (CM)<br> 
 * OBR-30: TRANSPORTATION MODE (ID)<br> 
 * OBR-31: REASON FOR STUDY (CE)<br> 
 * OBR-32: PRINCIPAL RESULT INTERPRETER (CN)<br> 
 * OBR-33: ASSISTANT RESULT INTERPRETER (CN)<br> 
 * OBR-34: TECHNICIAN (CN)<br> 
 * OBR-35: TRANSCRIPTIONIST (CN)<br> 
 * OBR-36: SCHEDULED - DATE/TIME (TS)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OBR : AbstractSegment  {

  /**
   * Creates a OBR (OBSERVATION REQUEST) segment object that belongs to the given 
   * message.  
   */
	public OBR(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - OBSERVATION REQUEST");
       this.add(typeof(CM), false, 1, 75, new System.Object[]{message}, "PLACER ORDER #");
       this.add(typeof(CM), false, 1, 75, new System.Object[]{message}, "FILLER ORDER #");
       this.add(typeof(CE), true, 1, 200, new System.Object[]{message}, "UNIVERSAL SERVICE IDENT.");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "PRIORITY");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "REQUESTED DATE-TIME");
       this.add(typeof(TS), true, 1, 19, new System.Object[]{message}, "OBSERVATION DATE/TIME");
       this.add(typeof(TS), true, 1, 19, new System.Object[]{message}, "OBSERVATION END DATE/TIME");
       this.add(typeof(CQ), true, 1, 20, new System.Object[]{message}, "COLLECTION VOLUME");
       this.add(typeof(CN), false, 0, 60, new System.Object[]{message}, "COLLECTOR IDENTIFIER");
       this.add(typeof(ST), false, 1, 1, new System.Object[]{message}, "SPECIMEN ACTION CODE");
       this.add(typeof(CM), false, 1, 60, new System.Object[]{message}, "DANGER CODE");
       this.add(typeof(ST), false, 1, 300, new System.Object[]{message}, "RELEVANT CLINICAL INFO.");
       this.add(typeof(TS), true, 1, 19, new System.Object[]{message}, "SPECIMEN RECEIVED DATE/TIME");
       this.add(typeof(CM), false, 1, 300, new System.Object[]{message}, "SPECIMEN SOURCE");
       this.add(typeof(CN), false, 0, 60, new System.Object[]{message}, "ORDERING PROVIDER");
       this.add(typeof(TN), false, 2, 40, new System.Object[]{message}, "ORDER CALL-BACK PHONE NUM");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "PLACERS FIELD #1");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "PLACERS FIELD #2");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "FILLERS FIELD #1");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "FILLERS FIELD #2");
       this.add(typeof(TS), true, 1, 19, new System.Object[]{message}, "RESULTS RPT/STATUS CHNG - DATE/T");
       this.add(typeof(CM), false, 1, 40, new System.Object[]{message}, "CHARGE TO PRACTICE");
       this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 74}, "DIAGNOSTIC SERV SECT ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 123}, "RESULT STATUS");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "LINKED RESULTS");
       this.add(typeof(CM), false, 0, 200, new System.Object[]{message}, "QUANTITY/TIMING");
       this.add(typeof(CN), false, 5, 80, new System.Object[]{message}, "RESULT COPIES TO");
       this.add(typeof(CM), false, 1, 150, new System.Object[]{message}, "PARENT ACCESSION #");
       this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 124}, "TRANSPORTATION MODE");
       this.add(typeof(CE), false, 0, 300, new System.Object[]{message}, "REASON FOR STUDY");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "PRINCIPAL RESULT INTERPRETER");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "ASSISTANT RESULT INTERPRETER");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "TECHNICIAN");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "TRANSCRIPTIONIST");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "SCHEDULED - DATE/TIME");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns SET ID - OBSERVATION REQUEST(OBR-1).
	*/
	public SI SETIDOBSERVATIONREQUEST
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
	* Returns PLACER ORDER #(OBR-2).
	*/
	public CM PLACERORDER
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns FILLER ORDER #(OBR-3).
	*/
	public CM FILLERORDER
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns UNIVERSAL SERVICE IDENT.(OBR-4).
	*/
	public CE UNIVERSALSERVICEIDENT
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns PRIORITY(OBR-5).
	*/
	public ST PRIORITY
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
	* Returns REQUESTED DATE-TIME(OBR-6).
	*/
	public TS REQUESTEDDATETIME
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns OBSERVATION DATE/TIME(OBR-7).
	*/
	public TS OBSERVATIONDATETIME
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns OBSERVATION END DATE/TIME(OBR-8).
	*/
	public TS OBSERVATIONENDDATETIME
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns COLLECTION VOLUME(OBR-9).
	*/
	public CQ COLLECTIONVOLUME
	{
		get{
			CQ ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns a single repetition of COLLECTOR IDENTIFIER(OBR-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CN getCOLLECTORIDENTIFIER(int rep)
	{
			CN ret = null;
			try
			{
			IType t = this.getField(10, rep);
				ret = (CN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of COLLECTOR IDENTIFIER (OBR-10).
   */
  public CN[] getCOLLECTORIDENTIFIER() {
     CN[] ret = null;
    try {
        IType[] t = this.getField(10);  
        ret = new CN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
	* Returns SPECIMEN ACTION CODE(OBR-11).
	*/
	public ST SPECIMENACTIONCODE
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(11, 0);
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
	* Returns DANGER CODE(OBR-12).
	*/
	public CM DANGERCODE
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns RELEVANT CLINICAL INFO.(OBR-13).
	*/
	public ST RELEVANTCLINICALINFO
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(13, 0);
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
	* Returns SPECIMEN RECEIVED DATE/TIME(OBR-14).
	*/
	public TS SPECIMENRECEIVEDDATETIME
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(14, 0);
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
	* Returns SPECIMEN SOURCE(OBR-15).
	*/
	public CM SPECIMENSOURCE
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(15, 0);
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
	* Returns a single repetition of ORDERING PROVIDER(OBR-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CN getORDERINGPROVIDER(int rep)
	{
			CN ret = null;
			try
			{
			IType t = this.getField(16, rep);
				ret = (CN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of ORDERING PROVIDER (OBR-16).
   */
  public CN[] getORDERINGPROVIDER() {
     CN[] ret = null;
    try {
        IType[] t = this.getField(16);  
        ret = new CN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
	* Returns a single repetition of ORDER CALL-BACK PHONE NUM(OBR-17).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getORDERCALLBACKPHONENUM(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.getField(17, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of ORDER CALL-BACK PHONE NUM (OBR-17).
   */
  public TN[] getORDERCALLBACKPHONENUM() {
     TN[] ret = null;
    try {
        IType[] t = this.getField(17);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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
	* Returns PLACERS FIELD #1(OBR-18).
	*/
	public ST PLACERSFIELD1
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(18, 0);
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
	* Returns PLACERS FIELD #2(OBR-19).
	*/
	public ST PLACERSFIELD2
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(19, 0);
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
	* Returns FILLERS FIELD #1(OBR-20).
	*/
	public ST FILLERSFIELD1
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(20, 0);
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
	* Returns FILLERS FIELD #2(OBR-21).
	*/
	public ST FILLERSFIELD2
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(21, 0);
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
	* Returns RESULTS RPT/STATUS CHNG - DATE/T(OBR-22).
	*/
	public TS RESULTSRPTSTATUSCHNGDATET
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(22, 0);
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
	* Returns CHARGE TO PRACTICE(OBR-23).
	*/
	public CM CHARGETOPRACTICE
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(23, 0);
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
	* Returns DIAGNOSTIC SERV SECT ID(OBR-24).
	*/
	public ID DIAGNOSTICSERVSECTID
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(24, 0);
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
	* Returns RESULT STATUS(OBR-25).
	*/
	public ID RESULTSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(25, 0);
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
	* Returns LINKED RESULTS(OBR-26).
	*/
	public CE LINKEDRESULTS
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(26, 0);
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
	* Returns a single repetition of QUANTITY/TIMING(OBR-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CM getQUANTITYTIMING(int rep)
	{
			CM ret = null;
			try
			{
			IType t = this.getField(27, rep);
				ret = (CM)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of QUANTITY/TIMING (OBR-27).
   */
  public CM[] getQUANTITYTIMING() {
     CM[] ret = null;
    try {
        IType[] t = this.getField(27);  
        ret = new CM[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CM)t[i];
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
	* Returns a single repetition of RESULT COPIES TO(OBR-28).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CN getRESULTCOPIESTO(int rep)
	{
			CN ret = null;
			try
			{
			IType t = this.getField(28, rep);
				ret = (CN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of RESULT COPIES TO (OBR-28).
   */
  public CN[] getRESULTCOPIESTO() {
     CN[] ret = null;
    try {
        IType[] t = this.getField(28);  
        ret = new CN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
	* Returns PARENT ACCESSION #(OBR-29).
	*/
	public CM PARENTACCESSION
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(29, 0);
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
	* Returns TRANSPORTATION MODE(OBR-30).
	*/
	public ID TRANSPORTATIONMODE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(30, 0);
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
	* Returns a single repetition of REASON FOR STUDY(OBR-31).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getREASONFORSTUDY(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.getField(31, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of REASON FOR STUDY (OBR-31).
   */
  public CE[] getREASONFORSTUDY() {
     CE[] ret = null;
    try {
        IType[] t = this.getField(31);  
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
	* Returns PRINCIPAL RESULT INTERPRETER(OBR-32).
	*/
	public CN PRINCIPALRESULTINTERPRETER
	{
		get{
			CN ret = null;
			try
			{
			IType t = this.getField(32, 0);
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
	* Returns ASSISTANT RESULT INTERPRETER(OBR-33).
	*/
	public CN ASSISTANTRESULTINTERPRETER
	{
		get{
			CN ret = null;
			try
			{
			IType t = this.getField(33, 0);
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
	* Returns TECHNICIAN(OBR-34).
	*/
	public CN TECHNICIAN
	{
		get{
			CN ret = null;
			try
			{
			IType t = this.getField(34, 0);
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
	* Returns TRANSCRIPTIONIST(OBR-35).
	*/
	public CN TRANSCRIPTIONIST
	{
		get{
			CN ret = null;
			try
			{
			IType t = this.getField(35, 0);
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
	* Returns SCHEDULED - DATE/TIME(OBR-36).
	*/
	public TS SCHEDULEDDATETIME
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(36, 0);
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