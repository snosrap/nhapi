using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the RRI_I12_OBSERVATION Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: OBR (OBR - observation request segment) 
    /// * 1: NTE (NTE - notes and comments segment) optional repeating
    /// * 2: RRI_I12_RESULTS_NOTES (a Group object) optional repeating
    ///</summary>
    [Serializable]
    public class RRI_I12_OBSERVATION : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RRI_I12_OBSERVATION Group.
        ///</summary>
        public RRI_I12_OBSERVATION(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(OBR), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(RRI_I12_RESULTS_NOTES), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRI_I12_OBSERVATION - this is probably a bug in the source code generator.", e);
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
        /// Returns  first repetition of RRI_I12_RESULTS_NOTES (a Group object) - creates it if necessary
        ///</summary>
        public RRI_I12_RESULTS_NOTES getRESULTS_NOTES()
        {
            RRI_I12_RESULTS_NOTES ret = null;
            try
            {
                ret = (RRI_I12_RESULTS_NOTES)this.GetStructure("RESULTS_NOTES");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RRI_I12_RESULTS_NOTES
        /// * (a Group object) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RRI_I12_RESULTS_NOTES getRESULTS_NOTES(int rep)
        {
            return (RRI_I12_RESULTS_NOTES)this.GetStructure("RESULTS_NOTES", rep);
        }

        /** 
         * Returns the number of existing repetitions of RRI_I12_RESULTS_NOTES 
         */
        public int RESULTS_NOTESReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("RESULTS_NOTES").Length;
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