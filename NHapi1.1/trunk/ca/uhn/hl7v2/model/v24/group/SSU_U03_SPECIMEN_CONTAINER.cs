using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SSU_U03_SPECIMEN_CONTAINER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SAC (Specimen and container detail) <b></b><br>
 * 1: OBX (Observation/Result) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class SSU_U03_SPECIMEN_CONTAINER : AbstractGroup 
	{

		/** 
		 * Creates a new SSU_U03_SPECIMEN_CONTAINER Group.
		 */
		public SSU_U03_SPECIMEN_CONTAINER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(SAC), true, false);
				this.add(typeof(OBX), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SSU_U03_SPECIMEN_CONTAINER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns SAC (Specimen and container detail) - creates it if necessary
		 */
		public SAC SAC 
		{ 
			get
			{
				SAC ret = null;
				try 
				{
					ret = (SAC)this.get_Renamed("SAC");
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
		 * Returns OBX (Observation/Result) - creates it if necessary
		 */
		public OBX OBX 
		{ 
			get
			{
				OBX ret = null;
				try 
				{
					ret = (OBX)this.get_Renamed("OBX");
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
