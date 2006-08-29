using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 QRF message segment. 
    /// This segment has the following fields:
    /// * QRF-1: Where Subject Filter (ST)
    /// * QRF-2: When data start date / time (TS)
    /// * QRF-3: When data end date / time (TS)
    /// * QRF-4: What User Qualifier (ST)
    /// * QRF-5: Other QRY Subject Filter (ST)
    /// * QRF-6: Which date / time qualifier (ID)
    /// * QRF-7: Which date / time status qualifier (ID)
    /// * QRF-8: Date / time selection qualifier (ID)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class QRF : AbstractSegment
    {

        /**
         * Creates a QRF (QUERY FILTER) segment object that belongs to the given 
         * message.  
         */
        public QRF(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), true, 0, 20, new System.Object[] { message }, "Where Subject Filter");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "When data start date / time");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "When data end date / time");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "What User Qualifier");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "Other QRY Subject Filter");
                this.add(typeof(ID), false, 0, 12, new System.Object[] { message, 156 }, "Which date / time qualifier");
                this.add(typeof(ID), false, 0, 12, new System.Object[] { message, 157 }, "Which date / time status qualifier");
                this.add(typeof(ID), false, 0, 12, new System.Object[] { message, 158 }, "Date / time selection qualifier");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns a single repetition of Where Subject Filter(QRF-1).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getWhereSubjectFilter(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(1, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Where Subject Filter (QRF-1).
        ///</summary>
        public ST[] getWhereSubjectFilter()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(1);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
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

        ///<summary>
        /// Returns When data start date / time(QRF-2).
        ///</summary>
        public TS WhenDataStartDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns When data end date / time(QRF-3).
        ///</summary>
        public TS WhenDataEndDateTime
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
        /// Returns a single repetition of What User Qualifier(QRF-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getWhatUserQualifier(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(4, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of What User Qualifier (QRF-4).
        ///</summary>
        public ST[] getWhatUserQualifier()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(4);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
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

        ///<summary>
        /// Returns a single repetition of Other QRY Subject Filter(QRF-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getOtherQRYSubjectFilter(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(5, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Other QRY Subject Filter (QRF-5).
        ///</summary>
        public ST[] getOtherQRYSubjectFilter()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(5);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
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

        ///<summary>
        /// Returns a single repetition of Which date / time qualifier(QRF-6).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getWhichDateTimeQualifier(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(6, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Which date / time qualifier (QRF-6).
        ///</summary>
        public ID[] getWhichDateTimeQualifier()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(6);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
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

        ///<summary>
        /// Returns a single repetition of Which date / time status qualifier(QRF-7).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getWhichDateTimeStatusQualifier(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(7, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Which date / time status qualifier (QRF-7).
        ///</summary>
        public ID[] getWhichDateTimeStatusQualifier()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(7);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
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

        ///<summary>
        /// Returns a single repetition of Date / time selection qualifier(QRF-8).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getDateTimeSelectionQualifier(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(8, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Date / time selection qualifier (QRF-8).
        ///</summary>
        public ID[] getDateTimeSelectionQualifier()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(8);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
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