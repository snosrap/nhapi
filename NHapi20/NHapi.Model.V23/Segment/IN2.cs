using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 IN2 message segment. 
    /// This segment has the following fields:
    /// * IN2-1: Insured's Employee ID (CX)
    /// * IN2-2: Insured's Social Security Number (ST)
    /// * IN2-3: Insured's Employer Name (XCN)
    /// * IN2-4: Employer Information Data (IS)
    /// * IN2-5: Mail Claim Party (IS)
    /// * IN2-6: Medicare Health Ins Card Number (ST)
    /// * IN2-7: Medicaid Case Name (XPN)
    /// * IN2-8: Medicaid Case Number (ST)
    /// * IN2-9: Champus Sponsor Name (XPN)
    /// * IN2-10: Champus ID Number (ST)
    /// * IN2-11: Dependent of Champus Recipient (CE)
    /// * IN2-12: Champus Organization (ST)
    /// * IN2-13: Champus Station (ST)
    /// * IN2-14: Champus Service (IS)
    /// * IN2-15: Champus Rank/Grade (IS)
    /// * IN2-16: Champus Status (IS)
    /// * IN2-17: Champus Retire Date (DT)
    /// * IN2-18: Champus Non-Avail Cert on File (ID)
    /// * IN2-19: Baby Coverage (ID)
    /// * IN2-20: Combine Baby Bill (ID)
    /// * IN2-21: Blood Deductible (ST)
    /// * IN2-22: Special Coverage Approval Name (XPN)
    /// * IN2-23: Special Coverage Approval Title (ST)
    /// * IN2-24: Non-Covered Insurance Code (ST)
    /// * IN2-25: Payor ID (CX)
    /// * IN2-26: Payor Subscriber ID (CX)
    /// * IN2-27: Eligibility Source (IS)
    /// * IN2-28: Room Coverage Type/Amount (CM_RMC)
    /// * IN2-29: Policy Type/Amount (CM_PTA)
    /// * IN2-30: Daily Deductible (CM_DDI)
    /// * IN2-31: Living Dependency (IS)
    /// * IN2-32: Ambulatory Status (IS)
    /// * IN2-33: Citizenship (IS)
    /// * IN2-34: Primary Language (CE)
    /// * IN2-35: Living Arrangement (IS)
    /// * IN2-36: Publicity Indicator (CE)
    /// * IN2-37: Protection Indicator (ID)
    /// * IN2-38: Student Indicator (IS)
    /// * IN2-39: Religion (IS)
    /// * IN2-40: Mother’s Maiden Name (XPN)
    /// * IN2-41: Nationality Code (CE)
    /// * IN2-42: Ethnic Group (IS)
    /// * IN2-43: Marital Status (IS)
    /// * IN2-44: Employment Start Date (DT)
    /// * IN2-45: Employment Stop Date (DT)
    /// * IN2-46: Job Title (ST)
    /// * IN2-47: Job Code/Class (JCC)
    /// * IN2-48: Job Status (IS)
    /// * IN2-49: Employer Contact Person Name (XPN)
    /// * IN2-50: Employer Contact Person Phone Number (XTN)
    /// * IN2-51: Employer Contact Reason (IS)
    /// * IN2-52: Insured’s Contact Person’s Name (XPN)
    /// * IN2-53: Insured’s Contact Person Telephone Number (XTN)
    /// * IN2-54: Insured’s Contact Person Reason (IS)
    /// * IN2-55: Relationship To The Patient Start Date (DT)
    /// * IN2-56: Relationship To The Patient Stop Date (DT)
    /// * IN2-57: Insurance Co. Contact Reason (IS)
    /// * IN2-58: Insurance Co. Contact Phone Number (XTN)
    /// * IN2-59: Policy Scope (IS)
    /// * IN2-60: Policy Source (IS)
    /// * IN2-61: Patient Member Number (CX)
    /// * IN2-62: Guarantor’s Relationship To Insured (IS)
    /// * IN2-63: Insured’s Telephone Number - Home (XTN)
    /// * IN2-64: Insured’s Employer Telephone Number (XTN)
    /// * IN2-65: Military Handicapped Program (CE)
    /// * IN2-66: Suspend Flag (ID)
    /// * IN2-67: Co-pay Limit Flag (ID)
    /// * IN2-68: Stoploss Limit Flag (ID)
    /// * IN2-69: Insured Organization Name And ID (XON)
    /// * IN2-70: Insured Employer Organization Name And ID (XON)
    /// * IN2-71: Race (IS)
    /// * IN2-72: Patient Relationship to Insured (ID)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class IN2 : AbstractSegment
    {

        /**
         * Creates a IN2 (Insurance additional info) segment object that belongs to the given 
         * message.  
         */
        public IN2(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(CX), false, 1, 59, new System.Object[] { message }, "Insured's Employee ID");
                this.add(typeof(ST), false, 1, 11, new System.Object[] { message }, "Insured's Social Security Number");
                this.add(typeof(XCN), false, 1, 130, new System.Object[] { message }, "Insured's Employer Name");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 139 }, "Employer Information Data");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 137 }, "Mail Claim Party");
                this.add(typeof(ST), false, 1, 15, new System.Object[] { message }, "Medicare Health Ins Card Number");
                this.add(typeof(XPN), false, 1, 48, new System.Object[] { message }, "Medicaid Case Name");
                this.add(typeof(ST), false, 1, 15, new System.Object[] { message }, "Medicaid Case Number");
                this.add(typeof(XPN), false, 1, 48, new System.Object[] { message }, "Champus Sponsor Name");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "Champus ID Number");
                this.add(typeof(CE), false, 1, 80, new System.Object[] { message }, "Dependent of Champus Recipient");
                this.add(typeof(ST), false, 1, 25, new System.Object[] { message }, "Champus Organization");
                this.add(typeof(ST), false, 1, 25, new System.Object[] { message }, "Champus Station");
                this.add(typeof(IS), false, 1, 14, new System.Object[] { message, 140 }, "Champus Service");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 141 }, "Champus Rank/Grade");
                this.add(typeof(IS), false, 1, 3, new System.Object[] { message, 142 }, "Champus Status");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Champus Retire Date");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Champus Non-Avail Cert on File");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Baby Coverage");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Combine Baby Bill");
                this.add(typeof(ST), false, 1, 1, new System.Object[] { message }, "Blood Deductible");
                this.add(typeof(XPN), false, 1, 48, new System.Object[] { message }, "Special Coverage Approval Name");
                this.add(typeof(ST), false, 1, 30, new System.Object[] { message }, "Special Coverage Approval Title");
                this.add(typeof(ST), false, 0, 8, new System.Object[] { message }, "Non-Covered Insurance Code");
                this.add(typeof(CX), false, 1, 59, new System.Object[] { message }, "Payor ID");
                this.add(typeof(CX), false, 1, 59, new System.Object[] { message }, "Payor Subscriber ID");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 144 }, "Eligibility Source");
                this.add(typeof(CM_RMC), false, 0, 25, new System.Object[] { message }, "Room Coverage Type/Amount");
                this.add(typeof(CM_PTA), false, 0, 25, new System.Object[] { message }, "Policy Type/Amount");
                this.add(typeof(CM_DDI), false, 1, 25, new System.Object[] { message }, "Daily Deductible");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 223 }, "Living Dependency");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 9 }, "Ambulatory Status");
                this.add(typeof(IS), false, 1, 4, new System.Object[] { message, 171 }, "Citizenship");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Primary Language");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 220 }, "Living Arrangement");
                this.add(typeof(CE), false, 1, 1, new System.Object[] { message }, "Publicity Indicator");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Protection Indicator");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 231 }, "Student Indicator");
                this.add(typeof(IS), false, 1, 3, new System.Object[] { message, 6 }, "Religion");
                this.add(typeof(XPN), false, 1, 48, new System.Object[] { message }, "Mother’s Maiden Name");
                this.add(typeof(CE), false, 1, 80, new System.Object[] { message }, "Nationality Code");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 189 }, "Ethnic Group");
                this.add(typeof(IS), false, 0, 1, new System.Object[] { message, 2 }, "Marital Status");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Employment Start Date");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Employment Stop Date");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "Job Title");
                this.add(typeof(JCC), false, 1, 20, new System.Object[] { message }, "Job Code/Class");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 311 }, "Job Status");
                this.add(typeof(XPN), false, 0, 48, new System.Object[] { message }, "Employer Contact Person Name");
                this.add(typeof(XTN), false, 0, 40, new System.Object[] { message }, "Employer Contact Person Phone Number");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 222 }, "Employer Contact Reason");
                this.add(typeof(XPN), false, 0, 48, new System.Object[] { message }, "Insured’s Contact Person’s Name");
                this.add(typeof(XTN), false, 0, 40, new System.Object[] { message }, "Insured’s Contact Person Telephone Number");
                this.add(typeof(IS), false, 0, 2, new System.Object[] { message, 222 }, "Insured’s Contact Person Reason");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Relationship To The Patient Start Date");
                this.add(typeof(DT), false, 0, 8, new System.Object[] { message }, "Relationship To The Patient Stop Date");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 232 }, "Insurance Co. Contact Reason");
                this.add(typeof(XTN), false, 1, 40, new System.Object[] { message }, "Insurance Co. Contact Phone Number");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 312 }, "Policy Scope");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 313 }, "Policy Source");
                this.add(typeof(CX), false, 1, 60, new System.Object[] { message }, "Patient Member Number");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 63 }, "Guarantor’s Relationship To Insured");
                this.add(typeof(XTN), false, 0, 40, new System.Object[] { message }, "Insured’s Telephone Number - Home");
                this.add(typeof(XTN), false, 0, 40, new System.Object[] { message }, "Insured’s Employer Telephone Number");
                this.add(typeof(CE), false, 1, 2, new System.Object[] { message }, "Military Handicapped Program");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 136 }, "Suspend Flag");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 136 }, "Co-pay Limit Flag");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 136 }, "Stoploss Limit Flag");
                this.add(typeof(XON), false, 0, 130, new System.Object[] { message }, "Insured Organization Name And ID");
                this.add(typeof(XON), false, 0, 130, new System.Object[] { message }, "Insured Employer Organization Name And ID");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 5 }, "Race");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 0 }, "Patient Relationship to Insured");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Insured's Employee ID(IN2-1).
        ///</summary>
        public CX InsuredSEmployeeID
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
                    ret = (CX)t;
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
        /// Returns Insured's Social Security Number(IN2-2).
        ///</summary>
        public ST InsuredSSocialSecurityNumber
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
        /// Returns Insured's Employer Name(IN2-3).
        ///</summary>
        public XCN InsuredSEmployerName
        {
            get
            {
                XCN ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (XCN)t;
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
        /// Returns Employer Information Data(IN2-4).
        ///</summary>
        public IS EmployerInformationData
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
                    ret = (IS)t;
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
        /// Returns Mail Claim Party(IN2-5).
        ///</summary>
        public IS MailClaimParty
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
                    ret = (IS)t;
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
        /// Returns Medicare Health Ins Card Number(IN2-6).
        ///</summary>
        public ST MedicareHealthInsCardNumber
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns Medicaid Case Name(IN2-7).
        ///</summary>
        public XPN MedicaidCaseName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
                    ret = (XPN)t;
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
        /// Returns Medicaid Case Number(IN2-8).
        ///</summary>
        public ST MedicaidCaseNumber
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
        /// Returns Champus Sponsor Name(IN2-9).
        ///</summary>
        public XPN ChampusSponsorName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
                    ret = (XPN)t;
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
        /// Returns Champus ID Number(IN2-10).
        ///</summary>
        public ST ChampusIDNumber
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
        /// Returns Dependent of Champus Recipient(IN2-11).
        ///</summary>
        public CE DependentOfChampusRecipient
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns Champus Organization(IN2-12).
        ///</summary>
        public ST ChampusOrganization
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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
        /// Returns Champus Station(IN2-13).
        ///</summary>
        public ST ChampusStation
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(13, 0);
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
        /// Returns Champus Service(IN2-14).
        ///</summary>
        public IS ChampusService
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(14, 0);
                    ret = (IS)t;
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
        /// Returns Champus Rank/Grade(IN2-15).
        ///</summary>
        public IS ChampusRankGrade
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(15, 0);
                    ret = (IS)t;
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
        /// Returns Champus Status(IN2-16).
        ///</summary>
        public IS ChampusStatus
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
                    ret = (IS)t;
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
        /// Returns Champus Retire Date(IN2-17).
        ///</summary>
        public DT ChampusRetireDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(17, 0);
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
        /// Returns Champus Non-Avail Cert on File(IN2-18).
        ///</summary>
        public ID ChampusNonAvailCertOnFile
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
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
        /// Returns Baby Coverage(IN2-19).
        ///</summary>
        public ID BabyCoverage
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
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
        /// Returns Combine Baby Bill(IN2-20).
        ///</summary>
        public ID CombineBabyBill
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
        /// Returns Blood Deductible(IN2-21).
        ///</summary>
        public ST BloodDeductible
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(21, 0);
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
        /// Returns Special Coverage Approval Name(IN2-22).
        ///</summary>
        public XPN SpecialCoverageApprovalName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
                    ret = (XPN)t;
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
        /// Returns Special Coverage Approval Title(IN2-23).
        ///</summary>
        public ST SpecialCoverageApprovalTitle
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(23, 0);
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
        /// Returns a single repetition of Non-Covered Insurance Code(IN2-24).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getNonCoveredInsuranceCode(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(24, rep);
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
        /// Returns all repetitions of Non-Covered Insurance Code (IN2-24).
        ///</summary>
        public ST[] getNonCoveredInsuranceCode()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(24);
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
        /// Returns Payor ID(IN2-25).
        ///</summary>
        public CX PayorID
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(25, 0);
                    ret = (CX)t;
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
        /// Returns Payor Subscriber ID(IN2-26).
        ///</summary>
        public CX PayorSubscriberID
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(26, 0);
                    ret = (CX)t;
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
        /// Returns Eligibility Source(IN2-27).
        ///</summary>
        public IS EligibilitySource
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(27, 0);
                    ret = (IS)t;
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
        /// Returns a single repetition of Room Coverage Type/Amount(IN2-28).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_RMC getRoomCoverageTypeAmount(int rep)
        {
            CM_RMC ret = null;
            try
            {
                IType t = this.GetField(28, rep);
                ret = (CM_RMC)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Room Coverage Type/Amount (IN2-28).
        ///</summary>
        public CM_RMC[] getRoomCoverageTypeAmount()
        {
            CM_RMC[] ret = null;
            try
            {
                IType[] t = this.GetField(28);
                ret = new CM_RMC[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_RMC)t[i];
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
        /// Returns a single repetition of Policy Type/Amount(IN2-29).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_PTA getPolicyTypeAmount(int rep)
        {
            CM_PTA ret = null;
            try
            {
                IType t = this.GetField(29, rep);
                ret = (CM_PTA)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Policy Type/Amount (IN2-29).
        ///</summary>
        public CM_PTA[] getPolicyTypeAmount()
        {
            CM_PTA[] ret = null;
            try
            {
                IType[] t = this.GetField(29);
                ret = new CM_PTA[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_PTA)t[i];
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
        /// Returns Daily Deductible(IN2-30).
        ///</summary>
        public CM_DDI DailyDeductible
        {
            get
            {
                CM_DDI ret = null;
                try
                {
                    IType t = this.GetField(30, 0);
                    ret = (CM_DDI)t;
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
        /// Returns Living Dependency(IN2-31).
        ///</summary>
        public IS LivingDependency
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(31, 0);
                    ret = (IS)t;
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
        /// Returns Ambulatory Status(IN2-32).
        ///</summary>
        public IS AmbulatoryStatus
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(32, 0);
                    ret = (IS)t;
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
        /// Returns Citizenship(IN2-33).
        ///</summary>
        public IS Citizenship
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(33, 0);
                    ret = (IS)t;
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
        /// Returns Primary Language(IN2-34).
        ///</summary>
        public CE PrimaryLanguage
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(34, 0);
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
        /// Returns Living Arrangement(IN2-35).
        ///</summary>
        public IS LivingArrangement
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(35, 0);
                    ret = (IS)t;
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
        /// Returns Publicity Indicator(IN2-36).
        ///</summary>
        public CE PublicityIndicator
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(36, 0);
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
        /// Returns Protection Indicator(IN2-37).
        ///</summary>
        public ID ProtectionIndicator
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(37, 0);
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
        /// Returns Student Indicator(IN2-38).
        ///</summary>
        public IS StudentIndicator
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(38, 0);
                    ret = (IS)t;
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
        /// Returns Religion(IN2-39).
        ///</summary>
        public IS Religion
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(39, 0);
                    ret = (IS)t;
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
        /// Returns Mother’s Maiden Name(IN2-40).
        ///</summary>
        public XPN MotherSMaidenName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(40, 0);
                    ret = (XPN)t;
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
        /// Returns Nationality Code(IN2-41).
        ///</summary>
        public CE NationalityCode
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(41, 0);
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
        /// Returns Ethnic Group(IN2-42).
        ///</summary>
        public IS EthnicGroup
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(42, 0);
                    ret = (IS)t;
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
        /// Returns a single repetition of Marital Status(IN2-43).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public IS getMaritalStatus(int rep)
        {
            IS ret = null;
            try
            {
                IType t = this.GetField(43, rep);
                ret = (IS)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Marital Status (IN2-43).
        ///</summary>
        public IS[] getMaritalStatus()
        {
            IS[] ret = null;
            try
            {
                IType[] t = this.GetField(43);
                ret = new IS[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (IS)t[i];
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
        /// Returns Employment Start Date(IN2-44).
        ///</summary>
        public DT EmploymentStartDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(44, 0);
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
        /// Returns Employment Stop Date(IN2-45).
        ///</summary>
        public DT EmploymentStopDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(45, 0);
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
        /// Returns Job Title(IN2-46).
        ///</summary>
        public ST JobTitle
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(46, 0);
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
        /// Returns Job Code/Class(IN2-47).
        ///</summary>
        public JCC JobCodeClass
        {
            get
            {
                JCC ret = null;
                try
                {
                    IType t = this.GetField(47, 0);
                    ret = (JCC)t;
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
        /// Returns Job Status(IN2-48).
        ///</summary>
        public IS JobStatus
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(48, 0);
                    ret = (IS)t;
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
        /// Returns a single repetition of Employer Contact Person Name(IN2-49).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XPN getEmployerContactPersonName(int rep)
        {
            XPN ret = null;
            try
            {
                IType t = this.GetField(49, rep);
                ret = (XPN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Employer Contact Person Name (IN2-49).
        ///</summary>
        public XPN[] getEmployerContactPersonName()
        {
            XPN[] ret = null;
            try
            {
                IType[] t = this.GetField(49);
                ret = new XPN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XPN)t[i];
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
        /// Returns a single repetition of Employer Contact Person Phone Number(IN2-50).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getEmployerContactPersonPhoneNumber(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(50, rep);
                ret = (XTN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Employer Contact Person Phone Number (IN2-50).
        ///</summary>
        public XTN[] getEmployerContactPersonPhoneNumber()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(50);
                ret = new XTN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XTN)t[i];
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
        /// Returns Employer Contact Reason(IN2-51).
        ///</summary>
        public IS EmployerContactReason
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(51, 0);
                    ret = (IS)t;
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
        /// Returns a single repetition of Insured’s Contact Person’s Name(IN2-52).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XPN getInsuredSContactPersonSName(int rep)
        {
            XPN ret = null;
            try
            {
                IType t = this.GetField(52, rep);
                ret = (XPN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Insured’s Contact Person’s Name (IN2-52).
        ///</summary>
        public XPN[] getInsuredSContactPersonSName()
        {
            XPN[] ret = null;
            try
            {
                IType[] t = this.GetField(52);
                ret = new XPN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XPN)t[i];
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
        /// Returns a single repetition of Insured’s Contact Person Telephone Number(IN2-53).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getInsuredSContactPersonTelephoneNumber(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(53, rep);
                ret = (XTN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Insured’s Contact Person Telephone Number (IN2-53).
        ///</summary>
        public XTN[] getInsuredSContactPersonTelephoneNumber()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(53);
                ret = new XTN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XTN)t[i];
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
        /// Returns a single repetition of Insured’s Contact Person Reason(IN2-54).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public IS getInsuredSContactPersonReason(int rep)
        {
            IS ret = null;
            try
            {
                IType t = this.GetField(54, rep);
                ret = (IS)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Insured’s Contact Person Reason (IN2-54).
        ///</summary>
        public IS[] getInsuredSContactPersonReason()
        {
            IS[] ret = null;
            try
            {
                IType[] t = this.GetField(54);
                ret = new IS[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (IS)t[i];
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
        /// Returns Relationship To The Patient Start Date(IN2-55).
        ///</summary>
        public DT RelationshipToThePatientStartDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(55, 0);
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
        /// Returns a single repetition of Relationship To The Patient Stop Date(IN2-56).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public DT getRelationshipToThePatientStopDate(int rep)
        {
            DT ret = null;
            try
            {
                IType t = this.GetField(56, rep);
                ret = (DT)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Relationship To The Patient Stop Date (IN2-56).
        ///</summary>
        public DT[] getRelationshipToThePatientStopDate()
        {
            DT[] ret = null;
            try
            {
                IType[] t = this.GetField(56);
                ret = new DT[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (DT)t[i];
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
        /// Returns Insurance Co. Contact Reason(IN2-57).
        ///</summary>
        public IS InsuranceCoContactReason
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(57, 0);
                    ret = (IS)t;
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
        /// Returns Insurance Co. Contact Phone Number(IN2-58).
        ///</summary>
        public XTN InsuranceCoContactPhoneNumber
        {
            get
            {
                XTN ret = null;
                try
                {
                    IType t = this.GetField(58, 0);
                    ret = (XTN)t;
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
        /// Returns Policy Scope(IN2-59).
        ///</summary>
        public IS PolicyScope
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(59, 0);
                    ret = (IS)t;
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
        /// Returns Policy Source(IN2-60).
        ///</summary>
        public IS PolicySource
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(60, 0);
                    ret = (IS)t;
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
        /// Returns Patient Member Number(IN2-61).
        ///</summary>
        public CX PatientMemberNumber
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(61, 0);
                    ret = (CX)t;
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
        /// Returns Guarantor’s Relationship To Insured(IN2-62).
        ///</summary>
        public IS GuarantorSRelationshipToInsured
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(62, 0);
                    ret = (IS)t;
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
        /// Returns a single repetition of Insured’s Telephone Number - Home(IN2-63).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getInsuredSTelephoneNumberHome(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(63, rep);
                ret = (XTN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Insured’s Telephone Number - Home (IN2-63).
        ///</summary>
        public XTN[] getInsuredSTelephoneNumberHome()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(63);
                ret = new XTN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XTN)t[i];
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
        /// Returns a single repetition of Insured’s Employer Telephone Number(IN2-64).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getInsuredSEmployerTelephoneNumber(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(64, rep);
                ret = (XTN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Insured’s Employer Telephone Number (IN2-64).
        ///</summary>
        public XTN[] getInsuredSEmployerTelephoneNumber()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(64);
                ret = new XTN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XTN)t[i];
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
        /// Returns Military Handicapped Program(IN2-65).
        ///</summary>
        public CE MilitaryHandicappedProgram
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(65, 0);
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
        /// Returns Suspend Flag(IN2-66).
        ///</summary>
        public ID SuspendFlag
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(66, 0);
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
        /// Returns Co-pay Limit Flag(IN2-67).
        ///</summary>
        public ID CoPayLimitFlag
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(67, 0);
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
        /// Returns Stoploss Limit Flag(IN2-68).
        ///</summary>
        public ID StoplossLimitFlag
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(68, 0);
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
        /// Returns a single repetition of Insured Organization Name And ID(IN2-69).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XON getInsuredOrganizationNameAndID(int rep)
        {
            XON ret = null;
            try
            {
                IType t = this.GetField(69, rep);
                ret = (XON)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Insured Organization Name And ID (IN2-69).
        ///</summary>
        public XON[] getInsuredOrganizationNameAndID()
        {
            XON[] ret = null;
            try
            {
                IType[] t = this.GetField(69);
                ret = new XON[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XON)t[i];
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
        /// Returns a single repetition of Insured Employer Organization Name And ID(IN2-70).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XON getInsuredEmployerOrganizationNameAndID(int rep)
        {
            XON ret = null;
            try
            {
                IType t = this.GetField(70, rep);
                ret = (XON)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Insured Employer Organization Name And ID (IN2-70).
        ///</summary>
        public XON[] getInsuredEmployerOrganizationNameAndID()
        {
            XON[] ret = null;
            try
            {
                IType[] t = this.GetField(70);
                ret = new XON[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XON)t[i];
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
        /// Returns Race(IN2-71).
        ///</summary>
        public IS Race
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(71, 0);
                    ret = (IS)t;
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
        /// Returns Patient Relationship to Insured(IN2-72).
        ///</summary>
        public ID PatientRelationshipToInsured
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(72, 0);
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


    }
}