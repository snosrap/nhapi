using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORS_O06_RSPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORS_O06_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORS_O06_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class ORS_O06_RSPONSE : AbstractGroup 
	{

		/** 
		 * Creates a new ORS_O06_RSPONSE Group.
		 */
		public ORS_O06_RSPONSE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORS_O06_PATIENT), false, false);
				this.add(typeof(ORS_O06_ORDER), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORS_O06_RSPONSE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORS_O06_PATIENT (a Group object) - creates it if necessary
		 */
		public ORS_O06_PATIENT PATIENT 
		{ 
			get
			{
				ORS_O06_PATIENT ret = null;
				try 
				{
					ret = (ORS_O06_PATIENT)this.get_Renamed("PATIENT");
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
		 * Returns  first repetition of ORS_O06_ORDER (a Group object) - creates it if necessary
		 */
		public ORS_O06_ORDER getORDER() 
		{
			ORS_O06_ORDER ret = null;
			try 
			{
				ret = (ORS_O06_ORDER)this.get_Renamed("ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ORS_O06_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ORS_O06_ORDER getORDER(int rep) 
		{ 
			return (ORS_O06_ORDER)this.get_Renamed("ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ORS_O06_ORDER 
		 */ 
		public int ORDERReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ORDER").Length; 
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
