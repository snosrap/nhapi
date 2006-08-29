using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V22.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V22.Segment
{

    ///<summary>
    /// Represents an HL7 RXC message segment. 
    /// This segment has the following fields:
    /// * RXC-1: RX Component Type (ID)
    /// * RXC-2: Component Code (CE)
    /// * RXC-3: Component Amount (NM)
    /// * RXC-4: Component Units (CE)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class RXC : AbstractSegment
    {

        /**
         * Creates a RXC (PHARMACY COMPONENT ORDER) segment object that belongs to the given 
         * message.  
         */
        public RXC(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ID), true, 1, 1, new System.Object[] { message, 166 }, "RX Component Type");
                this.add(typeof(CE), true, 1, 100, new System.Object[] { message }, "Component Code");
                this.add(typeof(NM), true, 1, 20, new System.Object[] { message }, "Component Amount");
                this.add(typeof(CE), true, 1, 20, new System.Object[] { message }, "Component Units");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns RX Component Type(RXC-1).
        ///</summary>
        public ID RXComponentType
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
        /// Returns Component Code(RXC-2).
        ///</summary>
        public CE ComponentCode
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns Component Amount(RXC-3).
        ///</summary>
        public NM ComponentAmount
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
        /// Returns Component Units(RXC-4).
        ///</summary>
        public CE ComponentUnits
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


    }
}