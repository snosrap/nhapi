using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V22.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V22.Group
{
    ///<summary>
    ///Represents the ORM_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: OBR (OBSERVATION REQUEST) 
    /// * 1: RQD (REQUISITION DETAIL) 
    /// * 2: RQ1 (REQUISITION DETAIL-!) 
    /// * 3: RXO (PHARMACY PRESCRIPTION ORDER) 
    /// * 4: ODS (DIETARY ORDERS, SUPPLEMENTS, and PREFERENCES) 
    /// * 5: ODT (DIET TRAY INSTRUCTION) 
    /// * 6: NTE (NOTES AND COMMENTS) optional repeating
    /// * 7: OBX (OBSERVATION RESULT) optional repeating
    /// * 8: NTE (NOTES AND COMMENTS) repeating
    ///</summary>
    [Serializable]
    public class ORM_O01_ORDER_DETAIL : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ORM_O01_ORDER_DETAIL Group.
        ///</summary>
        public ORM_O01_ORDER_DETAIL(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(OBR), true, false);
                this.add(typeof(RQD), true, false);
                this.add(typeof(RQ1), true, false);
                this.add(typeof(RXO), true, false);
                this.add(typeof(ODS), true, false);
                this.add(typeof(ODT), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(OBX), false, true);
                this.add(typeof(NTE), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns OBR (OBSERVATION REQUEST) - creates it if necessary
        ///</summary>
        public OBR OBR
        {
            get
            {
                OBR ret = null;
                try
                {
                    ret = (OBR)this.GetStructure("OBR");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns RQD (REQUISITION DETAIL) - creates it if necessary
        ///</summary>
        public RQD RQD
        {
            get
            {
                RQD ret = null;
                try
                {
                    ret = (RQD)this.GetStructure("RQD");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns RQ1 (REQUISITION DETAIL-!) - creates it if necessary
        ///</summary>
        public RQ1 RQ1
        {
            get
            {
                RQ1 ret = null;
                try
                {
                    ret = (RQ1)this.GetStructure("RQ1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns RXO (PHARMACY PRESCRIPTION ORDER) - creates it if necessary
        ///</summary>
        public RXO RXO
        {
            get
            {
                RXO ret = null;
                try
                {
                    ret = (RXO)this.GetStructure("RXO");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns ODS (DIETARY ORDERS, SUPPLEMENTS, and PREFERENCES) - creates it if necessary
        ///</summary>
        public ODS ODS
        {
            get
            {
                ODS ret = null;
                try
                {
                    ret = (ODS)this.GetStructure("ODS");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns ODT (DIET TRAY INSTRUCTION) - creates it if necessary
        ///</summary>
        public ODT ODT
        {
            get
            {
                ODT ret = null;
                try
                {
                    ret = (ODT)this.GetStructure("ODT");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

        ///<summary>
        /// Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary
        ///</summary>
        public NTE getNTE()
        {
            NTE ret = null;
            try
            {
                ret = (NTE)this.GetStructure("NTE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NTE
        /// * (NOTES AND COMMENTS) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NTE getNTE(int rep)
        {
            return (NTE)this.GetStructure("NTE", rep);
        }

        /** 
         * Returns the number of existing repetitions of NTE 
         */
        public int NTEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NTE").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns  first repetition of OBX (OBSERVATION RESULT) - creates it if necessary
        ///</summary>
        public OBX getOBX()
        {
            OBX ret = null;
            try
            {
                ret = (OBX)this.GetStructure("OBX");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of OBX
        /// * (OBSERVATION RESULT) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public OBX getOBX(int rep)
        {
            return (OBX)this.GetStructure("OBX", rep);
        }

        /** 
         * Returns the number of existing repetitions of OBX 
         */
        public int OBXReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("OBX").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

        ///<summary>
        /// Returns  first repetition of NTE2 (NOTES AND COMMENTS) - creates it if necessary
        ///</summary>
        public NTE getNTE2()
        {
            NTE ret = null;
            try
            {
                ret = (NTE)this.GetStructure("NTE2");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NTE2
        /// * (NOTES AND COMMENTS) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NTE getNTE2(int rep)
        {
            return (NTE)this.GetStructure("NTE2", rep);
        }

        /** 
         * Returns the number of existing repetitions of NTE2 
         */
        public int NTE2Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NTE2").Length;
                }
                catch (HL7Exception e)
                {
                    string message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.getHapiLog(GetType()).error(message, e);
                    throw new System.Exception(message);
                }
                return reps;
            }
        }

    }
}
