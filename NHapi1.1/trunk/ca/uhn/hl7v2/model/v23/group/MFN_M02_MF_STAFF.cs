using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M02_MF_STAFF Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master file entry segment) <b></b><br>
 * 1: STF (Staff identification segment) <b></b><br>
 * 2: PRA (Practitioner detail segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class MFN_M02_MF_STAFF : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M02_MF_STAFF Group.
		 */
		public MFN_M02_MF_STAFF(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(STF), true, false);
				this.add(typeof(PRA), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M02_MF_STAFF - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MFE (Master file entry segment) - creates it if necessary
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
		 * Returns STF (Staff identification segment) - creates it if necessary
		 */
		public STF STF 
		{ 
			get
			{
				STF ret = null;
				try 
				{
					ret = (STF)this.get_Renamed("STF");
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
		 * Returns PRA (Practitioner detail segment) - creates it if necessary
		 */
		public PRA PRA 
		{ 
			get
			{
				PRA ret = null;
				try 
				{
					ret = (PRA)this.get_Renamed("PRA");
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
