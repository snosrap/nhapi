using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 ECR message segment. 
 * This segment has the following fields:</p><p>
 * ECR-1: Command Response (CE)<br> 
 * ECR-2: Date/Time Completed (TS)<br> 
 * ECR-3: Command Response Parameters (TX)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ECR : AbstractSegment  {

  /**
   * Creates a ECR (Equipment Command Response) segment object that belongs to the given 
   * message.  
   */
  public ECR(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
       this.add(typeof(TX), false, 0, 65536, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Command Response (ECR-1).
	*/
	public CE CommandResponse
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
	* Returns Date/Time Completed (ECR-2).
	*/
	public TS DateTimeCompleted
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns a single repetition of Command Response Parameters (ECR-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TX getCommandResponseParameters(int rep)
	{
			TX ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (TX)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Command Response Parameters (ECR-3).
   */
  public TX[] getCommandResponseParameters() {
     TX[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new TX[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TX)t[i];
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