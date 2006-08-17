using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 MSH message segment. 
 * This segment has the following fields:</p><p>
 * MSH-1: Field separator (ST)<br> 
 * MSH-2: Encoding characters (ST)<br> 
 * MSH-3: Sending application (ST)<br> 
 * MSH-4: Sending facility (ST)<br> 
 * MSH-5: Receiving application (ST)<br> 
 * MSH-6: Receiving facility (ST)<br> 
 * MSH-7: Date / Time of message (TS)<br> 
 * MSH-8: Security (ST)<br> 
 * MSH-9: Message type (CM_MSG)<br> 
 * MSH-10: Message Control ID (ST)<br> 
 * MSH-11: Processing ID (ID)<br> 
 * MSH-12: Version ID (ID)<br> 
 * MSH-13: Sequence number (NM)<br> 
 * MSH-14: Continuation pointer (ST)<br> 
 * MSH-15: Accept acknowledgement type (ID)<br> 
 * MSH-16: Application acknowledgement type (ID)<br> 
 * MSH-17: Country code (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class MSH : AbstractSegment  {

  /**
   * Creates a MSH (MESSAGE HEADER) segment object that belongs to the given 
   * message.  
   */
	public MSH(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), true, 1, 1, new System.Object[]{message}, "Field separator");
       this.add(typeof(ST), true, 1, 4, new System.Object[]{message}, "Encoding characters");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "Sending application");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Sending facility");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Receiving application");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Receiving facility");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Date / Time of message");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Security");
       this.add(typeof(CM_MSG), true, 1, 7, new System.Object[]{message}, "Message type");
       this.add(typeof(ST), true, 1, 20, new System.Object[]{message}, "Message Control ID");
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 103}, "Processing ID");
       this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 104}, "Version ID");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "Sequence number");
       this.add(typeof(ST), false, 1, 180, new System.Object[]{message}, "Continuation pointer");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 155}, "Accept acknowledgement type");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 155}, "Application acknowledgement type");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "Country code");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Field separator(MSH-1).
	*/
	public ST FieldSeparator
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns Encoding characters(MSH-2).
	*/
	public ST EncodingCharacters
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
	* Returns Sending application(MSH-3).
	*/
	public ST SendingApplication
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
	* Returns Sending facility(MSH-4).
	*/
	public ST SendingFacility
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns Receiving application(MSH-5).
	*/
	public ST ReceivingApplication
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns Receiving facility(MSH-6).
	*/
	public ST ReceivingFacility
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns Date / Time of message(MSH-7).
	*/
	public TS DateTimeOfMessage
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns Security(MSH-8).
	*/
	public ST Security
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns Message type(MSH-9).
	*/
	public CM_MSG MessageType
	{
		get{
			CM_MSG ret = null;
			try
			{
			IType t = this.getField(9, 0);
				ret = (CM_MSG)t;
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
	* Returns Message Control ID(MSH-10).
	*/
	public ST MessageControlID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(10, 0);
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
	* Returns Processing ID(MSH-11).
	*/
	public ID ProcessingID
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(11, 0);
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
	* Returns Version ID(MSH-12).
	*/
	public ID VersionID
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns Sequence number(MSH-13).
	*/
	public NM SequenceNumber
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
	* Returns Continuation pointer(MSH-14).
	*/
	public ST ContinuationPointer
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(14, 0);
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
	* Returns Accept acknowledgement type(MSH-15).
	*/
	public ID AcceptAcknowledgementType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(15, 0);
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
	* Returns Application acknowledgement type(MSH-16).
	*/
	public ID ApplicationAcknowledgementType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(16, 0);
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
	* Returns Country code(MSH-17).
	*/
	public ID CountryCode
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(17, 0);
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