using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a DFT_P03 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: EVN (EVN - event type segment) <b></b><br>
 * 2: PID (PID - patient identification segment) <b></b><br>
 * 3: PD1 (PD1 - patient additional demographic segment) <b>optional </b><br>
 * 4: PV1 (PV1 - patient visit segment-) <b>optional </b><br>
 * 5: PV2 (PV2 - patient visit - additional information segment) <b>optional </b><br>
 * 6: DB1 (DB1 - Disability segment) <b>optional repeating</b><br>
 * 7: OBX (OBX - observation/result segment) <b>optional repeating</b><br>
 * 8: DFT_P03_FINANCIAL (a Group object) <b>repeating</b><br>
 * 9: DG1 (DG1 - diagnosis segment) <b>optional repeating</b><br>
 * 10: DRG (DRG - diagnosis related group segment) <b>optional </b><br>
 * 11: GT1 (GT1 - guarantor segment) <b>optional repeating</b><br>
 * 12: DFT_P03_INSURANCE (a Group object) <b>optional repeating</b><br>
 * 13: ACC (ACC - accident segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class DFT_P03 : AbstractMessage  
	{

		/** 
		 * Creates a new DFT_P03 Group with custom ModelClassFactory.
		 */
		public DFT_P03(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new DFT_P03 Group with DefaultModelClassFactory. 
		 */ 
		public DFT_P03() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(PV1), false, false);
				this.add(typeof(PV2), false, false);
				this.add(typeof(DB1), false, true);
				this.add(typeof(OBX), false, true);
				this.add(typeof(DFT_P03_FINANCIAL), true, true);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, false);
				this.add(typeof(GT1), false, true);
				this.add(typeof(DFT_P03_INSURANCE), false, true);
				this.add(typeof(ACC), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating DFT_P03 - this is probably a bug in the source code generator.", e);
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
		 * Returns EVN (EVN - event type segment) - creates it if necessary
		 */
		public EVN EVN 
		{ 
			get
			{
				EVN ret = null;
				try 
				{
					ret = (EVN)this.get_Renamed("EVN");
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
		 * Returns PID (PID - patient identification segment) - creates it if necessary
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
		 * Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary
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
		 * Returns PV1 (PV1 - patient visit segment-) - creates it if necessary
		 */
		public PV1 PV1 
		{ 
			get
			{
				PV1 ret = null;
				try 
				{
					ret = (PV1)this.get_Renamed("PV1");
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
		 * Returns PV2 (PV2 - patient visit - additional information segment) - creates it if necessary
		 */
		public PV2 PV2 
		{ 
			get
			{
				PV2 ret = null;
				try 
				{
					ret = (PV2)this.get_Renamed("PV2");
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
		 * Returns  first repetition of DB1 (DB1 - Disability segment) - creates it if necessary
		 */
		public DB1 getDB1() 
		{
			DB1 ret = null;
			try 
			{
				ret = (DB1)this.get_Renamed("DB1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of DB1
		 * (DB1 - Disability segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public DB1 getDB1(int rep) 
		{ 
			return (DB1)this.get_Renamed("DB1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of DB1 
		 */ 
		public int DB1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("DB1").Length; 
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
		 * Returns  first repetition of OBX (OBX - observation/result segment) - creates it if necessary
		 */
		public OBX getOBX() 
		{
			OBX ret = null;
			try 
			{
				ret = (OBX)this.get_Renamed("OBX");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of OBX
		 * (OBX - observation/result segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public OBX getOBX(int rep) 
		{ 
			return (OBX)this.get_Renamed("OBX", rep);
		}

		/** 
		 * Returns the number of existing repetitions of OBX 
		 */ 
		public int OBXReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("OBX").Length; 
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
		 * Returns  first repetition of DFT_P03_FINANCIAL (a Group object) - creates it if necessary
		 */
		public DFT_P03_FINANCIAL getFINANCIAL() 
		{
			DFT_P03_FINANCIAL ret = null;
			try 
			{
				ret = (DFT_P03_FINANCIAL)this.get_Renamed("FINANCIAL");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of DFT_P03_FINANCIAL
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public DFT_P03_FINANCIAL getFINANCIAL(int rep) 
		{ 
			return (DFT_P03_FINANCIAL)this.get_Renamed("FINANCIAL", rep);
		}

		/** 
		 * Returns the number of existing repetitions of DFT_P03_FINANCIAL 
		 */ 
		public int FINANCIALReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("FINANCIAL").Length; 
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
		 * Returns  first repetition of DG1 (DG1 - diagnosis segment) - creates it if necessary
		 */
		public DG1 getDG1() 
		{
			DG1 ret = null;
			try 
			{
				ret = (DG1)this.get_Renamed("DG1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of DG1
		 * (DG1 - diagnosis segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public DG1 getDG1(int rep) 
		{ 
			return (DG1)this.get_Renamed("DG1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of DG1 
		 */ 
		public int DG1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("DG1").Length; 
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
		 * Returns DRG (DRG - diagnosis related group segment) - creates it if necessary
		 */
		public DRG DRG 
		{ 
			get
			{
				DRG ret = null;
				try 
				{
					ret = (DRG)this.get_Renamed("DRG");
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
		 * Returns  first repetition of GT1 (GT1 - guarantor segment) - creates it if necessary
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
		 * (GT1 - guarantor segment) - creates it if necessary
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
		 * Returns  first repetition of DFT_P03_INSURANCE (a Group object) - creates it if necessary
		 */
		public DFT_P03_INSURANCE getINSURANCE() 
		{
			DFT_P03_INSURANCE ret = null;
			try 
			{
				ret = (DFT_P03_INSURANCE)this.get_Renamed("INSURANCE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of DFT_P03_INSURANCE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public DFT_P03_INSURANCE getINSURANCE(int rep) 
		{ 
			return (DFT_P03_INSURANCE)this.get_Renamed("INSURANCE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of DFT_P03_INSURANCE 
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
		 * Returns ACC (ACC - accident segment) - creates it if necessary
		 */
		public ACC ACC 
		{ 
			get
			{
				ACC ret = null;
				try 
				{
					ret = (ACC)this.get_Renamed("ACC");
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
