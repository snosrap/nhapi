using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 OBR message segment. 
    /// This segment has the following fields:
    /// * OBR-1: Set ID - Observation Request (SI)
    /// * OBR-2: Placer Order Number (CM_PLACER)
    /// * OBR-3: Filler Order Number (CM_FILLER)
    /// * OBR-4: Universal Service ID (CE)
    /// * OBR-5: Priority (not used) (ID)
    /// * OBR-6: Requested date / time (not used) (TS)
    /// * OBR-7: Observation date / time (TS)
    /// * OBR-8: Observation end date / time (TS)
    /// * OBR-9: Collection Volume (CQ_QUANTITY)
    /// * OBR-10: Collector Identifier (CN_PERSON)
    /// * OBR-11: Specimen action code (ID)
    /// * OBR-12: Danger Code (CE)
    /// * OBR-13: Relevant clinical information (ST)
    /// * OBR-14: Specimen received date / time (TS)
    /// * OBR-15: Specimen source (CM_SPS)
    /// * OBR-16: Ordering Provider (CN_PERSON)
    /// * OBR-17: Order Callback Phone Number (TN)
    /// * OBR-18: Placer field 1 (ST)
    /// * OBR-19: Placer field 2 (ST)
    /// * OBR-20: Filler Field 1 (ST)
    /// * OBR-21: Filler Field 2 (ST)
    /// * OBR-22: Results report / status change - date / time (TS)
    /// * OBR-23: Charge to Practice (CM_MOC)
    /// * OBR-24: Diagnostic service section ID (ID)
    /// * OBR-25: Result Status (ID)
    /// * OBR-26: Parent Result (CM_PARENT_RESULT)
    /// * OBR-27: Quantity / timing (TQ)
    /// * OBR-28: Result Copies To (CN_PERSON)
    /// * OBR-29: Parent Number (CM_EIP)
    /// * OBR-30: Transportation Mode (ID)
    /// * OBR-31: Reason for Study (CE)
    /// * OBR-32: Principal Result Interpreter (CM_NDL)
    /// * OBR-33: Assistant Result Interpreter (CM_NDL)
    /// * OBR-34: Technician (CM_NDL)
    /// * OBR-35: Transcriptionist (CM_NDL)
    /// * OBR-36: Scheduled date / time (TS)
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
         * Creates a OBR (OBSERVATION REQUEST) segment object that belongs to the given 
         * message.  
         */
        public OBR(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(SI), false, 1, 4, new System.Object[] { message }, "Set ID - Observation Request");
                this.add(typeof(CM_PLACER), false, 1, 75, new System.Object[] { message }, "Placer Order Number");
                this.add(typeof(CM_FILLER), false, 1, 75, new System.Object[] { message }, "Filler Order Number");
                this.add(typeof(CE), true, 1, 200, new System.Object[] { message }, "Universal Service ID");
                this.add(typeof(ID), false, 1, 2, new System.Object[] { message, 0 }, "Priority (not used)");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Requested date / time (not used)");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Observation date / time");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Observation end date / time");
                this.add(typeof(CQ_QUANTITY), false, 1, 20, new System.Object[] { message }, "Collection Volume");
                this.add(typeof(CN_PERSON), false, 0, 60, new System.Object[] { message }, "Collector Identifier");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 65 }, "Specimen action code");
                this.add(typeof(CE), false, 1, 60, new System.Object[] { message }, "Danger Code");
                this.add(typeof(ST), false, 1, 300, new System.Object[] { message }, "Relevant clinical information");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Specimen received date / time");
                this.add(typeof(CM_SPS), false, 1, 300, new System.Object[] { message }, "Specimen source");
                this.add(typeof(CN_PERSON), false, 1, 80, new System.Object[] { message }, "Ordering Provider");
                this.add(typeof(TN), false, 2, 40, new System.Object[] { message }, "Order Callback Phone Number");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Placer field 1");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Placer field 2");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Filler Field 1");
                this.add(typeof(ST), false, 1, 60, new System.Object[] { message }, "Filler Field 2");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Results report / status change - date / time");
                this.add(typeof(CM_MOC), false, 1, 40, new System.Object[] { message }, "Charge to Practice");
                this.add(typeof(ID), false, 1, 10, new System.Object[] { message, 74 }, "Diagnostic service section ID");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 123 }, "Result Status");
                this.add(typeof(CM_PARENT_RESULT), false, 1, 200, new System.Object[] { message }, "Parent Result");
                this.add(typeof(TQ), false, 0, 200, new System.Object[] { message }, "Quantity / timing");
                this.add(typeof(CN_PERSON), false, 5, 150, new System.Object[] { message }, "Result Copies To");
                this.add(typeof(CM_EIP), false, 1, 150, new System.Object[] { message }, "Parent Number");
                this.add(typeof(ID), false, 1, 20, new System.Object[] { message, 124 }, "Transportation Mode");
                this.add(typeof(CE), false, 0, 300, new System.Object[] { message }, "Reason for Study");
                this.add(typeof(CM_NDL), false, 1, 60, new System.Object[] { message }, "Principal Result Interpreter");
                this.add(typeof(CM_NDL), false, 0, 60, new System.Object[] { message }, "Assistant Result Interpreter");
                this.add(typeof(CM_NDL), false, 0, 60, new System.Object[] { message }, "Technician");
                this.add(typeof(CM_NDL), false, 0, 60, new System.Object[] { message }, "Transcriptionist");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Scheduled date / time");
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
        /// Returns Placer Order Number(OBR-2).
        ///</summary>
        public CM_PLACER PlacerOrderNumber
        {
            get
            {
                CM_PLACER ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
                    ret = (CM_PLACER)t;
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
        /// Returns Filler Order Number(OBR-3).
        ///</summary>
        public CM_FILLER FillerOrderNumber
        {
            get
            {
                CM_FILLER ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
                    ret = (CM_FILLER)t;
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
        /// Returns Universal Service ID(OBR-4).
        ///</summary>
        public CE UniversalServiceID
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
        /// Returns Priority (not used)(OBR-5).
        ///</summary>
        public ID PriorityNotused
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
        /// Returns Requested date / time (not used)(OBR-6).
        ///</summary>
        public TS RequestedDateTimeNotused
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
        /// Returns Observation date / time(OBR-7).
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
        /// Returns Observation end date / time(OBR-8).
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
        public CQ_QUANTITY CollectionVolume
        {
            get
            {
                CQ_QUANTITY ret = null;
                try
                {
                    IType t = this.GetField(9, 0);
                    ret = (CQ_QUANTITY)t;
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
        public CN_PERSON getCollectorIdentifier(int rep)
        {
            CN_PERSON ret = null;
            try
            {
                IType t = this.GetField(10, rep);
                ret = (CN_PERSON)t;
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
        public CN_PERSON[] getCollectorIdentifier()
        {
            CN_PERSON[] ret = null;
            try
            {
                IType[] t = this.GetField(10);
                ret = new CN_PERSON[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CN_PERSON)t[i];
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
        /// Returns Specimen action code(OBR-11).
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
        /// Returns Relevant clinical information(OBR-13).
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
        /// Returns Specimen received date / time(OBR-14).
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
        /// Returns Specimen source(OBR-15).
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
        /// Returns Ordering Provider(OBR-16).
        ///</summary>
        public CN_PERSON OrderingProvider
        {
            get
            {
                CN_PERSON ret = null;
                try
                {
                    IType t = this.GetField(16, 0);
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
        /// Returns a single repetition of Order Callback Phone Number(OBR-17).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TN getOrderCallbackPhoneNumber(int rep)
        {
            TN ret = null;
            try
            {
                IType t = this.GetField(17, rep);
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
        /// Returns all repetitions of Order Callback Phone Number (OBR-17).
        ///</summary>
        public TN[] getOrderCallbackPhoneNumber()
        {
            TN[] ret = null;
            try
            {
                IType[] t = this.GetField(17);
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
        /// Returns Placer field 1(OBR-18).
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
        /// Returns Placer field 2(OBR-19).
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
        /// Returns Results report / status change - date / time(OBR-22).
        ///</summary>
        public TS ResultsReportStatusChangeDateTime
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
        /// Returns Charge to Practice(OBR-23).
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
        /// Returns Diagnostic service section ID(OBR-24).
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
        public CM_PARENT_RESULT ParentResult
        {
            get
            {
                CM_PARENT_RESULT ret = null;
                try
                {
                    IType t = this.GetField(26, 0);
                    ret = (CM_PARENT_RESULT)t;
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
        /// Returns a single repetition of Quantity / timing(OBR-27).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public TQ getQuantityTiming(int rep)
        {
            TQ ret = null;
            try
            {
                IType t = this.GetField(27, rep);
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
        /// Returns all repetitions of Quantity / timing (OBR-27).
        ///</summary>
        public TQ[] getQuantityTiming()
        {
            TQ[] ret = null;
            try
            {
                IType[] t = this.GetField(27);
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
        /// Returns a single repetition of Result Copies To(OBR-28).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CN_PERSON getResultCopiesTo(int rep)
        {
            CN_PERSON ret = null;
            try
            {
                IType t = this.GetField(28, rep);
                ret = (CN_PERSON)t;
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
        public CN_PERSON[] getResultCopiesTo()
        {
            CN_PERSON[] ret = null;
            try
            {
                IType[] t = this.GetField(28);
                ret = new CN_PERSON[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CN_PERSON)t[i];
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
        /// Returns a single repetition of Reason for Study(OBR-31).
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
        /// Returns all repetitions of Reason for Study (OBR-31).
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
        /// Returns Scheduled date / time(OBR-36).
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


    }
}