using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the ORU_R01_ORDER_OBSERVATION Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORC (Common order segment) optional 
    /// * 1: OBR (Observation request segment) 
    /// * 2: NTE (Notes and comments segment) optional repeating
    /// * 3: ORU_R01_OBSERVATION (a Group object) repeating
    /// * 4: CTI (Clinical Trial Identification) optional repeating
    ///</summary>
    [Serializable]
    public class ORU_R01_ORDER_OBSERVATION : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ORU_R01_ORDER_OBSERVATION Group.
        ///</summary>
        public ORU_R01_ORDER_OBSERVATION(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORC), false, false);
                this.add(typeof(OBR), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(ORU_R01_OBSERVATION), true, true);
                this.add(typeof(CTI), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORU_R01_ORDER_OBSERVATION - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns ORC (Common order segment) - creates it if necessary
        ///</summary>
        public ORC ORC
        {
            get
            {
                ORC ret = null;
                try
                {
                    ret = (ORC)this.GetStructure("ORC");
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
        /// Returns OBR (Observation request segment) - creates it if necessary
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
        /// Returns  first repetition of ORU_R01_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public ORU_R01_OBSERVATION getOBSERVATION()
        {
            ORU_R01_OBSERVATION ret = null;
            try
            {
                ret = (ORU_R01_OBSERVATION)this.GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of ORU_R01_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public ORU_R01_OBSERVATION getOBSERVATION(int rep)
        {
            return (ORU_R01_OBSERVATION)this.GetStructure("OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of ORU_R01_OBSERVATION 
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

        ///<summary>
        /// Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary
        ///</summary>
        public CTI getCTI()
        {
            CTI ret = null;
            try
            {
                ret = (CTI)this.GetStructure("CTI");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of CTI
        /// * (Clinical Trial Identification) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public CTI getCTI(int rep)
        {
            return (CTI)this.GetStructure("CTI", rep);
        }

        /** 
         * Returns the number of existing repetitions of CTI 
         */
        public int CTIReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("CTI").Length;
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
