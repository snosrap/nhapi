using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 ORC message segment. 
 * This segment has the following fields:</p><p>
 * ORC-1: ORDER CONTROL (ST)<br> 
 * ORC-2: PLACER ORDER # (CM)<br> 
 * ORC-3: FILLER ORDER # (CM)<br> 
 * ORC-4: PLACER GROUP # (CM)<br> 
 * ORC-5: ORDER STATUS (ST)<br> 
 * ORC-6: RESPONSE FLAG (ST)<br> 
 * ORC-7: TIMING/QUANTITY (CM)<br> 
 * ORC-8: PARENT (CM)<br> 
 * ORC-9: DATE/TIME OF TRANSACTION (TS)<br> 
 * ORC-10: ENTERED BY (CN)<br> 
 * ORC-11: VERIFIED BY (CN)<br> 
 * ORC-12: ORDERING PROVIDER (CN)<br> 
 * ORC-13: ENTERER'S LOCATION (CM)<br> 
 * ORC-14: CALL BACK PHONE NUMBER (TN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ORC : AbstractSegment  {

  /**
   * Creates a ORC (COMMON ORDER) segment object that belongs to the given 
   * message.  
   */
  public ORC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ST), true, 1, 2, new System.Object[]{message}, "ORDER CONTROL");
       this.add(typeof(CM), false, 1, 75, new System.Object[]{message}, "PLACER ORDER #");
       this.add(typeof(CM), false, 1, 75, new System.Object[]{message}, "FILLER ORDER #");
       this.add(typeof(CM), false, 1, 75, new System.Object[]{message}, "PLACER GROUP #");
       this.add(typeof(ST), false, 1, 2, new System.Object[]{message}, "ORDER STATUS");
       this.add(typeof(ST), false, 1, 1, new System.Object[]{message}, "RESPONSE FLAG");
       this.add(typeof(CM), false, 1, 200, new System.Object[]{message}, "TIMING/QUANTITY");
       this.add(typeof(CM), false, 1, 200, new System.Object[]{message}, "PARENT");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "DATE/TIME OF TRANSACTION");
       this.add(typeof(CN), false, 1, 80, new System.Object[]{message}, "ENTERED BY");
       this.add(typeof(CN), false, 1, 80, new System.Object[]{message}, "VERIFIED BY");
       this.add(typeof(CN), false, 1, 80, new System.Object[]{message}, "ORDERING PROVIDER");
       this.add(typeof(CM), false, 1, 80, new System.Object[]{message}, "ENTERER'S LOCATION");
       this.add(typeof(TN), false, 2, 40, new System.Object[]{message}, "CALL BACK PHONE NUMBER");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns ORDER CONTROL(ORC-1).
	*/
	public ST ORDERCONTROL
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns PLACER ORDER #(ORC-2).
	*/
	public CM PLACERORDER
	{
		get{
			CM ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (CM)t;
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
	* Returns FILLER ORDER #(ORC-3).
	*/
	public CM FILLERORDER
	{
		get{
			CM ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (CM)t;
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
	* Returns PLACER GROUP #(ORC-4).
	*/
	public CM PLACERGROUP
	{
		get{
			CM ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (CM)t;
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
	* Returns ORDER STATUS(ORC-5).
	*/
	public ST ORDERSTATUS
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns RESPONSE FLAG(ORC-6).
	*/
	public ST RESPONSEFLAG
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns TIMING/QUANTITY(ORC-7).
	*/
	public CM TIMINGQUANTITY
	{
		get{
			CM ret = null;
			try
			{
			Type t = this.getField(7, 0);
				ret = (CM)t;
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
	* Returns PARENT(ORC-8).
	*/
	public CM PARENT
	{
		get{
			CM ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (CM)t;
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
	* Returns DATE/TIME OF TRANSACTION(ORC-9).
	*/
	public TS DATETIMEOFTRANSACTION
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
	* Returns ENTERED BY(ORC-10).
	*/
	public CN ENTEREDBY
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns VERIFIED BY(ORC-11).
	*/
	public CN VERIFIEDBY
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns ORDERING PROVIDER(ORC-12).
	*/
	public CN ORDERINGPROVIDER
	{
		get{
			CN ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns ENTERER'S LOCATION(ORC-13).
	*/
	public CM ENTERERSLOCATION
	{
		get{
			CM ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (CM)t;
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
	* Returns a single repetition of CALL BACK PHONE NUMBER(ORC-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getCALLBACKPHONENUMBER(int rep)
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
   * Returns all repetitions of CALL BACK PHONE NUMBER (ORC-14).
   */
  public TN[] getCALLBACKPHONENUMBER() {
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


}}