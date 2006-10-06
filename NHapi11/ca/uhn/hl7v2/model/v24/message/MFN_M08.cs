using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a MFN_M08 message structure (see chapter 8). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MFI (Master File Identification) <b></b><br>
 * 2: MFN_M08_MF_TEST_NUMERIC (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class MFN_M08 : AbstractMessage  
	{

		/** 
		 * Creates a new MFN_M08 Group with custom ModelClassFactory.
		 */
		public MFN_M08(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new MFN_M08 Group with DefaultModelClassFactory. 
		 */ 
		public MFN_M08() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MFI), true, false);
				this.add(typeof(MFN_M08_MF_TEST_NUMERIC), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M08 - this is probably a bug in the source code generator.", e);
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
		 * Returns MFI (Master File Identification) - creates it if necessary
		 */
		public MFI MFI 
		{ 
			get
			{
				MFI ret = null;
				try 
				{
					ret = (MFI)this.get_Renamed("MFI");
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
		 * Returns  first repetition of MFN_M08_MF_TEST_NUMERIC (a Group object) - creates it if necessary
		 */
		public MFN_M08_MF_TEST_NUMERIC getMF_TEST_NUMERIC() 
		{
			MFN_M08_MF_TEST_NUMERIC ret = null;
			try 
			{
				ret = (MFN_M08_MF_TEST_NUMERIC)this.get_Renamed("MF_TEST_NUMERIC");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of MFN_M08_MF_TEST_NUMERIC
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public MFN_M08_MF_TEST_NUMERIC getMF_TEST_NUMERIC(int rep) 
		{ 
			return (MFN_M08_MF_TEST_NUMERIC)this.get_Renamed("MF_TEST_NUMERIC", rep);
		}

		/** 
		 * Returns the number of existing repetitions of MFN_M08_MF_TEST_NUMERIC 
		 */ 
		public int MF_TEST_NUMERICReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("MF_TEST_NUMERIC").Length; 
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
