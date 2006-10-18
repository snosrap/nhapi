using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 BTS message segment. 
 * This segment has the following fields:</p><p>
 * BTS-1: BATCH MESSAGE COUNT (ST)<br> 
 * BTS-2: BATCH COMMENT (ST)<br> 
 * BTS-3: BATCH TOTALS (CM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class BTS : AbstractSegment  {

  /**
   * Creates a BTS (BATCH TRAILER) segment object that belongs to the given 
   * message.  
   */
  public BTS(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ST), false, 1, 10, new System.Object[]{message}, "BATCH MESSAGE COUNT");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "BATCH COMMENT");
       this.add(typeof(CM), false, 1, 100, new System.Object[]{message}, "BATCH TOTALS");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns BATCH MESSAGE COUNT(BTS-1).
	*/
	public ST BATCHMESSAGECOUNT
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
	* Returns BATCH COMMENT(BTS-2).
	*/
	public ST BATCHCOMMENT
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
	* Returns BATCH TOTALS(BTS-3).
	*/
	public CM BATCHTOTALS
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


}}