using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 SCH message segment. 
 * This segment has the following fields:</p><p>
 * SCH-1: Placer Appointment ID (EI)<br> 
 * SCH-2: Filler Appointment ID (EI)<br> 
 * SCH-3: Occurrence Number (NM)<br> 
 * SCH-4: Placer Group Number (EI)<br> 
 * SCH-5: Schedule ID (CE)<br> 
 * SCH-6: Event Reason (CE)<br> 
 * SCH-7: Appointment Reason (CE)<br> 
 * SCH-8: Appointment Type (CE)<br> 
 * SCH-9: Appointment Duration (NM)<br> 
 * SCH-10: Appointment Duration Units (CE)<br> 
 * SCH-11: Appointment Timing Quantity (TQ)<br> 
 * SCH-12: Placer Contact Person (XCN)<br> 
 * SCH-13: Placer Contact Phone Number (XTN)<br> 
 * SCH-14: Placer Contact Address (XAD)<br> 
 * SCH-15: Placer Contact Location (PL)<br> 
 * SCH-16: Filler Contact Person (XCN)<br> 
 * SCH-17: Filler Contact Phone Number (XTN)<br> 
 * SCH-18: Filler Contact Address (XAD)<br> 
 * SCH-19: Filler Contact Location (PL)<br> 
 * SCH-20: Entered By Person (XCN)<br> 
 * SCH-21: Entered By Phone Number (XTN)<br> 
 * SCH-22: Entered by Location (PL)<br> 
 * SCH-23: Parent Placer Appointment ID (EI)<br> 
 * SCH-24: Parent Filler Appointment ID (EI)<br> 
 * SCH-25: Filler Status Code (CE)<br> 
 * SCH-26: Placer Order Number (EI)<br> 
 * SCH-27: Filler Order Number (EI)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class SCH : AbstractSegment  {

  /**
   * Creates a SCH (Scheduling Activity Information) segment object that belongs to the given 
   * message.  
   */
  public SCH(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 5, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TQ), true, 0, 200, new System.Object[]{message});
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XTN), false, 1, 250, new System.Object[]{message});
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
       this.add(typeof(XCN), true, 0, 250, new System.Object[]{message});
       this.add(typeof(XTN), false, 1, 250, new System.Object[]{message});
       this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
       this.add(typeof(XCN), true, 0, 250, new System.Object[]{message});
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
       this.add(typeof(PL), false, 1, 80, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
       this.add(typeof(EI), false, 1, 75, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
       this.add(typeof(EI), false, 0, 22, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Placer Appointment ID (SCH-1).
	*/
	public EI PlacerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Filler Appointment ID (SCH-2).
	*/
	public EI FillerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Occurrence Number (SCH-3).
	*/
	public NM OccurrenceNumber
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Placer Group Number (SCH-4).
	*/
	public EI PlacerGroupNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Schedule ID (SCH-5).
	*/
	public CE ScheduleID
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Event Reason (SCH-6).
	*/
	public CE EventReason
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Appointment Reason (SCH-7).
	*/
	public CE AppointmentReason
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Appointment Type (SCH-8).
	*/
	public CE AppointmentType
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Appointment Duration (SCH-9).
	*/
	public NM AppointmentDuration
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Appointment Duration Units (SCH-10).
	*/
	public CE AppointmentDurationUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns a single repetition of Appointment Timing Quantity (SCH-11).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TQ getAppointmentTimingQuantity(int rep)
	{
			TQ ret = null;
			try
			{
			Type t = this.getField(11, rep);
				ret = (TQ)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Appointment Timing Quantity (SCH-11).
   */
  public TQ[] getAppointmentTimingQuantity() {
     TQ[] ret = null;
    try {
        Type[] t = this.getField(11);  
        ret = new TQ[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TQ)t[i];
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
	* Returns a single repetition of Placer Contact Person (SCH-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getPlacerContactPerson(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Placer Contact Person (SCH-12).
   */
  public XCN[] getPlacerContactPerson() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(12);  
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
	* Returns Placer Contact Phone Number (SCH-13).
	*/
	public XTN PlacerContactPhoneNumber
	{
		get{
			XTN ret = null;
			try
			{
			Type t = this.getField(13, 0);
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

	/**
	* Returns a single repetition of Placer Contact Address (SCH-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getPlacerContactAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Placer Contact Address (SCH-14).
   */
  public XAD[] getPlacerContactAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(14);  
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

	/**
	* Returns Placer Contact Location (SCH-15).
	*/
	public PL PlacerContactLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(15, 0);
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

	/**
	* Returns a single repetition of Filler Contact Person (SCH-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getFillerContactPerson(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Filler Contact Person (SCH-16).
   */
  public XCN[] getFillerContactPerson() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(16);  
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
	* Returns Filler Contact Phone Number (SCH-17).
	*/
	public XTN FillerContactPhoneNumber
	{
		get{
			XTN ret = null;
			try
			{
			Type t = this.getField(17, 0);
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

	/**
	* Returns a single repetition of Filler Contact Address (SCH-18).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getFillerContactAddress(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(18, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Filler Contact Address (SCH-18).
   */
  public XAD[] getFillerContactAddress() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(18);  
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

	/**
	* Returns Filler Contact Location (SCH-19).
	*/
	public PL FillerContactLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(19, 0);
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

	/**
	* Returns a single repetition of Entered By Person (SCH-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getEnteredByPerson(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(20, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Entered By Person (SCH-20).
   */
  public XCN[] getEnteredByPerson() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(20);  
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
	* Returns a single repetition of Entered By Phone Number (SCH-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getEnteredByPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(21, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Entered By Phone Number (SCH-21).
   */
  public XTN[] getEnteredByPhoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(21);  
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

	/**
	* Returns Entered by Location (SCH-22).
	*/
	public PL EnteredByLocation
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(22, 0);
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

	/**
	* Returns Parent Placer Appointment ID (SCH-23).
	*/
	public EI ParentPlacerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns Parent Filler Appointment ID (SCH-24).
	*/
	public EI ParentFillerAppointmentID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns Filler Status Code (SCH-25).
	*/
	public CE FillerStatusCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns a single repetition of Placer Order Number (SCH-26).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EI getPlacerOrderNumber(int rep)
	{
			EI ret = null;
			try
			{
			Type t = this.getField(26, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Placer Order Number (SCH-26).
   */
  public EI[] getPlacerOrderNumber() {
     EI[] ret = null;
    try {
        Type[] t = this.getField(26);  
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
	* Returns a single repetition of Filler Order Number (SCH-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public EI getFillerOrderNumber(int rep)
	{
			EI ret = null;
			try
			{
			Type t = this.getField(27, rep);
				ret = (EI)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Filler Order Number (SCH-27).
   */
  public EI[] getFillerOrderNumber() {
     EI[] ret = null;
    try {
        Type[] t = this.getField(27);  
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