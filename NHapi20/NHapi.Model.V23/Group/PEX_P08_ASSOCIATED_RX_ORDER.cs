using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the PEX_P08_ASSOCIATED_RX_ORDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: RXE (Pharmacy encoded order segment) 
    /// * 1: RXR (Pharmacy route segment) optional repeating
    ///</summary>
    [Serializable]
    public class PEX_P08_ASSOCIATED_RX_ORDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new PEX_P08_ASSOCIATED_RX_ORDER Group.
        ///</summary>
        public PEX_P08_ASSOCIATED_RX_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(RXE), true, false);
                this.add(typeof(RXR), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P08_ASSOCIATED_RX_ORDER - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns RXE (Pharmacy encoded order segment) - creates it if necessary
        ///</summary>
        public RXE RXE
        {
            get
            {
                RXE ret = null;
                try
                {
                    ret = (RXE)this.GetStructure("RXE");
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
        /// Returns  first repetition of RXR (Pharmacy route segment) - creates it if necessary
        ///</summary>
        public RXR getRXR()
        {
            RXR ret = null;
            try
            {
                ret = (RXR)this.GetStructure("RXR");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RXR
        /// * (Pharmacy route segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RXR getRXR(int rep)
        {
            return (RXR)this.GetStructure("RXR", rep);
        }

        /** 
         * Returns the number of existing repetitions of RXR 
         */
        public int RXRReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("RXR").Length;
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
