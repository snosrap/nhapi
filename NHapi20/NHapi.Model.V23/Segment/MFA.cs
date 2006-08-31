using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 MFA message segment. 
    /// This segment has the following fields:
    /// * MFA-1: Record-Level Event Code (ID)
    /// * MFA-2: MFN Control ID (ST)
    /// * MFA-3: Event Completion Date/Time (TS)
    /// * MFA-4: Error Return Code and/or Text (CE)
    /// * MFA-5: Primary Key Value (CE)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class MFA : AbstractSegment
    {

        /**
         * Creates a MFA (Master file acknowledgement segment) segment object that belongs to the given 
         * message.  
         */
        public MFA(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ID), true, 1, 3, new System.Object[] { message, 180 }, "Record-Level Event Code");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "MFN Control ID");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Event Completion Date/Time");
                this.add(typeof(CE), true, 1, 60, new System.Object[] { message }, "Error Return Code and/or Text");
                this.add(typeof(CE), true, 0, 60, new System.Object[] { message }, "Primary Key Value");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Record-Level Event Code(MFA-1).
        ///</summary>
        public ID RecordLevelEventCode
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
                    ret = (ID)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns MFN Control ID(MFA-2).
        ///</summary>
        public ST MFNControlID
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
                    ret = (ST)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Event Completion Date/Time(MFA-3).
        ///</summary>
        public TS EventCompletionDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (TS)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns Error Return Code and/or Text(MFA-4).
        ///</summary>
        public CE ErrorReturnCodeAndOrText
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
                    ret = (CE)t;
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new System.Exception("An unexpected error ocurred", he);
                }
                catch (System.Exception ex)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new System.Exception("An unexpected error ocurred", ex);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns a single repetition of Primary Key Value(MFA-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getPrimaryKeyValue(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(5, rep);
                ret = (CE)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Primary Key Value (MFA-5).
        ///</summary>
        public CE[] getPrimaryKeyValue()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(5);
                ret = new CE[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CE)t[i];
                }
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new System.Exception("An unexpected error ocurred", he);
            }
            catch (System.Exception cce)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
                throw new System.Exception("An unexpected error ocurred", cce);
            }
            return ret;
        }


    }
}