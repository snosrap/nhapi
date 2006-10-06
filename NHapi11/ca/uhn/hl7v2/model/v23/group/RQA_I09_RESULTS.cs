using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RQA_I09_RESULTS Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OBR (Observation request segment) <b></b><br>
 * 1: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 2: RQA_I09_OBSERVATION (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class RQA_I09_RESULTS : AbstractGroup 
	{

		/** 
		 * Creates a new RQA_I09_RESULTS Group.
		 */
		public RQA_I09_RESULTS(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(OBR), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(RQA_I09_OBSERVATION), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RQA_I09_RESULTS - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns OBR (Observation request segment) - creates it if necessary
		 */
		public OBR OBR 
		{ 
			get
			{
				OBR ret = null;
				try 
				{
					ret = (OBR)this.get_Renamed("OBR");
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
		 * Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
		 */
		public NTE getNTE() 
		{
			NTE ret = null;
			try 
			{
				ret = (NTE)this.get_Renamed("NTE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of NTE
		 * (Notes and comments segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public NTE getNTE(int rep) 
		{ 
			return (NTE)this.get_Renamed("NTE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of NTE 
		 */ 
		public int NTEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("NTE").Length; 
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

		/**
		 * Returns  first repetition of RQA_I09_OBSERVATION (a Group object) - creates it if necessary
		 */
		public RQA_I09_OBSERVATION getOBSERVATION() 
		{
			RQA_I09_OBSERVATION ret = null;
			try 
			{
				ret = (RQA_I09_OBSERVATION)this.get_Renamed("OBSERVATION");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RQA_I09_OBSERVATION
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RQA_I09_OBSERVATION getOBSERVATION(int rep) 
		{ 
			return (RQA_I09_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RQA_I09_OBSERVATION 
		 */ 
		public int OBSERVATIONReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("OBSERVATION").Length; 
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
