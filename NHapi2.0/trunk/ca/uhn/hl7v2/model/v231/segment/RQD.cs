using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v231.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v231.segment{

/**
 * <p>Represents an HL7 RQD message segment. 
 * This segment has the following fields:</p><p>
 * RQD-1: Requisition Line Number (SI)<br> 
 * RQD-2: Item Code - Internal (CE)<br> 
 * RQD-3: Item Code - External (CE)<br> 
 * RQD-4: Hospital Item Code (CE)<br> 
 * RQD-5: Requisition Quantity (NM)<br> 
 * RQD-6: Requisition Unit of Measure (CE)<br> 
 * RQD-7: Dept. Cost Center (IS)<br> 
 * RQD-8: Item Natural Account Code (IS)<br> 
 * RQD-9: Deliver To ID (CE)<br> 
 * RQD-10: Date Needed (DT)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RQD : AbstractSegment  {

  /**
   * Creates a RQD (RQD - requisition detail segment) segment object that belongs to the given 
   * message.  
   */
  public RQD(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 6, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 30, new System.Object[]{message, 319});
       this.add(typeof(IS), false, 1, 30, new System.Object[]{message, 320});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Requisition Line Number (RQD-1).
	*/
	public SI RequisitionLineNumber
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
	* Returns Item Code - Internal (RQD-2).
	*/
	public CE ItemCodeInternal
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Item Code - External (RQD-3).
	*/
	public CE ItemCodeExternal
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
	* Returns Hospital Item Code (RQD-4).
	*/
	public CE HospitalItemCode
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
	* Returns Requisition Quantity (RQD-5).
	*/
	public NM RequisitionQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Requisition Unit of Measure (RQD-6).
	*/
	public CE RequisitionUnitOfMeasure
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
	* Returns Dept. Cost Center (RQD-7).
	*/
	public IS DeptCostCenter
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Item Natural Account Code (RQD-8).
	*/
	public IS ItemNaturalAccountCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Deliver To ID (RQD-9).
	*/
	public CE DeliverToID
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Date Needed (RQD-10).
	*/
	public DT DateNeeded
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(10, 0);
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


}}