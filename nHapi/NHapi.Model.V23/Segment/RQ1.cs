using System;
using NHapi.Base.model;
using NHapi.Base.model.v23.datatype;

using ca.uhn.log;
using NHapi.Base.parser;
using NHapi.Base;

namespace NHapi.Base.model.v23.segment{

/**
 * <p>Represents an HL7 RQ1 message segment. 
 * This segment has the following fields:</p><p>
 * RQ1-1: Anticipated Price (ST)<br> 
 * RQ1-2: Manufactured ID (CE)<br> 
 * RQ1-3: Manufacturer's Catalog (ST)<br> 
 * RQ1-4: Vendor ID (CE)<br> 
 * RQ1-5: Vendor Catalog (ST)<br> 
 * RQ1-6: Taxable (ID)<br> 
 * RQ1-7: Substitute Allowed (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RQ1 : AbstractSegment  {

  /**
   * Creates a RQ1 (Requisition detail-1 segment) segment object that belongs to the given 
   * message.  
   */
  public RQ1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(ST), false, 1, 10, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Anticipated Price (RQ1-1).
	*/
	public ST AnticipatedPrice
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Manufactured ID (RQ1-2).
	*/
	public CE ManufacturedID
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Manufacturer's Catalog (RQ1-3).
	*/
	public ST ManufacturerSCatalog
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
	* Returns Vendor ID (RQ1-4).
	*/
	public CE VendorID
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Vendor Catalog (RQ1-5).
	*/
	public ST VendorCatalog
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Taxable (RQ1-6).
	*/
	public ID Taxable
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Substitute Allowed (RQ1-7).
	*/
	public ID SubstituteAllowed
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(7, 0);
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