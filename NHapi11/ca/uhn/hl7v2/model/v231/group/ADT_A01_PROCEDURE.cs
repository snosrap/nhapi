using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ADT_A01_PROCEDURE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PR1 (PR1 - procedures segment) <b></b><br>
 * 1: ROL (Role) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class ADT_A01_PROCEDURE : AbstractGroup 
	{

		/** 
		 * Creates a new ADT_A01_PROCEDURE Group.
		 */
		public ADT_A01_PROCEDURE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PR1), true, false);
				this.add(typeof(ROL), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ADT_A01_PROCEDURE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PR1 (PR1 - procedures segment) - creates it if necessary
		 */
		public PR1 PR1 
		{ 
			get
			{
				PR1 ret = null;
				try 
				{
					ret = (PR1)this.get_Renamed("PR1");
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
		 * Returns  first repetition of ROL (Role) - creates it if necessary
		 */
		public ROL getROL() 
		{
			ROL ret = null;
			try 
			{
				ret = (ROL)this.get_Renamed("ROL");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ROL
		 * (Role) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ROL getROL(int rep) 
		{ 
			return (ROL)this.get_Renamed("ROL", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ROL 
		 */ 
		public int ROLReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ROL").Length; 
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
