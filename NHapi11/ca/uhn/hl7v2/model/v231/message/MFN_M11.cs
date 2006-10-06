using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a MFN_M11 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: MFI (MFI - master file identification segment) <b></b><br>
 * 2: MFN_M11_MF_TEST_CALCULATED (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class MFN_M11 : AbstractMessage  
	{

		/** 
		 * Creates a new MFN_M11 Group with custom ModelClassFactory.
		 */
		public MFN_M11(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new MFN_M11 Group with DefaultModelClassFactory. 
		 */ 
		public MFN_M11() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MFI), true, false);
				this.add(typeof(MFN_M11_MF_TEST_CALCULATED), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M11 - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns MSH (MSH - message header segment) - creates it if necessary
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
		 * Returns MFI (MFI - master file identification segment) - creates it if necessary
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
		 * Returns  first repetition of MFN_M11_MF_TEST_CALCULATED (a Group object) - creates it if necessary
		 */
		public MFN_M11_MF_TEST_CALCULATED getMF_TEST_CALCULATED() 
		{
			MFN_M11_MF_TEST_CALCULATED ret = null;
			try 
			{
				ret = (MFN_M11_MF_TEST_CALCULATED)this.get_Renamed("MF_TEST_CALCULATED");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of MFN_M11_MF_TEST_CALCULATED
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public MFN_M11_MF_TEST_CALCULATED getMF_TEST_CALCULATED(int rep) 
		{ 
			return (MFN_M11_MF_TEST_CALCULATED)this.get_Renamed("MF_TEST_CALCULATED", rep);
		}

		/** 
		 * Returns the number of existing repetitions of MFN_M11_MF_TEST_CALCULATED 
		 */ 
		public int MF_TEST_CALCULATEDReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("MF_TEST_CALCULATED").Length; 
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
