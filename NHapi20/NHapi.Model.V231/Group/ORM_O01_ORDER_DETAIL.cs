using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the ORM_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: OBR (OBR - observation request segment) 
    /// * 1: RQD (RQD - requisition detail segment) 
    /// * 2: RQ1 (RQ1 - requisition detail-1 segment) 
    /// * 3: ODS (ODS - dietary orders, supplements, and preferences segment) 
    /// * 4: ODT (ODT - diet tray instructions segment) 
    /// * 5: RXO (RXO - pharmacy/treatment order segment) 
    /// * 6: NTE (NTE - notes and comments segment) optional repeating
    /// * 7: DG1 (DG1 - diagnosis segment) optional repeating
    /// * 8: ORM_O01_OBSERVATION (a Group object) optional repeating
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
                this.add(typeof(ODS), true, false);
                this.add(typeof(ODT), true, false);
                this.add(typeof(RXO), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(DG1), false, true);
                this.add(typeof(ORM_O01_OBSERVATION), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns OBR (OBR - observation request segment) - creates it if necessary
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
        /// Returns RQD (RQD - requisition detail segment) - creates it if necessary
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
        /// Returns RQ1 (RQ1 - requisition detail-1 segment) - creates it if necessary
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
        /// Returns ODS (ODS - dietary orders, supplements, and preferences segment) - creates it if necessary
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
        /// Returns ODT (ODT - diet tray instructions segment) - creates it if necessary
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
        /// Returns RXO (RXO - pharmacy/treatment order segment) - creates it if necessary
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
        /// Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
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
        /// * (NTE - notes and comments segment) - creates it if necessary
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
        /// Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary
        ///</summary>
        public DG1 getDG1()
        {
            DG1 ret = null;
            try
            {
                ret = (DG1)this.GetStructure("DG1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DG1
        /// * (DG1 - diagnosis segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DG1 getDG1(int rep)
        {
            return (DG1)this.GetStructure("DG1", rep);
        }

        /** 
         * Returns the number of existing repetitions of DG1 
         */
        public int DG1Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DG1").Length;
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
        /// Returns  first repetition of ORM_O01_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public ORM_O01_OBSERVATION getOBSERVATION()
        {
            ORM_O01_OBSERVATION ret = null;
            try
            {
                ret = (ORM_O01_OBSERVATION)this.GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ORM_O01_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ORM_O01_OBSERVATION getOBSERVATION(int rep)
        {
            return (ORM_O01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of ORM_O01_OBSERVATION 
         */
        public int OBSERVATIONReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("OBSERVATION").Length;
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
