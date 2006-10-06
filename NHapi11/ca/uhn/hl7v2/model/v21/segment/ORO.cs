using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v21.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v21.segment{

/**
 * <p>Represents an HL7 ORO message segment. 
 * This segment has the following fields:</p><p>
 * ORO-1: ORDER ITEM ID (CE)<br> 
 * ORO-2: SUBSTITUTE ALLOWED (ID)<br> 
 * ORO-3: RESULTS COPIES TO (CN)<br> 
 * ORO-4: STOCK LOCATION (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ORO : AbstractSegment  {

  /**
   * Creates a ORO (ORDER OTHER) segment object that belongs to the given 
   * message.  
   */
  public ORO(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), false, 1, 200, new System.Object[]{message}, "ORDER ITEM ID");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 0}, "SUBSTITUTE ALLOWED");
       this.add(typeof(CN), false, 0, 80, new System.Object[]{message}, "RESULTS COPIES TO");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 12}, "STOCK LOCATION");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns ORDER ITEM ID(ORO-1).
	*/
	public CE ORDERITEMID
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
	* Returns SUBSTITUTE ALLOWED(ORO-2).
	*/
	public ID SUBSTITUTEALLOWED
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns a single repetition of RESULTS COPIES TO(ORO-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CN getRESULTSCOPIESTO(int rep)
	{
			CN ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (CN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of RESULTS COPIES TO (ORO-3).
   */
  public CN[] getRESULTSCOPIESTO() {
     CN[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new CN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
	* Returns STOCK LOCATION(ORO-4).
	*/
	public ID STOCKLOCATION
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(4, 0);
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


}}