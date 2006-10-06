using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 NSC message segment. 
 * This segment has the following fields:</p><p>
 * NSC-1: Application Change Type (IS)<br> 
 * NSC-2: Current CPU (ST)<br> 
 * NSC-3: Current Fileserver (ST)<br> 
 * NSC-4: Current Application (HD)<br> 
 * NSC-5: Current Facility (HD)<br> 
 * NSC-6: New CPU (ST)<br> 
 * NSC-7: New Fileserver (ST)<br> 
 * NSC-8: New Application (HD)<br> 
 * NSC-9: New Facility (HD)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class NSC : AbstractSegment  {

  /**
   * Creates a NSC (Application Status Change) segment object that belongs to the given 
   * message.  
   */
  public NSC(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(IS), true, 1, 4, new System.Object[]{message, 409}, "Application Change Type");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Current CPU");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "Current Fileserver");
       this.add(typeof(HD), false, 1, 30, new System.Object[]{message}, "Current Application");
       this.add(typeof(HD), false, 1, 30, new System.Object[]{message}, "Current Facility");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "New CPU");
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message}, "New Fileserver");
       this.add(typeof(HD), false, 1, 30, new System.Object[]{message}, "New Application");
       this.add(typeof(HD), false, 1, 30, new System.Object[]{message}, "New Facility");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Application Change Type(NSC-1).
	*/
	public IS ApplicationChangeType
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (IS)t;
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
	* Returns Current CPU(NSC-2).
	*/
	public ST CurrentCPU
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
	* Returns Current Fileserver(NSC-3).
	*/
	public ST CurrentFileserver
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Current Application(NSC-4).
	*/
	public HD CurrentApplication
	{
		get{
			HD ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (HD)t;
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
	* Returns Current Facility(NSC-5).
	*/
	public HD CurrentFacility
	{
		get{
			HD ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (HD)t;
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
	* Returns New CPU(NSC-6).
	*/
	public ST NewCPU
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns New Fileserver(NSC-7).
	*/
	public ST NewFileserver
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns New Application(NSC-8).
	*/
	public HD NewApplication
	{
		get{
			HD ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (HD)t;
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
	* Returns New Facility(NSC-9).
	*/
	public HD NewFacility
	{
		get{
			HD ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (HD)t;
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