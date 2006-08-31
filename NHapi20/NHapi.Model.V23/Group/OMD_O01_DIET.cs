using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the OMD_O01_DIET Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ODS (Dietary orders, supplements, and preferences) repeating
    /// * 1: NTE (Notes and comments segment) optional repeating
    /// * 2: OMD_O01_OBSERVATION (a Group object) repeating
    ///</summary>
    [Serializable]
    public class OMD_O01_DIET : AbstractGroup
    {

        ///<summary> 
        /// Creates a new OMD_O01_DIET Group.
        ///</summary>
        public OMD_O01_DIET(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ODS), true, true);
                this.add(typeof(NTE), false, true);
                this.add(typeof(OMD_O01_OBSERVATION), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMD_O01_DIET - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns  first repetition of ODS (Dietary orders, supplements, and preferences) - creates it if necessary
        ///</summary>
        public ODS getODS()
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

        ///<summary>
        ///Returns a specific repetition of ODS
        /// * (Dietary orders, supplements, and preferences) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ODS getODS(int rep)
        {
            return (ODS)this.GetStructure("ODS", rep);
        }

        /** 
         * Returns the number of existing repetitions of ODS 
         */
        public int ODSReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("ODS").Length;
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
        /// Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
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
        /// * (Notes and comments segment) - creates it if necessary
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
        /// Returns  first repetition of OMD_O01_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public OMD_O01_OBSERVATION getOBSERVATION()
        {
            OMD_O01_OBSERVATION ret = null;
            try
            {
                ret = (OMD_O01_OBSERVATION)this.GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of OMD_O01_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public OMD_O01_OBSERVATION getOBSERVATION(int rep)
        {
            return (OMD_O01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of OMD_O01_OBSERVATION 
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
