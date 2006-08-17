using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 MSA message segment. 
 * This segment has the following fields:</p><p>
 * MSA-1: Acknowledgement code (ID)<br> 
 * MSA-2: Message Control ID (ST)<br> 
 * MSA-3: Text Message (ST)<br> 
 * MSA-4: Expected Sequence Number (NM)<br> 
 * MSA-5: Delayed Acknowledgement type (ID)<br> 
 * MSA-6: Error Condition (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class MSA : AbstractSegment  {

  /**
   * Creates a MSA (MESSAGE ACKNOWLEDGMENT) segment object that belongs to the given 
   * message.  
   */
	public MSA(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 8}, "Acknowledgement code");
       this.add(typeof(ST), true, 1, 20, new System.Object[]{message}, "Message Control ID");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "Text Message");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "Expected Sequence Number");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 102}, "Delayed Acknowledgement type");
       this.add(typeof(CE), false, 1, 100, new System.Object[]{message}, "Error Condition");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Acknowledgement code(MSA-1).
	*/
	public ID AcknowledgementCode
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns Message Control ID(MSA-2).
	*/
	public ST MessageControlID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns Text Message(MSA-3).
	*/
	public ST TextMessage
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns Expected Sequence Number(MSA-4).
	*/
	public NM ExpectedSequenceNumber
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns Delayed Acknowledgement type(MSA-5).
	*/
	public ID DelayedAcknowledgementType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns Error Condition(MSA-6).
	*/
	public CE ErrorCondition
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(6, 0);
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


}}