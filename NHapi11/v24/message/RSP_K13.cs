using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a RSP_K13 message structure (see chapter 5). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MSA (Message Acknowledgment) <b></b><br>
 * 2: ERR (Error) <b>optional </b><br>
 * 3: QAK (Query Acknowledgment) <b></b><br>
 * 4: QPD (Query Parameter Definition) <b></b><br>
 * 5: RSP_K13_ROW_DEFINITION (a Group object) <b>optional </b><br>
 * 6: DSC (Continuation Pointer) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class RSP_K13 : AbstractMessage  
	{

		/** 
		 * Creates a new RSP_K13 Group with custom ModelClassFactory.
		 */
		public RSP_K13(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new RSP_K13 Group with DefaultModelClassFactory. 
		 */ 
		public RSP_K13() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(ERR), false, false);
				this.add(typeof(QAK), true, false);
				this.add(typeof(QPD), true, false);
				this.add(typeof(RSP_K13_ROW_DEFINITION), false, false);
				this.add(typeof(DSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_K13 - this is probably a bug in the source code generator.", e);
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
		 * Returns MSA (Message Acknowledgment) - creates it if necessary
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
		 * Returns ERR (Error) - creates it if necessary
		 */
		public ERR ERR 
		{ 
			get
			{
				ERR ret = null;
				try 
				{
					ret = (ERR)this.get_Renamed("ERR");
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
		 * Returns QAK (Query Acknowledgment) - creates it if necessary
		 */
		public QAK QAK 
		{ 
			get
			{
				QAK ret = null;
				try 
				{
					ret = (QAK)this.get_Renamed("QAK");
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
		 * Returns QPD (Query Parameter Definition) - creates it if necessary
		 */
		public QPD QPD 
		{ 
			get
			{
				QPD ret = null;
				try 
				{
					ret = (QPD)this.get_Renamed("QPD");
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
		 * Returns RSP_K13_ROW_DEFINITION (a Group object) - creates it if necessary
		 */
		public RSP_K13_ROW_DEFINITION ROW_DEFINITION 
		{ 
			get
			{
				RSP_K13_ROW_DEFINITION ret = null;
				try 
				{
					ret = (RSP_K13_ROW_DEFINITION)this.get_Renamed("ROW_DEFINITION");
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
