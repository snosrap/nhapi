using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V24.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V24.Segment{

///<summary>
/// Represents an HL7 CSS message segment. 
/// This segment has the following fields:
/// * CSS-1: Study Scheduled Time Point (CE)
/// * CSS-2: Study Scheduled Patient Time Point (TS)
/// * CSS-3: Study Quality Control Codes (CE)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class CSS : AbstractSegment  {

  /**
   * Creates a CSS (Clinical Study Data Schedule Segment) segment object that belongs to the given 
   * message.  
   */
	public CSS(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Study Scheduled Time Point");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Study Scheduled Patient Time Point");
       this.add(typeof(CE), false, 3, 250, new System.Object[]{message}, "Study Quality Control Codes");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Study Scheduled Time Point(CSS-1).
	///</summary>
	public CE StudyScheduledTimePoint
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
	/// Returns Study Scheduled Patient Time Point(CSS-2).
	///</summary>
	public TS StudyScheduledPatientTimePoint
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(2, 0);
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

	///<summary>
	/// Returns a single repetition of Study Quality Control Codes(CSS-3).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE getStudyQualityControlCodes(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(3, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Study Quality Control Codes (CSS-3).
   ///</summary>
  public CE[] getStudyQualityControlCodes() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(3);  
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


}}