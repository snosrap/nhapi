using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORL_O22_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient identification) <b></b><br>
 * 1: ORL_O22_GENERAL_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class ORL_O22_PATIENT : AbstractGroup 
	{

		/** 
		 * Creates a new ORL_O22_PATIENT Group.
		 */
		public ORL_O22_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(ORL_O22_GENERAL_ORDER), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORL_O22_PATIENT - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PID (Patient identification) - creates it if necessary
		 */
		public PID PID 
		{ 
			get
			{
				PID ret = null;
				try 
				{
					ret = (PID)this.get_Renamed("PID");
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
		 * Returns  first repetition of ORL_O22_GENERAL_ORDER (a Group object) - creates it if necessary
		 */
		public ORL_O22_GENERAL_ORDER getGENERAL_ORDER() 
		{
			ORL_O22_GENERAL_ORDER ret = null;
			try 
			{
				ret = (ORL_O22_GENERAL_ORDER)this.get_Renamed("GENERAL_ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ORL_O22_GENERAL_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ORL_O22_GENERAL_ORDER getGENERAL_ORDER(int rep) 
		{ 
			return (ORL_O22_GENERAL_ORDER)this.get_Renamed("GENERAL_ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ORL_O22_GENERAL_ORDER 
		 */ 
		public int GENERAL_ORDERReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("GENERAL_ORDER").Length; 
				} 
				catch (HL7Exception e) 
				{ 
					string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
					HapiLogFactory.getHapiLog(GetType()).error(message, e); 
					throw new System.Exception(message);
				} 
				return reps; 
			}
		} 

	}
}
