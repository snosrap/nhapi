using System;
using NHapi.Base.Log;
using NHapi.Model.V22.Group;
using NHapi.Model.V22.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V22.Message
{
    ///<summary>
    /// Represents a ADT_A32 message structure (see chapter [AAA]). This structure contains the 
    /// following elements:
    /// * 0: MSH (MESSAGE HEADER) 
    /// * 1: EVN (EVENT TYPE) 
    /// * 2: PID (PATIENT IDENTIFICATION) 
    /// * 3: PV1 (PATIENT VISIT) 
    /// * 4: PV2 (PATIENT VISIT - additional information) optional 
    /// * 5: OBX (OBSERVATION RESULT) optional repeating
    ///</summary>
    [Serializable]
    public class ADT_A32 : AbstractMessage
    {

        ///<summary> 
        /// Creates a new ADT_A32 Group with custom IModelClassFactory.
        ///</summary>
        public ADT_A32(IModelClassFactory factory)
            : base(factory)
        {
            init(factory);
        }

        ///<summary>
        /// Creates a new ADT_A32 Group with DefaultModelClassFactory. 
        ///</summary> 
        public ADT_A32()
            : base(new DefaultModelClassFactory())
        {
            init(new DefaultModelClassFactory());
        }

        ///<summary>
        /// initalize method for ADT_A32.  This does the segment setup for the message. 
        ///</summary> 
        private void init(IModelClassFactory factory)
        {
            try
            {
                this.add(typeof(MSH), true, false);
                this.add(typeof(EVN), true, false);
                this.add(typeof(PID), true, false);
                this.add(typeof(PV1), true, false);
                this.add(typeof(PV2), false, false);
                this.add(typeof(OBX), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A32 - this is probably a bug in the source code generator.", e);
            }
        }

        ///<summary>
        /// Returns MSH (MESSAGE HEADER) - creates it if necessary
        ///</summary>
        public MSH MSH
        {
            get
            {
                MSH ret = null;
                try
                {
                    ret = (MSH)this.GetStructure("MSH");
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
        /// Returns EVN (EVENT TYPE) - creates it if necessary
        ///</summary>
        public EVN EVN
        {
            get
            {
                EVN ret = null;
                try
                {
                    ret = (EVN)this.GetStructure("EVN");
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
        /// Returns PID (PATIENT IDENTIFICATION) - creates it if necessary
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
        /// Returns PV1 (PATIENT VISIT) - creates it if necessary
        ///</summary>
        public PV1 PV1
        {
            get
            {
                PV1 ret = null;
                try
                {
                    ret = (PV1)this.GetStructure("PV1");
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
        /// Returns PV2 (PATIENT VISIT - additional information) - creates it if necessary
        ///</summary>
        public PV2 PV2
        {
            get
            {
                PV2 ret = null;
                try
                {
                    ret = (PV2)this.GetStructure("PV2");
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
        /// Returns  first repetition of OBX (OBSERVATION RESULT) - creates it if necessary
        ///</summary>
        public OBX getOBX()
        {
            OBX ret = null;
            try
            {
                ret = (OBX)this.GetStructure("OBX");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of OBX
        /// * (OBSERVATION RESULT) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public OBX getOBX(int rep)
        {
            return (OBX)this.GetStructure("OBX", rep);
        }

        /** 
         * Returns the number of existing repetitions of OBX 
         */
        public int OBXReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("OBX").Length;
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
