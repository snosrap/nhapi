using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 NTE message segment. 
    /// This segment has the following fields:
    /// * NTE-1: Set ID - Notes and Comments (SI)
    /// * NTE-2: Source of Comment (ID)
    /// * NTE-3: Comment (FT)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class NTE : AbstractSegment
    {

        /**
         * Creates a NTE (NOTES AND COMMENTS) segment object that belongs to the given 
         * message.  
         */
        public NTE(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), false, 1, 4, new System.Object[] { message }, "Set ID - Notes and Comments");
                this.add(typeof(ID), false, 1, 8, new System.Object[] { message, 105 }, "Source of Comment");
                this.add(typeof(FT), false, 0, 65536, new System.Object[] { message }, "Comment");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Set ID - Notes and Comments(NTE-1).
        ///</summary>
        public SI SetIDNotesAndComments
        {
            get
            {
                SI ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
                    ret = (SI)t;
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
        /// Returns Source of Comment(NTE-2).
        ///</summary>
        public ID SourceOfComment
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns a single repetition of Comment(NTE-3).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public FT getComment(int rep)
        {
            FT ret = null;
            try
            {
                IType t = this.GetField(3, rep);
                ret = (FT)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Comment (NTE-3).
        ///</summary>
        public FT[] getComment()
        {
            FT[] ret = null;
            try
            {
                IType[] t = this.GetField(3);
                ret = new FT[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (FT)t[i];
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