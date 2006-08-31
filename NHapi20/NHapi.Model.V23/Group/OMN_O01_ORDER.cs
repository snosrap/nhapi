using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using NHapi.Model.V23.Segment;

using NHapi.Base.Model;

namespace NHapi.Model.V23.Group
{
    ///<summary>
    ///Represents the OMN_O01_ORDER Group.  A Group is an ordered collection of message 
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements: 
    /// * 0: ORC (Common order segment) 
    /// * 1: OMN_O01_ORDER_DETAIL (a Group object) optional 
    /// * 2: BLG (Billing Segment) optional 
    ///</summary>
    [Serializable]
    public class OMN_O01_ORDER : AbstractGroup
    {

        ///<summary> 
        /// Creates a new OMN_O01_ORDER Group.
        ///</summary>
        public OMN_O01_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                this.add(typeof(ORC), true, false);
                this.add(typeof(OMN_O01_ORDER_DETAIL), false, false);
                this.add(typeof(BLG), false, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMN_O01_ORDER - this is probably a bug in the source code generator.", e);
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
        /// Returns OMN_O01_ORDER_DETAIL (a Group object) - creates it if necessary
        ///</summary>
        public OMN_O01_ORDER_DETAIL ORDER_DETAIL
        {
            get
            {
                OMN_O01_ORDER_DETAIL ret = null;
                try
                {
                    ret = (OMN_O01_ORDER_DETAIL)this.GetStructure("ORDER_DETAIL");
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
        /// Returns BLG (Billing Segment) - creates it if necessary
        ///</summary>
        public BLG BLG
        {
            get
            {
                BLG ret = null;
                try
                {
                    ret = (BLG)this.GetStructure("BLG");
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