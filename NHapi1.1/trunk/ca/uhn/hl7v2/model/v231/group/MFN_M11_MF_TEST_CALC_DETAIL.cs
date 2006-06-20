using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M11_MF_TEST_CALC_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OM6 (OM6 - Observations that are calculated from other observations segment) <b></b><br>
 * 1: OM2 (OM2 - numeric observation segment) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class MFN_M11_MF_TEST_CALC_DETAIL : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M11_MF_TEST_CALC_DETAIL Group.
		 */
		public MFN_M11_MF_TEST_CALC_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(OM6), true, false);
				this.add(typeof(OM2), true, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M11_MF_TEST_CALC_DETAIL - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns OM6 (OM6 - Observations that are calculated from other observations segment) - creates it if necessary
		 */
		public OM6 OM6 
		{ 
			get
			{
				OM6 ret = null;
				try 
				{
					ret = (OM6)this.get_Renamed("OM6");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

		/**
		 * Returns OM2 (OM2 - numeric observation segment) - creates it if necessary
		 */
		public OM2 OM2 
		{ 
			get
			{
				OM2 ret = null;
				try 
				{
					ret = (OM2)this.get_Renamed("OM2");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

	}
}
