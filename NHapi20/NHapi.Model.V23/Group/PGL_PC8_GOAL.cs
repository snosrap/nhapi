using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the PGL_PC8_GOAL Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: GOL (Goal Detail) 
    /// * 1: NTE (Notes and comments segment) optional repeating
    /// * 2: VAR (Variance) optional repeating
    /// * 3: PGL_PC8_GOAL_ROLE (a Group object) optional repeating
    /// * 4: PGL_PC8_PATHWAY (a Group object) optional repeating
    /// * 5: PGL_PC8_OBSERVATION (a Group object) optional repeating
    /// * 6: PGL_PC8_PROBLEM (a Group object) optional repeating
    /// * 7: PGL_PC8_ORDER (a Group object) optional repeating
    ///</summary>
    [Serializable]
    public class PGL_PC8_GOAL : AbstractGroup
    {

        ///<summary> 
        /// Creates a new PGL_PC8_GOAL Group.
        ///</summary>
        public PGL_PC8_GOAL(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(GOL), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(VAR), false, true);
                this.add(typeof(PGL_PC8_GOAL_ROLE), false, true);
                this.add(typeof(PGL_PC8_PATHWAY), false, true);
                this.add(typeof(PGL_PC8_OBSERVATION), false, true);
                this.add(typeof(PGL_PC8_PROBLEM), false, true);
                this.add(typeof(PGL_PC8_ORDER), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PGL_PC8_GOAL - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns GOL (Goal Detail) - creates it if necessary
        ///</summary>
        public GOL GOL
        {
            get
            {
                GOL ret = null;
                try
                {
                    ret = (GOL)this.GetStructure("GOL");
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
        /// Returns  first repetition of VAR (Variance) - creates it if necessary
        ///</summary>
        public VAR getVAR()
        {
            VAR ret = null;
            try
            {
                ret = (VAR)this.GetStructure("VAR");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of VAR
        /// * (Variance) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public VAR getVAR(int rep)
        {
            return (VAR)this.GetStructure("VAR", rep);
        }

        /** 
         * Returns the number of existing repetitions of VAR 
         */
        public int VARReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("VAR").Length;
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
        /// Returns  first repetition of PGL_PC8_GOAL_ROLE (a Group object) - creates it if necessary
        ///</summary>
        public PGL_PC8_GOAL_ROLE getGOAL_ROLE()
        {
            PGL_PC8_GOAL_ROLE ret = null;
            try
            {
                ret = (PGL_PC8_GOAL_ROLE)this.GetStructure("GOAL_ROLE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PGL_PC8_GOAL_ROLE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PGL_PC8_GOAL_ROLE getGOAL_ROLE(int rep)
        {
            return (PGL_PC8_GOAL_ROLE)this.GetStructure("GOAL_ROLE", rep);
        }

        /** 
         * Returns the number of existing repetitions of PGL_PC8_GOAL_ROLE 
         */
        public int GOAL_ROLEReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("GOAL_ROLE").Length;
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
        /// Returns  first repetition of PGL_PC8_PATHWAY (a Group object) - creates it if necessary
        ///</summary>
        public PGL_PC8_PATHWAY getPATHWAY()
        {
            PGL_PC8_PATHWAY ret = null;
            try
            {
                ret = (PGL_PC8_PATHWAY)this.GetStructure("PATHWAY");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PGL_PC8_PATHWAY
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PGL_PC8_PATHWAY getPATHWAY(int rep)
        {
            return (PGL_PC8_PATHWAY)this.GetStructure("PATHWAY", rep);
        }

        /** 
         * Returns the number of existing repetitions of PGL_PC8_PATHWAY 
         */
        public int PATHWAYReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("PATHWAY").Length;
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
        /// Returns  first repetition of PGL_PC8_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public PGL_PC8_OBSERVATION getOBSERVATION()
        {
            PGL_PC8_OBSERVATION ret = null;
            try
            {
                ret = (PGL_PC8_OBSERVATION)this.GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PGL_PC8_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PGL_PC8_OBSERVATION getOBSERVATION(int rep)
        {
            return (PGL_PC8_OBSERVATION)this.GetStructure("OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of PGL_PC8_OBSERVATION 
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
        /// Returns  first repetition of PGL_PC8_PROBLEM (a Group object) - creates it if necessary
        ///</summary>
        public PGL_PC8_PROBLEM getPROBLEM()
        {
            PGL_PC8_PROBLEM ret = null;
            try
            {
                ret = (PGL_PC8_PROBLEM)this.GetStructure("PROBLEM");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PGL_PC8_PROBLEM
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PGL_PC8_PROBLEM getPROBLEM(int rep)
        {
            return (PGL_PC8_PROBLEM)this.GetStructure("PROBLEM", rep);
        }

        /** 
         * Returns the number of existing repetitions of PGL_PC8_PROBLEM 
         */
        public int PROBLEMReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("PROBLEM").Length;
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
        /// Returns  first repetition of PGL_PC8_ORDER (a Group object) - creates it if necessary
        ///</summary>
        public PGL_PC8_ORDER getORDER()
        {
            PGL_PC8_ORDER ret = null;
            try
            {
                ret = (PGL_PC8_ORDER)this.GetStructure("ORDER");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PGL_PC8_ORDER
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PGL_PC8_ORDER getORDER(int rep)
        {
            return (PGL_PC8_ORDER)this.GetStructure("ORDER", rep);
        }

        /** 
         * Returns the number of existing repetitions of PGL_PC8_ORDER 
         */
        public int ORDERReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("ORDER").Length;
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
