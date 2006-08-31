using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 RXO message segment. 
    /// This segment has the following fields:
    /// * RXO-1: Requested Give Code (CE)
    /// * RXO-2: Requested Give Amount - Minimum (NM)
    /// * RXO-3: Requested Give Amount - Maximum (NM)
    /// * RXO-4: Requested Give Units (CE)
    /// * RXO-5: Requested Dosage Form (CE)
    /// * RXO-6: Provider's Pharmacy Instructions (CE)
    /// * RXO-7: Provider's Administration Instructions (CE)
    /// * RXO-8: Deliver-to location (CM_LA1)
    /// * RXO-9: Allow Substitutions (ID)
    /// * RXO-10: Requested Dispense Code (CE)
    /// * RXO-11: Requested Dispense Amount (NM)
    /// * RXO-12: Requested Dispense Units (CE)
    /// * RXO-13: Number of Refills (NM)
    /// * RXO-14: Ordering Provider's DEA Number (CN_PERSON)
    /// * RXO-15: Pharmacist Verifier ID (CN_PERSON)
    /// * RXO-16: Needs Human Review (ID)
    /// * RXO-17: Requested Give Per (Time Unit) (ST)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class RXO : AbstractSegment
    {

        /**
         * Creates a RXO (PHARMACY PRESCRIPTION ORDER) segment object that belongs to the given 
         * message.  
         */
        public RXO(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(CE), true, 1, 100, new System.Object[] { message }, "Requested Give Code");
                this.add(typeof(NM), true, 1, 20, new System.Object[] { message }, "Requested Give Amount - Minimum");
                this.add(typeof(NM), false, 1, 20, new System.Object[] { message }, "Requested Give Amount - Maximum");
                this.add(typeof(CE), true, 1, 60, new System.Object[] { message }, "Requested Give Units");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Requested Dosage Form");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Provider's Pharmacy Instructions");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Provider's Administration Instructions");
                this.add(typeof(CM_LA1), false, 1, 12, new System.Object[] { message }, "Deliver-to location");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 161 }, "Allow Substitutions");
                this.add(typeof(CE), false, 1, 100, new System.Object[] { message }, "Requested Dispense Code");
                this.add(typeof(NM), false, 1, 20, new System.Object[] { message }, "Requested Dispense Amount");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Requested Dispense Units");
                this.add(typeof(NM), false, 1, 3, new System.Object[] { message }, "Number of Refills");
                this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[] { message }, "Ordering Provider's DEA Number");
                this.add(typeof(CN_PERSON), false, 1, 60, new System.Object[] { message }, "Pharmacist Verifier ID");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 0 }, "Needs Human Review");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "Requested Give Per (Time Unit)");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Requested Give Code(RXO-1).
        ///</summary>
        public CE RequestedGiveCode
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
        /// Returns Requested Give Amount - Minimum(RXO-2).
        ///</summary>
        public NM RequestedGiveAmountMinimum
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns Requested Give Amount - Maximum(RXO-3).
        ///</summary>
        public NM RequestedGiveAmountMaximum
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns Requested Give Units(RXO-4).
        ///</summary>
        public CE RequestedGiveUnits
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
        /// Returns Requested Dosage Form(RXO-5).
        ///</summary>
        public CE RequestedDosageForm
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
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
        /// Returns a single repetition of Provider's Pharmacy Instructions(RXO-6).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getProviderSPharmacyInstructions(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(6, rep);
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
        /// Returns all repetitions of Provider's Pharmacy Instructions (RXO-6).
        ///</summary>
        public CE[] getProviderSPharmacyInstructions()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(6);
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
        /// Returns a single repetition of Provider's Administration Instructions(RXO-7).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getProviderSAdministrationInstructions(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(7, rep);
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
        /// Returns all repetitions of Provider's Administration Instructions (RXO-7).
        ///</summary>
        public CE[] getProviderSAdministrationInstructions()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(7);
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
        /// Returns Deliver-to location(RXO-8).
        ///</summary>
        public CM_LA1 DeliverToLocation
        {
            get
            {
                CM_LA1 ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
                    ret = (CM_LA1)t;
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
        /// Returns Allow Substitutions(RXO-9).
        ///</summary>
        public ID AllowSubstitutions
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
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
        /// Returns Requested Dispense Code(RXO-10).
        ///</summary>
        public CE RequestedDispenseCode
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
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
        /// Returns Requested Dispense Amount(RXO-11).
        ///</summary>
        public NM RequestedDispenseAmount
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns Requested Dispense Units(RXO-12).
        ///</summary>
        public CE RequestedDispenseUnits
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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
        /// Returns Number of Refills(RXO-13).
        ///</summary>
        public NM NumberOfRefills
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(13, 0);
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
        /// Returns Ordering Provider's DEA Number(RXO-14).
        ///</summary>
        public CN_PERSON OrderingProviderSDEANumber
        {
            get
            {
                CN_PERSON ret = null;
                try
                {
                    IType t = this.GetField(14, 0);
                    ret = (CN_PERSON)t;
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
        /// Returns Pharmacist Verifier ID(RXO-15).
        ///</summary>
        public CN_PERSON PharmacistVerifierID
        {
            get
            {
                CN_PERSON ret = null;
                try
                {
                    IType t = this.GetField(15, 0);
                    ret = (CN_PERSON)t;
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
        /// Returns Needs Human Review(RXO-16).
        ///</summary>
        public ID NeedsHumanReview
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
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
        /// Returns Requested Give Per (Time Unit)(RXO-17).
        ///</summary>
        public ST RequestedGivePerTimeUnit
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(17, 0);
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