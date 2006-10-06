using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a UDM_Q05 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: URD (URD - results/update definition segment) <b></b><br>
 * 2: URS (URS - unsolicited selection segment) <b>optional </b><br>
 * 3: DSP (DSP - display data segment) <b>repeating</b><br>
 * 4: DSC (DSC - Continuation pointer segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class UDM_Q05 : AbstractMessage  
	{

		/** 
		 * Creates a new UDM_Q05 Group with custom ModelClassFactory.
		 */
		public UDM_Q05(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new UDM_Q05 Group with DefaultModelClassFactory. 
		 */ 
		public UDM_Q05() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(URD), true, false);
				this.add(typeof(URS), false, false);
				this.add(typeof(DSP), true, true);
				this.add(typeof(DSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating UDM_Q05 - this is probably a bug in the source code generator.", e);
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
		 * Returns URD (URD - results/update definition segment) - creates it if necessary
		 */
		public URD URD 
		{ 
			get
			{
				URD ret = null;
				try 
				{
					ret = (URD)this.get_Renamed("URD");
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
		 * Returns URS (URS - unsolicited selection segment) - creates it if necessary
		 */
		public URS URS 
		{ 
			get
			{
				URS ret = null;
				try 
				{
					ret = (URS)this.get_Renamed("URS");
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
		 * Returns  first repetition of DSP (DSP - display data segment) - creates it if necessary
		 */
		public DSP getDSP() 
		{
			DSP ret = null;
			try 
			{
				ret = (DSP)this.get_Renamed("DSP");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of DSP
		 * (DSP - display data segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public DSP getDSP(int rep) 
		{ 
			return (DSP)this.get_Renamed("DSP", rep);
		}

		/** 
		 * Returns the number of existing repetitions of DSP 
		 */ 
		public int DSPReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("DSP").Length; 
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
		 * Returns DSC (DSC - Continuation pointer segment) - creates it if necessary
		 */
		public DSC DSC 
		{ 
			get
			{
				DSC ret = null;
				try 
				{
					ret = (DSC)this.get_Renamed("DSC");
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
