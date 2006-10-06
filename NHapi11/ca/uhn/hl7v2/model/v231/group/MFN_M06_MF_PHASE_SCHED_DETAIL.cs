using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M06_MF_PHASE_SCHED_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: CM1 (CM1 - clinical study phase master segment) <b></b><br>
 * 1: CM2 (CM2 - clinical study schedule master segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class MFN_M06_MF_PHASE_SCHED_DETAIL : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M06_MF_PHASE_SCHED_DETAIL Group.
		 */
		public MFN_M06_MF_PHASE_SCHED_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(CM1), true, false);
				this.add(typeof(CM2), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M06_MF_PHASE_SCHED_DETAIL - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns CM1 (CM1 - clinical study phase master segment) - creates it if necessary
		 */
		public CM1 CM1 
		{ 
			get
			{
				CM1 ret = null;
				try 
				{
					ret = (CM1)this.get_Renamed("CM1");
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
		 * Returns  first repetition of CM2 (CM2 - clinical study schedule master segment) - creates it if necessary
		 */
		public CM2 getCM2() 
		{
			CM2 ret = null;
			try 
			{
				ret = (CM2)this.get_Renamed("CM2");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of CM2
		 * (CM2 - clinical study schedule master segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public CM2 getCM2(int rep) 
		{ 
			return (CM2)this.get_Renamed("CM2", rep);
		}

		/** 
		 * Returns the number of existing repetitions of CM2 
		 */ 
		public int CM2Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("CM2").Length; 
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
