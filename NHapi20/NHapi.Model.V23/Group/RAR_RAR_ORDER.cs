using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the RAR_RAR_ORDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORC (Common order segment) 
    /// * 1: RAR_RAR_ENCODING (a Group object) optional 
    /// * 2: RXA (Pharmacy administration segment) repeating
    ///</summary>
    [Serializable]
    public class RAR_RAR_ORDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new RAR_RAR_ORDER Group.
        ///</summary>
        public RAR_RAR_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORC), true, false);
                this.add(typeof(RAR_RAR_ENCODING), false, false);
                this.add(typeof(RXA), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RAR_RAR_ORDER - this is probably a bug in the source code generator.", e);
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
        /// Returns RAR_RAR_ENCODING (a Group object) - creates it if necessary
        ///</summary>
        public RAR_RAR_ENCODING ENCODING
        {
            get
            {
                RAR_RAR_ENCODING ret = null;
                try
                {
                    ret = (RAR_RAR_ENCODING)this.GetStructure("ENCODING");
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
        /// Returns  first repetition of RXA (Pharmacy administration segment) - creates it if necessary
        ///</summary>
        public RXA getRXA()
        {
            RXA ret = null;
            try
            {
                ret = (RXA)this.GetStructure("RXA");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of RXA
        /// * (Pharmacy administration segment) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public RXA getRXA(int rep)
        {
            return (RXA)this.GetStructure("RXA", rep);
        }

        /** 
         * Returns the number of existing repetitions of RXA 
         */
        public int RXAReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("RXA").Length;
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
