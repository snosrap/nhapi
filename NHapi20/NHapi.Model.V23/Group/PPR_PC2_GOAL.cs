using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the PPR_PC2_GOAL Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: GOL (Goal Detail) 
    /// * 1: NTE (Notes and comments segment) optional repeating
    /// * 2: VAR (Variance) optional repeating
    /// * 3: PPR_PC2_GOAL_ROLE (a Group object) optional repeating
    /// * 4: PPR_PC2_GOAL_OBSERVATION (a Group object) optional repeating
    ///</summary>
    [Serializable]
    public class PPR_PC2_GOAL : AbstractGroup
    {

        ///<summary> 
        /// Creates a new PPR_PC2_GOAL Group.
        ///</summary>
        public PPR_PC2_GOAL(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(GOL), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(VAR), false, true);
                this.add(typeof(PPR_PC2_GOAL_ROLE), false, true);
                this.add(typeof(PPR_PC2_GOAL_OBSERVATION), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPR_PC2_GOAL - this is probably a bug in the source code generator.", e);
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
        /// Returns  first repetition of PPR_PC2_GOAL_ROLE (a Group object) - creates it if necessary
        ///</summary>
        public PPR_PC2_GOAL_ROLE getGOAL_ROLE()
        {
            PPR_PC2_GOAL_ROLE ret = null;
            try
            {
                ret = (PPR_PC2_GOAL_ROLE)this.GetStructure("GOAL_ROLE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PPR_PC2_GOAL_ROLE
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PPR_PC2_GOAL_ROLE getGOAL_ROLE(int rep)
        {
            return (PPR_PC2_GOAL_ROLE)this.GetStructure("GOAL_ROLE", rep);
        }

        /** 
         * Returns the number of existing repetitions of PPR_PC2_GOAL_ROLE 
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
        /// Returns  first repetition of PPR_PC2_GOAL_OBSERVATION (a Group object) - creates it if necessary
        ///</summary>
        public PPR_PC2_GOAL_OBSERVATION getGOAL_OBSERVATION()
        {
            PPR_PC2_GOAL_OBSERVATION ret = null;
            try
            {
                ret = (PPR_PC2_GOAL_OBSERVATION)this.GetStructure("GOAL_OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of PPR_PC2_GOAL_OBSERVATION
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public PPR_PC2_GOAL_OBSERVATION getGOAL_OBSERVATION(int rep)
        {
            return (PPR_PC2_GOAL_OBSERVATION)this.GetStructure("GOAL_OBSERVATION", rep);
        }

        /** 
         * Returns the number of existing repetitions of PPR_PC2_GOAL_OBSERVATION 
         */
        public int GOAL_OBSERVATIONReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("GOAL_OBSERVATION").Length;
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
