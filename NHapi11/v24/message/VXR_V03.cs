using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.group;
using ca.uhn.hl7v2.model.v24.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a VXR_V03 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message Header) <b></b><br>
 * 1: MSA (Message Acknowledgment) <b></b><br>
 * 2: QRD (Original-Style Query Definition) <b></b><br>
 * 3: QRF (Original Style Query Filter) <b>optional </b><br>
 * 4: PID (Patient identification) <b></b><br>
 * 5: PD1 (patient additional demographic) <b>optional </b><br>
 * 6: NK1 (Next of kin / associated parties) <b>optional repeating</b><br>
 * 7: VXR_V03_PATIENT_VISIT (a Group object) <b>optional </b><br>
 * 8: GT1 (Guarantor) <b>optional repeating</b><br>
 * 9: VXR_V03_INSURANCE (a Group object) <b>optional repeating</b><br>
 * 10: VXR_V03_ORDER (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.message

{
	public class VXR_V03 : AbstractMessage  
	{

		/** 
		 * Creates a new VXR_V03 Group with custom ModelClassFactory.
		 */
		public VXR_V03(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new VXR_V03 Group with DefaultModelClassFactory. 
		 */ 
		public VXR_V03() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(VXR_V03_PATIENT_VISIT), false, false);
				this.add(typeof(GT1), false, true);
				this.add(typeof(VXR_V03_INSURANCE), false, true);
				this.add(typeof(VXR_V03_ORDER), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating VXR_V03 - this is probably a bug in the source code generator.", e);
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
		 * Returns QRD (Original-Style Query Definition) - creates it if necessary
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
		 * Returns QRF (Original Style Query Filter) - creates it if necessary
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

		/**
		 * Returns PID (Patient identification) - creates it if necessary
		 */
		public PID PID 
		{ 
			get
			{
				PID ret = null;
				try 
				{
					ret = (PID)this.get_Renamed("PID");
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
		 * Returns PD1 (patient additional demographic) - creates it if necessary
		 */
		public PD1 PD1 
		{ 
			get
			{
				PD1 ret = null;
				try 
				{
					ret = (PD1)this.get_Renamed("PD1");
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
		 * Returns  first repetition of NK1 (Next of kin / associated parties) - creates it if necessary
		 */
		public NK1 getNK1() 
		{
			NK1 ret = null;
			try 
			{
				ret = (NK1)this.get_Renamed("NK1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of NK1
		 * (Next of kin / associated parties) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public NK1 getNK1(int rep) 
		{ 
			return (NK1)this.get_Renamed("NK1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of NK1 
		 */ 
		public int NK1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("NK1").Length; 
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
		 * Returns VXR_V03_PATIENT_VISIT (a Group object) - creates it if necessary
		 */
		public VXR_V03_PATIENT_VISIT PATIENT_VISIT 
		{ 
			get
			{
				VXR_V03_PATIENT_VISIT ret = null;
				try 
				{
					ret = (VXR_V03_PATIENT_VISIT)this.get_Renamed("PATIENT_VISIT");
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
		 * Returns  first repetition of GT1 (Guarantor) - creates it if necessary
		 */
		public GT1 getGT1() 
		{
			GT1 ret = null;
			try 
			{
				ret = (GT1)this.get_Renamed("GT1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of GT1
		 * (Guarantor) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public GT1 getGT1(int rep) 
		{ 
			return (GT1)this.get_Renamed("GT1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of GT1 
		 */ 
		public int GT1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("GT1").Length; 
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
		 * Returns  first repetition of VXR_V03_INSURANCE (a Group object) - creates it if necessary
		 */
		public VXR_V03_INSURANCE getINSURANCE() 
		{
			VXR_V03_INSURANCE ret = null;
			try 
			{
				ret = (VXR_V03_INSURANCE)this.get_Renamed("INSURANCE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of VXR_V03_INSURANCE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public VXR_V03_INSURANCE getINSURANCE(int rep) 
		{ 
			return (VXR_V03_INSURANCE)this.get_Renamed("INSURANCE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of VXR_V03_INSURANCE 
		 */ 
		public int INSURANCEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("INSURANCE").Length; 
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
		 * Returns  first repetition of VXR_V03_ORDER (a Group object) - creates it if necessary
		 */
		public VXR_V03_ORDER getORDER() 
		{
			VXR_V03_ORDER ret = null;
			try 
			{
				ret = (VXR_V03_ORDER)this.get_Renamed("ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of VXR_V03_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public VXR_V03_ORDER getORDER(int rep) 
		{ 
			return (VXR_V03_ORDER)this.get_Renamed("ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of VXR_V03_ORDER 
		 */ 
		public int ORDERReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ORDER").Length; 
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
