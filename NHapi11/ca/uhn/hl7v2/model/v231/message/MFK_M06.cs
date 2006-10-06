using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a MFK_M06 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: MSA (MSA - message acknowledgment segment) <b></b><br>
 * 2: MFI (MFI - master file identification segment) <b></b><br>
 * 3: MFA (MFA - master file acknowledgment segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class MFK_M06 : AbstractMessage  
	{

		/** 
		 * Creates a new MFK_M06 Group with custom ModelClassFactory.
		 */
		public MFK_M06(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new MFK_M06 Group with DefaultModelClassFactory. 
		 */ 
		public MFK_M06() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(MFI), true, false);
				this.add(typeof(MFA), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFK_M06 - this is probably a bug in the source code generator.", e);
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
		 * Returns MSA (MSA - message acknowledgment segment) - creates it if necessary
		 */
		public MSA MSA 
		{ 
			get
			{
				MSA ret = null;
				try 
				{
					ret = (MSA)this.get_Renamed("MSA");
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
		 * Returns  first repetition of MFA (MFA - master file acknowledgment segment) - creates it if necessary
		 */
		public MFA getMFA() 
		{
			MFA ret = null;
			try 
			{
				ret = (MFA)this.get_Renamed("MFA");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of MFA
		 * (MFA - master file acknowledgment segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public MFA getMFA(int rep) 
		{ 
			return (MFA)this.get_Renamed("MFA", rep);
		}

		/** 
		 * Returns the number of existing repetitions of MFA 
		 */ 
		public int MFAReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("MFA").Length; 
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
