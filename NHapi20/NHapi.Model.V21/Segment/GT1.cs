using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment{

/**
 * <p>Represents an HL7 GT1 message segment. 
 * This segment has the following fields:</p><p>
 * GT1-1: SET ID - GUARANTOR (SI)<br> 
 * GT1-2: GUARANTOR NUMBER (ID)<br> 
 * GT1-3: GUARANTOR NAME (PN)<br> 
 * GT1-4: GUARANTOR SPOUSE NAME (PN)<br> 
 * GT1-5: GUARANTOR ADDRESS (AD)<br> 
 * GT1-6: GUARANTOR PH. NUM.- HOME (TN)<br> 
 * GT1-7: GUARANTOR PH. NUM-BUSINESS (TN)<br> 
 * GT1-8: GUARANTOR DATE OF BIRTH (DT)<br> 
 * GT1-9: GUARANTOR SEX (ID)<br> 
 * GT1-10: GUARANTOR TYPE (ID)<br> 
 * GT1-11: GUARANTOR RELATIONSHIP (ID)<br> 
 * GT1-12: GUARANTOR SSN (ST)<br> 
 * GT1-13: GUARANTOR DATE - BEGIN (DT)<br> 
 * GT1-14: GUARANTOR DATE - END (DT)<br> 
 * GT1-15: GUARANTOR PRIORITY (NM)<br> 
 * GT1-16: GUARANTOR EMPLOYER NAME (ST)<br> 
 * GT1-17: GUARANTOR EMPLOYER ADDRESS (AD)<br> 
 * GT1-18: GUARANTOR EMPLOY PHONE # (TN)<br> 
 * GT1-19: GUARANTOR EMPLOYEE ID NUM (ST)<br> 
 * GT1-20: GUARANTOR EMPLOYMENT STATUS (ID)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class GT1 : AbstractSegment  {

  /**
   * Creates a GT1 (GUARANTOR) segment object that belongs to the given 
   * message.  
   */
	public GT1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "SET ID - GUARANTOR");
       this.add(typeof(ID), false, 1, 20, new System.Object[]{message, 0}, "GUARANTOR NUMBER");
       this.add(typeof(PN), true, 1, 48, new System.Object[]{message}, "GUARANTOR NAME");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "GUARANTOR SPOUSE NAME");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "GUARANTOR ADDRESS");
       this.add(typeof(TN), false, 1, 40, new System.Object[]{message}, "GUARANTOR PH. NUM.- HOME");
       this.add(typeof(TN), false, 1, 40, new System.Object[]{message}, "GUARANTOR PH. NUM-BUSINESS");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "GUARANTOR DATE OF BIRTH");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 1}, "GUARANTOR SEX");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 68}, "GUARANTOR TYPE");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 63}, "GUARANTOR RELATIONSHIP");
       this.add(typeof(ST), false, 1, 11, new System.Object[]{message}, "GUARANTOR SSN");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "GUARANTOR DATE - BEGIN");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "GUARANTOR DATE - END");
       this.add(typeof(NM), false, 1, 2, new System.Object[]{message}, "GUARANTOR PRIORITY");
       this.add(typeof(ST), false, 1, 45, new System.Object[]{message}, "GUARANTOR EMPLOYER NAME");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "GUARANTOR EMPLOYER ADDRESS");
       this.add(typeof(TN), false, 1, 40, new System.Object[]{message}, "GUARANTOR EMPLOY PHONE #");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "GUARANTOR EMPLOYEE ID NUM");
       this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 66}, "GUARANTOR EMPLOYMENT STATUS");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns SET ID - GUARANTOR(GT1-1).
	*/
	public SI SETIDGUARANTOR
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
	* Returns GUARANTOR NUMBER(GT1-2).
	*/
	public ID GUARANTORNUMBER
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
	* Returns GUARANTOR NAME(GT1-3).
	*/
	public PN GUARANTORNAME
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.getField(3, 0);
				ret = (PN)t;
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
	* Returns GUARANTOR SPOUSE NAME(GT1-4).
	*/
	public PN GUARANTORSPOUSENAME
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.getField(4, 0);
				ret = (PN)t;
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
	* Returns GUARANTOR ADDRESS(GT1-5).
	*/
	public AD GUARANTORADDRESS
	{
		get{
			AD ret = null;
			try
			{
			IType t = this.getField(5, 0);
				ret = (AD)t;
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
	* Returns GUARANTOR PH. NUM.- HOME(GT1-6).
	*/
	public TN GUARANTORPHNUMHOME
	{
		get{
			TN ret = null;
			try
			{
			IType t = this.getField(6, 0);
				ret = (TN)t;
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
	* Returns GUARANTOR PH. NUM-BUSINESS(GT1-7).
	*/
	public TN GUARANTORPHNUMBUSINESS
	{
		get{
			TN ret = null;
			try
			{
			IType t = this.getField(7, 0);
				ret = (TN)t;
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
	* Returns GUARANTOR DATE OF BIRTH(GT1-8).
	*/
	public DT GUARANTORDATEOFBIRTH
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(8, 0);
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
	* Returns GUARANTOR SEX(GT1-9).
	*/
	public ID GUARANTORSEX
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
	* Returns GUARANTOR TYPE(GT1-10).
	*/
	public ID GUARANTORTYPE
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
	* Returns GUARANTOR RELATIONSHIP(GT1-11).
	*/
	public ID GUARANTORRELATIONSHIP
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
	* Returns GUARANTOR SSN(GT1-12).
	*/
	public ST GUARANTORSSN
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(12, 0);
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
	* Returns GUARANTOR DATE - BEGIN(GT1-13).
	*/
	public DT GUARANTORDATEBEGIN
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(13, 0);
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
	* Returns GUARANTOR DATE - END(GT1-14).
	*/
	public DT GUARANTORDATEEND
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(14, 0);
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
	* Returns GUARANTOR PRIORITY(GT1-15).
	*/
	public NM GUARANTORPRIORITY
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
	* Returns GUARANTOR EMPLOYER NAME(GT1-16).
	*/
	public ST GUARANTOREMPLOYERNAME
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(16, 0);
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
	* Returns GUARANTOR EMPLOYER ADDRESS(GT1-17).
	*/
	public AD GUARANTOREMPLOYERADDRESS
	{
		get{
			AD ret = null;
			try
			{
			IType t = this.getField(17, 0);
				ret = (AD)t;
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
	* Returns GUARANTOR EMPLOY PHONE #(GT1-18).
	*/
	public TN GUARANTOREMPLOYPHONE
	{
		get{
			TN ret = null;
			try
			{
			IType t = this.getField(18, 0);
				ret = (TN)t;
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
	* Returns GUARANTOR EMPLOYEE ID NUM(GT1-19).
	*/
	public ST GUARANTOREMPLOYEEIDNUM
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(19, 0);
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
	* Returns GUARANTOR EMPLOYMENT STATUS(GT1-20).
	*/
	public ID GUARANTOREMPLOYMENTSTATUS
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.getField(20, 0);
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