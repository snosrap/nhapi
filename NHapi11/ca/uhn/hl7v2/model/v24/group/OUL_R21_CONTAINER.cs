using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OUL_R21_CONTAINER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: SAC (Specimen and container detail) <b></b><br>
 * 1: SID (Substance Identifier) <b>optional </b><br>
 * 2: OBX (Observation/Result) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class OUL_R21_CONTAINER : AbstractGroup 
	{

		/** 
		 * Creates a new OUL_R21_CONTAINER Group.
		 */
		public OUL_R21_CONTAINER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(SAC), true, false);
				this.add(typeof(SID), false, false);
				this.add(typeof(OBX), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OUL_R21_CONTAINER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns SAC (Specimen and container detail) - creates it if necessary
		 */
		public SAC SAC 
		{ 
			get
			{
				SAC ret = null;
				try 
				{
					ret = (SAC)this.get_Renamed("SAC");
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
		 * Returns SID (Substance Identifier) - creates it if necessary
		 */
		public SID SID 
		{ 
			get
			{
				SID ret = null;
				try 
				{
					ret = (SID)this.get_Renamed("SID");
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
		 * Returns  first repetition of OBX (Observation/Result) - creates it if necessary
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
		 * (Observation/Result) - creates it if necessary
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

	}
}
