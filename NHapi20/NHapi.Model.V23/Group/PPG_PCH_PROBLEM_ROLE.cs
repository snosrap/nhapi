using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the PPG_PCH_PROBLEM_ROLE Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ROL (Role) 
    /// * 1: VAR (Variance) optional repeating
    ///</summary>
    [Serializable]
    public class PPG_PCH_PROBLEM_ROLE : AbstractGroup
    {

        ///<summary> 
        /// Creates a new PPG_PCH_PROBLEM_ROLE Group.
        ///</summary>
        public PPG_PCH_PROBLEM_ROLE(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ROL), true, false);
                this.add(typeof(VAR), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPG_PCH_PROBLEM_ROLE - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns ROL (Role) - creates it if necessary
        ///</summary>
        public ROL ROL
        {
            get
            {
                ROL ret = null;
                try
                {
                    ret = (ROL)this.GetStructure("ROL");
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

    }
}
