using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 OBR message segment. 
    /// This segment has the following fields:
    /// * OBR-1: Set ID - Observation Request (SI)
    /// * OBR-2: Placer Order Number (EI)
    /// * OBR-3: Filler Order Number (EI)
    /// * OBR-4: Universal Service Identifier (CE)
    /// * OBR-5: Priority (ID)
    /// * OBR-6: Requested Date/Time (TS)
    /// * OBR-7: Observation Date/Time (TS)
    /// * OBR-8: Observation End Date/Time (TS)
    /// * OBR-9: Collection Volume (CQ)
    /// * OBR-10: Collector Identifier (XCN)
    /// * OBR-11: Specimen Action Code (ID)
    /// * OBR-12: Danger Code (CE)
    /// * OBR-13: Relevant Clinical Information (ST)
    /// * OBR-14: Specimen Received Date/Time (TS)
    /// * OBR-15: Specimen Source (CM_SPS)
    /// * OBR-16: Ordering Provider (XCN)
    /// * OBR-17: Order Callback Phone Number (XTN)
    /// * OBR-18: Placer Field 1 (ST)
    /// * OBR-19: Placer Field 2 (ST)
    /// * OBR-20: Filler Field 1 (ST)
    /// * OBR-21: Filler Field 2 (ST)
    /// * OBR-22: Results Rpt/Status Chng - Date/Time (TS)
    /// * OBR-23: Charge To Practice (CM_MOC)
    /// * OBR-24: Diagnostic Service Section ID (ID)
    /// * OBR-25: Result Status (ID)
    /// * OBR-26: Parent Result (CM_PRL)
    /// * OBR-27: Quantity/Timing (TQ)
    /// * OBR-28: Result Copies To (XCN)
    /// * OBR-29: Parent Number (CM_EIP)
    /// * OBR-30: Transportation Mode (ID)
    /// * OBR-31: Reason For Study (CE)
    /// * OBR-32: Principal Result Interpreter (CM_NDL)
    /// * OBR-33: Assistant Result Interpreter (CM_NDL)
    /// * OBR-34: Technician (CM_NDL)
    /// * OBR-35: Transcriptionist (CM_NDL)
    /// * OBR-36: Scheduled Date/Time (TS)
    /// * OBR-37: Number Of Sample Containers (NM)
    /// * OBR-38: Transport Logistics Of Collected Sample (CE)
    /// * OBR-39: Collector’s Comment (CE)
    /// * OBR-40: Transport Arrangement Responsibility (CE)
    /// * OBR-41: Transport Arranged (ID)
    /// * OBR-42: Escort Required (ID)
    /// * OBR-43: Planned Patient Transport Comment (CE)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class OBR : AbstractSegment
    {

        /**
         * Creates a OBR (Observation request segment) segment object that belongs to the given 
         * message.  
         */
        public OBR(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), false, 1, 4, new System.Object[] { message }, "Set ID - Observation Request");
                this.add(typeof(EI), false, 0, 22, new System.Object[] { message }, "Placer Order Number");
                this.add(typeof(EI), false, 1, 22, new System.Object[] { message }, "Filler Order Number");
                this.add(typeof(CE), true, 1, 200, new System.Object[] { message }, "Universal Service Identifier");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 0 }, "Priority");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Requested Date/Time");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Observation Date/Time");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Observation End Date/Time");
                this.add(typeof(CQ), false, 1, 20, new System.Object[] { message }, "Collection Volume");
                this.add(typeof(XCN), false, 0, 60, new System.Object[] { message }, "Collector Identifier");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 65 }, "Specimen Action Code");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Danger Code");
                this.add(typeof(ST), false, 1, 300, new System.Object[] { message }, "Relevant Clinical Information");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Specimen Received Date/Time");
                this.add(typeof(CM_SPS), false, 1, 300, new System.Object[] { message }, "Specimen Source");
                this.add(typeof(XCN), false, 0, 120, new System.Object[] { message }, "Ordering Provider");
                this.add(typeof(XTN), false, 2, 40, new System.Object[] { message }, "Order Callback Phone Number");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Placer Field 1");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Placer Field 2");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Filler Field 1");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Filler Field 2");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Results Rpt/Status Chng - Date/Time");
                this.add(typeof(CM_MOC), false, 1, 40, new System.Object[] { message }, "Charge To Practice");
                this.add(typeof(ID), false, 1, 10, new System.Object[] { message, 74 }, "Diagnostic Service Section ID");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 123 }, "Result Status");
                this.add(typeof(CM_PRL), false, 1, 200, new System.Object[] { message }, "Parent Result");
                this.add(typeof(TQ), true, 1, 200, new System.Object[] { message }, "Quantity/Timing");
                this.add(typeof(XCN), false, 5, 150, new System.Object[] { message }, "Result Copies To");
                this.add(typeof(CM_EIP), false, 1, 150, new System.Object[] { message }, "Parent Number");
                this.add(typeof(ID), false, 1, 20, new System.Object[] { message, 124 }, "Transportation Mode");
                this.add(typeof(CE), false, 0, 300, new System.Object[] { message }, "Reason For Study");
                this.add(typeof(CM_NDL), false, 1, 200, new System.Object[] { message }, "Principal Result Interpreter");
                this.add(typeof(CM_NDL), false, 0, 200, new System.Object[] { message }, "Assistant Result Interpreter");
                this.add(typeof(CM_NDL), false, 0, 200, new System.Object[] { message }, "Technician");
                this.add(typeof(CM_NDL), false, 0, 200, new System.Object[] { message }, "Transcriptionist");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Scheduled Date/Time");
                this.add(typeof(NM), false, 1, 4, new System.Object[] { message }, "Number Of Sample Containers");
                this.add(typeof(CE), false, 0, 60, new System.Object[] { message }, "Transport Logistics Of Collected Sample");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Collector’s Comment");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Transport Arrangement Responsibility");
                this.add(typeof(ID), false, 1, 30, new System.Object[] { message, 224 }, "Transport Arranged");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 225 }, "Escort Required");
                this.add(typeof(CE), false, 0, 200, new System.Object[] { message }, "Planned Patient Transport Comment");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Set ID - Observation Request(OBR-1).
        ///</summary>
        public SI SetIDObservationRequest
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
        /// Returns a single repetition of Placer Order Number(OBR-2).
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
        /// Returns all repetitions of Placer Order Number (OBR-2).
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
        /// Returns Filler Order Number(OBR-3).
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
        /// Returns Universal Service Identifier(OBR-4).
        ///</summary>
        public CE UniversalServiceIdentifier
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
        /// Returns Priority(OBR-5).
        ///</summary>
        public ID Priority
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
        /// Returns Requested Date/Time(OBR-6).
        ///</summary>
        public TS RequestedDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(6, 0);
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
        /// Returns Observation Date/Time(OBR-7).
        ///</summary>
        public TS ObservationDateTime
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
        /// Returns Observation End Date/Time(OBR-8).
        ///</summary>
        public TS ObservationEndDateTime
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
        /// Returns Collection Volume(OBR-9).
        ///</summary>
        public CQ CollectionVolume
        {
            get
            {
                CQ ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
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
        /// Returns a single repetition of Collector Identifier(OBR-10).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XCN getCollectorIdentifier(int rep)
        {
            XCN ret = null;
            try
            {
                IType t = this.GetField(10, rep);
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
        /// Returns all repetitions of Collector Identifier (OBR-10).
        ///</summary>
        public XCN[] getCollectorIdentifier()
        {
            XCN[] ret = null;
            try
            {
                IType[] t = this.GetField(10);
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
        /// Returns Specimen Action Code(OBR-11).
        ///</summary>
        public ID SpecimenActionCode
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
        /// Returns Danger Code(OBR-12).
        ///</summary>
        public CE DangerCode
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
        /// Returns Relevant Clinical Information(OBR-13).
        ///</summary>
        public ST RelevantClinicalInformation
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
        /// Returns Specimen Received Date/Time(OBR-14).
        ///</summary>
        public TS SpecimenReceivedDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(14, 0);
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
        /// Returns Specimen Source(OBR-15).
        ///</summary>
        public CM_SPS SpecimenSource
        {
            get
            {
                CM_SPS ret = null;
                try
                {
                    IType t = this.GetField(15, 0);
                    ret = (CM_SPS)t;
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
        /// Returns a single repetition of Ordering Provider(OBR-16).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XCN getOrderingProvider(int rep)
        {
            XCN ret = null;
            try
            {
                IType t = this.GetField(16, rep);
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
        /// Returns all repetitions of Ordering Provider (OBR-16).
        ///</summary>
        public XCN[] getOrderingProvider()
        {
            XCN[] ret = null;
            try
            {
                IType[] t = this.GetField(16);
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
        /// Returns a single repetition of Order Callback Phone Number(OBR-17).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XTN getOrderCallbackPhoneNumber(int rep)
        {
            XTN ret = null;
            try
            {
                IType t = this.GetField(17, rep);
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
        /// Returns all repetitions of Order Callback Phone Number (OBR-17).
        ///</summary>
        public XTN[] getOrderCallbackPhoneNumber()
        {
            XTN[] ret = null;
            try
            {
                IType[] t = this.GetField(17);
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
        /// Returns Placer Field 1(OBR-18).
        ///</summary>
        public ST PlacerField1
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(18, 0);
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
        /// Returns Placer Field 2(OBR-19).
        ///</summary>
        public ST PlacerField2
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
        /// Returns Filler Field 1(OBR-20).
        ///</summary>
        public ST FillerField1
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(20, 0);
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
        /// Returns Filler Field 2(OBR-21).
        ///</summary>
        public ST FillerField2
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
        /// Returns Results Rpt/Status Chng - Date/Time(OBR-22).
        ///</summary>
        public TS ResultsRptStatusChngDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(22, 0);
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
        /// Returns Charge To Practice(OBR-23).
        ///</summary>
        public CM_MOC ChargeToPractice
        {
            get
            {
                CM_MOC ret = null;
                try
                {
                    IType t = this.GetField(23, 0);
                    ret = (CM_MOC)t;
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
        /// Returns Diagnostic Service Section ID(OBR-24).
        ///</summary>
        public ID DiagnosticServiceSectionID
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
        /// Returns Result Status(OBR-25).
        ///</summary>
        public ID ResultStatus
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
        /// Returns Parent Result(OBR-26).
        ///</summary>
        public CM_PRL ParentResult
        {
            get
            {
                CM_PRL ret = null;
                try
                {
                    IType t = this.GetField(26, 0);
                    ret = (CM_PRL)t;
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
        /// Returns Quantity/Timing(OBR-27).
        ///</summary>
        public TQ QuantityTiming
        {
            get
            {
                TQ ret = null;
                try
                {
                    IType t = this.GetField(27, 0);
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
        /// Returns a single repetition of Result Copies To(OBR-28).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public XCN getResultCopiesTo(int rep)
        {
            XCN ret = null;
            try
            {
                IType t = this.GetField(28, rep);
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
        /// Returns all repetitions of Result Copies To (OBR-28).
        ///</summary>
        public XCN[] getResultCopiesTo()
        {
            XCN[] ret = null;
            try
            {
                IType[] t = this.GetField(28);
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
        /// Returns Parent Number(OBR-29).
        ///</summary>
        public CM_EIP ParentNumber
        {
            get
            {
                CM_EIP ret = null;
                try
                {
                    IType t = this.GetField(29, 0);
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
        /// Returns Transportation Mode(OBR-30).
        ///</summary>
        public ID TransportationMode
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

        ///<summary>
        /// Returns a single repetition of Reason For Study(OBR-31).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getReasonForStudy(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(31, rep);
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
        /// Returns all repetitions of Reason For Study (OBR-31).
        ///</summary>
        public CE[] getReasonForStudy()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(31);
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
        /// Returns Principal Result Interpreter(OBR-32).
        ///</summary>
        public CM_NDL PrincipalResultInterpreter
        {
            get
            {
                CM_NDL ret = null;
                try
                {
                    IType t = this.GetField(32, 0);
                    ret = (CM_NDL)t;
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
        /// Returns a single repetition of Assistant Result Interpreter(OBR-33).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_NDL getAssistantResultInterpreter(int rep)
        {
            CM_NDL ret = null;
            try
            {
                IType t = this.GetField(33, rep);
                ret = (CM_NDL)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Assistant Result Interpreter (OBR-33).
        ///</summary>
        public CM_NDL[] getAssistantResultInterpreter()
        {
            CM_NDL[] ret = null;
            try
            {
                IType[] t = this.GetField(33);
                ret = new CM_NDL[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_NDL)t[i];
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
        /// Returns a single repetition of Technician(OBR-34).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_NDL getTechnician(int rep)
        {
            CM_NDL ret = null;
            try
            {
                IType t = this.GetField(34, rep);
                ret = (CM_NDL)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Technician (OBR-34).
        ///</summary>
        public CM_NDL[] getTechnician()
        {
            CM_NDL[] ret = null;
            try
            {
                IType[] t = this.GetField(34);
                ret = new CM_NDL[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_NDL)t[i];
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
        /// Returns a single repetition of Transcriptionist(OBR-35).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_NDL getTranscriptionist(int rep)
        {
            CM_NDL ret = null;
            try
            {
                IType t = this.GetField(35, rep);
                ret = (CM_NDL)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Transcriptionist (OBR-35).
        ///</summary>
        public CM_NDL[] getTranscriptionist()
        {
            CM_NDL[] ret = null;
            try
            {
                IType[] t = this.GetField(35);
                ret = new CM_NDL[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_NDL)t[i];
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
        /// Returns Scheduled Date/Time(OBR-36).
        ///</summary>
        public TS ScheduledDateTime
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(36, 0);
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
        /// Returns Number Of Sample Containers(OBR-37).
        ///</summary>
        public NM NumberOfSampleContainers
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
        /// Returns a single repetition of Transport Logistics Of Collected Sample(OBR-38).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getTransportLogisticsOfCollectedSample(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(38, rep);
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
        /// Returns all repetitions of Transport Logistics Of Collected Sample (OBR-38).
        ///</summary>
        public CE[] getTransportLogisticsOfCollectedSample()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(38);
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
        /// Returns a single repetition of Collector’s Comment(OBR-39).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getCollectorSComment(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(39, rep);
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
        /// Returns all repetitions of Collector’s Comment (OBR-39).
        ///</summary>
        public CE[] getCollectorSComment()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(39);
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
        /// Returns Transport Arrangement Responsibility(OBR-40).
        ///</summary>
        public CE TransportArrangementResponsibility
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(40, 0);
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
        /// Returns Transport Arranged(OBR-41).
        ///</summary>
        public ID TransportArranged
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(41, 0);
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
        /// Returns Escort Required(OBR-42).
        ///</summary>
        public ID EscortRequired
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
        /// Returns a single repetition of Planned Patient Transport Comment(OBR-43).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CE getPlannedPatientTransportComment(int rep)
        {
            CE ret = null;
            try
            {
                IType t = this.GetField(43, rep);
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
        /// Returns all repetitions of Planned Patient Transport Comment (OBR-43).
        ///</summary>
        public CE[] getPlannedPatientTransportComment()
        {
            CE[] ret = null;
            try
            {
                IType[] t = this.GetField(43);
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


    }
}