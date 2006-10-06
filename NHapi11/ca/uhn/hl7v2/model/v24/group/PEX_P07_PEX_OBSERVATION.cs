using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_PEX_OBSERVATION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PEO (Product Experience Observation) <b></b><br>
 * 1: PEX_P07_PEX_CAUSE (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class PEX_P07_PEX_OBSERVATION : AbstractGroup 
	{

		/** 
		 * Creates a new PEX_P07_PEX_OBSERVATION Group.
		 */
		public PEX_P07_PEX_OBSERVATION(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PEO), true, false);
				this.add(typeof(PEX_P07_PEX_CAUSE), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_PEX_OBSERVATION - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PEO (Product Experience Observation) - creates it if necessary
		 */
		public PEO PEO 
		{ 
			get
			{
				PEO ret = null;
				try 
				{
					ret = (PEO)this.get_Renamed("PEO");
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
		 * Returns  first repetition of PEX_P07_PEX_CAUSE (a Group object) - creates it if necessary
		 */
		public PEX_P07_PEX_CAUSE getPEX_CAUSE() 
		{
			PEX_P07_PEX_CAUSE ret = null;
			try 
			{
				ret = (PEX_P07_PEX_CAUSE)this.get_Renamed("PEX_CAUSE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PEX_P07_PEX_CAUSE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PEX_P07_PEX_CAUSE getPEX_CAUSE(int rep) 
		{ 
			return (PEX_P07_PEX_CAUSE)this.get_Renamed("PEX_CAUSE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PEX_P07_PEX_CAUSE 
		 */ 
		public int PEX_CAUSEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PEX_CAUSE").Length; 
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
