using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V25.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V25.Segment{

///<summary>
/// Represents an HL7 GOL message segment. 
/// This segment has the following fields:
/// * GOL-1: Action Code (ID)
/// * GOL-2: Action Date/Time (TS)
/// * GOL-3: Goal ID (CE)
/// * GOL-4: Goal Instance ID (EI)
/// * GOL-5: Episode of Care ID (EI)
/// * GOL-6: Goal List Priority (NM)
/// * GOL-7: Goal Established Date/Time (TS)
/// * GOL-8: Expected Goal Achieve Date/Time (TS)
/// * GOL-9: Goal Classification (CE)
/// * GOL-10: Goal Management Discipline (CE)
/// * GOL-11: Current Goal Review Status (CE)
/// * GOL-12: Current Goal Review Date/Time (TS)
/// * GOL-13: Next Goal Review Date/Time (TS)
/// * GOL-14: Previous Goal Review Date/Time (TS)
/// * GOL-15: Goal Review Interval (TQ)
/// * GOL-16: Goal Evaluation (CE)
/// * GOL-17: Goal Evaluation Comment (ST)
/// * GOL-18: Goal Life Cycle Status (CE)
/// * GOL-19: Goal Life Cycle Status Date/Time (TS)
/// * GOL-20: Goal Target Type (CE)
/// * GOL-21: Goal Target Name (XPN)
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class GOL : AbstractSegment  {

  /**
   * Creates a GOL (Goal Detail) segment object that belongs to the given 
   * message.  
   */
	public GOL(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(ID), true, 1, 2, new System.Object[]{message, 287}, "Action Code");
       this.add(typeof(TS), true, 1, 26, new System.Object[]{message}, "Action Date/Time");
       this.add(typeof(CE), true, 1, 250, new System.Object[]{message}, "Goal ID");
       this.add(typeof(EI), true, 1, 60, new System.Object[]{message}, "Goal Instance ID");
       this.add(typeof(EI), false, 1, 60, new System.Object[]{message}, "Episode of Care ID");
       this.add(typeof(NM), false, 1, 60, new System.Object[]{message}, "Goal List Priority");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Goal Established Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Expected Goal Achieve Date/Time");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Goal Classification");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Goal Management Discipline");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Current Goal Review Status");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Current Goal Review Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Next Goal Review Date/Time");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Previous Goal Review Date/Time");
       this.add(typeof(TQ), false, 1, 200, new System.Object[]{message}, "Goal Review Interval");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Goal Evaluation");
       this.add(typeof(ST), false, 0, 300, new System.Object[]{message}, "Goal Evaluation Comment");
       this.add(typeof(CE), false, 1, 250, new System.Object[]{message}, "Goal Life Cycle Status");
       this.add(typeof(TS), false, 1, 26, new System.Object[]{message}, "Goal Life Cycle Status Date/Time");
       this.add(typeof(CE), false, 0, 250, new System.Object[]{message}, "Goal Target Type");
       this.add(typeof(XPN), false, 0, 250, new System.Object[]{message}, "Goal Target Name");
    } catch (HL7Exception he) {
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Action Code(GOL-1).
	///</summary>
	public ID ActionCode
	{
		get{
			ID ret = null;
			try
			{
			IType t = this.GetField(1, 0);
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
	/// Returns Action Date/Time(GOL-2).
	///</summary>
	public TS ActionDateTime
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
	/// Returns Goal ID(GOL-3).
	///</summary>
	public CE GoalID
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(3, 0);
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
	/// Returns Goal Instance ID(GOL-4).
	///</summary>
	public EI GoalInstanceID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(4, 0);
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

	///<summary>
	/// Returns Episode of Care ID(GOL-5).
	///</summary>
	public EI EpisodeOfCareID
	{
		get{
			EI ret = null;
			try
			{
			IType t = this.GetField(5, 0);
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

	///<summary>
	/// Returns Goal List Priority(GOL-6).
	///</summary>
	public NM GoalListPriority
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(6, 0);
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

	///<summary>
	/// Returns Goal Established Date/Time(GOL-7).
	///</summary>
	public TS GoalEstablishedDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(7, 0);
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
	/// Returns Expected Goal Achieve Date/Time(GOL-8).
	///</summary>
	public TS ExpectedGoalAchieveDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(8, 0);
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
	/// Returns Goal Classification(GOL-9).
	///</summary>
	public CE GoalClassification
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(9, 0);
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
	/// Returns Goal Management Discipline(GOL-10).
	///</summary>
	public CE GoalManagementDiscipline
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(10, 0);
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
	/// Returns Current Goal Review Status(GOL-11).
	///</summary>
	public CE CurrentGoalReviewStatus
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(11, 0);
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
	/// Returns Current Goal Review Date/Time(GOL-12).
	///</summary>
	public TS CurrentGoalReviewDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(12, 0);
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
	/// Returns Next Goal Review Date/Time(GOL-13).
	///</summary>
	public TS NextGoalReviewDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(13, 0);
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
	/// Returns Previous Goal Review Date/Time(GOL-14).
	///</summary>
	public TS PreviousGoalReviewDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(14, 0);
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
	/// Returns Goal Review Interval(GOL-15).
	///</summary>
	public TQ GoalReviewInterval
	{
		get{
			TQ ret = null;
			try
			{
			IType t = this.GetField(15, 0);
				ret = (TQ)t;
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
	/// Returns Goal Evaluation(GOL-16).
	///</summary>
	public CE GoalEvaluation
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(16, 0);
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
	/// Returns a single repetition of Goal Evaluation Comment(GOL-17).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public ST getGoalEvaluationComment(int rep)
	{
			ST ret = null;
			try
			{
			IType t = this.GetField(17, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Goal Evaluation Comment (GOL-17).
   ///</summary>
  public ST[] getGoalEvaluationComment() {
     ST[] ret = null;
    try {
        IType[] t = this.GetField(17);  
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

	///<summary>
	/// Returns Goal Life Cycle Status(GOL-18).
	///</summary>
	public CE GoalLifeCycleStatus
	{
		get{
			CE ret = null;
			try
			{
			IType t = this.GetField(18, 0);
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
	/// Returns Goal Life Cycle Status Date/Time(GOL-19).
	///</summary>
	public TS GoalLifeCycleStatusDateTime
	{
		get{
			TS ret = null;
			try
			{
			IType t = this.GetField(19, 0);
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
	/// Returns a single repetition of Goal Target Type(GOL-20).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public CE getGoalTargetType(int rep)
	{
			CE ret = null;
			try
			{
			IType t = this.GetField(20, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Goal Target Type (GOL-20).
   ///</summary>
  public CE[] getGoalTargetType() {
     CE[] ret = null;
    try {
        IType[] t = this.GetField(20);  
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

	///<summary>
	/// Returns a single repetition of Goal Target Name(GOL-21).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public XPN getGoalTargetName(int rep)
	{
			XPN ret = null;
			try
			{
			IType t = this.GetField(21, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Goal Target Name (GOL-21).
   ///</summary>
  public XPN[] getGoalTargetName() {
     XPN[] ret = null;
    try {
        IType[] t = this.GetField(21);  
        ret = new XPN[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (XPN)t[i];
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