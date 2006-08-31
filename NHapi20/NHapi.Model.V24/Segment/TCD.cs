using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 TCD message segment. 
/// This segment has the following fields:
/// * TCD-1: Universal Service Identifier (CE)
/// * TCD-2: Auto-Dilution Factor (SN)
/// * TCD-3: Rerun Dilution Factor (SN)
/// * TCD-4: Pre-Dilution Factor (SN)
/// * TCD-5: Endogenous Content of Pre-Dilution Diluent (SN)
/// * TCD-6: Automatic Repeat Allowed (ID)
/// * TCD-7: Reflex Allowed (ID)
/// * TCD-8: Analyte Repeat Status (CE)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class TCD : AbstractSegment  {

  /**
   * Creates a TCD (Test Code Detail) segment object that belongs to the given 
   * message.  
   */
	public TCD(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Universal Service Identifier");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Auto-Dilution Factor");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Rerun Dilution Factor");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Pre-Dilution Factor");
       this.add(typeof(SN), false, 1, 20, new System.Object[]{message}, "Endogenous Content of Pre-Dilution Diluent");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Automatic Repeat Allowed");
       this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136}, "Reflex Allowed");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Analyte Repeat Status");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Universal Service Identifier(TCD-1).
	///</summary>
	public CE UniversalServiceIdentifier
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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

	///<summary>
	/// Returns Auto-Dilution Factor(TCD-2).
	///</summary>
	public SN AutoDilutionFactor
	{
		get{
			SN ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (SN)t;
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

	///<summary>
	/// Returns Rerun Dilution Factor(TCD-3).
	///</summary>
	public SN RerunDilutionFactor
	{
		get{
			SN ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (SN)t;
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

	///<summary>
	/// Returns Pre-Dilution Factor(TCD-4).
	///</summary>
	public SN PreDilutionFactor
	{
		get{
			SN ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (SN)t;
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

	///<summary>
	/// Returns Endogenous Content of Pre-Dilution Diluent(TCD-5).
	///</summary>
	public SN EndogenousContentOfPreDilutionDiluent
	{
		get{
			SN ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (SN)t;
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

	///<summary>
	/// Returns Automatic Repeat Allowed(TCD-6).
	///</summary>
	public ID AutomaticRepeatAllowed
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

	///<summary>
	/// Returns Reflex Allowed(TCD-7).
	///</summary>
	public ID ReflexAllowed
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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

	///<summary>
	/// Returns Analyte Repeat Status(TCD-8).
	///</summary>
	public CE AnalyteRepeatStatus
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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