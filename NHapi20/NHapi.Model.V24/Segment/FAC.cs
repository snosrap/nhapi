using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 FAC message segment. 
/// This segment has the following fields:
/// * FAC-1: Facility ID-FAC (EI)
/// * FAC-2: Facility Type (ID)
/// * FAC-3: Facility Address (XAD)
/// * FAC-4: Facility Telecommunication (XTN)
/// * FAC-5: Contact Person (XCN)
/// * FAC-6: Contact Title (ST)
/// * FAC-7: Contact Address (XAD)
/// * FAC-8: Contact Telecommunication (XTN)
/// * FAC-9: Signature Authority (XCN)
/// * FAC-10: Signature Authority Title (ST)
/// * FAC-11: Signature Authority Address (XAD)
/// * FAC-12: Signature Authority Telecommunication (XTN)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class FAC : AbstractSegment  {

  /**
   * Creates a FAC (Facility) segment object that belongs to the given 
   * message.  
   */
	public FAC(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(EI), true, 1, 20, new System.Object[]{message}, "Facility ID-FAC");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 331}, "Facility Type");
       this.add(typeof(XAD), true, 0, 250, new System.Object[]{message}, "Facility Address");
       this.add(typeof(XTN), true, 1, 250, new System.Object[]{message}, "Facility Telecommunication");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Contact Person");
       this.add(typeof(ST), false, 0, 60, new System.Object[]{message}, "Contact Title");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Contact Address");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Contact Telecommunication");
       this.add(typeof(XCN), true, 0, 250, new System.Object[]{message}, "Signature Authority");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Signature Authority Title");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Signature Authority Address");
       this.add(typeof(XTN), false, 1, 250, new System.Object[]{message}, "Signature Authority Telecommunication");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Facility ID-FAC(FAC-1).
	///</summary>
	public EI FacilityIDFAC
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns Facility Type(FAC-2).
	///</summary>
	public ID FacilityType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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
	/// Returns a single repetition of Facility Address(FAC-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XAD getFacilityAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Facility Address (FAC-3).
   ///</summary>
  public XAD[] getFacilityAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(3);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
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
	/// Returns Facility Telecommunication(FAC-4).
	///</summary>
	public XTN FacilityTelecommunication
	{
		get{
			XTN ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (XTN)t;
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
	/// Returns a single repetition of Contact Person(FAC-5).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getContactPerson(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Contact Person (FAC-5).
   ///</summary>
  public XCN[] getContactPerson() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(5);  
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
	/// Returns a single repetition of Contact Title(FAC-6).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST getContactTitle(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(6, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Contact Title (FAC-6).
   ///</summary>
  public ST[] getContactTitle() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(6);  
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

	///<summary>
	/// Returns a single repetition of Contact Address(FAC-7).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XAD getContactAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Contact Address (FAC-7).
   ///</summary>
  public XAD[] getContactAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(7);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
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
	/// Returns a single repetition of Contact Telecommunication(FAC-8).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN getContactTelecommunication(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(8, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Contact Telecommunication (FAC-8).
   ///</summary>
  public XTN[] getContactTelecommunication() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(8);  
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
	/// Returns a single repetition of Signature Authority(FAC-9).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getSignatureAuthority(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(9, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Signature Authority (FAC-9).
   ///</summary>
  public XCN[] getSignatureAuthority() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(9);  
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
	/// Returns Signature Authority Title(FAC-10).
	///</summary>
	public ST SignatureAuthorityTitle
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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
	/// Returns a single repetition of Signature Authority Address(FAC-11).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XAD getSignatureAuthorityAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(11, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Signature Authority Address (FAC-11).
   ///</summary>
  public XAD[] getSignatureAuthorityAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(11);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
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
	/// Returns Signature Authority Telecommunication(FAC-12).
	///</summary>
	public XTN SignatureAuthorityTelecommunication
	{
		get{
			XTN ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (XTN)t;
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