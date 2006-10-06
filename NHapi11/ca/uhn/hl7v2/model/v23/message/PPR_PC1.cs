using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a PPR_PC1 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: PID (Patient Identification) <b></b><br>
 * 2: PPR_PC1_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 3: PPR_PC1_PROBLEM (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class PPR_PC1 : AbstractMessage  
	{

		/** 
		 * Creates a new PPR_PC1 Group with custom ModelClassFactory.
		 */
		public PPR_PC1(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new PPR_PC1 Group with DefaultModelClassFactory. 
		 */ 
		public PPR_PC1() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PPR_PC1_PATIENT_VISIT), false, false);
				this.add(typeof(PPR_PC1_PROBLEM), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPR_PC1 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (Message header segment) - creates it if necessary
		 */
		public MSH MSH 
		{ 
			get
			{
				MSH ret = null;
				try 
				{
					ret = (MSH)this.get_Renamed("MSH");
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
		 * Returns PPR_PC1_PATIENT_VISIT (a Group object) - creates it if necessary
		 */
		public PPR_PC1_PATIENT_VISIT PATIENT_VISIT 
		{ 
			get
			{
				PPR_PC1_PATIENT_VISIT ret = null;
				try 
				{
					ret = (PPR_PC1_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
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
		 * Returns  first repetition of PPR_PC1_PROBLEM (a Group object) - creates it if necessary
		 */
		public PPR_PC1_PROBLEM getPROBLEM() 
		{
			PPR_PC1_PROBLEM ret = null;
			try 
			{
				ret = (PPR_PC1_PROBLEM)this.get_Renamed("PROBLEM");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PPR_PC1_PROBLEM
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PPR_PC1_PROBLEM getPROBLEM(int rep) 
		{ 
			return (PPR_PC1_PROBLEM)this.get_Renamed("PROBLEM", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PPR_PC1_PROBLEM 
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
