using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 MSH message segment. 
 * This segment has the following fields:</p><p>
 * MSH-1: FIELD SEPARATOR (ST)<br> 
 * MSH-2: ENCODING CHARACTERS (ST)<br> 
 * MSH-3: SENDING APPLICATION (ST)<br> 
 * MSH-4: SENDING FACILITY (ST)<br> 
 * MSH-5: RECEIVING APPLICATION (ST)<br> 
 * MSH-6: RECEIVING FACILITY (ST)<br> 
 * MSH-7: DATE/TIME OF MESSAGE (TS)<br> 
 * MSH-8: Security (ST)<br> 
 * MSH-9: MESSAGE TYPE (ID)<br> 
 * MSH-10: MESSAGE CONTROL ID (ST)<br> 
 * MSH-11: PROCESSING ID (ID)<br> 
 * MSH-12: VERSION ID (NM)<br> 
 * MSH-13: SEQUENCE NUMBER (NM)<br> 
 * MSH-14: CONTINUATION POINTER (ST)<br> 
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
       this.add(typeof(ST), true, 1, 1, new System.Object[]{message}, "FIELD SEPARATOR");
       this.add(typeof(ST), true, 1, 4, new System.Object[]{message}, "ENCODING CHARACTERS");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "SENDING APPLICATION");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "SENDING FACILITY");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "RECEIVING APPLICATION");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "RECEIVING FACILITY");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "DATE/TIME OF MESSAGE");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Security");
       this.add(typeof(ID), true, 1, 7, new System.Object[]{message, 76}, "MESSAGE TYPE");
       this.add(typeof(ST), true, 1, 20, new System.Object[]{message}, "MESSAGE CONTROL ID");
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 103}, "PROCESSING ID");
       this.add(typeof(NM), true, 1, 8, new System.Object[]{message}, "VERSION ID");
       this.add(typeof(NM), false, 1, 15, new System.Object[]{message}, "SEQUENCE NUMBER");
       this.add(typeof(ST), false, 1, 180, new System.Object[]{message}, "CONTINUATION POINTER");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns FIELD SEPARATOR(MSH-1).
	*/
	public ST FIELDSEPARATOR
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
	* Returns ENCODING CHARACTERS(MSH-2).
	*/
	public ST ENCODINGCHARACTERS
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
	* Returns SENDING APPLICATION(MSH-3).
	*/
	public ST SENDINGAPPLICATION
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
	* Returns SENDING FACILITY(MSH-4).
	*/
	public ST SENDINGFACILITY
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
	* Returns RECEIVING APPLICATION(MSH-5).
	*/
	public ST RECEIVINGAPPLICATION
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
	* Returns RECEIVING FACILITY(MSH-6).
	*/
	public ST RECEIVINGFACILITY
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
	* Returns DATE/TIME OF MESSAGE(MSH-7).
	*/
	public TS DATETIMEOFMESSAGE
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
	* Returns MESSAGE TYPE(MSH-9).
	*/
	public ID MESSAGETYPE
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns MESSAGE CONTROL ID(MSH-10).
	*/
	public ST MESSAGECONTROLID
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
	* Returns PROCESSING ID(MSH-11).
	*/
	public ID PROCESSINGID
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
	* Returns VERSION ID(MSH-12).
	*/
	public NM VERSIONID
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
	* Returns SEQUENCE NUMBER(MSH-13).
	*/
	public NM SEQUENCENUMBER
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
	* Returns CONTINUATION POINTER(MSH-14).
	*/
	public ST CONTINUATIONPOINTER
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


}}