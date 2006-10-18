using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a SIU_S19 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: SCH (Schedule Activity Information) <b></b><br>
 * 2: NTE (Notes and comments segment) <b>optional repeating</b><br>
 * 3: SIU_S19_PATIENT (a Group object) <b>optional repeating</b><br>
 * 4: SIU_S19_RESOURCES (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class SIU_S19 : AbstractMessage  
	{

		/** 
		 * Creates a new SIU_S19 Group with custom ModelClassFactory.
		 */
		public SIU_S19(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new SIU_S19 Group with DefaultModelClassFactory. 
		 */ 
		public SIU_S19() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(SCH), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(SIU_S19_PATIENT), false, true);
				this.add(typeof(SIU_S19_RESOURCES), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SIU_S19 - this is probably a bug in the source code generator.", e);
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
		 * Returns SCH (Schedule Activity Information) - creates it if necessary
		 */
		public SCH SCH 
		{ 
			get
			{
				SCH ret = null;
				try 
				{
					ret = (SCH)this.get_Renamed("SCH");
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
		 * Returns  first repetition of SIU_S19_PATIENT (a Group object) - creates it if necessary
		 */
		public SIU_S19_PATIENT getPATIENT() 
		{
			SIU_S19_PATIENT ret = null;
			try 
			{
				ret = (SIU_S19_PATIENT)this.get_Renamed("PATIENT");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of SIU_S19_PATIENT
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public SIU_S19_PATIENT getPATIENT(int rep) 
		{ 
			return (SIU_S19_PATIENT)this.get_Renamed("PATIENT", rep);
		}

		/** 
		 * Returns the number of existing repetitions of SIU_S19_PATIENT 
		 */ 
		public int PATIENTReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PATIENT").Length; 
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
		 * Returns  first repetition of SIU_S19_RESOURCES (a Group object) - creates it if necessary
		 */
		public SIU_S19_RESOURCES getRESOURCES() 
		{
			SIU_S19_RESOURCES ret = null;
			try 
			{
				ret = (SIU_S19_RESOURCES)this.get_Renamed("RESOURCES");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of SIU_S19_RESOURCES
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public SIU_S19_RESOURCES getRESOURCES(int rep) 
		{ 
			return (SIU_S19_RESOURCES)this.get_Renamed("RESOURCES", rep);
		}

		/** 
		 * Returns the number of existing repetitions of SIU_S19_RESOURCES 
		 */ 
		public int RESOURCESReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RESOURCES").Length; 
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
