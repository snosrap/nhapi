using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment{

/**
 * <p>Represents an HL7 NK1 message segment. 
 * This segment has the following fields:</p><p>
 * NK1-1: Set ID - Next of Kin (SI)<br> 
 * NK1-2: Name (PN)<br> 
 * NK1-3: Relationship (CE)<br> 
 * NK1-4: Address (AD)<br> 
 * NK1-5: Phone Number (TN)<br> 
 * NK1-6: Business Phone Number (TN)<br> 
 * NK1-7: Contact Role (CE)<br> 
 * NK1-8: Start Date (DT)<br> 
 * NK1-9: End Date (DT)<br> 
 * NK1-10: Next of Kin (ST)<br> 
 * NK1-11: Next of kin job code / class (CM_JOB_CODE)<br> 
 * NK1-12: Next of Kin Employee Number (ST)<br> 
 * NK1-13: Organization Name (ST)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class NK1 : AbstractSegment  {

  /**
   * Creates a NK1 (NEXT OF KIN) segment object that belongs to the given 
   * message.  
   */
	public NK1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), true, 1, 4, new System.Object[]{message}, "Set ID - Next of Kin");
       this.add(typeof(PN), false, 1, 48, new System.Object[]{message}, "Name");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Relationship");
       this.add(typeof(AD), false, 1, 106, new System.Object[]{message}, "Address");
       this.add(typeof(TN), false, 3, 40, new System.Object[]{message}, "Phone Number");
       this.add(typeof(TN), false, 1, 40, new System.Object[]{message}, "Business Phone Number");
       this.add(typeof(CE), false, 1, 60, new System.Object[]{message}, "Contact Role");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "Start Date");
       this.add(typeof(DT), false, 1, 8, new System.Object[]{message}, "End Date");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Next of Kin");
       this.add(typeof(CM_JOB_CODE), false, 1, 60, new System.Object[]{message}, "Next of kin job code / class");
       this.add(typeof(ST), false, 1, 20, new System.Object[]{message}, "Next of Kin Employee Number");
       this.add(typeof(ST), false, 1, 60, new System.Object[]{message}, "Organization Name");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	/**
	* Returns Set ID - Next of Kin(NK1-1).
	*/
	public SI SetIDNextOfKin
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
	* Returns Name(NK1-2).
	*/
	public PN Name
	{
		get{
			PN ret = null;
			try
			{
			IType t = this.getField(2, 0);
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
	* Returns Relationship(NK1-3).
	*/
	public CE Relationship
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.getField(3, 0);
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
	* Returns Address(NK1-4).
	*/
	public AD Address
	{
		get{
			AD ret = null;
			try
			{
			IType t = this.getField(4, 0);
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
	* Returns a single repetition of Phone Number(NK1-5).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public TN getPhoneNumber(int rep)
	{
			TN ret = null;
			try
			{
			IType t = this.getField(5, rep);
				ret = (TN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Phone Number (NK1-5).
   */
  public TN[] getPhoneNumber() {
     TN[] ret = null;
    try {
        IType[] t = this.getField(5);  
        ret = new TN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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
	* Returns Business Phone Number(NK1-6).
	*/
	public TN BusinessPhoneNumber
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
	* Returns Contact Role(NK1-7).
	*/
	public CE ContactRole
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
	* Returns Start Date(NK1-8).
	*/
	public DT StartDate
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
	* Returns End Date(NK1-9).
	*/
	public DT EndDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.getField(9, 0);
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
	* Returns Next of Kin(NK1-10).
	*/
	public ST NextOfKin
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(10, 0);
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
	* Returns Next of kin job code / class(NK1-11).
	*/
	public CM_JOB_CODE NextOfKinJobCodeClass
	{
		get{
			CM_JOB_CODE ret = null;
			try
			{
			IType t = this.getField(11, 0);
				ret = (CM_JOB_CODE)t;
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
	* Returns Next of Kin Employee Number(NK1-12).
	*/
	public ST NextOfKinEmployeeNumber
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
	* Returns Organization Name(NK1-13).
	*/
	public ST OrganizationName
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.getField(13, 0);
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