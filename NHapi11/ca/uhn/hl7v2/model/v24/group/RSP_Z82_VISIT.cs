using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RSP_Z82_VISIT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: AL1 (Patient allergy information) <b>repeating</b><br>
 * 1: RSP_Z82_PATIENT_VISIT (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class RSP_Z82_VISIT : AbstractGroup 
	{

		/** 
		 * Creates a new RSP_Z82_VISIT Group.
		 */
		public RSP_Z82_VISIT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(AL1), true, true);
				this.add(typeof(RSP_Z82_PATIENT_VISIT), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_Z82_VISIT - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns  first repetition of AL1 (Patient allergy information) - creates it if necessary
		 */
		public AL1 getAL1() 
		{
			AL1 ret = null;
			try 
			{
				ret = (AL1)this.get_Renamed("AL1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of AL1
		 * (Patient allergy information) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public AL1 getAL1(int rep) 
		{ 
			return (AL1)this.get_Renamed("AL1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of AL1 
		 */ 
		public int AL1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("AL1").Length; 
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
		 * Returns RSP_Z82_PATIENT_VISIT (a Group object) - creates it if necessary
		 */
		public RSP_Z82_PATIENT_VISIT PATIENT_VISIT 
		{ 
			get
			{
				RSP_Z82_PATIENT_VISIT ret = null;
				try 
				{
					ret = (RSP_Z82_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
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
