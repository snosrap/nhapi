using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V231.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V231.Group
{
    ///<summary>
    ///Represents the RRO_O02_ORDER_DETAIL Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: RXO (RXO - pharmacy/treatment order segment) 
    /// * 1: NTE (NTE - notes and comments segment) optional repeating
    /// * 2: RXR (RXR - pharmacy/treatment route segment) repeating
    /// * 3: RXC (RXC - pharmacy/treatment component order segment) optional repeating
    /// * 4: NTE (NTE - notes and comments segment) optional repeating
    ///</summary>
    [Serializable]
    public class RRO_O02_ORDER_DETAIL : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RRO_O02_ORDER_DETAIL Group.
        ///</summary>
        public RRO_O02_ORDER_DETAIL(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(RXO), true, false);
                this.add(typeof(NTE), false, true);
                this.add(typeof(RXR), true, true);
                this.add(typeof(RXC), false, true);
                this.add(typeof(NTE), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RRO_O02_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
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

        ///<summary>
        /// Returns  first repetition of NTE2 (NTE - notes and comments segment) - creates it if necessary
        ///</summary>
        public NTE getNTE2()
        {
            NTE ret = null;
            try
            {
                ret = (NTE)this.GetStructure("NTE2");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of NTE2
        /// * (NTE - notes and comments segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public NTE getNTE2(int rep)
        {
            return (NTE)this.GetStructure("NTE2", rep);
        }

        /** 
         * Returns the number of existing repetitions of NTE2 
         */
        public int NTE2Reps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("NTE2").Length;
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
