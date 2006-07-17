using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 FT1 message segment. 
 * This segment has the following fields:</p><p>
 * FT1-1: SET ID - FINANCIAL TRANSACTION (SI)<br> 
 * FT1-2: TRANSACTION ID (ST)<br> 
 * FT1-3: TRANSACTION BATCH ID (ST)<br> 
 * FT1-4: TRANSACTION DATE (DT)<br> 
 * FT1-5: TRANSACTION POSTING DATE (DT)<br> 
 * FT1-6: TRANSACTION TYPE (ID)<br> 
 * FT1-7: TRANSACTION CODE (ID)<br> 
 * FT1-8: TRANSACTION DESCRIPTION (ST)<br> 
 * FT1-9: TRANSACTION DESCRIPTION - ALT (ST)<br> 
 * FT1-10: TRANSACTION AMOUNT - EXTENDED (NM)<br> 
 * FT1-11: TRANSACTION QUANTITY (NM)<br> 
 * FT1-12: TRANSACTION AMOUNT - UNIT (NM)<br> 
 * FT1-13: DEPARTMENT CODE (ST)<br> 
 * FT1-14: INSURANCE PLAN ID (ID)<br> 
 * FT1-15: INSURANCE AMOUNT (NM)<br> 
 * FT1-16: PATIENT LOCATION (ST)<br> 
 * FT1-17: FEE SCHEDULE (ID)<br> 
 * FT1-18: PATIENT TYPE (ID)<br> 
 * FT1-19: DIAGNOSIS CODE (ID)<br> 
 * FT1-20: PERFORMED BY CODE (CN)<br> 
 * FT1-21: ORDERED BY CODE (CN)<br> 
 * FT1-22: UNIT COST (NM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class FT1 : AbstractSegment  {

  /**
   * Creates a FT1 (FINANCIAL TRANSACTION) segment object that belongs to the given 
   * message.  
   */
  public FT1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), false, 1, 4, new System.Object[]{message}, "SET ID - FINANCIAL TRANSACTION");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "TRANSACTION ID");
       this.add(typeof(ST), false, 1, 5, new System.Object[]{message}, "TRANSACTION BATCH ID");
       this.add(typeof(DT), true, 1, 8, new System.Object[]{message}, "TRANSACTION DATE");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "TRANSACTION POSTING DATE");
       this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 17}, "TRANSACTION TYPE");
       this.add(typeof(ID), true, 1, 20, new System.Object[]{message, 96}, "TRANSACTION CODE");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "TRANSACTION DESCRIPTION");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "TRANSACTION DESCRIPTION - ALT");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "TRANSACTION AMOUNT - EXTENDED");
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "TRANSACTION QUANTITY");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "TRANSACTION AMOUNT - UNIT");
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message}, "DEPARTMENT CODE");
       this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 72}, "INSURANCE PLAN ID");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "INSURANCE AMOUNT");
       this.add(typeof(ST), false, 1, 12, new System.Object[]{message}, "PATIENT LOCATION");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 24}, "FEE SCHEDULE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18}, "PATIENT TYPE");
       this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 51}, "DIAGNOSIS CODE");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "PERFORMED BY CODE");
       this.add(typeof(CN), false, 1, 60, new System.Object[]{message}, "ORDERED BY CODE");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "UNIT COST");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns SET ID - FINANCIAL TRANSACTION(FT1-1).
	*/
	public SI SETIDFINANCIALTRANSACTION
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
	* Returns TRANSACTION ID(FT1-2).
	*/
	public ST TRANSACTIONID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns TRANSACTION BATCH ID(FT1-3).
	*/
	public ST TRANSACTIONBATCHID
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns TRANSACTION DATE(FT1-4).
	*/
	public DT TRANSACTIONDATE
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(4, 0);
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

	/**
	* Returns TRANSACTION POSTING DATE(FT1-5).
	*/
	public DT TRANSACTIONPOSTINGDATE
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(5, 0);
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

	/**
	* Returns TRANSACTION TYPE(FT1-6).
	*/
	public ID TRANSACTIONTYPE
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
	* Returns TRANSACTION CODE(FT1-7).
	*/
	public ID TRANSACTIONCODE
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns TRANSACTION DESCRIPTION(FT1-8).
	*/
	public ST TRANSACTIONDESCRIPTION
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns TRANSACTION DESCRIPTION - ALT(FT1-9).
	*/
	public ST TRANSACTIONDESCRIPTIONALT
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns TRANSACTION AMOUNT - EXTENDED(FT1-10).
	*/
	public NM TRANSACTIONAMOUNTEXTENDED
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns TRANSACTION QUANTITY(FT1-11).
	*/
	public NM TRANSACTIONQUANTITY
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns TRANSACTION AMOUNT - UNIT(FT1-12).
	*/
	public NM TRANSACTIONAMOUNTUNIT
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns DEPARTMENT CODE(FT1-13).
	*/
	public ST DEPARTMENTCODE
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
	* Returns INSURANCE PLAN ID(FT1-14).
	*/
	public ID INSURANCEPLANID
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns INSURANCE AMOUNT(FT1-15).
	*/
	public NM INSURANCEAMOUNT
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns PATIENT LOCATION(FT1-16).
	*/
	public ST PATIENTLOCATION
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
	* Returns FEE SCHEDULE(FT1-17).
	*/
	public ID FEESCHEDULE
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
	* Returns PATIENT TYPE(FT1-18).
	*/
	public ID PATIENTTYPE
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
	* Returns DIAGNOSIS CODE(FT1-19).
	*/
	public ID DIAGNOSISCODE
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
	* Returns PERFORMED BY CODE(FT1-20).
	*/
	public CN PERFORMEDBYCODE
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(20, 0);
				ret = (CN)t;
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
	* Returns ORDERED BY CODE(FT1-21).
	*/
	public CN ORDEREDBYCODE
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(21, 0);
				ret = (CN)t;
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
	* Returns UNIT COST(FT1-22).
	*/
	public NM UNITCOST
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(22, 0);
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


}}