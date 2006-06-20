using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a ORU_R01 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: ORU_R01_RESPONSE (a Group object) <b>repeating</b><br>
 * 2: DSC (Continuation pointer segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class ORU_R01 : AbstractMessage  
	{

		/** 
		 * Creates a new ORU_R01 Group with custom ModelClassFactory.
		 */
		public ORU_R01(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new ORU_R01 Group with DefaultModelClassFactory. 
		 */ 
		public ORU_R01() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(ORU_R01_RESPONSE), true, true);
				this.add(typeof(DSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORU_R01 - this is probably a bug in the source code generator.", e);
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
		 * Returns  first repetition of ORU_R01_RESPONSE (a Group object) - creates it if necessary
		 */
		public ORU_R01_RESPONSE getRESPONSE() 
		{
			ORU_R01_RESPONSE ret = null;
			try 
			{
				ret = (ORU_R01_RESPONSE)this.get_Renamed("RESPONSE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ORU_R01_RESPONSE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ORU_R01_RESPONSE getRESPONSE(int rep) 
		{ 
			return (ORU_R01_RESPONSE)this.get_Renamed("RESPONSE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ORU_R01_RESPONSE 
		 */ 
		public int RESPONSEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RESPONSE").Length; 
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
		 * Returns DSC (Continuation pointer segment) - creates it if necessary
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
