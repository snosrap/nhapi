using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the ROR_R0R_ORDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORC (ORC - common order segment) 
    /// * 1: RXO (RXO - pharmacy/treatment order segment) 
    /// * 2: RXR (RXR - pharmacy/treatment route segment) repeating
    /// * 3: RXC (RXC - pharmacy/treatment component order segment) optional repeating
    ///</summary>
    [Serializable]
    public class ROR_R0R_ORDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new ROR_R0R_ORDER Group.
        ///</summary>
        public ROR_R0R_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORC), true, false);
                this.add(typeof(RXO), true, false);
                this.add(typeof(RXR), true, true);
                this.add(typeof(RXC), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ROR_R0R_ORDER - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns ORC (ORC - common order segment) - creates it if necessary
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
        /// Returns  first repetition of RXR (RXR - pharmacy/treatment route segment) - creates it if necessary
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
        /// * (RXR - pharmacy/treatment route segment) - creates it if necessary
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

        ///<summary>
        /// Returns  first repetition of RXC (RXC - pharmacy/treatment component order segment) - creates it if necessary
        ///</summary>
        public RXC getRXC()
        {
            RXC ret = null;
            try
            {
                ret = (RXC)this.GetStructure("RXC");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RXC
        /// * (RXC - pharmacy/treatment component order segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RXC getRXC(int rep)
        {
            return (RXC)this.GetStructure("RXC", rep);
        }

        /** 
         * Returns the number of existing repetitions of RXC 
         */
        public int RXCReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("RXC").Length;
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
