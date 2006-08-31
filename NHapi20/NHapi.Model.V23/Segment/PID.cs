using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 PID message segment. 
    /// This segment has the following fields:
    /// * PID-1: Set ID - Patient ID (SI)
    /// * PID-2: Patient ID (External ID) (CX)
    /// * PID-3: Patient ID (Internal ID) (CX)
    /// * PID-4: Alternate Patient ID (CX)
    /// * PID-5: Patient Name (XPN)
    /// * PID-6: Mother's Maiden Name (XPN)
    /// * PID-7: Date of Birth (TS)
    /// * PID-8: Sex (IS)
    /// * PID-9: Patient Alias (XPN)
    /// * PID-10: Race (IS)
    /// * PID-11: Patient Address (XAD)
    /// * PID-12: County Code (IS)
    /// * PID-13: Phone Number - Home (TN)
    /// * PID-14: Phone Number - Business (TN)
    /// * PID-15: Primary Language (CE)
    /// * PID-16: Marital Status (IS)
    /// * PID-17: Religion (IS)
    /// * PID-18: Patient Account Number (CX)
    /// * PID-19: SSN Number - Patient (ST)
    /// * PID-20: Driver's License Number (DLN)
    /// * PID-21: Mother's Identifier (CX)
    /// * PID-22: Ethnic Group (IS)
    /// * PID-23: Birth Place (ST)
    /// * PID-24: Multiple Birth Indicator (ID)
    /// * PID-25: Birth Order (NM)
    /// * PID-26: Citizenship (IS)
    /// * PID-27: Veterans Military Status (CE)
    /// * PID-28: Nationality Code (CE)
    /// * PID-29: Patient Death Date and Time (TS)
    /// * PID-30: Patient Death Indicator (ID)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class PID : AbstractSegment
    {

        /**
         * Creates a PID (Patient Identification) segment object that belongs to the given 
         * message.  
         */
        public PID(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), false, 1, 4, new System.Object[] { message }, "Set ID - Patient ID");
                this.add(typeof(CX), false, 1, 16, new System.Object[] { message }, "Patient ID (External ID)");
                this.add(typeof(CX), true, 0, 20, new System.Object[] { message }, "Patient ID (Internal ID)");
                this.add(typeof(CX), false, 1, 12, new System.Object[] { message }, "Alternate Patient ID");
                this.add(typeof(XPN), true, 1, 48, new System.Object[] { message }, "Patient Name");
                this.add(typeof(XPN), false, 1, 48, new System.Object[] { message }, "Mother's Maiden Name");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Date of Birth");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 1 }, "Sex");
                this.add(typeof(XPN), false, 0, 48, new System.Object[] { message }, "Patient Alias");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 5 }, "Race");
                this.add(typeof(XAD), false, 0, 106, new System.Object[] { message }, "Patient Address");
                this.add(typeof(IS), false, 1, 4, new System.Object[] { message, 0 }, "County Code");
                this.add(typeof(TN), false, 0, 40, new System.Object[] { message }, "Phone Number - Home");
                this.add(typeof(TN), false, 0, 40, new System.Object[] { message }, "Phone Number - Business");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Primary Language");
                this.add(typeof(IS), false, 0, 1, new System.Object[] { message, 2 }, "Marital Status");
                this.add(typeof(IS), false, 1, 3, new System.Object[] { message, 6 }, "Religion");
                this.add(typeof(CX), false, 1, 20, new System.Object[] { message }, "Patient Account Number");
                this.add(typeof(ST), false, 1, 16, new System.Object[] { message }, "SSN Number - Patient");
                this.add(typeof(DLN), false, 1, 25, new System.Object[] { message }, "Driver's License Number");
                this.add(typeof(CX), false, 1, 20, new System.Object[] { message }, "Mother's Identifier");
                this.add(typeof(IS), false, 1, 1, new System.Object[] { message, 189 }, "Ethnic Group");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Birth Place");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 136 }, "Multiple Birth Indicator");
                this.add(typeof(NM), false, 1, 2, new System.Object[] { message }, "Birth Order");
                this.add(typeof(IS), false, 1, 4, new System.Object[] { message, 171 }, "Citizenship");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Veterans Military Status");
                this.add(typeof(CE), false, 1, 80, new System.Object[] { message }, "Nationality Code");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Patient Death Date and Time");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 136 }, "Patient Death Indicator");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Set ID - Patient ID(PID-1).
        ///</summary>
        public SI SetIDPatientID
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
        /// Returns Patient ID (External ID)(PID-2).
        ///</summary>
        public CX PatientIDExternalID
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns a single repetition of Patient ID (Internal ID)(PID-3).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CX getPatientIDInternalID(int rep)
        {
            CX ret = null;
            try
            {
                IType t = this.GetField(3, rep);
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
        /// Returns all repetitions of Patient ID (Internal ID) (PID-3).
        ///</summary>
        public CX[] getPatientIDInternalID()
        {
            CX[] ret = null;
            try
            {
                IType[] t = this.GetField(3);
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
        /// Returns Alternate Patient ID(PID-4).
        ///</summary>
        public CX AlternatePatientID
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
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
        /// Returns Patient Name(PID-5).
        ///</summary>
        public XPN PatientName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
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
        /// Returns Mother's Maiden Name(PID-6).
        ///</summary>
        public XPN MotherSMaidenName
        {
            get
            {
                XPN ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns Date of Birth(PID-7).
        ///</summary>
        public TS DateOfBirth
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
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
        /// Returns Sex(PID-8).
        ///</summary>
        public IS Sex
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns a single repetition of Patient Alias(PID-9).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XPN getPatientAlias(int rep)
        {
            XPN ret = null;
            try
            {
                IType t = this.GetField(9, rep);
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
        /// Returns all repetitions of Patient Alias (PID-9).
        ///</summary>
        public XPN[] getPatientAlias()
        {
            XPN[] ret = null;
            try
            {
                IType[] t = this.GetField(9);
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
        /// Returns Race(PID-10).
        ///</summary>
        public IS Race
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
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
        /// Returns a single repetition of Patient Address(PID-11).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XAD getPatientAddress(int rep)
        {
            XAD ret = null;
            try
            {
                IType t = this.GetField(11, rep);
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
        /// Returns all repetitions of Patient Address (PID-11).
        ///</summary>
        public XAD[] getPatientAddress()
        {
            XAD[] ret = null;
            try
            {
                IType[] t = this.GetField(11);
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
        /// Returns County Code(PID-12).
        ///</summary>
        public IS CountyCode
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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
        /// Returns a single repetition of Phone Number - Home(PID-13).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TN getPhoneNumberHome(int rep)
        {
            TN ret = null;
            try
            {
                IType t = this.GetField(13, rep);
                ret = (TN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Phone Number - Home (PID-13).
        ///</summary>
        public TN[] getPhoneNumberHome()
        {
            TN[] ret = null;
            try
            {
                IType[] t = this.GetField(13);
                ret = new TN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (TN)t[i];
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
        /// Returns a single repetition of Phone Number - Business(PID-14).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TN getPhoneNumberBusiness(int rep)
        {
            TN ret = null;
            try
            {
                IType t = this.GetField(14, rep);
                ret = (TN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Phone Number - Business (PID-14).
        ///</summary>
        public TN[] getPhoneNumberBusiness()
        {
            TN[] ret = null;
            try
            {
                IType[] t = this.GetField(14);
                ret = new TN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (TN)t[i];
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
        /// Returns Primary Language(PID-15).
        ///</summary>
        public CE PrimaryLanguage
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(15, 0);
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
        /// Returns a single repetition of Marital Status(PID-16).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public IS getMaritalStatus(int rep)
        {
            IS ret = null;
            try
            {
                IType t = this.GetField(16, rep);
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
        /// Returns all repetitions of Marital Status (PID-16).
        ///</summary>
        public IS[] getMaritalStatus()
        {
            IS[] ret = null;
            try
            {
                IType[] t = this.GetField(16);
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
        /// Returns Religion(PID-17).
        ///</summary>
        public IS Religion
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
        /// Returns Patient Account Number(PID-18).
        ///</summary>
        public CX PatientAccountNumber
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
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
        /// Returns SSN Number - Patient(PID-19).
        ///</summary>
        public ST SSNNumberPatient
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
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
        /// Returns Driver's License Number(PID-20).
        ///</summary>
        public DLN DriverSLicenseNumber
        {
            get
            {
                DLN ret = null;
                try
                {
                    IType t = this.GetField(20, 0);
                    ret = (DLN)t;
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
        /// Returns Mother's Identifier(PID-21).
        ///</summary>
        public CX MotherSIdentifier
        {
            get
            {
                CX ret = null;
                try
                {
                    IType t = this.GetField(21, 0);
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
        /// Returns Ethnic Group(PID-22).
        ///</summary>
        public IS EthnicGroup
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
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
        /// Returns Birth Place(PID-23).
        ///</summary>
        public ST BirthPlace
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
        /// Returns Multiple Birth Indicator(PID-24).
        ///</summary>
        public ID MultipleBirthIndicator
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(24, 0);
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
        /// Returns Birth Order(PID-25).
        ///</summary>
        public NM BirthOrder
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(25, 0);
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
        /// Returns Citizenship(PID-26).
        ///</summary>
        public IS Citizenship
        {
            get
            {
                IS ret = null;
                try
                {
                    IType t = this.GetField(26, 0);
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
        /// Returns Veterans Military Status(PID-27).
        ///</summary>
        public CE VeteransMilitaryStatus
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
        /// Returns Nationality Code(PID-28).
        ///</summary>
        public CE NationalityCode
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(28, 0);
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
        /// Returns Patient Death Date and Time(PID-29).
        ///</summary>
        public TS PatientDeathDateAndTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(29, 0);
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
        /// Returns Patient Death Indicator(PID-30).
        ///</summary>
        public ID PatientDeathIndicator
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(30, 0);
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