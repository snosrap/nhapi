using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V21.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V21.Segment
{

    ///<summary>
    /// Represents an HL7 URD message segment. 
    /// This segment has the following fields:
    /// * URD-1: R/U DATE/TIME (TS)
    /// * URD-2: REPORT PRIORITY (ID)
    /// * URD-3: R/U WHO SUBJECT DEFINITION (ST)
    /// * URD-4: R/U WHAT SUBJECT DEFINITION (ID)
    /// * URD-5: R/U WHAT DEPARTMENT CODE (ST)
    /// * URD-6: R/U DISPLAY/PRINT LOCATIONS (ST)
    /// * URD-7: R/U RESULTS LEVEL (ID)
    /// The get...() methods return data from individual fields.  These methods 
    /// do not throw exceptions and may therefore have to handle exceptions internally.  
    /// If an exception is handled internally, it is logged and null is returned.  
    /// This is not expected to happen - if it does happen this indicates not so much 
    /// an exceptional circumstance as a bug in the code for this class.
    ///</summary>
    [Serializable]
    public class URD : AbstractSegment
    {

        /**
         * Creates a URD (RESULTS/UPDATE DEFINITION) segment object that belongs to the given 
         * message.  
         */
        public URD(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            IMessage message = Message;
            try
            {
                this.add(typeof(TS), false, 1, 19, new System.Object[] { message }, "R/U DATE/TIME");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 109 }, "REPORT PRIORITY");
                this.add(typeof(ST), true, 0, 20, new System.Object[] { message }, "R/U WHO SUBJECT DEFINITION");
                this.add(typeof(ID), false, 0, 3, new System.Object[] { message, 48 }, "R/U WHAT SUBJECT DEFINITION");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "R/U WHAT DEPARTMENT CODE");
                this.add(typeof(ST), false, 0, 20, new System.Object[] { message }, "R/U DISPLAY/PRINT LOCATIONS");
                this.add(typeof(ID), false, 1, 1, new System.Object[] { message, 108 }, "R/U RESULTS LEVEL");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + GetType().Name, he);
            }
        }

        ///<summary>
        /// Returns R/U DATE/TIME(URD-1).
        ///</summary>
        public TS RUDATETIME
        {
            get
            {
                TS ret = null;
                try
                {
                    IType t = this.GetField(1, 0);
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
        /// Returns REPORT PRIORITY(URD-2).
        ///</summary>
        public ID REPORTPRIORITY
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
        /// Returns a single repetition of R/U WHO SUBJECT DEFINITION(URD-3).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUWHOSUBJECTDEFINITION(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(3, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U WHO SUBJECT DEFINITION (URD-3).
        ///</summary>
        public ST[] getRUWHOSUBJECTDEFINITION()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(3);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
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
        /// Returns a single repetition of R/U WHAT SUBJECT DEFINITION(URD-4).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ID getRUWHATSUBJECTDEFINITION(int rep)
        {
            ID ret = null;
            try
            {
                IType t = this.GetField(4, rep);
                ret = (ID)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U WHAT SUBJECT DEFINITION (URD-4).
        ///</summary>
        public ID[] getRUWHATSUBJECTDEFINITION()
        {
            ID[] ret = null;
            try
            {
                IType[] t = this.GetField(4);
                ret = new ID[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ID)t[i];
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
        /// Returns a single repetition of R/U WHAT DEPARTMENT CODE(URD-5).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUWHATDEPARTMENTCODE(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(5, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U WHAT DEPARTMENT CODE (URD-5).
        ///</summary>
        public ST[] getRUWHATDEPARTMENTCODE()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(5);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
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
        /// Returns a single repetition of R/U DISPLAY/PRINT LOCATIONS(URD-6).
        /// throws HL7Exception if the repetition number is invalid.
        /// <param name="rep">The repetition number (this is a repeating field)</param>
        ///</summary>
        public ST getRUDISPLAYPRINTLOCATIONS(int rep)
        {
            ST ret = null;
            try
            {
                IType t = this.GetField(6, rep);
                ret = (ST)t;
            }
            catch (System.Exception ex)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new System.Exception("An unexpected error ocurred", ex);
            }
            return ret;
        }

        ///<summary>
        /// Returns all repetitions of R/U DISPLAY/PRINT LOCATIONS (URD-6).
        ///</summary>
        public ST[] getRUDISPLAYPRINTLOCATIONS()
        {
            ST[] ret = null;
            try
            {
                IType[] t = this.GetField(6);
                ret = new ST[t.Length];
                for (int i = 0; i < ret.Length; i++)
                {
                    ret[i] = (ST)t[i];
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
        /// Returns R/U RESULTS LEVEL(URD-7).
        ///</summary>
        public ID RURESULTSLEVEL
        {
            get
            {
                ID ret = null;
                try
                {
                    IType t = this.GetField(7, 0);
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