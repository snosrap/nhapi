using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 AFF message segment. 
 * This segment has the following fields:</p><p>
 * AFF-1: Set ID _ AFF (SI)<br> 
 * AFF-2: Professional Organization (XON)<br> 
 * AFF-3: Professional Organization Address (XAD)<br> 
 * AFF-4: Professional Organization Affiliation Date Range (DR)<br> 
 * AFF-5: Professional Affiliation Additional Information (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class AFF : AbstractSegment  {

  /**
   * Creates a AFF (Professional Affiliation) segment object that belongs to the given 
   * message.  
   */
  public AFF(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 60, new System.Object[]{message});
       this.add(typeof(XON), true, 1, 250, new System.Object[]{message});
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message});
       this.add(typeof(DR), false, 0, 52, new System.Object[]{message});
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.GetType().FullName, he);
    }
  }

	/**
	* Returns Set ID _ AFF (AFF-1).
	*/
	public SI SetIDAFF
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
	* Returns Professional Organization (AFF-2).
	*/
	public XON ProfessionalOrganization
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Professional Organization Address (AFF-3).
	*/
	public XAD ProfessionalOrganizationAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (XAD)t;
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
	* Returns a single repetition of Professional Organization Affiliation Date Range (AFF-4).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public DR getProfessionalOrganizationAffiliationDateRange(int rep)
	{
			DR ret = null;
			try
			{
			Type t = this.getField(4, rep);
				ret = (DR)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Professional Organization Affiliation Date Range (AFF-4).
   */
  public DR[] getProfessionalOrganizationAffiliationDateRange() {
     DR[] ret = null;
    try {
        Type[] t = this.getField(4);  
        ret = new DR[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (DR)t[i];
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
	* Returns Professional Affiliation Additional Information (AFF-5).
	*/
	public ST ProfessionalAffiliationAdditionalInformation
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


}}