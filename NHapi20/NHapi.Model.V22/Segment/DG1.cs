using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 DG1 message segment. 
 * This segment has the following fields:</p><p>
 * DG1-1: Set ID - diagnosis (SI)<br> 
 * DG1-2: Diagnosis coding method (ID)<br> 
 * DG1-3: Diagnosis code (ID)<br> 
 * DG1-4: Diagnosis description (ST)<br> 
 * DG1-5: Diagnosis date / time (TS)<br> 
 * DG1-6: Diagnosis / DRG type (ID)<br> 
 * DG1-7: Major diagnostic category (CE)<br> 
 * DG1-8: Diagnostic related group (ID)<br> 
 * DG1-9: DRG approval indicator (ID)<br> 
 * DG1-10: DRG grouper review code (ID)<br> 
 * DG1-11: Outlier type (ID)<br> 
 * DG1-12: Outlier days (NM)<br> 
 * DG1-13: Outlier cost (NM)<br> 
 * DG1-14: Grouper version and type (ST)<br> 
 * DG1-15: Diagnosis / DRG priority (NM)<br> 
 * DG1-16: Diagnosing clinician (CN_PERSON)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class DG1 : AbstractSegment  {

  /**
   * Creates a DG1 (DIAGNOSIS) segment object that belongs to the given 
   * message.  
   */
	public DG1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - diagnosis");
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 53}, "Diagnosis coding method");
       this.add(typeof(ID), false, 1, 8, new System.Object[]{message, 51}, "Diagnosis code");
       this.add(typeof(ST), false, 1, 40, new System.Object[]{message}, "Diagnosis description");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Diagnosis date / time");
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 52}, "Diagnosis / DRG type");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Major diagnostic category");
       this.add(typeof(ID), false, 1, 4, new System.Object[]{message, 55}, "Diagnostic related group");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 0}, "DRG approval indicator");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 56}, "DRG grouper review code");
       this.add(typeof(ID), false, 1, 60, new System.Object[]{message, 83}, "Outlier type");
       this.add(typeof(NM), false, 1, 3, new System.Object[]{message}, "Outlier days");
       this.add(typeof(NM), false, 1, 12, new System.Object[]{message}, "Outlier cost");
       this.add(typeof(ST), false, 1, 4, new System.Object[]{message}, "Grouper version and type");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "Diagnosis / DRG priority");
       this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[]{message}, "Diagnosing clinician");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Set ID - diagnosis(DG1-1).
	*/
	public SI SetIDDiagnosis
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.getField(1, 0);
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
	* Returns Diagnosis coding method(DG1-2).
	*/
	public ID DiagnosisCodingMethod
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns Diagnosis code(DG1-3).
	*/
	public ID DiagnosisCode
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns Diagnosis description(DG1-4).
	*/
	public ST DiagnosisDescription
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns Diagnosis date / time(DG1-5).
	*/
	public TS DiagnosisDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.getField(5, 0);
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
	* Returns Diagnosis / DRG type(DG1-6).
	*/
	public ID DiagnosisDRGType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(6, 0);
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
	* Returns Major diagnostic category(DG1-7).
	*/
	public CE MajorDiagnosticCategory
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(7, 0);
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
	* Returns Diagnostic related group(DG1-8).
	*/
	public ID DiagnosticRelatedGroup
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns DRG approval indicator(DG1-9).
	*/
	public ID DRGApprovalIndicator
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns DRG grouper review code(DG1-10).
	*/
	public ID DRGGrouperReviewCode
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(10, 0);
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
	* Returns Outlier type(DG1-11).
	*/
	public ID OutlierType
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(11, 0);
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
	* Returns Outlier days(DG1-12).
	*/
	public NM OutlierDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns Outlier cost(DG1-13).
	*/
	public NM OutlierCost
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(13, 0);
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
	* Returns Grouper version and type(DG1-14).
	*/
	public ST GrouperVersionAndType
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(14, 0);
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
	* Returns Diagnosis / DRG priority(DG1-15).
	*/
	public NM DiagnosisDRGPriority
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.getField(15, 0);
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
	* Returns Diagnosing clinician(DG1-16).
	*/
	public CN_PERSON DiagnosingClinician
	{
		get{
			CN_PERSON ret = null;
			try
			{
			IType t = this.getField(16, 0);
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


}}