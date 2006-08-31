using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 ORC message segment. 
    /// This segment has the following fields:
    /// * ORC-1: Order Control (ID)
    /// * ORC-2: Placer Order Number (EI)
    /// * ORC-3: Filler Order Number (EI)
    /// * ORC-4: Placer Group Number (EI)
    /// * ORC-5: Order Status (ID)
    /// * ORC-6: Response Flag (ID)
    /// * ORC-7: Quantity/Timing (TQ)
    /// * ORC-8: Parent (CM_EIP)
    /// * ORC-9: Date/Time of Transaction (TS)
    /// * ORC-10: Entered By (XCN)
    /// * ORC-11: Verified By (XCN)
    /// * ORC-12: Ordering Provider (XCN)
    /// * ORC-13: Enterer's Location (PL)
    /// * ORC-14: Call Back Phone Number (TN)
    /// * ORC-15: Order Effective Date/Time (TS)
    /// * ORC-16: Order Control Code Reason (CE)
    /// * ORC-17: Entering Organization (CE)
    /// * ORC-18: Entering Device (CE)
    /// * ORC-19: Action By (XCN)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class ORC : AbstractSegment
    {

        /**
         * Creates a ORC (Common order segment) segment object that belongs to the given 
         * message.  
         */
        public ORC(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ID), true, 1, 2, new System.Object[] { message, 119 }, "Order Control");
                this.add(typeof(EI), false, 0, 22, new System.Object[] { message }, "Placer Order Number");
                this.add(typeof(EI), false, 1, 22, new System.Object[] { message }, "Filler Order Number");
                this.add(typeof(EI), false, 1, 22, new System.Object[] { message }, "Placer Group Number");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 38 }, "Order Status");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 121 }, "Response Flag");
                this.add(typeof(TQ), true, 1, 200, new System.Object[] { message }, "Quantity/Timing");
                this.add(typeof(CM_EIP), false, 1, 200, new System.Object[] { message }, "Parent");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Date/Time of Transaction");
                this.add(typeof(XCN), false, 1, 120, new System.Object[] { message }, "Entered By");
                this.add(typeof(XCN), false, 1, 120, new System.Object[] { message }, "Verified By");
                this.add(typeof(XCN), false, 0, 120, new System.Object[] { message }, "Ordering Provider");
                this.add(typeof(PL), false, 1, 80, new System.Object[] { message }, "Enterer's Location");
                this.add(typeof(TN), false, 2, 40, new System.Object[] { message }, "Call Back Phone Number");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Order Effective Date/Time");
                this.add(typeof(CE), false, 1, 200, new System.Object[] { message }, "Order Control Code Reason");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Entering Organization");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Entering Device");
                this.add(typeof(XCN), false, 1, 120, new System.Object[] { message }, "Action By");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Order Control(ORC-1).
        ///</summary>
        public ID OrderControl
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns a single repetition of Placer Order Number(ORC-2).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public EI getPlacerOrderNumber(int rep)
        {
            EI ret = null;
            try
            {
                IType t = this.GetField(2, rep);
                ret = (EI)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Placer Order Number (ORC-2).
        ///</summary>
        public EI[] getPlacerOrderNumber()
        {
            EI[] ret = null;
            try
            {
                IType[] t = this.GetField(2);
                ret = new EI[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (EI)t[i];
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
        /// Returns Filler Order Number(ORC-3).
        ///</summary>
        public EI FillerOrderNumber
        {
            get
            {
                EI ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (EI)t;
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
        /// Returns Placer Group Number(ORC-4).
        ///</summary>
        public EI PlacerGroupNumber
        {
            get
            {
                EI ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
                    ret = (EI)t;
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
        /// Returns Order Status(ORC-5).
        ///</summary>
        public ID OrderStatus
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(5, 0);
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
        /// Returns Response Flag(ORC-6).
        ///</summary>
        public ID ResponseFlag
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns Quantity/Timing(ORC-7).
        ///</summary>
        public TQ QuantityTiming
        {
            get
            {
                TQ ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
                    ret = (TQ)t;
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
        /// Returns Parent(ORC-8).
        ///</summary>
        public CM_EIP Parent
        {
            get
            {
                CM_EIP ret = null;
                try
                {
                    IType t = this.GetField(8, 0);
                    ret = (CM_EIP)t;
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
        /// Returns Date/Time of Transaction(ORC-9).
        ///</summary>
        public TS DateTimeOfTransaction
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

        ///<summary>
        /// Returns Entered By(ORC-10).
        ///</summary>
        public XCN EnteredBy
        {
            get
            {
                XCN ret = null;
                try
                {
                    IType t = this.GetField(10, 0);
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
        /// Returns Verified By(ORC-11).
        ///</summary>
        public XCN VerifiedBy
        {
            get
            {
                XCN ret = null;
                try
                {
                    IType t = this.GetField(11, 0);
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
        /// Returns a single repetition of Ordering Provider(ORC-12).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XCN getOrderingProvider(int rep)
        {
            XCN ret = null;
            try
            {
                IType t = this.GetField(12, rep);
                ret = (XCN)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Ordering Provider (ORC-12).
        ///</summary>
        public XCN[] getOrderingProvider()
        {
            XCN[] ret = null;
            try
            {
                IType[] t = this.GetField(12);
                ret = new XCN[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (XCN)t[i];
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
        /// Returns Enterer's Location(ORC-13).
        ///</summary>
        public PL EntererSLocation
        {
            get
            {
                PL ret = null;
                try
                {
                    IType t = this.GetField(13, 0);
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
        /// Returns a single repetition of Call Back Phone Number(ORC-14).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TN getCallBackPhoneNumber(int rep)
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
        /// Returns all repetitions of Call Back Phone Number (ORC-14).
        ///</summary>
        public TN[] getCallBackPhoneNumber()
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
        /// Returns Order Effective Date/Time(ORC-15).
        ///</summary>
        public TS OrderEffectiveDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(15, 0);
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
        /// Returns Order Control Code Reason(ORC-16).
        ///</summary>
        public CE OrderControlCodeReason
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

        ///<summary>
        /// Returns Entering Organization(ORC-17).
        ///</summary>
        public CE EnteringOrganization
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(17, 0);
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
        /// Returns Entering Device(ORC-18).
        ///</summary>
        public CE EnteringDevice
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
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
        /// Returns Action By(ORC-19).
        ///</summary>
        public XCN ActionBy
        {
            get
            {
                XCN ret = null;
                try
                {
                    IType t = this.GetField(19, 0);
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


    }
}