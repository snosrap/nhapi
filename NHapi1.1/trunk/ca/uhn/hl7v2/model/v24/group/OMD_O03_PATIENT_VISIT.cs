using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OMD_O03_PATIENT_VISIT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PV1 (Patient visit) <b></b><br>
 * 1: PV2 (Patient visit - additional information) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class OMD_O03_PATIENT_VISIT : AbstractGroup 
	{

		/** 
		 * Creates a new OMD_O03_PATIENT_VISIT Group.
		 */
		public OMD_O03_PATIENT_VISIT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PV1), true, false);
				this.add(typeof(PV2), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OMD_O03_PATIENT_VISIT - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PV1 (Patient visit) - creates it if necessary
		 */
		public PV1 PV1 
		{ 
			get
			{
				PV1 ret = null;
				try 
				{
					ret = (PV1)this.get_Renamed("PV1");
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
		 * Returns PV2 (Patient visit - additional information) - creates it if necessary
		 */
		public PV2 PV2 
		{ 
			get
			{
				PV2 ret = null;
				try 
				{
					ret = (PV2)this.get_Renamed("PV2");
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
