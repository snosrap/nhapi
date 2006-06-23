using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 OM1 message segment. 
 * This segment has the following fields:</p><p>
 * OM1-1: Sequence Number - Test/ Observation Master File (NM)<br> 
 * OM1-2: Producer's Service/Test/Observation ID (CE)<br> 
 * OM1-3: Permitted Data Types (ID)<br> 
 * OM1-4: Specimen Required (ID)<br> 
 * OM1-5: Producer ID (CE)<br> 
 * OM1-6: Observation Description (TX)<br> 
 * OM1-7: Other Service/Test/Observation IDs for the Observation (CE)<br> 
 * OM1-8: Other Names (ST)<br> 
 * OM1-9: Preferred Report Name for the Observation (ST)<br> 
 * OM1-10: Preferred Short Name or Mnemonic for Observation (ST)<br> 
 * OM1-11: Preferred Long Name for the Observation (ST)<br> 
 * OM1-12: Orderability (ID)<br> 
 * OM1-13: Identity of Instrument Used to Perform this Study (CE)<br> 
 * OM1-14: Coded Representation of Method (CE)<br> 
 * OM1-15: Portable Device Indicator (ID)<br> 
 * OM1-16: Observation Producing Department/Section (CE)<br> 
 * OM1-17: Telephone Number of Section (XTN)<br> 
 * OM1-18: Nature of Service/Test/Observation (IS)<br> 
 * OM1-19: Report Subheader (CE)<br> 
 * OM1-20: Report Display Order (ST)<br> 
 * OM1-21: Date/Time Stamp for any change in Definition for the Observation (TS)<br> 
 * OM1-22: Effective Date/Time of Change (TS)<br> 
 * OM1-23: Typical Turn-Around Time (NM)<br> 
 * OM1-24: Processing Time (NM)<br> 
 * OM1-25: Processing Priority (ID)<br> 
 * OM1-26: Reporting Priority (ID)<br> 
 * OM1-27: Outside Site(s) Where Observation may be Performed (CE)<br> 
 * OM1-28: Address of Outside Site(s) (XAD)<br> 
 * OM1-29: Phone Number of Outside Site (XTN)<br> 
 * OM1-30: Confidentiality Code (IS)<br> 
 * OM1-31: Observations Required to Interpret the Observation (CE)<br> 
 * OM1-32: Interpretation of Observations (TX)<br> 
 * OM1-33: Contraindications to Observations (CE)<br> 
 * OM1-34: Reflex Tests/Observations (CE)<br> 
 * OM1-35: Rules that Trigger Reflex Testing (TX)<br> 
 * OM1-36: Fixed Canned Message (CE)<br> 
 * OM1-37: Patient Preparation (TX)<br> 
 * OM1-38: Procedure Medication (CE)<br> 
 * OM1-39: Factors that may Affect Affect the Observation (TX)<br> 
 * OM1-40: Service/Test/Observation Performance Schedule (ST)<br> 
 * OM1-41: Description of Test Methods (TX)<br> 
 * OM1-42: Kind of Quantity Observed (CE)<br> 
 * OM1-43: Point Versus Interval (CE)<br> 
 * OM1-44: Challenge Information (TX)<br> 
 * OM1-45: Relationship Modifier (CE)<br> 
 * OM1-46: Target Anatomic Site Of Test (CE)<br> 
 * OM1-47: Modality Of Imaging Measurement (CE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class OM1 : AbstractSegment  {

  /**
   * Creates a OM1 (General Segment) segment object that belongs to the given 
   * message.  
   */
  public OM1(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(ID), false, 0, 12, new System.Object[]{message, 125});
       this.add(typeof(ID), true, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(ST), true, 0, 200, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 30, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 8, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 200, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XTN), false, 1, 250, new System.Object[]{message});
       this.add(typeof(IS), true, 1, 1, new System.Object[]{message, 174});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
       this.add(typeof(ID), false, 0, 40, new System.Object[]{message, 168});
       this.add(typeof(ID), false, 1, 5, new System.Object[]{message, 169});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(XAD), false, 0, 1000, new System.Object[]{message});
       this.add(typeof(XTN), false, 1, 400, new System.Object[]{message});
       this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 177});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 65536, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 65536, new System.Object[]{message});
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 80, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 65536, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
       this.add(typeof(ST), false, 0, 60, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 65536, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(TX), false, 1, 200, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Sequence Number - Test/ Observation Master File (OM1-1).
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
	* Returns Producer's Service/Test/Observation ID (OM1-2).
	*/
	public CE ProducerSServiceTestObservationID
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
	* Returns a single repetition of Permitted Data Types (OM1-3).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getPermittedDataTypes(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(3, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Permitted Data Types (OM1-3).
   */
  public ID[] getPermittedDataTypes() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(3);  
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
	* Returns Specimen Required (OM1-4).
	*/
	public ID SpecimenRequired
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Producer ID (OM1-5).
	*/
	public CE ProducerID
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
	* Returns Observation Description (OM1-6).
	*/
	public TX ObservationDescription
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Other Service/Test/Observation IDs for the Observation (OM1-7).
	*/
	public CE OtherServiceTestObservationIDsForTheObservation
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
	* Returns a single repetition of Other Names (OM1-8).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getOtherNames(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(8, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Other Names (OM1-8).
   */
  public ST[] getOtherNames() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(8);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
	* Returns Preferred Report Name for the Observation (OM1-9).
	*/
	public ST PreferredReportNameForTheObservation
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
	* Returns Preferred Short Name or Mnemonic for Observation (OM1-10).
	*/
	public ST PreferredShortNameOrMnemonicForObservation
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Preferred Long Name for the Observation (OM1-11).
	*/
	public ST PreferredLongNameForTheObservation
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Orderability (OM1-12).
	*/
	public ID Orderability
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns a single repetition of Identity of Instrument Used to Perform this Study (OM1-13).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getIdentityOfInstrumentUsedToPerformThisStudy(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(13, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Identity of Instrument Used to Perform this Study (OM1-13).
   */
  public CE[] getIdentityOfInstrumentUsedToPerformThisStudy() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(13);  
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

	/**
	* Returns a single repetition of Coded Representation of Method (OM1-14).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getCodedRepresentationOfMethod(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(14, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Coded Representation of Method (OM1-14).
   */
  public CE[] getCodedRepresentationOfMethod() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(14);  
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

	/**
	* Returns Portable Device Indicator (OM1-15).
	*/
	public ID PortableDeviceIndicator
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns a single repetition of Observation Producing Department/Section (OM1-16).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getObservationProducingDepartmentSection(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(16, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Observation Producing Department/Section (OM1-16).
   */
  public CE[] getObservationProducingDepartmentSection() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(16);  
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

	/**
	* Returns Telephone Number of Section (OM1-17).
	*/
	public XTN TelephoneNumberOfSection
	{
		get{
			XTN ret = null;
			try
			{
			Type t = this.getField(17, 0);
				ret = (XTN)t;
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
	* Returns Nature of Service/Test/Observation (OM1-18).
	*/
	public IS NatureOfServiceTestObservation
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Report Subheader (OM1-19).
	*/
	public CE ReportSubheader
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns Report Display Order (OM1-20).
	*/
	public ST ReportDisplayOrder
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(20, 0);
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
	* Returns Date/Time Stamp for any change in Definition for the Observation (OM1-21).
	*/
	public TS DateTimeStampForAnyChangeInDefinitionForTheObservation
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(21, 0);
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
	* Returns Effective Date/Time of Change (OM1-22).
	*/
	public TS EffectiveDateTimeOfChange
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(22, 0);
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
	* Returns Typical Turn-Around Time (OM1-23).
	*/
	public NM TypicalTurnAroundTime
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(23, 0);
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
	* Returns Processing Time (OM1-24).
	*/
	public NM ProcessingTime
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(24, 0);
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
	* Returns a single repetition of Processing Priority (OM1-25).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ID getProcessingPriority(int rep)
	{
			ID ret = null;
			try
			{
			Type t = this.getField(25, rep);
				ret = (ID)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Processing Priority (OM1-25).
   */
  public ID[] getProcessingPriority() {
     ID[] ret = null;
    try {
        Type[] t = this.getField(25);  
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
	* Returns Reporting Priority (OM1-26).
	*/
	public ID ReportingPriority
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(26, 0);
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
	* Returns a single repetition of Outside Site(s) Where Observation may be Performed (OM1-27).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getOutsideSiteSWhereObservationMayBePerformed(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(27, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Outside Site(s) Where Observation may be Performed (OM1-27).
   */
  public CE[] getOutsideSiteSWhereObservationMayBePerformed() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(27);  
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

	/**
	* Returns a single repetition of Address of Outside Site(s) (OM1-28).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XAD getAddressOfOutsideSiteS(int rep)
	{
			XAD ret = null;
			try
			{
			Type t = this.getField(28, rep);
				ret = (XAD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Address of Outside Site(s) (OM1-28).
   */
  public XAD[] getAddressOfOutsideSiteS() {
     XAD[] ret = null;
    try {
        Type[] t = this.getField(28);  
        ret = new XAD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XAD)t[i];
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
	* Returns Phone Number of Outside Site (OM1-29).
	*/
	public XTN PhoneNumberOfOutsideSite
	{
		get{
			XTN ret = null;
			try
			{
			Type t = this.getField(29, 0);
				ret = (XTN)t;
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
	* Returns Confidentiality Code (OM1-30).
	*/
	public IS ConfidentialityCode
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(30, 0);
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
	* Returns Observations Required to Interpret the Observation (OM1-31).
	*/
	public CE ObservationsRequiredToInterpretTheObservation
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(31, 0);
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
	* Returns Interpretation of Observations (OM1-32).
	*/
	public TX InterpretationOfObservations
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(32, 0);
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
	* Returns Contraindications to Observations (OM1-33).
	*/
	public CE ContraindicationsToObservations
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(33, 0);
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
	* Returns a single repetition of Reflex Tests/Observations (OM1-34).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getReflexTestsObservations(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(34, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Reflex Tests/Observations (OM1-34).
   */
  public CE[] getReflexTestsObservations() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(34);  
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

	/**
	* Returns Rules that Trigger Reflex Testing (OM1-35).
	*/
	public TX RulesThatTriggerReflexTesting
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(35, 0);
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
	* Returns Fixed Canned Message (OM1-36).
	*/
	public CE FixedCannedMessage
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(36, 0);
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
	* Returns Patient Preparation (OM1-37).
	*/
	public TX PatientPreparation
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(37, 0);
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
	* Returns Procedure Medication (OM1-38).
	*/
	public CE ProcedureMedication
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(38, 0);
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
	* Returns Factors that may Affect Affect the Observation (OM1-39).
	*/
	public TX FactorsThatMayAffectAffectTheObservation
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(39, 0);
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
	* Returns a single repetition of Service/Test/Observation Performance Schedule (OM1-40).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getServiceTestObservationPerformanceSchedule(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(40, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Service/Test/Observation Performance Schedule (OM1-40).
   */
  public ST[] getServiceTestObservationPerformanceSchedule() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(40);  
        ret = new ST[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
	* Returns Description of Test Methods (OM1-41).
	*/
	public TX DescriptionOfTestMethods
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(41, 0);
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
	* Returns Kind of Quantity Observed (OM1-42).
	*/
	public CE KindOfQuantityObserved
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(42, 0);
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
	* Returns Point Versus Interval (OM1-43).
	*/
	public CE PointVersusInterval
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(43, 0);
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
	* Returns Challenge Information (OM1-44).
	*/
	public TX ChallengeInformation
	{
		get{
			TX ret = null;
			try
			{
			Type t = this.getField(44, 0);
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
	* Returns Relationship Modifier (OM1-45).
	*/
	public CE RelationshipModifier
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(45, 0);
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
	* Returns Target Anatomic Site Of Test (OM1-46).
	*/
	public CE TargetAnatomicSiteOfTest
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(46, 0);
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
	* Returns Modality Of Imaging Measurement (OM1-47).
	*/
	public CE ModalityOfImagingMeasurement
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(47, 0);
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