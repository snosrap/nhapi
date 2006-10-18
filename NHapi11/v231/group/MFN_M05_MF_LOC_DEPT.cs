using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the MFN_M05_MF_LOC_DEPT Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: LDP (LDP - location department segment) <b></b><br>
 * 1: LCH (LCH - location characteristic segment) <b>optional repeating</b><br>
 * 2: LCC (LCC - location charge code segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class MFN_M05_MF_LOC_DEPT : AbstractGroup 
	{

		/** 
		 * Creates a new MFN_M05_MF_LOC_DEPT Group.
		 */
		public MFN_M05_MF_LOC_DEPT(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(LDP), true, false);
				this.add(typeof(LCH), false, true);
				this.add(typeof(LCC), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating MFN_M05_MF_LOC_DEPT - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns LDP (LDP - location department segment) - creates it if necessary
		 */
		public LDP LDP 
		{ 
			get
			{
				LDP ret = null;
				try 
				{
					ret = (LDP)this.get_Renamed("LDP");
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
		 * Returns  first repetition of LCH (LCH - location characteristic segment) - creates it if necessary
		 */
		public LCH getLCH() 
		{
			LCH ret = null;
			try 
			{
				ret = (LCH)this.get_Renamed("LCH");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of LCH
		 * (LCH - location characteristic segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public LCH getLCH(int rep) 
		{ 
			return (LCH)this.get_Renamed("LCH", rep);
		}

		/** 
		 * Returns the number of existing repetitions of LCH 
		 */ 
		public int LCHReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("LCH").Length; 
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
		 * Returns  first repetition of LCC (LCC - location charge code segment) - creates it if necessary
		 */
		public LCC getLCC() 
		{
			LCC ret = null;
			try 
			{
				ret = (LCC)this.get_Renamed("LCC");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of LCC
		 * (LCC - location charge code segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public LCC getLCC(int rep) 
		{ 
			return (LCC)this.get_Renamed("LCC", rep);
		}

		/** 
		 * Returns the number of existing repetitions of LCC 
		 */ 
		public int LCCReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("LCC").Length; 
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
