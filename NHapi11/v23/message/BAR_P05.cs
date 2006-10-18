using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a BAR_P05 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: EVN (Event type) <b></b><br>
 * 2: PID (Patient Identification) <b></b><br>
 * 3: PD1 (Patient Demographic) <b>optional </b><br>
 * 4: BAR_P05_VISIT (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class BAR_P05 : AbstractMessage  
	{

		/** 
		 * Creates a new BAR_P05 Group with custom ModelClassFactory.
		 */
		public BAR_P05(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new BAR_P05 Group with DefaultModelClassFactory. 
		 */ 
		public BAR_P05() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(BAR_P05_VISIT), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P05 - this is probably a bug in the source code generator.", e);
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
		 * Returns EVN (Event type) - creates it if necessary
		 */
		public EVN EVN 
		{ 
			get
			{
				EVN ret = null;
				try 
				{
					ret = (EVN)this.get_Renamed("EVN");
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
		 * Returns PD1 (Patient Demographic) - creates it if necessary
		 */
		public PD1 PD1 
		{ 
			get
			{
				PD1 ret = null;
				try 
				{
					ret = (PD1)this.get_Renamed("PD1");
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
		 * Returns  first repetition of BAR_P05_VISIT (a Group object) - creates it if necessary
		 */
		public BAR_P05_VISIT getVISIT() 
		{
			BAR_P05_VISIT ret = null;
			try 
			{
				ret = (BAR_P05_VISIT)this.get_Renamed("VISIT");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of BAR_P05_VISIT
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public BAR_P05_VISIT getVISIT(int rep) 
		{ 
			return (BAR_P05_VISIT)this.get_Renamed("VISIT", rep);
		}

		/** 
		 * Returns the number of existing repetitions of BAR_P05_VISIT 
		 */ 
		public int VISITReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("VISIT").Length; 
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
