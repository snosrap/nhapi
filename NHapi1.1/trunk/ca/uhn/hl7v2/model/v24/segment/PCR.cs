using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 PCR message segment. 
 * This segment has the following fields:</p><p>
 * PCR-1: Implicated Product (CE)<br> 
 * PCR-2: Generic Product (IS)<br> 
 * PCR-3: Product Class (CE)<br> 
 * PCR-4: Total Duration Of Therapy (CQ)<br> 
 * PCR-5: Product Manufacture Date (TS)<br> 
 * PCR-6: Product Expiration Date (TS)<br> 
 * PCR-7: Product Implantation Date (TS)<br> 
 * PCR-8: Product Explantation Date (TS)<br> 
 * PCR-9: Single Use Device (IS)<br> 
 * PCR-10: Indication For Product Use (CE)<br> 
 * PCR-11: Product Problem (IS)<br> 
 * PCR-12: Product Serial/Lot Number (ST)<br> 
 * PCR-13: Product Available For Inspection (IS)<br> 
 * PCR-14: Product Evaluation Performed (CE)<br> 
 * PCR-15: Product Evaluation Status (CE)<br> 
 * PCR-16: Product Evaluation Results (CE)<br> 
 * PCR-17: Evaluated Product Source (ID)<br> 
 * PCR-18: Date Product Returned To Manufacturer (TS)<br> 
 * PCR-19: Device Operator Qualifications (ID)<br> 
 * PCR-20: Relatedness Assessment (ID)<br> 
 * PCR-21: Action Taken In Response To The Event (ID)<br> 
 * PCR-22: Event Causality Observations (ID)<br> 
 * PCR-23: Indirect Exposure Mechanism (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class PCR : AbstractSegment  {

  /**
   * Creates a PCR (Possible Causal Relationship) segment object that belongs to the given 
   * message.  
   */
  public PCR(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Implicated Product");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 249}, "Generic Product");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Product Class");
       this.add(typeof(CQ), false, 1, 8, new System.Object[]{message}, "Total Duration Of Therapy");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Manufacture Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Expiration Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Implantation Date");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Product Explantation Date");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 244}, "Single Use Device");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Indication For Product Use");
       this.add(typeof(IS), false, 1, 8, new System.Object[]{message, 245}, "Product Problem");
       this.add(typeof(ST), false, 3, 30, new System.Object[]{message}, "Product Serial/Lot Number");
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 246}, "Product Available For Inspection");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Product Evaluation Performed");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Product Evaluation Status");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Product Evaluation Results");
       this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 248}, "Evaluated Product Source");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date Product Returned To Manufacturer");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 242}, "Device Operator Qualifications");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 250}, "Relatedness Assessment");
       this.add(typeof(ID), false, 6, 2, new System.Object[]{message, 251}, "Action Taken In Response To The Event");
       this.add(typeof(ID), false, 6, 2, new System.Object[]{message, 252}, "Event Causality Observations");
       this.add(typeof(ID), false, 3, 1, new System.Object[]{message, 253}, "Indirect Exposure Mechanism");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Implicated Product(PCR-1).
	*/
	public CE ImplicatedProduct
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Generic Product(PCR-2).
	*/
	public IS GenericProduct
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
	* Returns Product Class(PCR-3).
	*/
	public CE ProductClass
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Total Duration Of Therapy(PCR-4).
	*/
	public CQ TotalDurationOfTherapy
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Product Manufacture Date(PCR-5).
	*/
	public TS ProductManufactureDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Product Expiration Date(PCR-6).
	*/
	public TS ProductExpirationDate
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
	* Returns Product Implantation Date(PCR-7).
	*/
	public TS ProductImplantationDate
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
	* Returns Product Explantation Date(PCR-8).
	*/
	public TS ProductExplantationDate
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
	* Returns Single Use Device(PCR-9).
	*/
	public IS SingleUseDevice
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Indication For Product Use(PCR-10).
	*/
	public CE IndicationForProductUse
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
	* Returns Product Problem(PCR-11).
	*/
	public IS ProductProblem
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns a single repetition of Product Serial/Lot Number(PCR-12).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getProductSerialLotNumber(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(12, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Product Serial/Lot Number (PCR-12).
   */
  public ST[] getProductSerialLotNumber() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(12);  
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

	/**
	* Returns Product Available For Inspection(PCR-13).
	*/
	public IS ProductAvailableForInspection
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Product Evaluation Performed(PCR-14).
	*/
	public CE ProductEvaluationPerformed
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns Product Evaluation Status(PCR-15).
	*/
	public CE ProductEvaluationStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns Product Evaluation Results(PCR-16).
	*/
	public CE ProductEvaluationResults
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
	* Returns Evaluated Product Source(PCR-17).
	*/
	public ID EvaluatedProductSource
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
	* Returns Date Product Returned To Manufacturer(PCR-18).
	*/
	public TS DateProductReturnedToManufacturer
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Device Operator Qualifications(PCR-19).
	*/
	public ID DeviceOperatorQualifications
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
	* Returns Relatedness Assessment(PCR-20).
	*/
	public ID RelatednessAssessment
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
	* Returns a single repetition of Action Taken In Response To The Event(PCR-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getActionTakenInResponseToTheEvent(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(21, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Action Taken In Response To The Event (PCR-21).
   */
  public ID[] getActionTakenInResponseToTheEvent() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(21);  
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
	* Returns a single repetition of Event Causality Observations(PCR-22).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getEventCausalityObservations(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(22, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Event Causality Observations (PCR-22).
   */
  public ID[] getEventCausalityObservations() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(22);  
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
	* Returns a single repetition of Indirect Exposure Mechanism(PCR-23).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getIndirectExposureMechanism(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(23, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Indirect Exposure Mechanism (PCR-23).
   */
  public ID[] getIndirectExposureMechanism() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(23);  
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


}}