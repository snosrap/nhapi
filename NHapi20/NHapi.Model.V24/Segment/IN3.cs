using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 IN3 message segment. 
/// This segment has the following fields:
/// * IN3-1: Set ID - IN3 (SI)
/// * IN3-2: Certification Number (CX)
/// * IN3-3: Certified By (XCN)
/// * IN3-4: Certification Required (ID)
/// * IN3-5: Penalty (MOP)
/// * IN3-6: Certification Date/Time (TS)
/// * IN3-7: Certification Modify Date/Time (TS)
/// * IN3-8: Operator (XCN)
/// * IN3-9: Certification Begin Date (DT)
/// * IN3-10: Certification End Date (DT)
/// * IN3-11: Days (DTN)
/// * IN3-12: Non-Concur Code/Description (CE)
/// * IN3-13: Non-Concur Effective Date/Time (TS)
/// * IN3-14: Physician Reviewer (XCN)
/// * IN3-15: Certification Contact (ST)
/// * IN3-16: Certification Contact Phone Number (XTN)
/// * IN3-17: Appeal Reason (CE)
/// * IN3-18: Certification Agency (CE)
/// * IN3-19: Certification Agency Phone Number (XTN)
/// * IN3-20: Pre-Certification Req/Window (PCF)
/// * IN3-21: Case Manager (ST)
/// * IN3-22: Second Opinion Date (DT)
/// * IN3-23: Second Opinion Status (IS)
/// * IN3-24: Second Opinion Documentation Received (IS)
/// * IN3-25: Second Opinion Physician (XCN)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class IN3 : AbstractSegment  {

  /**
   * Creates a IN3 (Insurance Additional Information, Certification) segment object that belongs to the given 
   * message.  
   */
	public IN3(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - IN3");
       this.add(typeof(CX), false, 1, 250, new System.Object[]{message}, "Certification Number");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Certified By");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Certification Required");
       this.add(typeof(MOP), false, 1, 10, new System.Object[]{message}, "Penalty");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Certification Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Certification Modify Date/Time");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Operator");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Certification Begin Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Certification End Date");
       this.add(typeof(DTN), false, 1, 3, new System.Object[]{message}, "Days");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Non-Concur Code/Description");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Non-Concur Effective Date/Time");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Physician Reviewer");
       this.add(typeof(ST), false, 1, 48, new System.Object[]{message}, "Certification Contact");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Certification Contact Phone Number");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Appeal Reason");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Certification Agency");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Certification Agency Phone Number");
       this.add(typeof(PCF), false, 0, 40, new System.Object[]{message}, "Pre-Certification Req/Window");
       this.add(typeof(ST), false, 1, 48, new System.Object[]{message}, "Case Manager");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Second Opinion Date");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 151}, "Second Opinion Status");
       this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 152}, "Second Opinion Documentation Received");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Second Opinion Physician");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID - IN3(IN3-1).
	///</summary>
	public SI SetIDIN3
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns Certification Number(IN3-2).
	///</summary>
	public CX CertificationNumber
	{
		get{
			CX ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (CX)t;
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

	///<summary>
	/// Returns a single repetition of Certified By(IN3-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getCertifiedBy(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Certified By (IN3-3).
   ///</summary>
  public XCN[] getCertifiedBy() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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

	///<summary>
	/// Returns Certification Required(IN3-4).
	///</summary>
	public ID CertificationRequired
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

	///<summary>
	/// Returns Penalty(IN3-5).
	///</summary>
	public MOP Penalty
	{
		get{
			MOP ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (MOP)t;
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

	///<summary>
	/// Returns Certification Date/Time(IN3-6).
	///</summary>
	public TS CertificationDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

	///<summary>
	/// Returns Certification Modify Date/Time(IN3-7).
	///</summary>
	public TS CertificationModifyDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

	///<summary>
	/// Returns a single repetition of Operator(IN3-8).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getOperator(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(8, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Operator (IN3-8).
   ///</summary>
  public XCN[] getOperator() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(8);  
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

	///<summary>
	/// Returns Certification Begin Date(IN3-9).
	///</summary>
	public DT CertificationBeginDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (DT)t;
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

	///<summary>
	/// Returns Certification End Date(IN3-10).
	///</summary>
	public DT CertificationEndDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(10, 0);
				ret = (DT)t;
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

	///<summary>
	/// Returns Days(IN3-11).
	///</summary>
	public DTN Days
	{
		get{
			DTN ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (DTN)t;
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

	///<summary>
	/// Returns Non-Concur Code/Description(IN3-12).
	///</summary>
	public CE NonConcurCodeDescription
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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

	///<summary>
	/// Returns Non-Concur Effective Date/Time(IN3-13).
	///</summary>
	public TS NonConcurEffectiveDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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

	///<summary>
	/// Returns a single repetition of Physician Reviewer(IN3-14).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getPhysicianReviewer(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(14, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Physician Reviewer (IN3-14).
   ///</summary>
  public XCN[] getPhysicianReviewer() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(14);  
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

	///<summary>
	/// Returns Certification Contact(IN3-15).
	///</summary>
	public ST CertificationContact
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(15, 0);
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

	///<summary>
	/// Returns a single repetition of Certification Contact Phone Number(IN3-16).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN getCertificationContactPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Certification Contact Phone Number (IN3-16).
   ///</summary>
  public XTN[] getCertificationContactPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(16);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
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

	///<summary>
	/// Returns Appeal Reason(IN3-17).
	///</summary>
	public CE AppealReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(17, 0);
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

	///<summary>
	/// Returns Certification Agency(IN3-18).
	///</summary>
	public CE CertificationAgency
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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

	///<summary>
	/// Returns a single repetition of Certification Agency Phone Number(IN3-19).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN getCertificationAgencyPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(19, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Certification Agency Phone Number (IN3-19).
   ///</summary>
  public XTN[] getCertificationAgencyPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(19);  
        ret = new XTN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XTN)t[i];
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

	///<summary>
	/// Returns a single repetition of Pre-Certification Req/Window(IN3-20).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public PCF getPreCertificationReqWindow(int rep)
	{
			PCF ret = null;
			try
			{
			IType t = this.GetField(20, rep);
				ret = (PCF)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Pre-Certification Req/Window (IN3-20).
   ///</summary>
  public PCF[] getPreCertificationReqWindow() {
     PCF[] ret = null;
    try {
        IType[] t = this.GetField(20);  
        ret = new PCF[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (PCF)t[i];
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

	///<summary>
	/// Returns Case Manager(IN3-21).
	///</summary>
	public ST CaseManager
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(21, 0);
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

	///<summary>
	/// Returns Second Opinion Date(IN3-22).
	///</summary>
	public DT SecondOpinionDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(22, 0);
				ret = (DT)t;
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

	///<summary>
	/// Returns Second Opinion Status(IN3-23).
	///</summary>
	public IS SecondOpinionStatus
	{
		get{
			IS ret = null;
			try
			{
			IType t = this.GetField(23, 0);
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

	///<summary>
	/// Returns a single repetition of Second Opinion Documentation Received(IN3-24).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public IS getSecondOpinionDocumentationReceived(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(24, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Second Opinion Documentation Received (IN3-24).
   ///</summary>
  public IS[] getSecondOpinionDocumentationReceived() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(24);  
        ret = new IS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (IS)t[i];
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

	///<summary>
	/// Returns a single repetition of Second Opinion Physician(IN3-25).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getSecondOpinionPhysician(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(25, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Second Opinion Physician (IN3-25).
   ///</summary>
  public XCN[] getSecondOpinionPhysician() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(25);  
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