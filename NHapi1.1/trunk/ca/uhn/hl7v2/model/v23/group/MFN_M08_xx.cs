using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M08_xx Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OM2 (Numeric observation) <b>optional </b><br>
 * 1: OM3 (Categorical test/observation) <b>optional </b><br>
 * 2: OM4 (Observations that require specimens) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class MFN_M08_xx : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M08_xx Group.
		 */
		public MFN_M08_xx(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(OM2), false, false);
				this.add(typeof(OM3), false, false);
				this.add(typeof(OM4), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M08_xx - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns OM2 (Numeric observation) - creates it if necessary
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

		/**
		 * Returns OM3 (Categorical test/observation) - creates it if necessary
		 */
		public OM3 OM3 
		{ 
			get
			{
				OM3 ret = null;
				try 
				{
					ret = (OM3)this.get_Renamed("OM3");
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
		 * Returns OM4 (Observations that require specimens) - creates it if necessary
		 */
		public OM4 OM4 
		{ 
			get
			{
				OM4 ret = null;
				try 
				{
					ret = (OM4)this.get_Renamed("OM4");
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
