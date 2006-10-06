using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RDR_RDR_ENCODING Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXE (Pharmacy encoded order segment) <b></b><br>
 * 1: RXR (Pharmacy route segment) <b></b><br>
 * 2: RXC (Pharmacy component order segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class RDR_RDR_ENCODING : AbstractGroup 
	{

		/** 
		 * Creates a new RDR_RDR_ENCODING Group.
		 */
		public RDR_RDR_ENCODING(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RXE), true, false);
				this.add(typeof(RXR), true, false);
				this.add(typeof(RXC), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RDR_RDR_ENCODING - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RXE (Pharmacy encoded order segment) - creates it if necessary
		 */
		public RXE RXE 
		{ 
			get
			{
				RXE ret = null;
				try 
				{
					ret = (RXE)this.get_Renamed("RXE");
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
		 * Returns RXR (Pharmacy route segment) - creates it if necessary
		 */
		public RXR RXR 
		{ 
			get
			{
				RXR ret = null;
				try 
				{
					ret = (RXR)this.get_Renamed("RXR");
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
		 * Returns  first repetition of RXC (Pharmacy component order segment) - creates it if necessary
		 */
		public RXC getRXC() 
		{
			RXC ret = null;
			try 
			{
				ret = (RXC)this.get_Renamed("RXC");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RXC
		 * (Pharmacy component order segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXC getRXC(int rep) 
		{ 
			return (RXC)this.get_Renamed("RXC", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXC 
		 */ 
		public int RXCReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXC").Length; 
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
