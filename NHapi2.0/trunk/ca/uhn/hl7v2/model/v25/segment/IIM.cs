using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 IIM message segment. 
 * This segment has the following fields:</p><p>
 * IIM-1: Primary Key Value - IIM (CWE)<br> 
 * IIM-2: Service Item Code (CWE)<br> 
 * IIM-3: Inventory Lot Number (ST)<br> 
 * IIM-4: Inventory Expiration Date (TS)<br> 
 * IIM-5: Inventory Manufacturer Name (CWE)<br> 
 * IIM-6: Inventory Location (CWE)<br> 
 * IIM-7: Inventory Received Date (TS)<br> 
 * IIM-8: Inventory Received Quantity (NM)<br> 
 * IIM-9: Inventory Received Quantity Unit (CWE)<br> 
 * IIM-10: Inventory Received Item Cost (MO)<br> 
 * IIM-11: Inventory On Hand Date (TS)<br> 
 * IIM-12: Inventory On Hand Quantity (NM)<br> 
 * IIM-13: Inventory On Hand Quantity Unit (CWE)<br> 
 * IIM-14: Procedure Code (CE)<br> 
 * IIM-15: Procedure Code Modifier (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IIM : AbstractSegment  {

  /**
   * Creates a IIM (Inventory Item Master) segment object that belongs to the given 
   * message.  
   */
  public IIM(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(CWE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(CWE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(MO), false, 1, 12, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Primary Key Value - IIM (IIM-1).
	*/
	public CWE PrimaryKeyValueIIM
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (CWE)t;
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
	* Returns Service Item Code (IIM-2).
	*/
	public CWE ServiceItemCode
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(2, 0);
				ret = (CWE)t;
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
	* Returns Inventory Lot Number (IIM-3).
	*/
	public ST InventoryLotNumber
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
	* Returns Inventory Expiration Date (IIM-4).
	*/
	public TS InventoryExpirationDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Inventory Manufacturer Name (IIM-5).
	*/
	public CWE InventoryManufacturerName
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(5, 0);
				ret = (CWE)t;
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
	* Returns Inventory Location (IIM-6).
	*/
	public CWE InventoryLocation
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (CWE)t;
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
	* Returns Inventory Received Date (IIM-7).
	*/
	public TS InventoryReceivedDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Inventory Received Quantity (IIM-8).
	*/
	public NM InventoryReceivedQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Inventory Received Quantity Unit (IIM-9).
	*/
	public CWE InventoryReceivedQuantityUnit
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (CWE)t;
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
	* Returns Inventory Received Item Cost (IIM-10).
	*/
	public MO InventoryReceivedItemCost
	{
		get{
			MO ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (MO)t;
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
	* Returns Inventory On Hand Date (IIM-11).
	*/
	public TS InventoryOnHandDate
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Inventory On Hand Quantity (IIM-12).
	*/
	public NM InventoryOnHandQuantity
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Inventory On Hand Quantity Unit (IIM-13).
	*/
	public CWE InventoryOnHandQuantityUnit
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(13, 0);
				ret = (CWE)t;
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
	* Returns Procedure Code (IIM-14).
	*/
	public CE ProcedureCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns a single repetition of Procedure Code Modifier (IIM-15).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getProcedureCodeModifier(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(15, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Procedure Code Modifier (IIM-15).
   */
  public CE[] getProcedureCodeModifier() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(15);  
        ret = new CE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
    }
    return ret;
  }


}}