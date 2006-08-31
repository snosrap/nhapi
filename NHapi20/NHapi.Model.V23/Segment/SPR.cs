using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 SPR message segment. 
    /// This segment has the following fields:
    /// * SPR-1: Query tag (ST)
    /// * SPR-2: Query/ Response Format Code (ID)
    /// * SPR-3: Stored procedure name (CE)
    /// * SPR-4: Input parameter list (QIP)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class SPR : AbstractSegment
    {

        /**
         * Creates a SPR (Stored Procedure Request Definition) segment object that belongs to the given 
         * message.  
         */
        public SPR(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(ST), false, 1, 32, new System.Object[] { message }, "Query tag");
                this.add(typeof(ID), true, 1, 1, new System.Object[] { message, 106 }, "Query/ Response Format Code");
                this.add(typeof(CE), true, 1, 60, new System.Object[] { message }, "Stored procedure name");
                this.add(typeof(QIP), false, 0, 256, new System.Object[] { message }, "Input parameter list");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns Query tag(SPR-1).
        ///</summary>
        public ST QueryTag
        {
            get
            {
                ST ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns Query/ Response Format Code(SPR-2).
        ///</summary>
        public ID QueryResponseFormatCode
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(2, 0);
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
        /// Returns Stored procedure name(SPR-3).
        ///</summary>
        public CE StoredProcedureName
        {
            get
            {
                CE ret = null;
                try
                {
                    IType t = this.GetField(3, 0);
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
        /// Returns a single repetition of Input parameter list(SPR-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public QIP getInputParameterList(int rep)
        {
            QIP ret = null;
            try
            {
                IType t = this.GetField(4, rep);
                ret = (QIP)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Input parameter list (SPR-4).
        ///</summary>
        public QIP[] getInputParameterList()
        {
            QIP[] ret = null;
            try
            {
                IType[] t = this.GetField(4);
                ret = new QIP[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (QIP)t[i];
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