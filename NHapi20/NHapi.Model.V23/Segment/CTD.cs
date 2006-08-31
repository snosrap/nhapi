using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 CTD message segment. 
    /// This segment has the following fields:
    /// * CTD-1: Contact Role (CE)
    /// * CTD-2: Contact Name (XPN)
    /// * CTD-3: Contact Address (XAD)
    /// * CTD-4: Contact Location (PL)
    /// * CTD-5: Contact Communication Information (XTN)
    /// * CTD-6: Preferred Method of Contact (CE)
    /// * CTD-7: Contact Identifiers (CM_PI)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class CTD : AbstractSegment
    {

        /**
         * Creates a CTD (Contact Data) segment object that belongs to the given 
         * message.  
         */
        public CTD(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(CE), true, 1, 60, new System.Object[] { message }, "Contact Role");
                this.add(typeof(XPN), false, 0, 106, new System.Object[] { message }, "Contact Name");
                this.add(typeof(XAD), false, 0, 60, new System.Object[] { message }, "Contact Address");
                this.add(typeof(PL), false, 1, 60, new System.Object[] { message }, "Contact Location");
                this.add(typeof(XTN), false, 0, 20, new System.Object[] { message }, "Contact Communication Information");
                this.add(typeof(CE), false, 1, 200, new System.Object[] { message }, "Preferred Method of Contact");
                this.add(typeof(CM_PI), false, 0, 100, new System.Object[] { message }, "Contact Identifiers");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Contact Role(CTD-1).
        ///</summary>
        public CE ContactRole
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns a single repetition of Contact Name(CTD-2).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XPN getContactName(int rep)
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
        /// Returns all repetitions of Contact Name (CTD-2).
        ///</summary>
        public XPN[] getContactName()
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
        /// Returns a single repetition of Contact Address(CTD-3).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XAD getContactAddress(int rep)
        {
            XAD ret = null;
            try
            {
                IType t = this.GetField(3, rep);
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
        /// Returns all repetitions of Contact Address (CTD-3).
        ///</summary>
        public XAD[] getContactAddress()
        {
            XAD[] ret = null;
            try
            {
                IType[] t = this.GetField(3);
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
        /// Returns Contact Location(CTD-4).
        ///</summary>
        public PL ContactLocation
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
        /// Returns a single repetition of Contact Communication Information(CTD-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getContactCommunicationInformation(int rep)
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
        /// Returns all repetitions of Contact Communication Information (CTD-5).
        ///</summary>
        public XTN[] getContactCommunicationInformation()
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
        /// Returns Preferred Method of Contact(CTD-6).
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
        /// Returns a single repetition of Contact Identifiers(CTD-7).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_PI getContactIdentifiers(int rep)
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
        /// Returns all repetitions of Contact Identifiers (CTD-7).
        ///</summary>
        public CM_PI[] getContactIdentifiers()
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


    }
}