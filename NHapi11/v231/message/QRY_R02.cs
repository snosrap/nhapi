using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a QRY_R02 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: QRD (QRD - original-style query definition segment) <b></b><br>
 * 2: QRF (QRF - original style query filter segment) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class QRY_R02 : AbstractMessage  
	{

		/** 
		 * Creates a new QRY_R02 Group with custom ModelClassFactory.
		 */
		public QRY_R02(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new QRY_R02 Group with DefaultModelClassFactory. 
		 */ 
		public QRY_R02() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), true, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating QRY_R02 - this is probably a bug in the source code generator.", e);
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
		 * Returns QRF (QRF - original style query filter segment) - creates it if necessary
		 */
		public QRF QRF 
		{ 
			get
			{
				QRF ret = null;
				try 
				{
					ret = (QRF)this.get_Renamed("QRF");
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
