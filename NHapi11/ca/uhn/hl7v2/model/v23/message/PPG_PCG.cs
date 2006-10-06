using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a PPG_PCG message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: PID (Patient Identification) <b></b><br>
 * 2: PPG_PCG_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 3: PPG_PCG_PATHWAY (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class PPG_PCG : AbstractMessage  
	{

		/** 
		 * Creates a new PPG_PCG Group with custom ModelClassFactory.
		 */
		public PPG_PCG(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new PPG_PCG Group with DefaultModelClassFactory. 
		 */ 
		public PPG_PCG() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PPG_PCG_PATIENT_VISIT), false, false);
				this.add(typeof(PPG_PCG_PATHWAY), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PPG_PCG - this is probably a bug in the source code generator.", e);
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
		 * Returns PPG_PCG_PATIENT_VISIT (a Group object) - creates it if necessary
		 */
		public PPG_PCG_PATIENT_VISIT PATIENT_VISIT 
		{ 
			get
			{
				PPG_PCG_PATIENT_VISIT ret = null;
				try 
				{
					ret = (PPG_PCG_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
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
		 * Returns  first repetition of PPG_PCG_PATHWAY (a Group object) - creates it if necessary
		 */
		public PPG_PCG_PATHWAY getPATHWAY() 
		{
			PPG_PCG_PATHWAY ret = null;
			try 
			{
				ret = (PPG_PCG_PATHWAY)this.get_Renamed("PATHWAY");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PPG_PCG_PATHWAY
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PPG_PCG_PATHWAY getPATHWAY(int rep) 
		{ 
			return (PPG_PCG_PATHWAY)this.get_Renamed("PATHWAY", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PPG_PCG_PATHWAY 
		 */ 
		public int PATHWAYReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PATHWAY").Length; 
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
