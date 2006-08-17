using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 MSA message segment. 
 * This segment has the following fields:</p><p>
 * MSA-1: ACKNOWLEDGMENT CODE (ID)<br> 
 * MSA-2: MESSAGE CONTROL ID (ST)<br> 
 * MSA-3: TEXT MESSAGE (ST)<br> 
 * MSA-4: EXPECTED SEQUENCE NUMBER (NM)<br> 
 * MSA-5: DELAYED ACKNOWLEDGMENT TYPE (ID)<br> 
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
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 8}, "ACKNOWLEDGMENT CODE");
       this.add(typeof(ST), true, 1, 20, new System.Object[]{message}, "MESSAGE CONTROL ID");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "TEXT MESSAGE");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "EXPECTED SEQUENCE NUMBER");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 102}, "DELAYED ACKNOWLEDGMENT TYPE");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns ACKNOWLEDGMENT CODE(MSA-1).
	*/
	public ID ACKNOWLEDGMENTCODE
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
	* Returns MESSAGE CONTROL ID(MSA-2).
	*/
	public ST MESSAGECONTROLID
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
	* Returns TEXT MESSAGE(MSA-3).
	*/
	public ST TEXTMESSAGE
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
	* Returns EXPECTED SEQUENCE NUMBER(MSA-4).
	*/
	public NM EXPECTEDSEQUENCENUMBER
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
	* Returns DELAYED ACKNOWLEDGMENT TYPE(MSA-5).
	*/
	public ID DELAYEDACKNOWLEDGMENTTYPE
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


}}