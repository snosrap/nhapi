using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RPI_I01_PROVIDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PRD (Provider Data) <b></b><br>
 * 1: CTD (Contact Data) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class RPI_I01_PROVIDER : AbstractGroup 
	{

		/** 
		 * Creates a new RPI_I01_PROVIDER Group.
		 */
		public RPI_I01_PROVIDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PRD), true, false);
				this.add(typeof(CTD), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RPI_I01_PROVIDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PRD (Provider Data) - creates it if necessary
		 */
		public PRD PRD 
		{ 
			get
			{
				PRD ret = null;
				try 
				{
					ret = (PRD)this.get_Renamed("PRD");
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
		 * Returns  first repetition of CTD (Contact Data) - creates it if necessary
		 */
		public CTD getCTD() 
		{
			CTD ret = null;
			try 
			{
				ret = (CTD)this.get_Renamed("CTD");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of CTD
		 * (Contact Data) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public CTD getCTD(int rep) 
		{ 
			return (CTD)this.get_Renamed("CTD", rep);
		}

		/** 
		 * Returns the number of existing repetitions of CTD 
		 */ 
		public int CTDReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("CTD").Length; 
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
