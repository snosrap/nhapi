using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 QPD message segment. 
 * This segment has the following fields:</p><p>
 * QPD-1: Message Query Name (CE)<br> 
 * QPD-2: Query Tag (ST)<br> 
 * QPD-3: User Parameters (in successive fields) (varies)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class QPD : AbstractSegment  {

  /**
   * Creates a QPD (Query Parameter Definition) segment object that belongs to the given 
   * message.  
   */
  public QPD(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 32, new System.Object[]{message});
       this.add(typeof(Varies), false, 1, 256, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Message Query Name (QPD-1).
	*/
	public CE MessageQueryName
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
	* Returns Query Tag (QPD-2).
	*/
	public ST QueryTag
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
	* Returns User Parameters (in successive fields) (QPD-3).
	*/
	public Varies UserParametersInsuccessivefields
	{
		get{
			Varies ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (Varies)t;
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