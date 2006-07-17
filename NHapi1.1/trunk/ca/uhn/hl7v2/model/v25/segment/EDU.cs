using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v25.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v25.segment{

/**
 * <p>Represents an HL7 EDU message segment. 
 * This segment has the following fields:</p><p>
 * EDU-1: Set ID _ EDU (SI)<br> 
 * EDU-2: Academic Degree (IS)<br> 
 * EDU-3: Academic Degree Program Date Range (DR)<br> 
 * EDU-4: Academic Degree Program Participation Date Range (DR)<br> 
 * EDU-5: Academic Degree Granted Date (DT)<br> 
 * EDU-6: School (XON)<br> 
 * EDU-7: School Type Code (CE)<br> 
 * EDU-8: School Address (XAD)<br> 
 * EDU-9: Major Field of Study (CWE)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class EDU : AbstractSegment  {

  /**
   * Creates a EDU (Educational Detail) segment object that belongs to the given 
   * message.  
   */
  public EDU(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
    try {
       this.add(typeof(SI), true, 1, 60, new System.Object[]{message}, "Set ID _ EDU");
       this.add(typeof(IS), false, 1, 10, new System.Object[]{message, 360}, "Academic Degree");
       this.add(typeof(DR), false, 1, 52, new System.Object[]{message}, "Academic Degree Program Date Range");
       this.add(typeof(DR), false, 1, 52, new System.Object[]{message}, "Academic Degree Program Participation Date Range");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Academic Degree Granted Date");
       this.add(typeof(XON), false, 1, 250, new System.Object[]{message}, "School");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "School Type Code");
       this.add(typeof(XAD), false, 1, 250, new System.Object[]{message}, "School Address");
       this.add(typeof(CWE), false, 0, 250, new System.Object[]{message}, "Major Field of Study");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Set ID _ EDU(EDU-1).
	*/
	public SI SetIDEDU
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
	* Returns Academic Degree(EDU-2).
	*/
	public IS AcademicDegree
	{
		get{
			IS ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Academic Degree Program Date Range(EDU-3).
	*/
	public DR AcademicDegreeProgramDateRange
	{
		get{
			DR ret = null;
			try
			{
			Type t = this.getField(3, 0);
				ret = (DR)t;
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
	* Returns Academic Degree Program Participation Date Range(EDU-4).
	*/
	public DR AcademicDegreeProgramParticipationDateRange
	{
		get{
			DR ret = null;
			try
			{
			Type t = this.getField(4, 0);
				ret = (DR)t;
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
	* Returns Academic Degree Granted Date(EDU-5).
	*/
	public DT AcademicDegreeGrantedDate
	{
		get{
			DT ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns School(EDU-6).
	*/
	public XON School
	{
		get{
			XON ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns School Type Code(EDU-7).
	*/
	public CE SchoolTypeCode
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
	* Returns School Address(EDU-8).
	*/
	public XAD SchoolAddress
	{
		get{
			XAD ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns a single repetition of Major Field of Study(EDU-9).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CWE getMajorFieldOfStudy(int rep)
	{
			CWE ret = null;
			try
			{
			Type t = this.getField(9, rep);
				ret = (CWE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Major Field of Study (EDU-9).
   */
  public CWE[] getMajorFieldOfStudy() {
     CWE[] ret = null;
    try {
        Type[] t = this.getField(9);  
        ret = new CWE[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (CWE)t[i];
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