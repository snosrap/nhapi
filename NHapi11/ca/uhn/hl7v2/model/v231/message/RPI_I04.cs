using System;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v231.group;
using ca.uhn.hl7v2.model.v231.segment;
using ca.uhn.hl7v2;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2.model;

/**
 * <p>Represents a RPI_I04 message structure (see chapter [AAA]). This structure contains the 
 * following elements: </p>
 * 0: MSH (MSH - message header segment) <b></b><br>
 * 1: MSA (MSA - message acknowledgment segment) <b></b><br>
 * 2: RPI_I04_PROVIDER (a Group object) <b>repeating</b><br>
 * 3: PID (PID - patient identification segment) <b></b><br>
 * 4: NK1 (NK1 - next of kin / associated parties segment-) <b>optional repeating</b><br>
 * 5: RPI_I04_GUARANTOR_INSURANCE (a Group object) <b>optional </b><br>
 * 6: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.message

{
	[Serializable]
	public class RPI_I04 : AbstractMessage  
	{

		/** 
		 * Creates a new RPI_I04 Group with custom ModelClassFactory.
		 */
		public RPI_I04(ModelClassFactory factory) : base(factory)
		{
			init(factory);
		}

		/**
		 * Creates a new RPI_I04 Group with DefaultModelClassFactory. 
		 */ 
		public RPI_I04() : base(new DefaultModelClassFactory()) 
		{ 
			init(new DefaultModelClassFactory());
		}

		private void init(ModelClassFactory factory) 
		{
			try 
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(MSA), true, false);
				this.add(typeof(RPI_I04_PROVIDER), true, true);
				this.add(typeof(PID), true, false);
				this.add(typeof(NK1), false, true);
				this.add(typeof(RPI_I04_GUARANTOR_INSURANCE), false, false);
				this.add(typeof(NTE), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RPI_I04 - this is probably a bug in the source code generator.", e);
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
		 * Returns  first repetition of RPI_I04_PROVIDER (a Group object) - creates it if necessary
		 */
		public RPI_I04_PROVIDER getPROVIDER() 
		{
			RPI_I04_PROVIDER ret = null;
			try 
			{
				ret = (RPI_I04_PROVIDER)this.get_Renamed("PROVIDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RPI_I04_PROVIDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RPI_I04_PROVIDER getPROVIDER(int rep) 
		{ 
			return (RPI_I04_PROVIDER)this.get_Renamed("PROVIDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RPI_I04_PROVIDER 
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
		 * Returns  first repetition of NK1 (NK1 - next of kin / associated parties segment-) - creates it if necessary
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
		 * (NK1 - next of kin / associated parties segment-) - creates it if necessary
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
		 * Returns RPI_I04_GUARANTOR_INSURANCE (a Group object) - creates it if necessary
		 */
		public RPI_I04_GUARANTOR_INSURANCE GUARANTOR_INSURANCE 
		{ 
			get
			{
				RPI_I04_GUARANTOR_INSURANCE ret = null;
				try 
				{
					ret = (RPI_I04_GUARANTOR_INSURANCE)this.get_Renamed("GUARANTOR_INSURANCE");
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
		 * Returns  first repetition of NTE (NTE - notes and comments segment) - creates it if necessary
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
		 * (NTE - notes and comments segment) - creates it if necessary
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
