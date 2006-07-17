using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 IAM message segment. 
 * This segment has the following fields:</p><p>
 * IAM-1: Set ID - IAM (SI)<br> 
 * IAM-2: Allergen Type Code (CE)<br> 
 * IAM-3: Allergen Code/Mnemonic/Description (CE)<br> 
 * IAM-4: Allergy Severity Code (CE)<br> 
 * IAM-5: Allergy Reaction Code (ST)<br> 
 * IAM-6: Allergy Action Code (CNE)<br> 
 * IAM-7: Allergy Unique Identifier (EI)<br> 
 * IAM-8: Action Reason (ST)<br> 
 * IAM-9: Sensitivity to Causative Agent Code (CE)<br> 
 * IAM-10: Allergen Group Code/Mnemonic/Description (CE)<br> 
 * IAM-11: Onset Date (DT)<br> 
 * IAM-12: Onset Date Text (ST)<br> 
 * IAM-13: Reported Date/Time (TS)<br> 
 * IAM-14: Reported By (XPN)<br> 
 * IAM-15: Relationship to Patient Code (CE)<br> 
 * IAM-16: Alert Device Code (CE)<br> 
 * IAM-17: Allergy Clinical Status Code (CE)<br> 
 * IAM-18: Statused by Person (XCN)<br> 
 * IAM-19: Statused by Organization (XON)<br> 
 * IAM-20: Statused at Date/Time (TS)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class IAM : AbstractSegment  {

  /**
   * Creates a IAM (Patient Adverse Reaction Information) segment object that belongs to the given 
   * message.  
   */
  public IAM(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - IAM");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Allergen Type Code");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Allergen Code/Mnemonic/Description");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Allergy Severity Code");
       this.add(typeof(ST), false, 0, 15, new System.Object[]{message}, "Allergy Reaction Code");
       this.add(typeof(CNE), true, 1, 250, new System.Object[]{message}, "Allergy Action Code");
       this.add(typeof(EI), false, 1, 427, new System.Object[]{message}, "Allergy Unique Identifier");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Action Reason");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Sensitivity to Causative Agent Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Allergen Group Code/Mnemonic/Description");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Onset Date");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Onset Date Text");
       this.add(typeof(TS), false, 1, 8, new System.Object[]{message}, "Reported Date/Time");
       this.add(typeof(XPN), false, 1, 250, new System.Object[]{message}, "Reported By");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Relationship to Patient Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Alert Device Code");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Allergy Clinical Status Code");
       this.add(typeof(XCN), false, 1, 250, new System.Object[]{message}, "Statused by Person");
       this.add(typeof(XON), false, 1, 250, new System.Object[]{message}, "Statused by Organization");
       this.add(typeof(TS), false, 1, 8, new System.Object[]{message}, "Statused at Date/Time");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID - IAM(IAM-1).
	*/
	public SI SetIDIAM
	{
		get{
			SI ret = null;
			try
			{
			Type t = this.getField(1, 0);
				ret = (SI)t;
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
	* Returns Allergen Type Code(IAM-2).
	*/
	public CE AllergenTypeCode
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
	* Returns Allergen Code/Mnemonic/Description(IAM-3).
	*/
	public CE AllergenCodeMnemonicDescription
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(3, 0);
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
	* Returns Allergy Severity Code(IAM-4).
	*/
	public CE AllergySeverityCode
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
	* Returns a single repetition of Allergy Reaction Code(IAM-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getAllergyReactionCode(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(5, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Allergy Reaction Code (IAM-5).
   */
  public ST[] getAllergyReactionCode() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(5);  
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
	* Returns Allergy Action Code(IAM-6).
	*/
	public CNE AllergyActionCode
	{
		get{
			CNE ret = null;
			try
			{
			Type t = this.getField(6, 0);
				ret = (CNE)t;
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
	* Returns Allergy Unique Identifier(IAM-7).
	*/
	public EI AllergyUniqueIdentifier
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Action Reason(IAM-8).
	*/
	public ST ActionReason
	{
		get{
			ST ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Sensitivity to Causative Agent Code(IAM-9).
	*/
	public CE SensitivityToCausativeAgentCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(9, 0);
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
	* Returns Allergen Group Code/Mnemonic/Description(IAM-10).
	*/
	public CE AllergenGroupCodeMnemonicDescription
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(10, 0);
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
	* Returns Onset Date(IAM-11).
	*/
	public DT OnsetDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(11, 0);
				ret = (DT)t;
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
	* Returns Onset Date Text(IAM-12).
	*/
	public ST OnsetDateText
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

	/**
	* Returns Reported Date/Time(IAM-13).
	*/
	public TS ReportedDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(13, 0);
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
	* Returns Reported By(IAM-14).
	*/
	public XPN ReportedBy
	{
		get{
			XPN ret = null;
			try
			{
			Type t = this.getField(14, 0);
				ret = (XPN)t;
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
	* Returns Relationship to Patient Code(IAM-15).
	*/
	public CE RelationshipToPatientCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(15, 0);
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
	* Returns Alert Device Code(IAM-16).
	*/
	public CE AlertDeviceCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(16, 0);
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
	* Returns Allergy Clinical Status Code(IAM-17).
	*/
	public CE AllergyClinicalStatusCode
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(17, 0);
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
	* Returns Statused by Person(IAM-18).
	*/
	public XCN StatusedByPerson
	{
		get{
			XCN ret = null;
			try
			{
			Type t = this.getField(18, 0);
				ret = (XCN)t;
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
	* Returns Statused by Organization(IAM-19).
	*/
	public XON StatusedByOrganization
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(19, 0);
				ret = (XON)t;
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
	* Returns Statused at Date/Time(IAM-20).
	*/
	public TS StatusedAtDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(20, 0);
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


}}