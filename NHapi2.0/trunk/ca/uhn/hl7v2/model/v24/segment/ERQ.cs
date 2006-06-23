using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 ERQ message segment. 
 * This segment has the following fields:</p><p>
 * ERQ-1: Query Tag (ST)<br> 
 * ERQ-2: Event Identifier (CE)<br> 
 * ERQ-3: Input Parameter List (QIP)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class ERQ : AbstractSegment  {

  /**
   * Creates a ERQ (Event Replay Query) segment object that belongs to the given 
   * message.  
   */
  public ERQ(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ST), false, 1, 32, new System.Object[]{message});
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(QIP), false, 0, 256, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Query Tag (ERQ-1).
	*/
	public ST QueryTag
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
	* Returns Event Identifier (ERQ-2).
	*/
	public CE EventIdentifier
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
	* Returns a single repetition of Input Parameter List (ERQ-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public QIP getInputParameterList(int rep)
	{
			QIP ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (QIP)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Input Parameter List (ERQ-3).
   */
  public QIP[] getInputParameterList() {
     QIP[] ret = null;
    try {
        Type[] t = this.getField(3);  
        ret = new QIP[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (QIP)t[i];
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