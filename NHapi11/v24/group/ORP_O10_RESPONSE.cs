using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORP_O10_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORP_O10_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORP_O10_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class ORP_O10_RESPONSE : AbstractGroup 
	{

		/** 
		 * Creates a new ORP_O10_RESPONSE Group.
		 */
		public ORP_O10_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORP_O10_PATIENT), false, false);
				this.add(typeof(ORP_O10_ORDER), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORP_O10_RESPONSE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORP_O10_PATIENT (a Group object) - creates it if necessary
		 */
		public ORP_O10_PATIENT PATIENT 
		{ 
			get
			{
				ORP_O10_PATIENT ret = null;
				try 
				{
					ret = (ORP_O10_PATIENT)this.get_Renamed("PATIENT");
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
		 * Returns  first repetition of ORP_O10_ORDER (a Group object) - creates it if necessary
		 */
		public ORP_O10_ORDER getORDER() 
		{
			ORP_O10_ORDER ret = null;
			try 
			{
				ret = (ORP_O10_ORDER)this.get_Renamed("ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ORP_O10_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ORP_O10_ORDER getORDER(int rep) 
		{ 
			return (ORP_O10_ORDER)this.get_Renamed("ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ORP_O10_ORDER 
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
