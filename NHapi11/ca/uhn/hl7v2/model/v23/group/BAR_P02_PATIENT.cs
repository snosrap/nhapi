using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the BAR_P02_PATIENT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PID (Patient Identification) <b></b><br>
 * 1: PD1 (Patient Demographic) <b>optional </b><br>
 * 2: PV1 (Patient visit) <b>optional </b><br>
 * 3: DB1 (Disability Segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class BAR_P02_PATIENT : AbstractGroup 
	{

		/** 
		 * Creates a new BAR_P02_PATIENT Group.
		 */
		public BAR_P02_PATIENT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(PV1), false, false);
				this.add(typeof(DB1), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating BAR_P02_PATIENT - this is probably a bug in the source code generator.", e);
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
		 * Returns PD1 (Patient Demographic) - creates it if necessary
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
		 * Returns PV1 (Patient visit) - creates it if necessary
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
		 * Returns  first repetition of DB1 (Disability Segment) - creates it if necessary
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
		 * (Disability Segment) - creates it if necessary
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

	}
}
