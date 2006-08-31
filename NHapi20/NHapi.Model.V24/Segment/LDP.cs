using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 LDP message segment. 
/// This segment has the following fields:
/// * LDP-1: Primary Key Value - LDP (PL)
/// * LDP-2: Location Department (CE)
/// * LDP-3: Location Service (IS)
/// * LDP-4: Specialty Type (CE)
/// * LDP-5: Valid Patient Classes (IS)
/// * LDP-6: Active/Inactive Flag (ID)
/// * LDP-7: Activation Date  LDP (TS)
/// * LDP-8: Inactivation Date - LDP (TS)
/// * LDP-9: Inactivated Reason (ST)
/// * LDP-10: Visiting Hours (VH)
/// * LDP-11: Contact Phone (XTN)
/// * LDP-12: Location Cost Center (CE)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class LDP : AbstractSegment  {

  /**
   * Creates a LDP (Location Department) segment object that belongs to the given 
   * message.  
   */
	public LDP(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(PL), true, 1, 200, new System.Object[]{message}, "Primary Key Value - LDP");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Location Department");
       this.add(typeof(IS), false, 0, 3, new System.Object[]{message, 69}, "Location Service");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Specialty Type");
       this.add(typeof(IS), false, 0, 1, new System.Object[]{message, 4}, "Valid Patient Classes");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 183}, "Active/Inactive Flag");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Activation Date  LDP");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Inactivation Date - LDP");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "Inactivated Reason");
       this.add(typeof(VH), false, 0, 80, new System.Object[]{message}, "Visiting Hours");
       this.add(typeof(XTN), false, 1, 250, new System.Object[]{message}, "Contact Phone");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Location Cost Center");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Primary Key Value - LDP(LDP-1).
	///</summary>
	public PL PrimaryKeyValueLDP
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (PL)t;
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
	/// Returns Location Department(LDP-2).
	///</summary>
	public CE LocationDepartment
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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
	/// Returns a single repetition of Location Service(LDP-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public IS getLocationService(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Location Service (LDP-3).
   ///</summary>
  public IS[] getLocationService() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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
	/// Returns a single repetition of Specialty Type(LDP-4).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE getSpecialtyType(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(4, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Specialty Type (LDP-4).
   ///</summary>
  public CE[] getSpecialtyType() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(4);  
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

	///<summary>
	/// Returns a single repetition of Valid Patient Classes(LDP-5).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public IS getValidPatientClasses(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(5, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Valid Patient Classes (LDP-5).
   ///</summary>
  public IS[] getValidPatientClasses() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(5);  
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
	/// Returns Active/Inactive Flag(LDP-6).
	///</summary>
	public ID ActiveInactiveFlag
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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
	/// Returns Activation Date  LDP(LDP-7).
	///</summary>
	public TS ActivationDateLDP
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
	/// Returns Inactivation Date - LDP(LDP-8).
	///</summary>
	public TS InactivationDateLDP
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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
	/// Returns Inactivated Reason(LDP-9).
	///</summary>
	public ST InactivatedReason
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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
	/// Returns a single repetition of Visiting Hours(LDP-10).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public VH getVisitingHours(int rep)
	{
			VH ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (VH)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Visiting Hours (LDP-10).
   ///</summary>
  public VH[] getVisitingHours() {
     VH[] ret = null;
    try {
        IType[] t = this.GetField(10);  
        ret = new VH[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (VH)t[i];
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
	/// Returns Contact Phone(LDP-11).
	///</summary>
	public XTN ContactPhone
	{
		get{
			XTN ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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
	/// Returns Location Cost Center(LDP-12).
	///</summary>
	public CE LocationCostCenter
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


}}