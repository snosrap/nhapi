using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 OM4 message segment. 
 * This segment has the following fields:</p><p>
 * OM4-1: Sequence Number - Test/Observation Master File (NM)<br> 
 * OM4-2: Derived Specimen (ID)<br> 
 * OM4-3: Container Description (TX)<br> 
 * OM4-4: Container Volume (NM)<br> 
 * OM4-5: Container Units (CE)<br> 
 * OM4-6: Specimen (CE)<br> 
 * OM4-7: Additive (CWE)<br> 
 * OM4-8: Preparation (TX)<br> 
 * OM4-9: Special Handling Requirements (TX)<br> 
 * OM4-10: Normal Collection Volume (CQ)<br> 
 * OM4-11: Minimum Collection Volume (CQ)<br> 
 * OM4-12: Specimen Requirements (TX)<br> 
 * OM4-13: Specimen Priorities (ID)<br> 
 * OM4-14: Specimen Retention Time (CQ)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OM4 : AbstractSegment  {

  /**
   * Creates a OM4 (Observations that Require Specimens) segment object that belongs to the given 
   * message.  
   */
  public OM4(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(NM), false, 1, 4, new System.Object[]{message}, "Sequence Number - Test/Observation Master File");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 170}, "Derived Specimen");
       this.add(typeof(TX), false, 1, 60, new System.Object[]{message}, "Container Description");
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message}, "Container Volume");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Container Units");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Specimen");
       this.add(typeof(CWE), false, 1, 250, new System.Object[]{message}, "Additive");
       this.add(typeof(TX), false, 1, 10240, new System.Object[]{message}, "Preparation");
       this.add(typeof(TX), false, 1, 10240, new System.Object[]{message}, "Special Handling Requirements");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Normal Collection Volume");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Minimum Collection Volume");
       this.add(typeof(TX), false, 1, 10240, new System.Object[]{message}, "Specimen Requirements");
       this.add(typeof(ID), false, 0, 1, new System.Object[]{message, 27}, "Specimen Priorities");
       this.add(typeof(CQ), false, 1, 20, new System.Object[]{message}, "Specimen Retention Time");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Sequence Number - Test/Observation Master File(OM4-1).
	*/
	public NM SequenceNumberTestObservationMasterFile
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
	* Returns Derived Specimen(OM4-2).
	*/
	public ID DerivedSpecimen
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
	* Returns Container Description(OM4-3).
	*/
	public TX ContainerDescription
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (TX)t;
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
	* Returns Container Volume(OM4-4).
	*/
	public NM ContainerVolume
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Container Units(OM4-5).
	*/
	public CE ContainerUnits
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
	* Returns Specimen(OM4-6).
	*/
	public CE Specimen
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Additive(OM4-7).
	*/
	public CWE Additive
	{
		get{
			CWE ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Preparation(OM4-8).
	*/
	public TX Preparation
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(8, 0);
				ret = (TX)t;
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
	* Returns Special Handling Requirements(OM4-9).
	*/
	public TX SpecialHandlingRequirements
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(9, 0);
				ret = (TX)t;
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
	* Returns Normal Collection Volume(OM4-10).
	*/
	public CQ NormalCollectionVolume
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(10, 0);
				ret = (CQ)t;
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
	* Returns Minimum Collection Volume(OM4-11).
	*/
	public CQ MinimumCollectionVolume
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (CQ)t;
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
	* Returns Specimen Requirements(OM4-12).
	*/
	public TX SpecimenRequirements
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(12, 0);
				ret = (TX)t;
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
	* Returns a single repetition of Specimen Priorities(OM4-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getSpecimenPriorities(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Specimen Priorities (OM4-13).
   */
  public ID[] getSpecimenPriorities() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(13);  
        ret = new ID[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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

	/**
	* Returns Specimen Retention Time(OM4-14).
	*/
	public CQ SpecimenRetentionTime
	{
		get{
			CQ ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (CQ)t;
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