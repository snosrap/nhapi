using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a RQQ_Q09 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: ERQ (Event Replay Query) <b></b><br>
 * 2: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class RQQ_Q09 : AbstractMessage  
	{

		/** 
		 * Creates a new RQQ_Q09 Group with custom ModelClassFactory.
		 */
		public RQQ_Q09(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new RQQ_Q09 Group with DefaultModelClassFactory. 
		 */ 
		public RQQ_Q09() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(ERQ), true, false);
				this.add(typeof(DSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RQQ_Q09 - this is probably a bug in the source code generator.", e);
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
		 * Returns ERQ (Event Replay Query) - creates it if necessary
		 */
		public ERQ ERQ 
		{ 
			get
			{
				ERQ ret = null;
				try 
				{
					ret = (ERQ)this.get_Renamed("ERQ");
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
		 * Returns DSC (Continuation Pointer) - creates it if necessary
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
