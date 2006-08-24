using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 BHS message segment. 
 * This segment has the following fields:</p><p>
 * BHS-1: BATCH FIELD SEPARATOR (ST)<br> 
 * BHS-2: BATCH ENCODING CHARACTERS (ST)<br> 
 * BHS-3: BATCH SENDING APPLICATION (ST)<br> 
 * BHS-4: BATCH SENDING FACILITY (ST)<br> 
 * BHS-5: BATCH RECEIVING APPLICATION (ST)<br> 
 * BHS-6: BATCH RECEIVING FACILITY (ST)<br> 
 * BHS-7: BATCH CREATION DATE/TIME (TS)<br> 
 * BHS-8: BATCH SECURITY (ST)<br> 
 * BHS-9: BATCH NAME/ID/TYPE (ST)<br> 
 * BHS-10: BATCH COMMENT (ST)<br> 
 * BHS-11: BATCH CONTROL ID (ST)<br> 
 * BHS-12: REFERENCE BATCH CONTROL ID (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class BHS : AbstractSegment  {

  /**
   * Creates a BHS (BATCH HEADER) segment object that belongs to the given 
   * message.  
   */
	public BHS(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ST), true, 1, 1, new System.Object[]{message}, "BATCH FIELD SEPARATOR");
       this.add(typeof(ST), true, 1, 3, new System.Object[]{message}, "BATCH ENCODING CHARACTERS");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "BATCH SENDING APPLICATION");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "BATCH SENDING FACILITY");
       this.add(typeof(ST), false, 1, 15, new System.Object[]{message}, "BATCH RECEIVING APPLICATION");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "BATCH RECEIVING FACILITY");
       this.add(typeof(TS), false, 1, 19, new System.Object[]{message}, "BATCH CREATION DATE/TIME");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "BATCH SECURITY");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "BATCH NAME/ID/TYPE");
       this.add(typeof(ST), false, 1, 80, new System.Object[]{message}, "BATCH COMMENT");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "BATCH CONTROL ID");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "REFERENCE BATCH CONTROL ID");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns BATCH FIELD SEPARATOR(BHS-1).
	*/
	public ST BATCHFIELDSEPARATOR
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
	* Returns BATCH ENCODING CHARACTERS(BHS-2).
	*/
	public ST BATCHENCODINGCHARACTERS
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
	* Returns BATCH SENDING APPLICATION(BHS-3).
	*/
	public ST BATCHSENDINGAPPLICATION
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
	* Returns BATCH SENDING FACILITY(BHS-4).
	*/
	public ST BATCHSENDINGFACILITY
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
	* Returns BATCH RECEIVING APPLICATION(BHS-5).
	*/
	public ST BATCHRECEIVINGAPPLICATION
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
	* Returns BATCH RECEIVING FACILITY(BHS-6).
	*/
	public ST BATCHRECEIVINGFACILITY
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
	* Returns BATCH CREATION DATE/TIME(BHS-7).
	*/
	public TS BATCHCREATIONDATETIME
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
	* Returns BATCH SECURITY(BHS-8).
	*/
	public ST BATCHSECURITY
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
	* Returns BATCH NAME/ID/TYPE(BHS-9).
	*/
	public ST BATCHNAMEIDTYPE
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns BATCH COMMENT(BHS-10).
	*/
	public ST BATCHCOMMENT
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
	* Returns BATCH CONTROL ID(BHS-11).
	*/
	public ST BATCHCONTROLID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(11, 0);
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
	* Returns REFERENCE BATCH CONTROL ID(BHS-12).
	*/
	public ST REFERENCEBATCHCONTROLID
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(12, 0);
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