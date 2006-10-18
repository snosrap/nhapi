using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a SUR_P09 message structure (see chapter 7). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: SUR_P09_FACILITY (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class SUR_P09 : AbstractMessage  
	{

		/** 
		 * Creates a new SUR_P09 Group with custom ModelClassFactory.
		 */
		public SUR_P09(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new SUR_P09 Group with DefaultModelClassFactory. 
		 */ 
		public SUR_P09() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SUR_P09_FACILITY), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SUR_P09 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (Message Header) - creates it if necessary
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
		 * Returns  first repetition of SUR_P09_FACILITY (a Group object) - creates it if necessary
		 */
		public SUR_P09_FACILITY getFACILITY() 
		{
			SUR_P09_FACILITY ret = null;
			try 
			{
				ret = (SUR_P09_FACILITY)this.get_Renamed("FACILITY");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of SUR_P09_FACILITY
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public SUR_P09_FACILITY getFACILITY(int rep) 
		{ 
			return (SUR_P09_FACILITY)this.get_Renamed("FACILITY", rep);
		}

		/** 
		 * Returns the number of existing repetitions of SUR_P09_FACILITY 
		 */ 
		public int FACILITYReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("FACILITY").Length; 
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
