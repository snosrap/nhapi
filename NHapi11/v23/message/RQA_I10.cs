using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.group;
using ca.uhn.hl7v2.model.v23.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a RQA_I10 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (Message header segment) <b></b><br>
 * 1: RF1 (Referral Information Segment) <b>optional </b><br>
 * 2: RQA_I10_AUTHORIZATION (a Group object) <b>optional </b><br>
 * 3: RQA_I10_PROVIDER (a Group object) <b>repeating</b><br>
 * 4: PID (Patient Identification) <b></b><br>
 * 5: NK1 (Next of kin) <b>optional repeating</b><br>
 * 6: RQA_I10_GUARANTOR_INSURANCE (a Group object) <b>optional </b><br>
 * 7: ACC (Accident) <b>optional </b><br>
 * 8: DG1 (Diagnosis) <b>optional repeating</b><br>
 * 9: DRG (Diagnosis Related Group) <b>optional repeating</b><br>
 * 10: AL1 (Patient allergy information) <b>optional repeating</b><br>
 * 11: RQA_I10_PROCEDURE (a Group object) <b>optional repeating</b><br>
 * 12: RQA_I10_RESULTS (a Group object) <b>optional repeating</b><br>
 * 13: RQA_I10_VISIT (a Group object) <b>optional </b><br>
 * 14: NTE (Notes and comments segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.message

{
	public class RQA_I10 : AbstractMessage  
	{

		/** 
		 * Creates a new RQA_I10 Group with custom ModelClassFactory.
		 */
		public RQA_I10(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new RQA_I10 Group with DefaultModelClassFactory. 
		 */ 
		public RQA_I10() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(RF1), false, false);
				this.add(typeof(RQA_I10_AUTHORIZATION), false, false);
				this.add(typeof(RQA_I10_PROVIDER), true, true);
				this.add(typeof(PID), true, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(RQA_I10_GUARANTOR_INSURANCE), false, false);
				this.add(typeof(ACC), false, false);
				this.add(typeof(DG1), false, true);
				this.add(typeof(DRG), false, true);
				this.add(typeof(AL1), false, true);
				this.add(typeof(RQA_I10_PROCEDURE), false, true);
				this.add(typeof(RQA_I10_RESULTS), false, true);
				this.add(typeof(RQA_I10_VISIT), false, false);
				this.add(typeof(NTE), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RQA_I10 - this is probably a bug in the source code generator.", e);
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
		 * Returns RF1 (Referral Information Segment) - creates it if necessary
		 */
		public RF1 RF1 
		{ 
			get
			{
				RF1 ret = null;
				try 
				{
					ret = (RF1)this.get_Renamed("RF1");
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
		 * Returns RQA_I10_AUTHORIZATION (a Group object) - creates it if necessary
		 */
		public RQA_I10_AUTHORIZATION AUTHORIZATION 
		{ 
			get
			{
				RQA_I10_AUTHORIZATION ret = null;
				try 
				{
					ret = (RQA_I10_AUTHORIZATION)this.get_Renamed("AUTHORIZATION");
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
		 * Returns  first repetition of RQA_I10_PROVIDER (a Group object) - creates it if necessary
		 */
		public RQA_I10_PROVIDER getPROVIDER() 
		{
			RQA_I10_PROVIDER ret = null;
			try 
			{
				ret = (RQA_I10_PROVIDER)this.get_Renamed("PROVIDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RQA_I10_PROVIDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RQA_I10_PROVIDER getPROVIDER(int rep) 
		{ 
			return (RQA_I10_PROVIDER)this.get_Renamed("PROVIDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RQA_I10_PROVIDER 
		 */ 
		public int PROVIDERReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PROVIDER").Length; 
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
		 * Returns PID (Patient Identification) - creates it if necessary
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
		 * Returns  first repetition of NK1 (Next of kin) - creates it if necessary
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
		 * (Next of kin) - creates it if necessary
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
		 * Returns RQA_I10_GUARANTOR_INSURANCE (a Group object) - creates it if necessary
		 */
		public RQA_I10_GUARANTOR_INSURANCE GUARANTOR_INSURANCE 
		{ 
			get
			{
				RQA_I10_GUARANTOR_INSURANCE ret = null;
				try 
				{
					ret = (RQA_I10_GUARANTOR_INSURANCE)this.get_Renamed("GUARANTOR_INSURANCE");
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
		 * Returns ACC (Accident) - creates it if necessary
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

		/**
		 * Returns  first repetition of DG1 (Diagnosis) - creates it if necessary
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
		 * (Diagnosis) - creates it if necessary
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
		 * Returns  first repetition of DRG (Diagnosis Related Group) - creates it if necessary
		 */
		public DRG getDRG() 
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

		/**
		 * Returns a specific repetition of DRG
		 * (Diagnosis Related Group) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public DRG getDRG(int rep) 
		{ 
			return (DRG)this.get_Renamed("DRG", rep);
		}

		/** 
		 * Returns the number of existing repetitions of DRG 
		 */ 
		public int DRGReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("DRG").Length; 
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
		 * Returns  first repetition of AL1 (Patient allergy information) - creates it if necessary
		 */
		public AL1 getAL1() 
		{
			AL1 ret = null;
			try 
			{
				ret = (AL1)this.get_Renamed("AL1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of AL1
		 * (Patient allergy information) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public AL1 getAL1(int rep) 
		{ 
			return (AL1)this.get_Renamed("AL1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of AL1 
		 */ 
		public int AL1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("AL1").Length; 
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
		 * Returns  first repetition of RQA_I10_PROCEDURE (a Group object) - creates it if necessary
		 */
		public RQA_I10_PROCEDURE getPROCEDURE() 
		{
			RQA_I10_PROCEDURE ret = null;
			try 
			{
				ret = (RQA_I10_PROCEDURE)this.get_Renamed("PROCEDURE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RQA_I10_PROCEDURE
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RQA_I10_PROCEDURE getPROCEDURE(int rep) 
		{ 
			return (RQA_I10_PROCEDURE)this.get_Renamed("PROCEDURE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RQA_I10_PROCEDURE 
		 */ 
		public int PROCEDUREReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PROCEDURE").Length; 
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
		 * Returns  first repetition of RQA_I10_RESULTS (a Group object) - creates it if necessary
		 */
		public RQA_I10_RESULTS getRESULTS() 
		{
			RQA_I10_RESULTS ret = null;
			try 
			{
				ret = (RQA_I10_RESULTS)this.get_Renamed("RESULTS");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RQA_I10_RESULTS
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RQA_I10_RESULTS getRESULTS(int rep) 
		{ 
			return (RQA_I10_RESULTS)this.get_Renamed("RESULTS", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RQA_I10_RESULTS 
		 */ 
		public int RESULTSReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RESULTS").Length; 
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
		 * Returns RQA_I10_VISIT (a Group object) - creates it if necessary
		 */
		public RQA_I10_VISIT VISIT 
		{ 
			get
			{
				RQA_I10_VISIT ret = null;
				try 
				{
					ret = (RQA_I10_VISIT)this.get_Renamed("VISIT");
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
		 * Returns  first repetition of NTE (Notes and comments segment) - creates it if necessary
		 */
		public NTE getNTE() 
		{
			NTE ret = null;
			try 
			{
				ret = (NTE)this.get_Renamed("NTE");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of NTE
		 * (Notes and comments segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public NTE getNTE(int rep) 
		{ 
			return (NTE)this.get_Renamed("NTE", rep);
		}

		/** 
		 * Returns the number of existing repetitions of NTE 
		 */ 
		public int NTEReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("NTE").Length; 
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
