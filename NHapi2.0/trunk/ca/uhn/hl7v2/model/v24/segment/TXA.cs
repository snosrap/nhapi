using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 TXA message segment. 
 * This segment has the following fields:</p><p>
 * TXA-1: Set ID- TXA (SI)<br> 
 * TXA-2: Document Type (IS)<br> 
 * TXA-3: Document Content Presentation (ID)<br> 
 * TXA-4: Activity Date/Time (TS)<br> 
 * TXA-5: Primary Activity Provider Code/Name (XCN)<br> 
 * TXA-6: Origination Date/Time (TS)<br> 
 * TXA-7: Transcription Date/Time (TS)<br> 
 * TXA-8: Edit Date/Time (TS)<br> 
 * TXA-9: Originator Code/Name (XCN)<br> 
 * TXA-10: Assigned Document Authenticator (XCN)<br> 
 * TXA-11: Transcriptionist Code/Name (XCN)<br> 
 * TXA-12: Unique Document Number (EI)<br> 
 * TXA-13: Parent Document Number (EI)<br> 
 * TXA-14: Placer Order Number (EI)<br> 
 * TXA-15: Filler Order Number (EI)<br> 
 * TXA-16: Unique Document File Name (ST)<br> 
 * TXA-17: Document Completion Status (ID)<br> 
 * TXA-18: Document Confidentiality Status (ID)<br> 
 * TXA-19: Document Availability Status (ID)<br> 
 * TXA-20: Document Storage Status (ID)<br> 
 * TXA-21: Document Change Reason (ST)<br> 
 * TXA-22: Authentication Person, Time Stamp (PPN)<br> 
 * TXA-23: Distributed Copies (Code and Name of Recipients) (XCN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class TXA : AbstractSegment  {

  /**
   * Creates a TXA (Transcription Document Header) segment object that belongs to the given 
   * message.  
   */
  public TXA(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
       this.add(typeof(IS), true, 1, 30, new System.Object[]{message, 270});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 191});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(TS), false, 0, 26, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(EI), true, 1, 30, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 30, new System.Object[]{message});
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 271});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 272});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 273});
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 275});
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
       this.add(typeof(PPN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Set ID- TXA (TXA-1).
	*/
	public SI SetIDTXA
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
	* Returns Document Type (TXA-2).
	*/
	public IS DocumentType
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (IS)t;
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
	* Returns Document Content Presentation (TXA-3).
	*/
	public ID DocumentContentPresentation
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
	* Returns Activity Date/Time (TXA-4).
	*/
	public TS ActivityDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns a single repetition of Primary Activity Provider Code/Name (TXA-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getPrimaryActivityProviderCodeName(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Primary Activity Provider Code/Name (TXA-5).
   */
  public XCN[] getPrimaryActivityProviderCodeName() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(5);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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
	* Returns Origination Date/Time (TXA-6).
	*/
	public TS OriginationDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Transcription Date/Time (TXA-7).
	*/
	public TS TranscriptionDateTime
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
	* Returns a single repetition of Edit Date/Time (TXA-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TS getEditDateTime(int rep)
	{
			TS ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (TS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Edit Date/Time (TXA-8).
   */
  public TS[] getEditDateTime() {
     TS[] ret = null;
    try {
        Type[] t = this.getField(8);  
        ret = new TS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TS)t[i];
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
	* Returns a single repetition of Originator Code/Name (TXA-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getOriginatorCodeName(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Originator Code/Name (TXA-9).
   */
  public XCN[] getOriginatorCodeName() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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
	* Returns a single repetition of Assigned Document Authenticator (TXA-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getAssignedDocumentAuthenticator(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(10, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Assigned Document Authenticator (TXA-10).
   */
  public XCN[] getAssignedDocumentAuthenticator() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(10);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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
	* Returns a single repetition of Transcriptionist Code/Name (TXA-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getTranscriptionistCodeName(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Transcriptionist Code/Name (TXA-11).
   */
  public XCN[] getTranscriptionistCodeName() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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
	* Returns Unique Document Number (TXA-12).
	*/
	public EI UniqueDocumentNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (EI)t;
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
	* Returns Parent Document Number (TXA-13).
	*/
	public EI ParentDocumentNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (EI)t;
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
	* Returns a single repetition of Placer Order Number (TXA-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EI getPlacerOrderNumber(int rep)
	{
			EI ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Placer Order Number (TXA-14).
   */
  public EI[] getPlacerOrderNumber() {
     EI[] ret = null;
    try {
        Type[] t = this.getField(14);  
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
	* Returns Filler Order Number (TXA-15).
	*/
	public EI FillerOrderNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (EI)t;
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
	* Returns Unique Document File Name (TXA-16).
	*/
	public ST UniqueDocumentFileName
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns Document Completion Status (TXA-17).
	*/
	public ID DocumentCompletionStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Document Confidentiality Status (TXA-18).
	*/
	public ID DocumentConfidentialityStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Document Availability Status (TXA-19).
	*/
	public ID DocumentAvailabilityStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Document Storage Status (TXA-20).
	*/
	public ID DocumentStorageStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Document Change Reason (TXA-21).
	*/
	public ST DocumentChangeReason
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns a single repetition of Authentication Person, Time Stamp (TXA-22).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public PPN getAuthenticationPersonTimeStamp(int rep)
	{
			PPN ret = null;
			try
			{
			Type t = this.getField(22, rep);
				ret = (PPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Authentication Person, Time Stamp (TXA-22).
   */
  public PPN[] getAuthenticationPersonTimeStamp() {
     PPN[] ret = null;
    try {
        Type[] t = this.getField(22);  
        ret = new PPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PPN)t[i];
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
	* Returns a single repetition of Distributed Copies (Code and Name of Recipients) (TXA-23).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getDistributedCopiesCodeandNameofRecipients(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(23, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Distributed Copies (Code and Name of Recipients) (TXA-23).
   */
  public XCN[] getDistributedCopiesCodeandNameofRecipients() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(23);  
        ret = new XCN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XCN)t[i];
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