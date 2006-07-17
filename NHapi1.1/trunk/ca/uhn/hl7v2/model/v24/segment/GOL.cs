using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment{

/**
 * <p>Represents an HL7 GOL message segment. 
 * This segment has the following fields:</p><p>
 * GOL-1: Action Code (ID)<br> 
 * GOL-2: Action Date/Time (TS)<br> 
 * GOL-3: Goal ID (CE)<br> 
 * GOL-4: Goal Instance ID (EI)<br> 
 * GOL-5: Episode of Care ID (EI)<br> 
 * GOL-6: Goal List Priority (NM)<br> 
 * GOL-7: Goal Established Date/Time (TS)<br> 
 * GOL-8: Expected Goal Achieve Date/Time (TS)<br> 
 * GOL-9: Goal Classification (CE)<br> 
 * GOL-10: Goal Management Discipline (CE)<br> 
 * GOL-11: Current Goal Review Status (CE)<br> 
 * GOL-12: Current Goal Review Date/Time (TS)<br> 
 * GOL-13: Next Goal Review Date/Time (TS)<br> 
 * GOL-14: Previous Goal Review Date/Time (TS)<br> 
 * GOL-15: Goal Review Interval (TQ)<br> 
 * GOL-16: Goal Evaluation (CE)<br> 
 * GOL-17: Goal Evaluation Comment (ST)<br> 
 * GOL-18: Goal Life Cycle Status (CE)<br> 
 * GOL-19: Goal Life Cycle Status Date/Time (TS)<br> 
 * GOL-20: Goal Target Type (CE)<br> 
 * GOL-21: Goal Target Name (XPN)<br> 
 * </p><p>The get...() methods return data from individual fields.  These methods 
 * do not throw exceptions and may therefore have to handle exceptions internally.  
 * If an exception is handled internally, it is logged and null is returned.  
 * This is not expected to happen - if it does happen this indicates not so much 
 * an exceptional circumstance as a bug in the code for this class.</p>    
 */
[Serializable]
public class GOL : AbstractSegment  {

  /**
   * Creates a GOL (Goal Detail) segment object that belongs to the given 
   * message.  
   */
  public GOL(Group parent, ModelClassFactory factory) : base(parent,factory) {
    Message message = Message;
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
        HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
    }
  }

	/**
	* Returns Action Code(GOL-1).
	*/
	public ID ActionCode
	{
		get{
			ID ret = null;
			try
			{
			Type t = this.getField(1, 0);
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
	* Returns Action Date/Time(GOL-2).
	*/
	public TS ActionDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(2, 0);
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
	* Returns Goal ID(GOL-3).
	*/
	public CE GoalID
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
	* Returns Goal Instance ID(GOL-4).
	*/
	public EI GoalInstanceID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(4, 0);
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
	* Returns Episode of Care ID(GOL-5).
	*/
	public EI EpisodeOfCareID
	{
		get{
			EI ret = null;
			try
			{
			Type t = this.getField(5, 0);
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
	* Returns Goal List Priority(GOL-6).
	*/
	public NM GoalListPriority
	{
		get{
			NM ret = null;
			try
			{
			Type t = this.getField(6, 0);
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
	* Returns Goal Established Date/Time(GOL-7).
	*/
	public TS GoalEstablishedDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(7, 0);
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
	* Returns Expected Goal Achieve Date/Time(GOL-8).
	*/
	public TS ExpectedGoalAchieveDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(8, 0);
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
	* Returns Goal Classification(GOL-9).
	*/
	public CE GoalClassification
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
	* Returns Goal Management Discipline(GOL-10).
	*/
	public CE GoalManagementDiscipline
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
	* Returns Current Goal Review Status(GOL-11).
	*/
	public CE CurrentGoalReviewStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(11, 0);
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
	* Returns Current Goal Review Date/Time(GOL-12).
	*/
	public TS CurrentGoalReviewDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(12, 0);
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
	* Returns Next Goal Review Date/Time(GOL-13).
	*/
	public TS NextGoalReviewDateTime
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
	* Returns Previous Goal Review Date/Time(GOL-14).
	*/
	public TS PreviousGoalReviewDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(14, 0);
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
	* Returns Goal Review Interval(GOL-15).
	*/
	public TQ GoalReviewInterval
	{
		get{
			TQ ret = null;
			try
			{
			Type t = this.getField(15, 0);
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

	/**
	* Returns Goal Evaluation(GOL-16).
	*/
	public CE GoalEvaluation
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
	* Returns a single repetition of Goal Evaluation Comment(GOL-17).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public ST getGoalEvaluationComment(int rep)
	{
			ST ret = null;
			try
			{
			Type t = this.getField(17, rep);
				ret = (ST)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Goal Evaluation Comment (GOL-17).
   */
  public ST[] getGoalEvaluationComment() {
     ST[] ret = null;
    try {
        Type[] t = this.getField(17);  
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
	* Returns Goal Life Cycle Status(GOL-18).
	*/
	public CE GoalLifeCycleStatus
	{
		get{
			CE ret = null;
			try
			{
			Type t = this.getField(18, 0);
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
	* Returns Goal Life Cycle Status Date/Time(GOL-19).
	*/
	public TS GoalLifeCycleStatusDateTime
	{
		get{
			TS ret = null;
			try
			{
			Type t = this.getField(19, 0);
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
	* Returns a single repetition of Goal Target Type(GOL-20).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public CE getGoalTargetType(int rep)
	{
			CE ret = null;
			try
			{
			Type t = this.getField(20, rep);
				ret = (CE)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Goal Target Type (GOL-20).
   */
  public CE[] getGoalTargetType() {
     CE[] ret = null;
    try {
        Type[] t = this.getField(20);  
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
	* Returns a single repetition of Goal Target Name(GOL-21).
	* @param rep the repetition number (this is a repeating field)
	* @throws HL7Exception if the repetition number is invalid.
	*/
	public XPN getGoalTargetName(int rep)
	{
			XPN ret = null;
			try
			{
			Type t = this.getField(21, rep);
				ret = (XPN)t;
		} catch (System.Exception ex) {
			HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  /**
   * Returns all repetitions of Goal Target Name (GOL-21).
   */
  public XPN[] getGoalTargetName() {
     XPN[] ret = null;
    try {
        Type[] t = this.getField(21);  
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