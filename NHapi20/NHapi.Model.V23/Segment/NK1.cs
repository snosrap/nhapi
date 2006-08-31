using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 NK1 message segment. 
    /// This segment has the following fields:
    /// * NK1-1: Set ID - Next of Kin (SI)
    /// * NK1-2: Name (XPN)
    /// * NK1-3: Relationship (CE)
    /// * NK1-4: Address (XAD)
    /// * NK1-5: Phone Number (XTN)
    /// * NK1-6: Business Phone Number (XTN)
    /// * NK1-7: Contact Role (CE)
    /// * NK1-8: Start Date (DT)
    /// * NK1-9: End Date (DT)
    /// * NK1-10: Next of Kin/Associated Parties Job Title (ST)
    /// * NK1-11: Next of Kin Job/Associated Parties Code/Class (JCC)
    /// * NK1-12: Next of Kin/Associated Parties Employee Number (CX)
    /// * NK1-13: Organization Name (XON)
    /// * NK1-14: Marital Status (IS)
    /// * NK1-15: Sex (IS)
    /// * NK1-16: Date of Birth (TS)
    /// * NK1-17: Living Dependency (IS)
    /// * NK1-18: Ambulatory Status (IS)
    /// * NK1-19: Citizenship (IS)
    /// * NK1-20: Primary Language (CE)
    /// * NK1-21: Living Arrangement (IS)
    /// * NK1-22: Publicity Indicator (CE)
    /// * NK1-23: Protection Indicator (ID)
    /// * NK1-24: Student Indicator (IS)
    /// * NK1-25: Religion (IS)
    /// * NK1-26: Mother’s Maiden Name (XPN)
    /// * NK1-27: Nationality Code (CE)
    /// * NK1-28: Ethnic Group (IS)
    /// * NK1-29: Contact Reason (CE)
    /// * NK1-30: Contact Person's Name (XPN)
    /// * NK1-31: Contact Person’s Telephone Number (XTN)
    /// * NK1-32: Contact Person’s Address (XAD)
    /// * NK1-33: Associated Party’s Identifiers (CX)
    /// * NK1-34: Job Status (IS)
    /// * NK1-35: Race (IS)
    /// * NK1-36: Handicap (IS)
    /// * NK1-37: Contact Person Social Security Number (ST)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class NK1 : AbstractSegment
    {

        /**
         * Creates a NK1 (Next of kin) segment object that belongs to the given 
         * message.  
         */
        public NK1(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), true, 1, 4, new System.Object[] { message }, "Set ID - Next of Kin");
                this.add(typeof(XPN), false, 0, 48, new System.Object[] { message }, "Name");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Relationship");
                this.add(typeof(XAD), false, 0, 106, new System.Object[] { message }, "Address");
                this.add(typeof(XTN), false, 0, 40, new System.Object[] { message }, "Phone Number");
                this.add(typeof(XTN), false, 0, 40, new System.Object[] { message }, "Business Phone Number");
                this.add(typeof(CE), true, 1, 60, new System.Object[] { message }, "Contact Role");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "Start Date");
                this.add(typeof(DT), false, 1, 8, new System.Object[] { message }, "End Date");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Next of Kin/Associated Parties Job Title");
                this.add(typeof(JCC), false, 1, 20, new System.Object[] { message }, "Next of Kin Job/Associated Parties Code/Class");
                this.add(typeof(CX), false, 1, 20, new System.Object[] { message }, "Next of Kin/Associated Parties Employee Number");
                this.add(typeof(XON), false, 0, 60, new System.Object[] { message }, "Organization Name");
                this.add(typeof(IS), false, 0, 1, new System.Object[] { message, 2 }, "Marital Status");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 1 }, "Sex");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Date of Birth");
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
                this.add(typeof(CE), false, 1, 2, new System.Object[] { message }, "Contact Reason");
                this.add(typeof(XPN), false, 0, 48, new System.Object[] { message }, "Contact Person's Name");
                this.add(typeof(XTN), false, 0, 40, new System.Object[] { message }, "Contact Person’s Telephone Number");
                this.add(typeof(XAD), false, 0, 106, new System.Object[] { message }, "Contact Person’s Address");
                this.add(typeof(CX), false, 0, 32, new System.Object[] { message }, "Associated Party’s Identifiers");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 311 }, "Job Status");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 5 }, "Race");
                this.add(typeof(IS), false, 1, 2, new System.Object[] { message, 310 }, "Handicap");
                this.add(typeof(ST), false, 1, 16, new System.Object[] { message }, "Contact Person Social Security Number");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Set ID - Next of Kin(NK1-1).
        ///</summary>
        public SI SetIDNextOfKin
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
        /// Returns a single repetition of Name(NK1-2).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XPN getName(int rep)
        {
            XPN ret = null;
            try
            {
                IType t = this.GetField(2, rep);
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
        /// Returns all repetitions of Name (NK1-2).
        ///</summary>
        public XPN[] getName()
        {
            XPN[] ret = null;
            try
            {
                IType[] t = this.GetField(2);
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
        /// Returns Relationship(NK1-3).
        ///</summary>
        public CE Relationship
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns a single repetition of Address(NK1-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XAD getAddress(int rep)
        {
            XAD ret = null;
            try
            {
                IType t = this.GetField(4, rep);
                ret = (XAD)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Address (NK1-4).
        ///</summary>
        public XAD[] getAddress()
        {
            XAD[] ret = null;
            try
            {
                IType[] t = this.GetField(4);
                ret = new XAD[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XAD)t[i];
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
        /// Returns a single repetition of Phone Number(NK1-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getPhoneNumber(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(5, rep);
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
        /// Returns all repetitions of Phone Number (NK1-5).
        ///</summary>
        public XTN[] getPhoneNumber()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(5);
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
        /// Returns a single repetition of Business Phone Number(NK1-6).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getBusinessPhoneNumber(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(6, rep);
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
        /// Returns all repetitions of Business Phone Number (NK1-6).
        ///</summary>
        public XTN[] getBusinessPhoneNumber()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(6);
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
        /// Returns Contact Role(NK1-7).
        ///</summary>
        public CE ContactRole
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
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
        /// Returns Start Date(NK1-8).
        ///</summary>
        public DT StartDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns End Date(NK1-9).
        ///</summary>
        public DT EndDate
        {
            get
            {
                DT ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
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
        /// Returns Next of Kin/Associated Parties Job Title(NK1-10).
        ///</summary>
        public ST NextOfKinAssociatedPartiesJobTitle
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
        /// Returns Next of Kin Job/Associated Parties Code/Class(NK1-11).
        ///</summary>
        public JCC NextOfKinJobAssociatedPartiesCodeClass
        {
            get
            {
                JCC ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns Next of Kin/Associated Parties Employee Number(NK1-12).
        ///</summary>
        public CX NextOfKinAssociatedPartiesEmployeeNumber
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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
        /// Returns a single repetition of Organization Name(NK1-13).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XON getOrganizationName(int rep)
        {
            XON ret = null;
            try
            {
                IType t = this.GetField(13, rep);
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
        /// Returns all repetitions of Organization Name (NK1-13).
        ///</summary>
        public XON[] getOrganizationName()
        {
            XON[] ret = null;
            try
            {
                IType[] t = this.GetField(13);
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
        /// Returns a single repetition of Marital Status(NK1-14).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public IS getMaritalStatus(int rep)
        {
            IS ret = null;
            try
            {
                IType t = this.GetField(14, rep);
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
        /// Returns all repetitions of Marital Status (NK1-14).
        ///</summary>
        public IS[] getMaritalStatus()
        {
            IS[] ret = null;
            try
            {
                IType[] t = this.GetField(14);
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
        /// Returns Sex(NK1-15).
        ///</summary>
        public IS Sex
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
        /// Returns Date of Birth(NK1-16).
        ///</summary>
        public TS DateOfBirth
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
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
        /// Returns Living Dependency(NK1-17).
        ///</summary>
        public IS LivingDependency
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(17, 0);
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
        /// Returns Ambulatory Status(NK1-18).
        ///</summary>
        public IS AmbulatoryStatus
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
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
        /// Returns Citizenship(NK1-19).
        ///</summary>
        public IS Citizenship
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
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
        /// Returns Primary Language(NK1-20).
        ///</summary>
        public CE PrimaryLanguage
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(20, 0);
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
        /// Returns Living Arrangement(NK1-21).
        ///</summary>
        public IS LivingArrangement
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(21, 0);
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
        /// Returns Publicity Indicator(NK1-22).
        ///</summary>
        public CE PublicityIndicator
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
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
        /// Returns Protection Indicator(NK1-23).
        ///</summary>
        public ID ProtectionIndicator
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
        /// Returns Student Indicator(NK1-24).
        ///</summary>
        public IS StudentIndicator
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(24, 0);
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
        /// Returns Religion(NK1-25).
        ///</summary>
        public IS Religion
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(25, 0);
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
        /// Returns Mother’s Maiden Name(NK1-26).
        ///</summary>
        public XPN MotherSMaidenName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(26, 0);
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
        /// Returns Nationality Code(NK1-27).
        ///</summary>
        public CE NationalityCode
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(27, 0);
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
        /// Returns Ethnic Group(NK1-28).
        ///</summary>
        public IS EthnicGroup
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(28, 0);
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
        /// Returns Contact Reason(NK1-29).
        ///</summary>
        public CE ContactReason
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(29, 0);
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
        /// Returns a single repetition of Contact Person's Name(NK1-30).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XPN getContactPersonSName(int rep)
        {
            XPN ret = null;
            try
            {
                IType t = this.GetField(30, rep);
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
        /// Returns all repetitions of Contact Person's Name (NK1-30).
        ///</summary>
        public XPN[] getContactPersonSName()
        {
            XPN[] ret = null;
            try
            {
                IType[] t = this.GetField(30);
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
        /// Returns a single repetition of Contact Person’s Telephone Number(NK1-31).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getContactPersonSTelephoneNumber(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(31, rep);
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
        /// Returns all repetitions of Contact Person’s Telephone Number (NK1-31).
        ///</summary>
        public XTN[] getContactPersonSTelephoneNumber()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(31);
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
        /// Returns a single repetition of Contact Person’s Address(NK1-32).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XAD getContactPersonSAddress(int rep)
        {
            XAD ret = null;
            try
            {
                IType t = this.GetField(32, rep);
                ret = (XAD)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Contact Person’s Address (NK1-32).
        ///</summary>
        public XAD[] getContactPersonSAddress()
        {
            XAD[] ret = null;
            try
            {
                IType[] t = this.GetField(32);
                ret = new XAD[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XAD)t[i];
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
        /// Returns a single repetition of Associated Party’s Identifiers(NK1-33).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CX getAssociatedPartySIdentifiers(int rep)
        {
            CX ret = null;
            try
            {
                IType t = this.GetField(33, rep);
                ret = (CX)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Associated Party’s Identifiers (NK1-33).
        ///</summary>
        public CX[] getAssociatedPartySIdentifiers()
        {
            CX[] ret = null;
            try
            {
                IType[] t = this.GetField(33);
                ret = new CX[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CX)t[i];
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
        /// Returns Job Status(NK1-34).
        ///</summary>
        public IS JobStatus
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(34, 0);
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
        /// Returns Race(NK1-35).
        ///</summary>
        public IS Race
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
        /// Returns Handicap(NK1-36).
        ///</summary>
        public IS Handicap
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(36, 0);
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
        /// Returns Contact Person Social Security Number(NK1-37).
        ///</summary>
        public ST ContactPersonSocialSecurityNumber
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(37, 0);
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


    }
}