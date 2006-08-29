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
    /// Represents a ADT_A30 message structure (see chapter [AAA]). This structure contains the 
    /// following elements:
    /// * 0: MSH (MESSAGE HEADER) 
    /// * 1: EVN (EVENT TYPE) 
    /// * 2: PID (PATIENT IDENTIFICATION) 
    /// * 3: MRG (MERGE PATIENT INFORMATION) 
    ///</summary>
    [Serializable]
    public class ADT_A30 : AbstractMessage
    {

        ///<summary> 
        /// Creates a new ADT_A30 Group with custom IModelClassFactory.
        ///</summary>
        public ADT_A30(IModelClassFactory factory)
            : base(factory)
        {
            init(factory);
        }

        ///<summary>
        /// Creates a new ADT_A30 Group with DefaultModelClassFactory. 
        ///</summary> 
        public ADT_A30()
            : base(new DefaultModelClassFactory())
        {
            init(new DefaultModelClassFactory());
        }

        ///<summary>
        /// initalize method for ADT_A30.  This does the segment setup for the message. 
        ///</summary> 
        private void init(IModelClassFactory factory)
        {
            try
            {
                this.add(typeof(MSH), true, false);
                this.add(typeof(EVN), true, false);
                this.add(typeof(PID), true, false);
                this.add(typeof(MRG), true, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A30 - this is probably a bug in the source code generator.", e);
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
        /// Returns MRG (MERGE PATIENT INFORMATION) - creates it if necessary
        ///</summary>
        public MRG MRG
        {
            get
            {
                MRG ret = null;
                try
                {
                    ret = (MRG)this.GetStructure("MRG");
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
