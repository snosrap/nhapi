using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 LCH message segment. 
 * This segment has the following fields:</p><p>
 * LCH-1: Primary Key Value - LCH (PL)<br> 
 * LCH-2: Segment Action Code (ID)<br> 
 * LCH-3: Segment Unique Key (EI)<br> 
 * LCH-4: Location Characteristic ID (CE)<br> 
 * LCH-5: Location Characteristic Value-LCH (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class LCH : AbstractSegment  {

  /**
   * Creates a LCH (Location Characteristic) segment object that belongs to the given 
   * message.  
   */
  public LCH(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(PL), true, 1, 200, new System.Object[]{message}, "Primary Key Value - LCH");
       this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 206}, "Segment Action Code");
       this.add(typeof(EI), false, 1, 80, new System.Object[]{message}, "Segment Unique Key");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Location Characteristic ID");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Location Characteristic Value-LCH");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Primary Key Value - LCH(LCH-1).
	*/
	public PL PrimaryKeyValueLCH
	{
		get{
			PL ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (PL)t;
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
	* Returns Segment Action Code(LCH-2).
	*/
	public ID SegmentActionCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Segment Unique Key(LCH-3).
	*/
	public EI SegmentUniqueKey
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (EI)t;
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
	* Returns Location Characteristic ID(LCH-4).
	*/
	public CE LocationCharacteristicID
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
	* Returns Location Characteristic Value-LCH(LCH-5).
	*/
	public CE LocationCharacteristicValueLCH
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(5, 0);
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