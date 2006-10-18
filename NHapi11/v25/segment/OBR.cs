using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 OBR message segment. 
 * This segment has the following fields:</p><p>
 * OBR-1: Set ID - OBR (SI)<br> 
 * OBR-2: Placer Order Number (EI)<br> 
 * OBR-3: Filler Order Number (EI)<br> 
 * OBR-4: Universal Service Identifier (CE)<br> 
 * OBR-5: Priority _ OBR (ID)<br> 
 * OBR-6: Requested Date/Time (TS)<br> 
 * OBR-7: Observation Date/Time (TS)<br> 
 * OBR-8: Observation End Date/Time (TS)<br> 
 * OBR-9: Collection Volume (CQ)<br> 
 * OBR-10: Collector Identifier (XCN)<br> 
 * OBR-11: Specimen Action Code (ID)<br> 
 * OBR-12: Danger Code (CE)<br> 
 * OBR-13: Relevant Clinical Information (ST)<br> 
 * OBR-14: Specimen Received Date/Time (TS)<br> 
 * OBR-15: Specimen Source (SPS)<br> 
 * OBR-16: Ordering Provider (XCN)<br> 
 * OBR-17: Order Callback Phone Number (XTN)<br> 
 * OBR-18: Placer Field 1 (ST)<br> 
 * OBR-19: Placer Field 2 (ST)<br> 
 * OBR-20: Filler Field 1 (ST)<br> 
 * OBR-21: Filler Field 2 (ST)<br> 
 * OBR-22: Results Rpt/Status Chng - Date/Time (TS)<br> 
 * OBR-23: Charge to Practice (MOC)<br> 
 * OBR-24: Diagnostic Serv Sect ID (ID)<br> 
 * OBR-25: Result Status (ID)<br> 
 * OBR-26: Parent Result (PRL)<br> 
 * OBR-27: Quantity/Timing (TQ)<br> 
 * OBR-28: Result Copies To (XCN)<br> 
 * OBR-29: Parent (EIP)<br> 
 * OBR-30: Transportation Mode (ID)<br> 
 * OBR-31: Reason for Study (CE)<br> 
 * OBR-32: Principal Result Interpreter (NDL)<br> 
 * OBR-33: Assistant Result Interpreter (NDL)<br> 
 * OBR-34: Technician (NDL)<br> 
 * OBR-35: Transcriptionist (NDL)<br> 
 * OBR-36: Scheduled Date/Time (TS)<br> 
 * OBR-37: Number of Sample Containers * (NM)<br> 
 * OBR-38: Transport Logistics of Collected Sample (CE)<br> 
 * OBR-39: Collector's Comment * (CE)<br> 
 * OBR-40: Transport Arrangement Responsibility (CE)<br> 
 * OBR-41: Transport Arranged (ID)<br> 
 * OBR-42: Escort Required (ID)<br> 
 * OBR-43: Planned Patient Transport Comment (CE)<br> 
 * OBR-44: Procedure Code (CE)<br> 
 * OBR-45: Procedure Code Modifier (CE)<br> 
 * OBR-46: Placer Supplemental Service Information (CE)<br> 
 * OBR-47: Filler Supplemental Service Information (CE)<br> 
 * OBR-48: Medically Necessary Duplicate Procedure Reason. (CWE)<br> 
 * OBR-49: Result Handling (IS)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OBR : AbstractSegment  {

  /**
   * Creates a OBR (Observation Request) segment object that belongs to the given 
   * message.  
   */
  public OBR(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "Set ID - OBR");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Placer Order Number");
       this.add(typeof(EI), false, 1, 22, new System.Object[]{message}, "Filler Order Number");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Universal Service Identifier");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Priority _ OBR");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Requested Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Observation Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Observation End Date/Time");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Collection Volume");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Collector Identifier");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 65}, "Specimen Action Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Danger Code");
       this.add(typeof(ST), false, 1, 300, new System.Object[]{message}, "Relevant Clinical Information");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Specimen Received Date/Time");
       this.add(typeof(SPS), false, 1, 300, new System.Object[]{message}, "Specimen Source");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Ordering Provider");
       this.add(typeof(XTN), false, 0, 250, new System.Object[]{message}, "Order Callback Phone Number");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Placer Field 1");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Placer Field 2");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Filler Field 1");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Filler Field 2");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Results Rpt/Status Chng - Date/Time");
       this.add(typeof(MOC), false, 1, 40, new System.Object[]{message}, "Charge to Practice");
       this.add(typeof(ID), false, 1, 10, new System.Object[]{message, 74}, "Diagnostic Serv Sect ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 123}, "Result Status");
       this.add(typeof(PRL), false, 1, 400, new System.Object[]{message}, "Parent Result");
       this.add(typeof(TQ), false, 0, 200, new System.Object[]{message}, "Quantity/Timing");
       this.add(typeof(XCN), false, 0, 250, new System.Object[]{message}, "Result Copies To");
       this.add(typeof(EIP), false, 1, 200, new System.Object[]{message}, "Parent");
       this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 124}, "Transportation Mode");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Reason for Study");
       this.add(typeof(NDL), false, 1, 200, new System.Object[]{message}, "Principal Result Interpreter");
       this.add(typeof(NDL), false, 0, 200, new System.Object[]{message}, "Assistant Result Interpreter");
       this.add(typeof(NDL), false, 0, 200, new System.Object[]{message}, "Technician");
       this.add(typeof(NDL), false, 0, 200, new System.Object[]{message}, "Transcriptionist");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Scheduled Date/Time");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Number of Sample Containers *");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Transport Logistics of Collected Sample");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Collector's Comment *");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Transport Arrangement Responsibility");
       this.add(typeof(ID), false, 1, 30, new System.Object[]{message, 224}, "Transport Arranged");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 225}, "Escort Required");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Planned Patient Transport Comment");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Procedure Code");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Procedure Code Modifier");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Placer Supplemental Service Information");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Filler Supplemental Service Information");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Medically Necessary Duplicate Procedure Reason.");
       this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 507}, "Result Handling");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - OBR(OBR-1).
	*/
	public SI SetIDOBR
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
	* Returns Placer Order Number(OBR-2).
	*/
	public EI PlacerOrderNumber
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
	* Returns Filler Order Number(OBR-3).
	*/
	public EI FillerOrderNumber
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Universal Service Identifier(OBR-4).
	*/
	public CE UniversalServiceIdentifier
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Priority _ OBR(OBR-5).
	*/
	public ID PriorityOBR
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
	* Returns Requested Date/Time(OBR-6).
	*/
	public TS RequestedDateTime
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
	* Returns Observation Date/Time(OBR-7).
	*/
	public TS ObservationDateTime
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
	* Returns Observation End Date/Time(OBR-8).
	*/
	public TS ObservationEndDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Collection Volume(OBR-9).
	*/
	public CQ CollectionVolume
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns a single repetition of Collector Identifier(OBR-10).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getCollectorIdentifier(int rep)
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
   * Returns all repetitions of Collector Identifier (OBR-10).
   */
  public XCN[] getCollectorIdentifier() {
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
	* Returns Specimen Action Code(OBR-11).
	*/
	public ID SpecimenActionCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Danger Code(OBR-12).
	*/
	public CE DangerCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Relevant Clinical Information(OBR-13).
	*/
	public ST RelevantClinicalInformation
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Specimen Received Date/Time(OBR-14).
	*/
	public TS SpecimenReceivedDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns Specimen Source(OBR-15).
	*/
	public SPS SpecimenSource
	{
		get{
			SPS ret = null;
			try
			{
			Type t = this.getField(15, 0);
				ret = (SPS)t;
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
	* Returns a single repetition of Ordering Provider(OBR-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getOrderingProvider(int rep)
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
   * Returns all repetitions of Ordering Provider (OBR-16).
   */
  public XCN[] getOrderingProvider() {
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
	* Returns a single repetition of Order Callback Phone Number(OBR-17).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XTN getOrderCallbackPhoneNumber(int rep)
	{
			XTN ret = null;
			try
			{
			Type t = this.getField(17, rep);
				ret = (XTN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Order Callback Phone Number (OBR-17).
   */
  public XTN[] getOrderCallbackPhoneNumber() {
     XTN[] ret = null;
    try {
        Type[] t = this.getField(17);  
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
	* Returns Placer Field 1(OBR-18).
	*/
	public ST PlacerField1
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Placer Field 2(OBR-19).
	*/
	public ST PlacerField2
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Filler Field 1(OBR-20).
	*/
	public ST FillerField1
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Filler Field 2(OBR-21).
	*/
	public ST FillerField2
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
	* Returns Results Rpt/Status Chng - Date/Time(OBR-22).
	*/
	public TS ResultsRptStatusChngDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns Charge to Practice(OBR-23).
	*/
	public MOC ChargeToPractice
	{
		get{
			MOC ret = null;
			try
			{
			Type t = this.getField(23, 0);
				ret = (MOC)t;
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
	* Returns Diagnostic Serv Sect ID(OBR-24).
	*/
	public ID DiagnosticServSectID
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns Result Status(OBR-25).
	*/
	public ID ResultStatus
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(25, 0);
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
	* Returns Parent Result(OBR-26).
	*/
	public PRL ParentResult
	{
		get{
			PRL ret = null;
			try
			{
			Type t = this.getField(26, 0);
				ret = (PRL)t;
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
	* Returns a single repetition of Quantity/Timing(OBR-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TQ getQuantityTiming(int rep)
	{
			TQ ret = null;
			try
			{
			Type t = this.getField(27, rep);
				ret = (TQ)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Quantity/Timing (OBR-27).
   */
  public TQ[] getQuantityTiming() {
     TQ[] ret = null;
    try {
        Type[] t = this.getField(27);  
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
	* Returns a single repetition of Result Copies To(OBR-28).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XCN getResultCopiesTo(int rep)
	{
			XCN ret = null;
			try
			{
			Type t = this.getField(28, rep);
				ret = (XCN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Result Copies To (OBR-28).
   */
  public XCN[] getResultCopiesTo() {
     XCN[] ret = null;
    try {
        Type[] t = this.getField(28);  
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
	* Returns Parent(OBR-29).
	*/
	public EIP Parent
	{
		get{
			EIP ret = null;
			try
			{
			Type t = this.getField(29, 0);
				ret = (EIP)t;
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
	* Returns Transportation Mode(OBR-30).
	*/
	public ID TransportationMode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(30, 0);
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
	* Returns a single repetition of Reason for Study(OBR-31).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getReasonForStudy(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(31, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Reason for Study (OBR-31).
   */
  public CE[] getReasonForStudy() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(31);  
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
	* Returns Principal Result Interpreter(OBR-32).
	*/
	public NDL PrincipalResultInterpreter
	{
		get{
			NDL ret = null;
			try
			{
			Type t = this.getField(32, 0);
				ret = (NDL)t;
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
	* Returns a single repetition of Assistant Result Interpreter(OBR-33).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public NDL getAssistantResultInterpreter(int rep)
	{
			NDL ret = null;
			try
			{
			Type t = this.getField(33, rep);
				ret = (NDL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Assistant Result Interpreter (OBR-33).
   */
  public NDL[] getAssistantResultInterpreter() {
     NDL[] ret = null;
    try {
        Type[] t = this.getField(33);  
        ret = new NDL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NDL)t[i];
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
	* Returns a single repetition of Technician(OBR-34).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public NDL getTechnician(int rep)
	{
			NDL ret = null;
			try
			{
			Type t = this.getField(34, rep);
				ret = (NDL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Technician (OBR-34).
   */
  public NDL[] getTechnician() {
     NDL[] ret = null;
    try {
        Type[] t = this.getField(34);  
        ret = new NDL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NDL)t[i];
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
	* Returns a single repetition of Transcriptionist(OBR-35).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public NDL getTranscriptionist(int rep)
	{
			NDL ret = null;
			try
			{
			Type t = this.getField(35, rep);
				ret = (NDL)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Transcriptionist (OBR-35).
   */
  public NDL[] getTranscriptionist() {
     NDL[] ret = null;
    try {
        Type[] t = this.getField(35);  
        ret = new NDL[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (NDL)t[i];
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
	* Returns Scheduled Date/Time(OBR-36).
	*/
	public TS ScheduledDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(36, 0);
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
	* Returns Number of Sample Containers *(OBR-37).
	*/
	public NM NumberOfSampleContainers
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(37, 0);
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
	* Returns a single repetition of Transport Logistics of Collected Sample(OBR-38).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getTransportLogisticsOfCollectedSample(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(38, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Transport Logistics of Collected Sample (OBR-38).
   */
  public CE[] getTransportLogisticsOfCollectedSample() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(38);  
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
	* Returns a single repetition of Collector's Comment *(OBR-39).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getCollectorSComment(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(39, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Collector's Comment * (OBR-39).
   */
  public CE[] getCollectorSComment() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(39);  
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
	* Returns Transport Arrangement Responsibility(OBR-40).
	*/
	public CE TransportArrangementResponsibility
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(40, 0);
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
	* Returns Transport Arranged(OBR-41).
	*/
	public ID TransportArranged
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns Escort Required(OBR-42).
	*/
	public ID EscortRequired
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(42, 0);
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
	* Returns a single repetition of Planned Patient Transport Comment(OBR-43).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getPlannedPatientTransportComment(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(43, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Planned Patient Transport Comment (OBR-43).
   */
  public CE[] getPlannedPatientTransportComment() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(43);  
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
	* Returns Procedure Code(OBR-44).
	*/
	public CE ProcedureCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(44, 0);
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
	* Returns a single repetition of Procedure Code Modifier(OBR-45).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getProcedureCodeModifier(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(45, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Procedure Code Modifier (OBR-45).
   */
  public CE[] getProcedureCodeModifier() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(45);  
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
	* Returns a single repetition of Placer Supplemental Service Information(OBR-46).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getPlacerSupplementalServiceInformation(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(46, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Placer Supplemental Service Information (OBR-46).
   */
  public CE[] getPlacerSupplementalServiceInformation() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(46);  
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
	* Returns a single repetition of Filler Supplemental Service Information(OBR-47).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getFillerSupplementalServiceInformation(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(47, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Filler Supplemental Service Information (OBR-47).
   */
  public CE[] getFillerSupplementalServiceInformation() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(47);  
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
	* Returns Medically Necessary Duplicate Procedure Reason.(OBR-48).
	*/
	public CWE MedicallyNecessaryDuplicateProcedureReason
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(48, 0);
				ret = (CWE)t;
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
	* Returns Result Handling(OBR-49).
	*/
	public IS ResultHandling
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(49, 0);
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


}}