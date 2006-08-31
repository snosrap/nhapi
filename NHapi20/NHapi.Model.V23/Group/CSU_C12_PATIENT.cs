using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the CSU_C12_PATIENT Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: PID (Patient Identification) 
    /// * 1: PD1 (Patient Demographic) optional 
    /// * 2: NTE (Notes and comments segment) optional repeating
    /// * 3: CSU_C12_VISIT (a Group object) optional 
    /// * 4: CSR (Clinical Study Registration) 
    /// * 5: CSU_C12_STUDY_PHASE (a Group object) repeating
    ///</summary>
    [Serializable]
    public class CSU_C12_PATIENT : AbstractGroup
    {

        ///<summary> 
        /// Creates a new CSU_C12_PATIENT Group.
        ///</summary>
        public CSU_C12_PATIENT(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(PID), true, false);
                this.add(typeof(PD1), false, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(CSU_C12_VISIT), false, false);
                this.add(typeof(CSR), true, false);
                this.add(typeof(CSU_C12_STUDY_PHASE), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating CSU_C12_PATIENT - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns PID (Patient Identification) - creates it if necessary
        ///</summary>
        public PID PID
        {
            get
            {
                PID ret = null;
                try
                {
                    ret = (PID)this.GetStructure("PID");
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
        /// Returns PD1 (Patient Demographic) - creates it if necessary
        ///</summary>
        public PD1 PD1
        {
            get
            {
                PD1 ret = null;
                try
                {
                    ret = (PD1)this.GetStructure("PD1");
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
        /// Returns CSU_C12_VISIT (a Group object) - creates it if necessary
        ///</summary>
        public CSU_C12_VISIT VISIT
        {
            get
            {
                CSU_C12_VISIT ret = null;
                try
                {
                    ret = (CSU_C12_VISIT)this.GetStructure("VISIT");
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
        /// Returns CSR (Clinical Study Registration) - creates it if necessary
        ///</summary>
        public CSR CSR
        {
            get
            {
                CSR ret = null;
                try
                {
                    ret = (CSR)this.GetStructure("CSR");
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
        /// Returns  first repetition of CSU_C12_STUDY_PHASE (a Group object) - creates it if necessary
        ///</summary>
        public CSU_C12_STUDY_PHASE getSTUDY_PHASE()
        {
            CSU_C12_STUDY_PHASE ret = null;
            try
            {
                ret = (CSU_C12_STUDY_PHASE)this.GetStructure("STUDY_PHASE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of CSU_C12_STUDY_PHASE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public CSU_C12_STUDY_PHASE getSTUDY_PHASE(int rep)
        {
            return (CSU_C12_STUDY_PHASE)this.GetStructure("STUDY_PHASE", rep);
        }

        /** 
         * Returns the number of existing repetitions of CSU_C12_STUDY_PHASE 
         */
        public int STUDY_PHASEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("STUDY_PHASE").Length;
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
