using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M07_MF_CLIN_STUDY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: MFE (Master file entry segment) <b></b><br>
 * 1: CM0 (Clinical Study Master) <b></b><br>
 * 2: MFN_M07_MF_PHASE_SCHED_DETAIL (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class MFN_M07_MF_CLIN_STUDY : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M07_MF_CLIN_STUDY Group.
		 */
		public MFN_M07_MF_CLIN_STUDY(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(MFE), true, false);
				this.add(typeof(CM0), true, false);
				this.add(typeof(MFN_M07_MF_PHASE_SCHED_DETAIL), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M07_MF_CLIN_STUDY - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MFE (Master file entry segment) - creates it if necessary
		 */
		public MFE MFE 
		{ 
			get
			{
				MFE ret = null;
				try 
				{
					ret = (MFE)this.get_Renamed("MFE");
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
		 * Returns CM0 (Clinical Study Master) - creates it if necessary
		 */
		public CM0 CM0 
		{ 
			get
			{
				CM0 ret = null;
				try 
				{
					ret = (CM0)this.get_Renamed("CM0");
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
		 * Returns  first repetition of MFN_M07_MF_PHASE_SCHED_DETAIL (a Group object) - creates it if necessary
		 */
		public MFN_M07_MF_PHASE_SCHED_DETAIL getMF_PHASE_SCHED_DETAIL() 
		{
			MFN_M07_MF_PHASE_SCHED_DETAIL ret = null;
			try 
			{
				ret = (MFN_M07_MF_PHASE_SCHED_DETAIL)this.get_Renamed("MF_PHASE_SCHED_DETAIL");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of MFN_M07_MF_PHASE_SCHED_DETAIL
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public MFN_M07_MF_PHASE_SCHED_DETAIL getMF_PHASE_SCHED_DETAIL(int rep) 
		{ 
			return (MFN_M07_MF_PHASE_SCHED_DETAIL)this.get_Renamed("MF_PHASE_SCHED_DETAIL", rep);
		}

		/** 
		 * Returns the number of existing repetitions of MFN_M07_MF_PHASE_SCHED_DETAIL 
		 */ 
		public int MF_PHASE_SCHED_DETAILReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("MF_PHASE_SCHED_DETAIL").Length; 
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
