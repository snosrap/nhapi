using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 NST message segment. 
 * This segment has the following fields:</p><p>
 * NST-1: STATISTICS AVAILABLE (ID)<br> 
 * NST-2: SOURCE IDENTIFIER (ST)<br> 
 * NST-3: SOURCE TYPE (ID)<br> 
 * NST-4: STATISTICS START (TS)<br> 
 * NST-5: STATISTICS END (TS)<br> 
 * NST-6: RECEIVE CHARACTER COUNT (NM)<br> 
 * NST-7: SEND CHARACTER COUNT (NM)<br> 
 * NST-8: MESSAGES RECEIVED (NM)<br> 
 * NST-9: MESSAGES SENT (NM)<br> 
 * NST-10: CHECKSUM ERRORS RECEIVED (NM)<br> 
 * NST-11: LENGTH ERRORS RECEIVED (NM)<br> 
 * NST-12: OTHER ERRORS RECEIVED (NM)<br> 
 * NST-13: CONNECT TIMEOUTS (NM)<br> 
 * NST-14: RECEIVE TIMEOUTS (NM)<br> 
 * NST-15: NETWORK ERRORS (NM)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class NST : AbstractSegment  {

  /**
   * Creates a NST (STATISTICS) segment object that belongs to the given 
   * message.  
   */
	public NST(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 0}, "STATISTICS AVAILABLE");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "SOURCE IDENTIFIER");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 0}, "SOURCE TYPE");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "STATISTICS START");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "STATISTICS END");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "RECEIVE CHARACTER COUNT");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "SEND CHARACTER COUNT");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "MESSAGES RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "MESSAGES SENT");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "CHECKSUM ERRORS RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "LENGTH ERRORS RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "OTHER ERRORS RECEIVED");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "CONNECT TIMEOUTS");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "RECEIVE TIMEOUTS");
       this.add(typeof(NM), false, 1, 10, new System.Object[]{message}, "NETWORK ERRORS");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns STATISTICS AVAILABLE(NST-1).
	*/
	public ID STATISTICSAVAILABLE
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
	* Returns SOURCE IDENTIFIER(NST-2).
	*/
	public ST SOURCEIDENTIFIER
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
	* Returns SOURCE TYPE(NST-3).
	*/
	public ID SOURCETYPE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns STATISTICS START(NST-4).
	*/
	public TS STATISTICSSTART
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns STATISTICS END(NST-5).
	*/
	public TS STATISTICSEND
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns RECEIVE CHARACTER COUNT(NST-6).
	*/
	public NM RECEIVECHARACTERCOUNT
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns SEND CHARACTER COUNT(NST-7).
	*/
	public NM SENDCHARACTERCOUNT
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns MESSAGES RECEIVED(NST-8).
	*/
	public NM MESSAGESRECEIVED
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns MESSAGES SENT(NST-9).
	*/
	public NM MESSAGESSENT
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns CHECKSUM ERRORS RECEIVED(NST-10).
	*/
	public NM CHECKSUMERRORSRECEIVED
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(10, 0);
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
	* Returns LENGTH ERRORS RECEIVED(NST-11).
	*/
	public NM LENGTHERRORSRECEIVED
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(11, 0);
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
	* Returns OTHER ERRORS RECEIVED(NST-12).
	*/
	public NM OTHERERRORSRECEIVED
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns CONNECT TIMEOUTS(NST-13).
	*/
	public NM CONNECTTIMEOUTS
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(13, 0);
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
	* Returns RECEIVE TIMEOUTS(NST-14).
	*/
	public NM RECEIVETIMEOUTS
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(14, 0);
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
	* Returns NETWORK ERRORS(NST-15).
	*/
	public NM NETWORKERRORS
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(15, 0);
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


}}