using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 EVN message segment. 
    /// This segment has the following fields:
    /// * EVN-1: Event Type Code (ID)
    /// * EVN-2: Date / time of event (TS)
    /// * EVN-3: Date / time planned event (TS)
    /// * EVN-4: Event Reason Code (ID)
    /// * EVN-5: Operator ID (ID)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class EVN : AbstractSegment
    {

        /**
         * Creates a EVN (EVENT TYPE) segment object that belongs to the given 
         * message.  
         */
        public EVN(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ID), true, 1, 3, new System.Object[] { message, 3 }, "Event Type Code");
                this.add(typeof(TS), true, 1, 26, new System.Object[] { message }, "Date / time of event");
                this.add(typeof(TS), false, 1, 26, new System.Object[] { message }, "Date / time planned event");
                this.add(typeof(ID), false, 1, 3, new System.Object[] { message, 62 }, "Event Reason Code");
                this.add(typeof(ID), false, 1, 5, new System.Object[] { message, 188 }, "Operator ID");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Event Type Code(EVN-1).
        ///</summary>
        public ID EventTypeCode
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
        /// Returns Date / time of event(EVN-2).
        ///</summary>
        public TS DateTimeOfEvent
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns Date / time planned event(EVN-3).
        ///</summary>
        public TS DateTimePlannedEvent
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns Event Reason Code(EVN-4).
        ///</summary>
        public ID EventReasonCode
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(4, 0);
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
        /// Returns Operator ID(EVN-5).
        ///</summary>
        public ID OperatorID
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


    }
}