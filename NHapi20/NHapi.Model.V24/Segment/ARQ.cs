using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 ARQ message segment. 
/// This segment has the following fields:
/// * ARQ-1: Placer Appointment ID (EI)
/// * ARQ-2: Filler Appointment ID (EI)
/// * ARQ-3: Occurrence Number (NM)
/// * ARQ-4: Placer Group Number (EI)
/// * ARQ-5: Schedule ID (CE)
/// * ARQ-6: Request Event Reason (CE)
/// * ARQ-7: Appointment Reason (CE)
/// * ARQ-8: Appointment Type (CE)
/// * ARQ-9: Appointment Duration (NM)
/// * ARQ-10: Appointment Duration Units (CE)
/// * ARQ-11: Requested Start Date/Time Range (DR)
/// * ARQ-12: Priority-ARQ (ST)
/// * ARQ-13: Repeating Interval (RI)
/// * ARQ-14: Repeating Interval Duration (ST)
/// * ARQ-15: Placer Contact Person (XCN)
/// * ARQ-16: Placer Contact Phone Number (XTN)
/// * ARQ-17: Placer Contact Address (XAD)
/// * ARQ-18: Placer Contact Location (PL)
/// * ARQ-19: Entered By Person (XCN)
/// * ARQ-20: Entered By Phone Number (XTN)
/// * ARQ-21: Entered by Location (PL)
/// * ARQ-22: Parent Placer Appointment ID (EI)
/// * ARQ-23: Parent Filler Appointment ID (EI)
/// * ARQ-24: Placer Order Number (EI)
/// * ARQ-25: Filler Order Number (EI)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class ARQ : AbstractSegment  {

  /**
   * Creates a ARQ (Appointment Request) segment object that belongs to the given 
   * message.  
   */
	public ARQ(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(EI), true, 1, 75, new System.Object[]{message}, "Placer Appointment ID");
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message}, "Filler Appointment ID");
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message}, "Occurrence Number");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Placer Group Number");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Schedule ID");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Request Event Reason");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Appointment Reason");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Appointment Type");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Appointment Duration");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Appointment Duration Units");
       this.add(typeof(DR), false, 0, 53, new System.Object[]{message}, "Requested Start Date/Time Range");
       this.add(typeof(ST), false, 1, 5, new System.Object[]{message}, "Priority-ARQ");
       this.add(typeof(RI), false, 1, 100, new System.Object[]{message}, "Repeating Interval");
       this.add(typeof(ST), false, 1, 5, new System.Object[]{message}, "Repeating Interval Duration");
       this.add(typeof(XCN), true, 0, 250, new System.Object[]{message}, "Placer Contact Person");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Placer Contact Phone Number");
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message}, "Placer Contact Address");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Placer Contact Location");
       this.add(typeof(XCN), true, 0, 250, new System.Object[]{message}, "Entered By Person");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Entered By Phone Number");
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message}, "Entered by Location");
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message}, "Parent Placer Appointment ID");
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message}, "Parent Filler Appointment ID");
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message}, "Placer Order Number");
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message}, "Filler Order Number");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Placer Appointment ID(ARQ-1).
	///</summary>
	public EI PlacerAppointmentID
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
	/// Returns Filler Appointment ID(ARQ-2).
	///</summary>
	public EI FillerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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
	/// Returns Occurrence Number(ARQ-3).
	///</summary>
	public NM OccurrenceNumber
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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

	///<summary>
	/// Returns Placer Group Number(ARQ-4).
	///</summary>
	public EI PlacerGroupNumber
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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
	/// Returns Schedule ID(ARQ-5).
	///</summary>
	public CE ScheduleID
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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
	/// Returns Request Event Reason(ARQ-6).
	///</summary>
	public CE RequestEventReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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
	/// Returns Appointment Reason(ARQ-7).
	///</summary>
	public CE AppointmentReason
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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
	/// Returns Appointment Type(ARQ-8).
	///</summary>
	public CE AppointmentType
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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
	/// Returns Appointment Duration(ARQ-9).
	///</summary>
	public NM AppointmentDuration
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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

	///<summary>
	/// Returns Appointment Duration Units(ARQ-10).
	///</summary>
	public CE AppointmentDurationUnits
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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
	/// Returns a single repetition of Requested Start Date/Time Range(ARQ-11).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public DR getRequestedStartDateTimeRange(int rep)
	{
			DR ret = null;
			try
			{
			IType t = this.GetField(11, rep);
				ret = (DR)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Requested Start Date/Time Range (ARQ-11).
   ///</summary>
  public DR[] getRequestedStartDateTimeRange() {
     DR[] ret = null;
    try {
        IType[] t = this.GetField(11);  
        ret = new DR[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (DR)t[i];
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
	/// Returns Priority-ARQ(ARQ-12).
	///</summary>
	public ST PriorityARQ
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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
	/// Returns Repeating Interval(ARQ-13).
	///</summary>
	public RI RepeatingInterval
	{
		get{
			RI ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (RI)t;
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
	/// Returns Repeating Interval Duration(ARQ-14).
	///</summary>
	public ST RepeatingIntervalDuration
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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
	/// Returns a single repetition of Placer Contact Person(ARQ-15).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getPlacerContactPerson(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(15, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Placer Contact Person (ARQ-15).
   ///</summary>
  public XCN[] getPlacerContactPerson() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(15);  
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
	/// Returns a single repetition of Placer Contact Phone Number(ARQ-16).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN getPlacerContactPhoneNumber(int rep)
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
  /// Returns all repetitions of Placer Contact Phone Number (ARQ-16).
   ///</summary>
  public XTN[] getPlacerContactPhoneNumber() {
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
	/// Returns a single repetition of Placer Contact Address(ARQ-17).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XAD getPlacerContactAddress(int rep)
	{
			XAD ret = null;
			try
			{
			IType t = this.GetField(17, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Placer Contact Address (ARQ-17).
   ///</summary>
  public XAD[] getPlacerContactAddress() {
     XAD[] ret = null;
    try {
        IType[] t = this.GetField(17);  
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
	/// Returns Placer Contact Location(ARQ-18).
	///</summary>
	public PL PlacerContactLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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
	/// Returns a single repetition of Entered By Person(ARQ-19).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XCN getEnteredByPerson(int rep)
	{
			XCN ret = null;
			try
			{
			IType t = this.GetField(19, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Entered By Person (ARQ-19).
   ///</summary>
  public XCN[] getEnteredByPerson() {
     XCN[] ret = null;
    try {
        IType[] t = this.GetField(19);  
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
	/// Returns a single repetition of Entered By Phone Number(ARQ-20).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XTN getEnteredByPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			IType t = this.GetField(20, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Entered By Phone Number (ARQ-20).
   ///</summary>
  public XTN[] getEnteredByPhoneNumber() {
     XTN[] ret = null;
    try {
        IType[] t = this.GetField(20);  
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
	/// Returns Entered by Location(ARQ-21).
	///</summary>
	public PL EnteredByLocation
	{
		get{
			PL ret = null;
			try
			{
			IType t = this.GetField(21, 0);
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
	/// Returns Parent Placer Appointment ID(ARQ-22).
	///</summary>
	public EI ParentPlacerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(22, 0);
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
	/// Returns Parent Filler Appointment ID(ARQ-23).
	///</summary>
	public EI ParentFillerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(23, 0);
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
	/// Returns a single repetition of Placer Order Number(ARQ-24).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public EI getPlacerOrderNumber(int rep)
	{
			EI ret = null;
			try
			{
			IType t = this.GetField(24, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Placer Order Number (ARQ-24).
   ///</summary>
  public EI[] getPlacerOrderNumber() {
     EI[] ret = null;
    try {
        IType[] t = this.GetField(24);  
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

	///<summary>
	/// Returns a single repetition of Filler Order Number(ARQ-25).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public EI getFillerOrderNumber(int rep)
	{
			EI ret = null;
			try
			{
			IType t = this.GetField(25, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Filler Order Number (ARQ-25).
   ///</summary>
  public EI[] getFillerOrderNumber() {
     EI[] ret = null;
    try {
        IType[] t = this.GetField(25);  
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


}}