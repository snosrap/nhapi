using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v22.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v22.segment{

/**
 * <p>Represents an HL7 RXA message segment. 
 * This segment has the following fields:</p><p>
 * RXA-1: Give Sub-ID Counter (NM)<br> 
 * RXA-2: Administration Sub-ID Counter (NM)<br> 
 * RXA-3: Date / time start of administration (TS)<br> 
 * RXA-4: Date / time end of administration (TS)<br> 
 * RXA-5: Administered Code (CE)<br> 
 * RXA-6: Administered Amount (NM)<br> 
 * RXA-7: Administered Units (CE)<br> 
 * RXA-8: Administered Dosage Form (CE)<br> 
 * RXA-9: Administration Notes (ST)<br> 
 * RXA-10: Administering Provider (CN_PERSON)<br> 
 * RXA-11: Administered-at Location (CM_LA1)<br> 
 * RXA-12: Administered Per (Time Unit) (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class RXA : AbstractSegment  {

  /**
   * Creates a RXA (PHARMACY AADMINISTRATION) segment object that belongs to the given 
   * message.  
   */
  public RXA(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(NM), true, 1, 4, new System.Object[]{message}, "Give Sub-ID Counter");
       this.add(typeof(NM), true, 1, 4, new System.Object[]{message}, "Administration Sub-ID Counter");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Date / time start of administration");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Date / time end of administration");
       this.add(typeof(CE), true, 1, 100, new System.Object[]{message}, "Administered Code");
       this.add(typeof(NM), true, 1, 20, new System.Object[]{message}, "Administered Amount");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Administered Units");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Administered Dosage Form");
       this.add(typeof(ST), false, 1, 200, new System.Object[]{message}, "Administration Notes");
       this.add(typeof(CN_PERSON), false, 1, 200, new System.Object[]{message}, "Administering Provider");
       this.add(typeof(CM_LA1), false, 1, 12, new System.Object[]{message}, "Administered-at Location");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Administered Per (Time Unit)");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Give Sub-ID Counter(RXA-1).
	*/
	public NM GiveSubIDCounter
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Administration Sub-ID Counter(RXA-2).
	*/
	public NM AdministrationSubIDCounter
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Date / time start of administration(RXA-3).
	*/
	public TS DateTimeStartOfAdministration
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Date / time end of administration(RXA-4).
	*/
	public TS DateTimeEndOfAdministration
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
	* Returns Administered Code(RXA-5).
	*/
	public CE AdministeredCode
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

	/**
	* Returns Administered Amount(RXA-6).
	*/
	public NM AdministeredAmount
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Administered Units(RXA-7).
	*/
	public CE AdministeredUnits
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Administered Dosage Form(RXA-8).
	*/
	public CE AdministeredDosageForm
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Administration Notes(RXA-9).
	*/
	public ST AdministrationNotes
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Administering Provider(RXA-10).
	*/
	public CN_PERSON AdministeringProvider
	{
		get{
			CN_PERSON ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (CN_PERSON)t;
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
	* Returns Administered-at Location(RXA-11).
	*/
	public CM_LA1 AdministeredAtLocation
	{
		get{
			CM_LA1 ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CM_LA1)t;
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
	* Returns Administered Per (Time Unit)(RXA-12).
	*/
	public ST AdministeredPerTimeUnit
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(12, 0);
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