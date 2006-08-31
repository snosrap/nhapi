using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 PRD message segment. 
    /// This segment has the following fields:
    /// * PRD-1: Role (CE)
    /// * PRD-2: Provider Name (XPN)
    /// * PRD-3: Provider Address (XAD)
    /// * PRD-4: Provider Location (PL)
    /// * PRD-5: Provider Communication Information (XTN)
    /// * PRD-6: Preferred Method of Contact (CE)
    /// * PRD-7: Provider Identifiers (CM_PI)
    /// * PRD-8: Effective Start Date of Role (TS)
    /// * PRD-9: Effective End Date of Role (TS)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class PRD : AbstractSegment
    {

        /**
         * Creates a PRD (Provider Data) segment object that belongs to the given 
         * message.  
         */
        public PRD(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(CE), true, 0, 200, new System.Object[] { message }, "Role");
                this.add(typeof(XPN), false, 0, 106, new System.Object[] { message }, "Provider Name");
                this.add(typeof(XAD), false, 1, 60, new System.Object[] { message }, "Provider Address");
                this.add(typeof(PL), false, 1, 60, new System.Object[] { message }, "Provider Location");
                this.add(typeof(XTN), false, 0, 20, new System.Object[] { message }, "Provider Communication Information");
                this.add(typeof(CE), false, 1, 200, new System.Object[] { message }, "Preferred Method of Contact");
                this.add(typeof(CM_PI), false, 0, 100, new System.Object[] { message }, "Provider Identifiers");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Effective Start Date of Role");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Effective End Date of Role");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns a single repetition of Role(PRD-1).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getRole(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(1, rep);
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
        /// Returns all repetitions of Role (PRD-1).
        ///</summary>
        public CE[] getRole()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(1);
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

        ///<summary>
        /// Returns a single repetition of Provider Name(PRD-2).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XPN getProviderName(int rep)
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
        /// Returns all repetitions of Provider Name (PRD-2).
        ///</summary>
        public XPN[] getProviderName()
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
        /// Returns Provider Address(PRD-3).
        ///</summary>
        public XAD ProviderAddress
        {
            get
            {
                XAD ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (XAD)t;
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
        /// Returns Provider Location(PRD-4).
        ///</summary>
        public PL ProviderLocation
        {
            get
            {
                PL ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
                    ret = (PL)t;
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
        /// Returns a single repetition of Provider Communication Information(PRD-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getProviderCommunicationInformation(int rep)
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
        /// Returns all repetitions of Provider Communication Information (PRD-5).
        ///</summary>
        public XTN[] getProviderCommunicationInformation()
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
        /// Returns Preferred Method of Contact(PRD-6).
        ///</summary>
        public CE PreferredMethodOfContact
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns a single repetition of Provider Identifiers(PRD-7).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_PI getProviderIdentifiers(int rep)
        {
            CM_PI ret = null;
            try
            {
                IType t = this.GetField(7, rep);
                ret = (CM_PI)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Provider Identifiers (PRD-7).
        ///</summary>
        public CM_PI[] getProviderIdentifiers()
        {
            CM_PI[] ret = null;
            try
            {
                IType[] t = this.GetField(7);
                ret = new CM_PI[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_PI)t[i];
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
        /// Returns Effective Start Date of Role(PRD-8).
        ///</summary>
        public TS EffectiveStartDateOfRole
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns Effective End Date of Role(PRD-9).
        ///</summary>
        public TS EffectiveEndDateOfRole
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
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


    }
}