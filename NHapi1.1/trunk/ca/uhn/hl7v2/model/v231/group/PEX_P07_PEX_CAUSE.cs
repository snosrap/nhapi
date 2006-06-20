using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_PEX_CAUSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: PCR (PCR - possible causal relationship segment) <b></b><br>
 * 1: PEX_P07_RX_ORDER (a Group object) <b>optional </b><br>
 * 2: PEX_P07_RX_ADMINISTRATION (a Group object) <b>optional repeating</b><br>
 * 3: PRB (Problem Detail) <b>optional repeating</b><br>
 * 4: OBX (OBX - observation/result segment) <b>optional repeating</b><br>
 * 5: NTE (NTE - notes and comments segment) <b>optional repeating</b><br>
 * 6: PEX_P07_ASSOCIATED_PERSON (a Group object) <b>optional </b><br>
 * 7: PEX_P07_STUDY (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class PEX_P07_PEX_CAUSE : AbstractGroup 
	{

		/** 
		 * Creates a new PEX_P07_PEX_CAUSE Group.
		 */
		public PEX_P07_PEX_CAUSE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(PCR), true, false);
				this.add(typeof(PEX_P07_RX_ORDER), false, false);
				this.add(typeof(PEX_P07_RX_ADMINISTRATION), false, true);
				this.add(typeof(PRB), false, true);
				this.add(typeof(OBX), false, true);
				this.add(typeof(NTE), false, true);
				this.add(typeof(PEX_P07_ASSOCIATED_PERSON), false, false);
				this.add(typeof(PEX_P07_STUDY), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_PEX_CAUSE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns PCR (PCR - possible causal relationship segment) - creates it if necessary
		 */
		public PCR PCR 
		{ 
			get
			{
				PCR ret = null;
				try 
				{
					ret = (PCR)this.get_Renamed("PCR");
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
		 * Returns PEX_P07_RX_ORDER (a Group object) - creates it if necessary
		 */
		public PEX_P07_RX_ORDER RX_ORDER 
		{ 
			get
			{
				PEX_P07_RX_ORDER ret = null;
				try 
				{
					ret = (PEX_P07_RX_ORDER)this.get_Renamed("RX_ORDER");
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
		 * Returns  first repetition of PEX_P07_RX_ADMINISTRATION (a Group object) - creates it if necessary
		 */
		public PEX_P07_RX_ADMINISTRATION getRX_ADMINISTRATION() 
		{
			PEX_P07_RX_ADMINISTRATION ret = null;
			try 
			{
				ret = (PEX_P07_RX_ADMINISTRATION)this.get_Renamed("RX_ADMINISTRATION");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PEX_P07_RX_ADMINISTRATION
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PEX_P07_RX_ADMINISTRATION getRX_ADMINISTRATION(int rep) 
		{ 
			return (PEX_P07_RX_ADMINISTRATION)this.get_Renamed("RX_ADMINISTRATION", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PEX_P07_RX_ADMINISTRATION 
		 */ 
		public int RX_ADMINISTRATIONReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RX_ADMINISTRATION").Length; 
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
		 * Returns  first repetition of PRB (Problem Detail) - creates it if necessary
		 */
		public PRB getPRB() 
		{
			PRB ret = null;
			try 
			{
				ret = (PRB)this.get_Renamed("PRB");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PRB
		 * (Problem Detail) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PRB getPRB(int rep) 
		{ 
			return (PRB)this.get_Renamed("PRB", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PRB 
		 */ 
		public int PRBReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("PRB").Length; 
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

		/**
		 * Returns PEX_P07_ASSOCIATED_PERSON (a Group object) - creates it if necessary
		 */
		public PEX_P07_ASSOCIATED_PERSON ASSOCIATED_PERSON 
		{ 
			get
			{
				PEX_P07_ASSOCIATED_PERSON ret = null;
				try 
				{
					ret = (PEX_P07_ASSOCIATED_PERSON)this.get_Renamed("ASSOCIATED_PERSON");
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
		 * Returns  first repetition of PEX_P07_STUDY (a Group object) - creates it if necessary
		 */
		public PEX_P07_STUDY getSTUDY() 
		{
			PEX_P07_STUDY ret = null;
			try 
			{
				ret = (PEX_P07_STUDY)this.get_Renamed("STUDY");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of PEX_P07_STUDY
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public PEX_P07_STUDY getSTUDY(int rep) 
		{ 
			return (PEX_P07_STUDY)this.get_Renamed("STUDY", rep);
		}

		/** 
		 * Returns the number of existing repetitions of PEX_P07_STUDY 
		 */ 
		public int STUDYReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("STUDY").Length; 
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
