using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 PSH message segment. 
    /// This segment has the following fields:
    /// * PSH-1: Report Type (ST)
    /// * PSH-2: Report Form Identifier (ST)
    /// * PSH-3: Report Date (TS)
    /// * PSH-4: Report Interval Start Date (TS)
    /// * PSH-5: Report Interval End Date (TS)
    /// * PSH-6: Quantity Manufactured (CQ)
    /// * PSH-7: Quantity Distributed (CQ)
    /// * PSH-8: Quantity Distributed Method (ID)
    /// * PSH-9: Quantity Distributed Comment (FT)
    /// * PSH-10: Quantity in Use (CQ)
    /// * PSH-11: Quantity in Use Method (ID)
    /// * PSH-12: Quantity in Use Comment (FT)
    /// * PSH-13: Number of Product Experience Reports Filed by Facility (NM)
    /// * PSH-14: Number of Product Experience Reports Filed by Distributor (NM)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class PSH : AbstractSegment
    {

        /**
         * Creates a PSH (Product Summary Header) segment object that belongs to the given 
         * message.  
         */
        public PSH(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), true, 1, 60, new System.Object[] { message }, "Report Type");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Report Form Identifier");
                this.add(typeof(TS), true, 1, 26, new System.Object[] { message }, "Report Date");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Report Interval Start Date");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Report Interval End Date");
                this.add(typeof(CQ), false, 1, 12, new System.Object[] { message }, "Quantity Manufactured");
                this.add(typeof(CQ), false, 1, 12, new System.Object[] { message }, "Quantity Distributed");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 329 }, "Quantity Distributed Method");
                this.add(typeof(FT), false, 1, 600, new System.Object[] { message }, "Quantity Distributed Comment");
                this.add(typeof(CQ), false, 1, 12, new System.Object[] { message }, "Quantity in Use");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 329 }, "Quantity in Use Method");
                this.add(typeof(FT), false, 1, 600, new System.Object[] { message }, "Quantity in Use Comment");
                this.add(typeof(NM), false, 8, 2, new System.Object[] { message }, "Number of Product Experience Reports Filed by Facility");
                this.add(typeof(NM), false, 8, 2, new System.Object[] { message }, "Number of Product Experience Reports Filed by Distributor");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Report Type(PSH-1).
        ///</summary>
        public ST ReportType
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns Report Form Identifier(PSH-2).
        ///</summary>
        public ST ReportFormIdentifier
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
        /// Returns Report Date(PSH-3).
        ///</summary>
        public TS ReportDate
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
        /// Returns Report Interval Start Date(PSH-4).
        ///</summary>
        public TS ReportIntervalStartDate
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
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
        /// Returns Report Interval End Date(PSH-5).
        ///</summary>
        public TS ReportIntervalEndDate
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
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
        /// Returns Quantity Manufactured(PSH-6).
        ///</summary>
        public CQ QuantityManufactured
        {
            get
            {
                CQ ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
                    ret = (CQ)t;
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
        /// Returns Quantity Distributed(PSH-7).
        ///</summary>
        public CQ QuantityDistributed
        {
            get
            {
                CQ ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
                    ret = (CQ)t;
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
        /// Returns Quantity Distributed Method(PSH-8).
        ///</summary>
        public ID QuantityDistributedMethod
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns Quantity Distributed Comment(PSH-9).
        ///</summary>
        public FT QuantityDistributedComment
        {
            get
            {
                FT ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
                    ret = (FT)t;
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
        /// Returns Quantity in Use(PSH-10).
        ///</summary>
        public CQ QuantityInUse
        {
            get
            {
                CQ ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
                    ret = (CQ)t;
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
        /// Returns Quantity in Use Method(PSH-11).
        ///</summary>
        public ID QuantityInUseMethod
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns Quantity in Use Comment(PSH-12).
        ///</summary>
        public FT QuantityInUseComment
        {
            get
            {
                FT ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
                    ret = (FT)t;
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
        /// Returns a single repetition of Number of Product Experience Reports Filed by Facility(PSH-13).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public NM getNumberOfProductExperienceReportsFiledByFacility(int rep)
        {
            NM ret = null;
            try
            {
                IType t = this.GetField(13, rep);
                ret = (NM)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Number of Product Experience Reports Filed by Facility (PSH-13).
        ///</summary>
        public NM[] getNumberOfProductExperienceReportsFiledByFacility()
        {
            NM[] ret = null;
            try
            {
                IType[] t = this.GetField(13);
                ret = new NM[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (NM)t[i];
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
        /// Returns a single repetition of Number of Product Experience Reports Filed by Distributor(PSH-14).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public NM getNumberOfProductExperienceReportsFiledByDistributor(int rep)
        {
            NM ret = null;
            try
            {
                IType t = this.GetField(14, rep);
                ret = (NM)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Number of Product Experience Reports Filed by Distributor (PSH-14).
        ///</summary>
        public NM[] getNumberOfProductExperienceReportsFiledByDistributor()
        {
            NM[] ret = null;
            try
            {
                IType[] t = this.GetField(14);
                ret = new NM[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (NM)t[i];
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