using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M03_MF_TEST Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (MFE - master file entry segment) <b></b><br>
 * 1: OM1 (OM1 - general segment (fields that apply to most observations)) <b></b><br>
 * 2: Hxx (any HL7 segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class MFN_M03_MF_TEST : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M03_MF_TEST Group.
		 */
		public MFN_M03_MF_TEST(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(OM1), true, false);
				this.add(typeof(Hxx), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M03_MF_TEST - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MFE (MFE - master file entry segment) - creates it if necessary
		 */
		public MFE MFE 
		{ 
			get
			{
				MFE ret = null;
				try 
				{
					ret = (MFE)this.get_Renamed("MFE");
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
		 * Returns OM1 (OM1 - general segment (fields that apply to most observations)) - creates it if necessary
		 */
		public OM1 OM1 
		{ 
			get
			{
				OM1 ret = null;
				try 
				{
					ret = (OM1)this.get_Renamed("OM1");
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
		 * Returns Hxx (any HL7 segment) - creates it if necessary
		 */
		public Hxx Hxx 
		{ 
			get
			{
				Hxx ret = null;
				try 
				{
					ret = (Hxx)this.get_Renamed("Hxx");
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
