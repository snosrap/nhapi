using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 BLG message segment. 
 * This segment has the following fields:</p><p>
 * BLG-1: WHEN TO CHARGE (CM)<br> 
 * BLG-2: CHARGE TYPE (ID)<br> 
 * BLG-3: ACCOUNT ID (CM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class BLG : AbstractSegment  {

  /**
   * Creates a BLG (BILLING) segment object that belongs to the given 
   * message.  
   */
	public BLG(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CM), false, 1, 15, new System.Object[]{message}, "WHEN TO CHARGE");
       this.add(typeof(ID), false, 1, 50, new System.Object[]{message, 122}, "CHARGE TYPE");
       this.add(typeof(CM), false, 1, 100, new System.Object[]{message}, "ACCOUNT ID");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns WHEN TO CHARGE(BLG-1).
	*/
	public CM WHENTOCHARGE
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns CHARGE TYPE(BLG-2).
	*/
	public ID CHARGETYPE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns ACCOUNT ID(BLG-3).
	*/
	public CM ACCOUNTID
	{
		get{
			CM ret = null;
			try
			{
			IType t = this.getField(3, 0);
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