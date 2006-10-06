using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PRR_PC5_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient Identification) <b></b><br>
 * 1: PRR_PC5_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 2: PRR_PC5_PROBLEM (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class PRR_PC5_PATIENT : AbstractGroup 
	{

		/** 
		 * Creates a new PRR_PC5_PATIENT Group.
		 */
		public PRR_PC5_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PRR_PC5_PATIENT_VISIT), false, false);
				this.add(typeof(PRR_PC5_PROBLEM), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PRR_PC5_PATIENT - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PID (Patient Identification) - creates it if necessary
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
		 * Returns PRR_PC5_PATIENT_VISIT (a Group object) - creates it if necessary
		 */
		public PRR_PC5_PATIENT_VISIT PATIENT_VISIT 
		{ 
			get
			{
				PRR_PC5_PATIENT_VISIT ret = null;
				try 
				{
					ret = (PRR_PC5_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
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
		 * Returns  first repetition of PRR_PC5_PROBLEM (a Group object) - creates it if necessary
		 */
		public PRR_PC5_PROBLEM getPROBLEM() 
		{
			PRR_PC5_PROBLEM ret = null;
			try 
			{
				ret = (PRR_PC5_PROBLEM)this.get_Renamed("PROBLEM");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PRR_PC5_PROBLEM
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PRR_PC5_PROBLEM getPROBLEM(int rep) 
		{ 
			return (PRR_PC5_PROBLEM)this.get_Renamed("PROBLEM", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PRR_PC5_PROBLEM 
		 */ 
		public int PROBLEMReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PROBLEM").Length; 
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
