using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 MRG message segment. 
 * This segment has the following fields:</p><p>
 * MRG-1: Prior Patient ID - Internal (CM_PAT_ID)<br> 
 * MRG-2: Prior Alternate Patient ID (CM_PAT_ID)<br> 
 * MRG-3: Prior Patient Account Number (CK_ACCOUNT_NO)<br> 
 * MRG-4: Prior Patient ID - External (CK_PAT_ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class MRG : AbstractSegment  {

  /**
   * Creates a MRG (MERGE PATIENT INFORMATION) segment object that belongs to the given 
   * message.  
   */
	public MRG(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CM_PAT_ID), true, 1, 20, new System.Object[]{message}, "Prior Patient ID - Internal");
       this.add(typeof(CM_PAT_ID), false, 1, 16, new System.Object[]{message}, "Prior Alternate Patient ID");
       this.add(typeof(CK_ACCOUNT_NO), false, 1, 20, new System.Object[]{message}, "Prior Patient Account Number");
       this.add(typeof(CK_PAT_ID), false, 1, 16, new System.Object[]{message}, "Prior Patient ID - External");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Prior Patient ID - Internal(MRG-1).
	*/
	public CM_PAT_ID PriorPatientIDInternal
	{
		get{
			CM_PAT_ID ret = null;
			try
			{
			IType t = this.getField(1, 0);
				ret = (CM_PAT_ID)t;
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
	* Returns Prior Alternate Patient ID(MRG-2).
	*/
	public CM_PAT_ID PriorAlternatePatientID
	{
		get{
			CM_PAT_ID ret = null;
			try
			{
			IType t = this.getField(2, 0);
				ret = (CM_PAT_ID)t;
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
	* Returns Prior Patient Account Number(MRG-3).
	*/
	public CK_ACCOUNT_NO PriorPatientAccountNumber
	{
		get{
			CK_ACCOUNT_NO ret = null;
			try
			{
			IType t = this.getField(3, 0);
				ret = (CK_ACCOUNT_NO)t;
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
	* Returns Prior Patient ID - External(MRG-4).
	*/
	public CK_PAT_ID PriorPatientIDExternal
	{
		get{
			CK_PAT_ID ret = null;
			try
			{
			IType t = this.getField(4, 0);
				ret = (CK_PAT_ID)t;
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