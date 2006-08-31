using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V23.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V23.Segment
{

    ///<summary>
    /// Represents an HL7 ERR message segment. 
    /// This segment has the following fields:
    /// * ERR-1: Error Code and Location (CM_ELD)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class ERR : AbstractSegment
    {

        /**
         * Creates a ERR (Error segment) segment object that belongs to the given 
         * message.  
         */
        public ERR(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(CM_ELD), true, 0, 80, new System.Object[] { message }, "Error Code and Location");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns a single repetition of Error Code and Location(ERR-1).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public CM_ELD getErrorCodeAndLocation(int rep)
        {
            CM_ELD ret = null;
            try
            {
                IType t = this.GetField(1, rep);
                ret = (CM_ELD)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of Error Code and Location (ERR-1).
        ///</summary>
        public CM_ELD[] getErrorCodeAndLocation()
        {
            CM_ELD[] ret = null;
            try
            {
                IType[] t = this.GetField(1);
                ret = new CM_ELD[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (CM_ELD)t[i];
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