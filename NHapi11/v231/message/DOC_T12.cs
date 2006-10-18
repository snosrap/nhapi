using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a DOC_T12 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: MSA (MSA - message acknowledgment segment) <b></b><br>
 * 2: ERR (ERR - error segment) <b>optional </b><br>
 * 3: QAK (Query Acknowledgement) <b>optional </b><br>
 * 4: QRD (QRD - original-style query definition segment) <b></b><br>
 * 5: DOC_T12_RESULT (a Group object) <b>repeating</b><br>
 * 6: DSC (DSC - Continuation pointer segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class DOC_T12 : AbstractMessage  
	{

		/** 
		 * Creates a new DOC_T12 Group with custom ModelClassFactory.
		 */
		public DOC_T12(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new DOC_T12 Group with DefaultModelClassFactory. 
		 */ 
		public DOC_T12() : base(new DefaultModelClassFactory()) 
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
				this.add(typeof(QAK), false, false);
				this.add(typeof(QRD), true, false);
				this.add(typeof(DOC_T12_RESULT), true, true);
				this.add(typeof(DSC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DOC_T12 - this is probably a bug in the source code generator.", e);
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
		 * Returns ERR (ERR - error segment) - creates it if necessary
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
		 * Returns QAK (Query Acknowledgement) - creates it if necessary
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
		 * Returns QRD (QRD - original-style query definition segment) - creates it if necessary
		 */
		public QRD QRD 
		{ 
			get
			{
				QRD ret = null;
				try 
				{
					ret = (QRD)this.get_Renamed("QRD");
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
		 * Returns  first repetition of DOC_T12_RESULT (a Group object) - creates it if necessary
		 */
		public DOC_T12_RESULT getRESULT() 
		{
			DOC_T12_RESULT ret = null;
			try 
			{
				ret = (DOC_T12_RESULT)this.get_Renamed("RESULT");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of DOC_T12_RESULT
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public DOC_T12_RESULT getRESULT(int rep) 
		{ 
			return (DOC_T12_RESULT)this.get_Renamed("RESULT", rep);
		}

		/** 
		 * Returns the number of existing repetitions of DOC_T12_RESULT 
		 */ 
		public int RESULTReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RESULT").Length; 
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
