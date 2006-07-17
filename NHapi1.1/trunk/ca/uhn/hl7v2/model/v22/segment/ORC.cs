using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 ORC message segment. 
 * This segment has the following fields:</p><p>
 * ORC-1: Order Control (ID)<br> 
 * ORC-2: Placer Order Number (CM_PLACER)<br> 
 * ORC-3: Filler Order Number (CM_FILLER)<br> 
 * ORC-4: Placer Group Number (CM_GROUP_ID)<br> 
 * ORC-5: Order Status (ID)<br> 
 * ORC-6: Response Flag (ID)<br> 
 * ORC-7: Quantity / timing (TQ)<br> 
 * ORC-8: Parent (CM_EIP)<br> 
 * ORC-9: Date / time of transaction (TS)<br> 
 * ORC-10: Entered By (CN_PERSON)<br> 
 * ORC-11: Verified By (CN_PERSON)<br> 
 * ORC-12: Ordering Provider (CN_PERSON)<br> 
 * ORC-13: Enterer's Location (CM_PARENT_RESULT)<br> 
 * ORC-14: Call Back Phone Number (TN)<br> 
 * ORC-15: Order effective date / time (TS)<br> 
 * ORC-16: Order Control Code Reason (CE)<br> 
 * ORC-17: Entering Organization (CE)<br> 
 * ORC-18: Entering Device (CE)<br> 
 * ORC-19: Action by (CN_PERSON)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ORC : AbstractSegment  {

  /**
   * Creates a ORC (COMMOM ORDER) segment object that belongs to the given 
   * message.  
   */
  public ORC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 119}, "Order Control");
       this.add(typeof(CM_PLACER), false, 1, 75, new System.Object[]{message}, "Placer Order Number");
       this.add(typeof(CM_FILLER), false, 1, 75, new System.Object[]{message}, "Filler Order Number");
       this.add(typeof(CM_GROUP_ID), false, 1, 75, new System.Object[]{message}, "Placer Group Number");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 38}, "Order Status");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 121}, "Response Flag");
       this.add(typeof(TQ), false, 0, 200, new System.Object[]{message}, "Quantity / timing");
       this.add(typeof(CM_EIP), false, 1, 200, new System.Object[]{message}, "Parent");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date / time of transaction");
       this.add(typeof(CN_PERSON), false, 1, 80, new System.Object[]{message}, "Entered By");
       this.add(typeof(CN_PERSON), false, 1, 80, new System.Object[]{message}, "Verified By");
       this.add(typeof(CN_PERSON), false, 1, 80, new System.Object[]{message}, "Ordering Provider");
       this.add(typeof(CM_PARENT_RESULT), false, 1, 80, new System.Object[]{message}, "Enterer's Location");
       this.add(typeof(TN), false, 2, 40, new System.Object[]{message}, "Call Back Phone Number");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Order effective date / time");
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "Order Control Code Reason");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Entering Organization");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Entering Device");
       this.add(typeof(CN_PERSON), false, 1, 80, new System.Object[]{message}, "Action by");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Order Control(ORC-1).
	*/
	public ID OrderControl
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Placer Order Number(ORC-2).
	*/
	public CM_PLACER PlacerOrderNumber
	{
		get{
			CM_PLACER ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (CM_PLACER)t;
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
	* Returns Filler Order Number(ORC-3).
	*/
	public CM_FILLER FillerOrderNumber
	{
		get{
			CM_FILLER ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (CM_FILLER)t;
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
	* Returns Placer Group Number(ORC-4).
	*/
	public CM_GROUP_ID PlacerGroupNumber
	{
		get{
			CM_GROUP_ID ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (CM_GROUP_ID)t;
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
	* Returns Order Status(ORC-5).
	*/
	public ID OrderStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Response Flag(ORC-6).
	*/
	public ID ResponseFlag
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
	* Returns a single repetition of Quantity / timing(ORC-7).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TQ getQuantityTiming(int rep)
	{
			TQ ret = null;
			try
			{
			Type t = this.getField(7, rep);
				ret = (TQ)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Quantity / timing (ORC-7).
   */
  public TQ[] getQuantityTiming() {
     TQ[] ret = null;
    try {
        Type[] t = this.getField(7);  
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
	* Returns Parent(ORC-8).
	*/
	public CM_EIP Parent
	{
		get{
			CM_EIP ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CM_EIP)t;
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
	* Returns Date / time of transaction(ORC-9).
	*/
	public TS DateTimeOfTransaction
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Entered By(ORC-10).
	*/
	public CN_PERSON EnteredBy
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (CN_PERSON)t;
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
	* Returns Verified By(ORC-11).
	*/
	public CN_PERSON VerifiedBy
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CN_PERSON)t;
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
	* Returns Ordering Provider(ORC-12).
	*/
	public CN_PERSON OrderingProvider
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (CN_PERSON)t;
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
	* Returns Enterer's Location(ORC-13).
	*/
	public CM_PARENT_RESULT EntererSLocation
	{
		get{
			CM_PARENT_RESULT ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (CM_PARENT_RESULT)t;
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
	* Returns a single repetition of Call Back Phone Number(ORC-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getCallBackPhoneNumber(int rep)
	{
			TN ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Call Back Phone Number (ORC-14).
   */
  public TN[] getCallBackPhoneNumber() {
     TN[] ret = null;
    try {
        Type[] t = this.getField(14);  
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
	* Returns Order effective date / time(ORC-15).
	*/
	public TS OrderEffectiveDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns Order Control Code Reason(ORC-16).
	*/
	public CE OrderControlCodeReason
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns Entering Organization(ORC-17).
	*/
	public CE EnteringOrganization
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Entering Device(ORC-18).
	*/
	public CE EnteringDevice
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Action by(ORC-19).
	*/
	public CN_PERSON ActionBy
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (CN_PERSON)t;
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