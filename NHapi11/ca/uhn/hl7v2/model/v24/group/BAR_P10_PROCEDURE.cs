using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the BAR_P10_PROCEDURE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PR1 (Procedures) <b></b><br>
 * 1: GP2 (Grouping/Reimbursement - Procedure Line Item) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class BAR_P10_PROCEDURE : AbstractGroup 
	{

		/** 
		 * Creates a new BAR_P10_PROCEDURE Group.
		 */
		public BAR_P10_PROCEDURE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PR1), true, false);
				this.add(typeof(GP2), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P10_PROCEDURE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PR1 (Procedures) - creates it if necessary
		 */
		public PR1 PR1 
		{ 
			get
			{
				PR1 ret = null;
				try 
				{
					ret = (PR1)this.get_Renamed("PR1");
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
		 * Returns GP2 (Grouping/Reimbursement - Procedure Line Item) - creates it if necessary
		 */
		public GP2 GP2 
		{ 
			get
			{
				GP2 ret = null;
				try 
				{
					ret = (GP2)this.get_Renamed("GP2");
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
