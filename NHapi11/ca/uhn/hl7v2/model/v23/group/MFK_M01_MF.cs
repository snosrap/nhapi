using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFK_M01_MF Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFA (Master file acknowledgement segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class MFK_M01_MF : AbstractGroup 
	{

		/** 
		 * Creates a new MFK_M01_MF Group.
		 */
		public MFK_M01_MF(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(MFA), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFK_M01_MF - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MFA (Master file acknowledgement segment) - creates it if necessary
		 */
		public MFA MFA 
		{ 
			get
			{
				MFA ret = null;
				try 
				{
					ret = (MFA)this.get_Renamed("MFA");
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
