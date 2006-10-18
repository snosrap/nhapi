using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the REF_I13_PROCEDURE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PR1 (Procedures) <b></b><br>
 * 1: REF_I13_AUTHORIZATION (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class REF_I13_PROCEDURE : AbstractGroup 
	{

		/** 
		 * Creates a new REF_I13_PROCEDURE Group.
		 */
		public REF_I13_PROCEDURE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PR1), true, false);
				this.add(typeof(REF_I13_AUTHORIZATION), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating REF_I13_PROCEDURE - this is probably a bug in the source code generator.", e);
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
		 * Returns REF_I13_AUTHORIZATION (a Group object) - creates it if necessary
		 */
		public REF_I13_AUTHORIZATION AUTHORIZATION 
		{ 
			get
			{
				REF_I13_AUTHORIZATION ret = null;
				try 
				{
					ret = (REF_I13_AUTHORIZATION)this.get_Renamed("AUTHORIZATION");
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
