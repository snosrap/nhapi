using System;
using NHapi.Base.Log;
using NHapi.Model.V21.Group;
using NHapi.Model.V21.Segment;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;

namespace NHapi.Model.V21.Message
{
    ///<summary>
    /// Represents a DSR_Q01 message structure (see chapter [AAA]). This structure contains the 
    /// following elements:
    /// * 0: MSH (MESSAGE HEADER) 
    /// * 1: MSA (MESSAGE ACKNOWLEDGMENT) 
    /// * 2: QRD (QUERY DEFINITION) 
    /// * 3: QRF (QUERY FILTER) optional 
    /// * 4: DSP (DISPLAY DATA) repeating
    /// * 5: DSC (CONTINUATION POINTER) 
    ///</summary>
    [Serializable]
    public class DSR_Q01 : AbstractMessage
    {

        ///<summary> 
        /// Creates a new DSR_Q01 Group with custom IModelClassFactory.
        ///</summary>
        public DSR_Q01(IModelClassFactory factory)
            : base(factory)
        {
            init(factory);
        }

        ///<summary>
        /// Creates a new DSR_Q01 Group with DefaultModelClassFactory. 
        ///</summary> 
        public DSR_Q01()
            : base(new DefaultModelClassFactory())
        {
            init(new DefaultModelClassFactory());
        }

        ///<summary>
        /// initalize method for DSR_Q01.  This does the segment setup for the message. 
        ///</summary> 
        private void init(IModelClassFactory factory)
        {
            try
            {
                this.add(typeof(MSH), true, false);
                this.add(typeof(MSA), true, false);
                this.add(typeof(QRD), true, false);
                this.add(typeof(QRF), false, false);
                this.add(typeof(DSP), true, true);
                this.add(typeof(DSC), true, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DSR_Q01 - this is probably a bug in the source code generator.", e);
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
        /// Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary
        ///</summary>
        public MSA MSA
        {
            get
            {
                MSA ret = null;
                try
                {
                    ret = (MSA)this.GetStructure("MSA");
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
        /// Returns QRD (QUERY DEFINITION) - creates it if necessary
        ///</summary>
        public QRD QRD
        {
            get
            {
                QRD ret = null;
                try
                {
                    ret = (QRD)this.GetStructure("QRD");
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
        /// Returns QRF (QUERY FILTER) - creates it if necessary
        ///</summary>
        public QRF QRF
        {
            get
            {
                QRF ret = null;
                try
                {
                    ret = (QRF)this.GetStructure("QRF");
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
        /// Returns  first repetition of DSP (DISPLAY DATA) - creates it if necessary
        ///</summary>
        public DSP getDSP()
        {
            DSP ret = null;
            try
            {
                ret = (DSP)this.GetStructure("DSP");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new System.Exception("An unexpected error ocurred", e);
            }
            return ret;
        }

        ///<summary>
        ///Returns a specific repetition of DSP
        /// * (DISPLAY DATA) - creates it if necessary
        /// throws HL7Exception if the repetition requested is more than one 
        ///     greater than the number of existing repetitions.
        ///</summary>
        public DSP getDSP(int rep)
        {
            return (DSP)this.GetStructure("DSP", rep);
        }

        /** 
         * Returns the number of existing repetitions of DSP 
         */
        public int DSPReps
        {
            get
            {
                int reps = -1;
                try
                {
                    reps = this.GetAll("DSP").Length;
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
        /// Returns DSC (CONTINUATION POINTER) - creates it if necessary
        ///</summary>
        public DSC DSC
        {
            get
            {
                DSC ret = null;
                try
                {
                    ret = (DSC)this.GetStructure("DSC");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new System.Exception("An unexpected error ocurred", e);
                }
                return ret;
            }
        }

    }
}