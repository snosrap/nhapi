using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 RXG message segment. 
    /// This segment has the following fields:
    /// * RXG-1: Give Sub-ID Counter (NM)
    /// * RXG-2: Dispense Sub-ID Counter (NM)
    /// * RXG-3: Quantity / timing (TQ)
    /// * RXG-4: Give Code (CE)
    /// * RXG-5: Give Amount - Minimum (NM)
    /// * RXG-6: Give Amount - Maximum (NM)
    /// * RXG-7: Give Units (CE)
    /// * RXG-8: Give Dosage Form (CE)
    /// * RXG-9: Administration Notes (ST)
    /// * RXG-10: Substitution Status (ID)
    /// * RXG-11: Deliver-to location (CM_LA1)
    /// * RXG-12: Needs Human Review (ID)
    /// * RXG-13: Pharmacy Special Administration Instructions (CE)
    /// * RXG-14: Give Per (Time Unit) (ST)
    /// * RXG-15: Give Rate Amount (CE)
    /// * RXG-16: Give Rate Units (CE)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class RXG : AbstractSegment
    {

        /**
         * Creates a RXG (PHARMACY GIVE) segment object that belongs to the given 
         * message.  
         */
        public RXG(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(NM), true, 1, 4, new System.Object[] { message }, "Give Sub-ID Counter");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "Dispense Sub-ID Counter");
                this.add(typeof(TQ), false, 0, 200, new System.Object[] { message }, "Quantity / timing");
                this.add(typeof(CE), true, 1, 100, new System.Object[] { message }, "Give Code");
                this.add(typeof(NM), true, 1, 20, new System.Object[] { message }, "Give Amount - Minimum");
                this.add(typeof(NM), false, 1, 20, new System.Object[] { message }, "Give Amount - Maximum");
                this.add(typeof(CE), true, 1, 60, new System.Object[] { message }, "Give Units");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Give Dosage Form");
                this.add(typeof(ST), false, 1, 200, new System.Object[] { message }, "Administration Notes");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 167 }, "Substitution Status");
                this.add(typeof(CM_LA1), false, 1, 12, new System.Object[] { message }, "Deliver-to location");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 0 }, "Needs Human Review");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Pharmacy Special Administration Instructions");
                this.add(typeof(ST), false, 1, 20, new System.Object[] { message }, "Give Per (Time Unit)");
                this.add(typeof(CE), false, 1, 6, new System.Object[] { message }, "Give Rate Amount");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Give Rate Units");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Give Sub-ID Counter(RXG-1).
        ///</summary>
        public NM GiveSubIDCounter
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns Dispense Sub-ID Counter(RXG-2).
        ///</summary>
        public NM DispenseSubIDCounter
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
        /// Returns a single repetition of Quantity / timing(RXG-3).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TQ getQuantityTiming(int rep)
        {
            TQ ret = null;
            try
            {
                IType t = this.GetField(3, rep);
                ret = (TQ)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Quantity / timing (RXG-3).
        ///</summary>
        public TQ[] getQuantityTiming()
        {
            TQ[] ret = null;
            try
            {
                IType[] t = this.GetField(3);
                ret = new TQ[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (TQ)t[i];
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
        /// Returns Give Code(RXG-4).
        ///</summary>
        public CE GiveCode
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
        /// Returns Give Amount - Minimum(RXG-5).
        ///</summary>
        public NM GiveAmountMinimum
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
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
        /// Returns Give Amount - Maximum(RXG-6).
        ///</summary>
        public NM GiveAmountMaximum
        {
            get
            {
                NM ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns Give Units(RXG-7).
        ///</summary>
        public CE GiveUnits
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
        /// Returns Give Dosage Form(RXG-8).
        ///</summary>
        public CE GiveDosageForm
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
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
        /// Returns Administration Notes(RXG-9).
        ///</summary>
        public ST AdministrationNotes
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
        /// Returns Substitution Status(RXG-10).
        ///</summary>
        public ID SubstitutionStatus
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
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
        /// Returns Deliver-to location(RXG-11).
        ///</summary>
        public CM_LA1 DeliverToLocation
        {
            get
            {
                CM_LA1 ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns Needs Human Review(RXG-12).
        ///</summary>
        public ID NeedsHumanReview
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(12, 0);
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
        /// Returns a single repetition of Pharmacy Special Administration Instructions(RXG-13).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getPharmacySpecialAdministrationInstructions(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(13, rep);
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
        /// Returns all repetitions of Pharmacy Special Administration Instructions (RXG-13).
        ///</summary>
        public CE[] getPharmacySpecialAdministrationInstructions()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(13);
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
        /// Returns Give Per (Time Unit)(RXG-14).
        ///</summary>
        public ST GivePerTimeUnit
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
        /// Returns Give Rate Amount(RXG-15).
        ///</summary>
        public CE GiveRateAmount
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
        /// Returns Give Rate Units(RXG-16).
        ///</summary>
        public CE GiveRateUnits
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
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


    }
}