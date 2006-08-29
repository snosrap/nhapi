using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment
{

    ///<summary>
    /// Represents an HL7 IN1 message segment. 
    /// This segment has the following fields:
    /// * IN1-1: SET ID - INSURANCE (SI)
    /// * IN1-2: INSURANCE PLAN ID (ID)
    /// * IN1-3: INSURANCE COMPANY ID (ST)
    /// * IN1-4: INSURANCE COMPANY NAME (ST)
    /// * IN1-5: INSURANCE COMPANY ADDRESS (AD)
    /// * IN1-6: INSURANCE CO. CONTACT PERS (PN)
    /// * IN1-7: INSURANCE CO PHONE NUMBER (TN)
    /// * IN1-8: GROUP NUMBER (ST)
    /// * IN1-9: GROUP NAME (ST)
    /// * IN1-10: INSURED'S GROUP EMP. ID (ST)
    /// * IN1-11: INSURED'S GROUP EMP. NAME (ST)
    /// * IN1-12: PLAN EFFECTIVE DATE (DT)
    /// * IN1-13: PLAN EXPIRATION DATE (DT)
    /// * IN1-14: AUTHORIZATION INFORMATION (ST)
    /// * IN1-15: PLAN TYPE (ID)
    /// * IN1-16: NAME OF INSURED (PN)
    /// * IN1-17: INSURED'S RELATIONSHIP TO PATIENT (ID)
    /// * IN1-18: INSURED'S DATE OF BIRTH (DT)
    /// * IN1-19: INSURED'S ADDRESS (AD)
    /// * IN1-20: ASSIGNMENT OF BENEFITS (ID)
    /// * IN1-21: COORDINATION OF BENEFITS (ID)
    /// * IN1-22: COORD OF BEN. PRIORITY (ST)
    /// * IN1-23: NOTICE OF ADMISSION CODE (ID)
    /// * IN1-24: NOTICE OF ADMISSION DATE (DT)
    /// * IN1-25: RPT OF ELIGIBILITY CODE (ID)
    /// * IN1-26: RPT OF ELIGIBILITY DATE (DT)
    /// * IN1-27: RELEASE INFORMATION CODE (ID)
    /// * IN1-28: PRE-ADMIT CERT. (PAC) (ST)
    /// * IN1-29: VERIFICATION DATE (DT)
    /// * IN1-30: VERIFICATION BY (CM)
    /// * IN1-31: TYPE OF AGREEMENT CODE (ID)
    /// * IN1-32: BILLING STATUS (ID)
    /// * IN1-33: LIFETIME RESERVE DAYS (NM)
    /// * IN1-34: DELAY BEFORE L. R. DAY (NM)
    /// * IN1-35: COMPANY PLAN CODE (ST)
    /// * IN1-36: POLICY NUMBER (ST)
    /// * IN1-37: POLICY DEDUCTIBLE (NM)
    /// * IN1-38: POLICY LIMIT - AMOUNT (NM)
    /// * IN1-39: POLICY LIMIT - DAYS (NM)
    /// * IN1-40: ROOM RATE - SEMI-PRIVATE (NM)
    /// * IN1-41: ROOM RATE - PRIVATE (NM)
    /// * IN1-42: INSURED'S EMPLOYMENT STATUS (ID)
    /// * IN1-43: INSURED'S SEX (ID)
    /// * IN1-44: INSURED'S EMPLOYER ADDRESS (AD)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class IN1 : AbstractSegment
    {

        /**
         * Creates a IN1 (INSURANCE) segment object that belongs to the given 
         * message.  
         */
        public IN1(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), true, 1, 4, new System.Object[] { message }, "SET ID - INSURANCE");
                this.add(typeof(ID), true, 1, 8, new System.Object[] { message, 72 }, "INSURANCE PLAN ID");
                this.add(typeof(ST), true, 1, 6, new System.Object[] { message }, "INSURANCE COMPANY ID");
                this.add(typeof(ST), false, 1, 45, new System.Object[] { message }, "INSURANCE COMPANY NAME");
                this.add(typeof(AD), false, 1, 106, new System.Object[] { message }, "INSURANCE COMPANY ADDRESS");
                this.add(typeof(PN), false, 1, 48, new System.Object[] { message }, "INSURANCE CO. CONTACT PERS");
                this.add(typeof(TN), false, 1, 40, new System.Object[] { message }, "INSURANCE CO PHONE NUMBER");
                this.add(typeof(ST), false, 1, 12, new System.Object[] { message }, "GROUP NUMBER");
                this.add(typeof(ST), false, 1, 35, new System.Object[] { message }, "GROUP NAME");
                this.add(typeof(ST), false, 1, 12, new System.Object[] { message }, "INSURED'S GROUP EMP. ID");
                this.add(typeof(ST), false, 1, 45, new System.Object[] { message }, "INSURED'S GROUP EMP. NAME");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "PLAN EFFECTIVE DATE");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "PLAN EXPIRATION DATE");
                this.add(typeof(ST), false, 1, 55, new System.Object[] { message }, "AUTHORIZATION INFORMATION");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 86 }, "PLAN TYPE");
                this.add(typeof(PN), false, 1, 48, new System.Object[] { message }, "NAME OF INSURED");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 63 }, "INSURED'S RELATIONSHIP TO PATIENT");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "INSURED'S DATE OF BIRTH");
                this.add(typeof(AD), false, 1, 106, new System.Object[] { message }, "INSURED'S ADDRESS");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 0 }, "ASSIGNMENT OF BENEFITS");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 0 }, "COORDINATION OF BENEFITS");
                this.add(typeof(ST), false, 1, 2, new System.Object[] { message }, "COORD OF BEN. PRIORITY");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 81 }, "NOTICE OF ADMISSION CODE");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "NOTICE OF ADMISSION DATE");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 94 }, "RPT OF ELIGIBILITY CODE");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "RPT OF ELIGIBILITY DATE");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 93 }, "RELEASE INFORMATION CODE");
                this.add(typeof(ST), false, 1, 15, new System.Object[] { message }, "PRE-ADMIT CERT. (PAC)");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "VERIFICATION DATE");
                this.add(typeof(CM), false, 1, 60, new System.Object[] { message }, "VERIFICATION BY");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 98 }, "TYPE OF AGREEMENT CODE");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 22 }, "BILLING STATUS");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "LIFETIME RESERVE DAYS");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "DELAY BEFORE L. R. DAY");
                this.add(typeof(ST), false, 1, 8, new System.Object[] { message }, "COMPANY PLAN CODE");
                this.add(typeof(ST), false, 1, 15, new System.Object[] { message }, "POLICY NUMBER");
                this.add(typeof(NM), false, 1, 12, new System.Object[] { message }, "POLICY DEDUCTIBLE");
                this.add(typeof(NM), false, 1, 12, new System.Object[] { message }, "POLICY LIMIT - AMOUNT");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "POLICY LIMIT - DAYS");
                this.add(typeof(NM), false, 1, 12, new System.Object[] { message }, "ROOM RATE - SEMI-PRIVATE");
                this.add(typeof(NM), false, 1, 12, new System.Object[] { message }, "ROOM RATE - PRIVATE");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 66 }, "INSURED'S EMPLOYMENT STATUS");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 1 }, "INSURED'S SEX");
                this.add(typeof(AD), false, 1, 106, new System.Object[] { message }, "INSURED'S EMPLOYER ADDRESS");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns SET ID - INSURANCE(IN1-1).
        ///</summary>
        public SI SETIDINSURANCE
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
        /// Returns INSURANCE PLAN ID(IN1-2).
        ///</summary>
        public ID INSURANCEPLANID
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
        /// Returns INSURANCE COMPANY ID(IN1-3).
        ///</summary>
        public ST INSURANCECOMPANYID
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns INSURANCE COMPANY NAME(IN1-4).
        ///</summary>
        public ST INSURANCECOMPANYNAME
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
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
        /// Returns INSURANCE COMPANY ADDRESS(IN1-5).
        ///</summary>
        public AD INSURANCECOMPANYADDRESS
        {
            get
            {
                AD ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
                    ret = (AD)t;
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
        /// Returns INSURANCE CO. CONTACT PERS(IN1-6).
        ///</summary>
        public PN INSURANCECOCONTACTPERS
        {
            get
            {
                PN ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
                    ret = (PN)t;
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
        /// Returns INSURANCE CO PHONE NUMBER(IN1-7).
        ///</summary>
        public TN INSURANCECOPHONENUMBER
        {
            get
            {
                TN ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
                    ret = (TN)t;
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
        /// Returns GROUP NUMBER(IN1-8).
        ///</summary>
        public ST GROUPNUMBER
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns GROUP NAME(IN1-9).
        ///</summary>
        public ST GROUPNAME
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
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
        /// Returns INSURED'S GROUP EMP. ID(IN1-10).
        ///</summary>
        public ST INSUREDSGROUPEMPID
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
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
        /// Returns INSURED'S GROUP EMP. NAME(IN1-11).
        ///</summary>
        public ST INSUREDSGROUPEMPNAME
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns PLAN EFFECTIVE DATE(IN1-12).
        ///</summary>
        public DT PLANEFFECTIVEDATE
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
                    ret = (DT)t;
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
        /// Returns PLAN EXPIRATION DATE(IN1-13).
        ///</summary>
        public DT PLANEXPIRATIONDATE
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(13, 0);
                    ret = (DT)t;
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
        /// Returns AUTHORIZATION INFORMATION(IN1-14).
        ///</summary>
        public ST AUTHORIZATIONINFORMATION
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(14, 0);
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
        /// Returns PLAN TYPE(IN1-15).
        ///</summary>
        public ID PLANTYPE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(15, 0);
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
        /// Returns NAME OF INSURED(IN1-16).
        ///</summary>
        public PN NAMEOFINSURED
        {
            get
            {
                PN ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
                    ret = (PN)t;
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
        /// Returns INSURED'S RELATIONSHIP TO PATIENT(IN1-17).
        ///</summary>
        public ID INSUREDSRELATIONSHIPTOPATIENT
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(17, 0);
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
        /// Returns INSURED'S DATE OF BIRTH(IN1-18).
        ///</summary>
        public DT INSUREDSDATEOFBIRTH
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
                    ret = (DT)t;
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
        /// Returns INSURED'S ADDRESS(IN1-19).
        ///</summary>
        public AD INSUREDSADDRESS
        {
            get
            {
                AD ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
                    ret = (AD)t;
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
        /// Returns ASSIGNMENT OF BENEFITS(IN1-20).
        ///</summary>
        public ID ASSIGNMENTOFBENEFITS
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(20, 0);
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
        /// Returns COORDINATION OF BENEFITS(IN1-21).
        ///</summary>
        public ID COORDINATIONOFBENEFITS
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(21, 0);
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
        /// Returns COORD OF BEN. PRIORITY(IN1-22).
        ///</summary>
        public ST COORDOFBENPRIORITY
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
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
        /// Returns NOTICE OF ADMISSION CODE(IN1-23).
        ///</summary>
        public ID NOTICEOFADMISSIONCODE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(23, 0);
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
        /// Returns NOTICE OF ADMISSION DATE(IN1-24).
        ///</summary>
        public DT NOTICEOFADMISSIONDATE
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(24, 0);
                    ret = (DT)t;
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
        /// Returns RPT OF ELIGIBILITY CODE(IN1-25).
        ///</summary>
        public ID RPTOFELIGIBILITYCODE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(25, 0);
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
        /// Returns RPT OF ELIGIBILITY DATE(IN1-26).
        ///</summary>
        public DT RPTOFELIGIBILITYDATE
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(26, 0);
                    ret = (DT)t;
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
        /// Returns RELEASE INFORMATION CODE(IN1-27).
        ///</summary>
        public ID RELEASEINFORMATIONCODE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(27, 0);
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
        /// Returns PRE-ADMIT CERT. (PAC)(IN1-28).
        ///</summary>
        public ST PREADMITCERT
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(28, 0);
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
        /// Returns VERIFICATION DATE(IN1-29).
        ///</summary>
        public DT VERIFICATIONDATE
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(29, 0);
                    ret = (DT)t;
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
        /// Returns VERIFICATION BY(IN1-30).
        ///</summary>
        public CM VERIFICATIONBY
        {
            get
            {
                CM ret = null;
                try
                {
                    IType t = this.GetField(30, 0);
                    ret = (CM)t;
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
        /// Returns TYPE OF AGREEMENT CODE(IN1-31).
        ///</summary>
        public ID TYPEOFAGREEMENTCODE
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(31, 0);
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
        /// Returns BILLING STATUS(IN1-32).
        ///</summary>
        public ID BILLINGSTATUS
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(32, 0);
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
        /// Returns LIFETIME RESERVE DAYS(IN1-33).
        ///</summary>
        public NM LIFETIMERESERVEDAYS
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(33, 0);
                    ret = (NM)t;
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
        /// Returns DELAY BEFORE L. R. DAY(IN1-34).
        ///</summary>
        public NM DELAYBEFORELRDAY
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(34, 0);
                    ret = (NM)t;
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
        /// Returns COMPANY PLAN CODE(IN1-35).
        ///</summary>
        public ST COMPANYPLANCODE
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(35, 0);
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
        /// Returns POLICY NUMBER(IN1-36).
        ///</summary>
        public ST POLICYNUMBER
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(36, 0);
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
        /// Returns POLICY DEDUCTIBLE(IN1-37).
        ///</summary>
        public NM POLICYDEDUCTIBLE
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(37, 0);
                    ret = (NM)t;
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
        /// Returns POLICY LIMIT - AMOUNT(IN1-38).
        ///</summary>
        public NM POLICYLIMITAMOUNT
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(38, 0);
                    ret = (NM)t;
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
        /// Returns POLICY LIMIT - DAYS(IN1-39).
        ///</summary>
        public NM POLICYLIMITDAYS
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(39, 0);
                    ret = (NM)t;
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
        /// Returns ROOM RATE - SEMI-PRIVATE(IN1-40).
        ///</summary>
        public NM ROOMRATESEMIPRIVATE
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(40, 0);
                    ret = (NM)t;
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
        /// Returns ROOM RATE - PRIVATE(IN1-41).
        ///</summary>
        public NM ROOMRATEPRIVATE
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(41, 0);
                    ret = (NM)t;
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
        /// Returns INSURED'S EMPLOYMENT STATUS(IN1-42).
        ///</summary>
        public ID INSUREDSEMPLOYMENTSTATUS
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(42, 0);
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
        /// Returns INSURED'S SEX(IN1-43).
        ///</summary>
        public ID INSUREDSSEX
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(43, 0);
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
        /// Returns INSURED'S EMPLOYER ADDRESS(IN1-44).
        ///</summary>
        public AD INSUREDSEMPLOYERADDRESS
        {
            get
            {
                AD ret = null;
                try
                {
                    IType t = this.GetField(44, 0);
                    ret = (AD)t;
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


    }
}