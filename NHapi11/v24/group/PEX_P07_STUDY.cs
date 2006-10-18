using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the PEX_P07_STUDY Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: CSR (Clinical Study Registration) <b></b><br>
 * 1: CSP (Clinical Study Phase) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class PEX_P07_STUDY : AbstractGroup 
	{

		/** 
		 * Creates a new PEX_P07_STUDY Group.
		 */
		public PEX_P07_STUDY(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(CSR), true, false);
				this.add(typeof(CSP), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating PEX_P07_STUDY - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns CSR (Clinical Study Registration) - creates it if necessary
		 */
		public CSR CSR 
		{ 
			get
			{
				CSR ret = null;
				try 
				{
					ret = (CSR)this.get_Renamed("CSR");
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
		 * Returns  first repetition of CSP (Clinical Study Phase) - creates it if necessary
		 */
		public CSP getCSP() 
		{
			CSP ret = null;
			try 
			{
				ret = (CSP)this.get_Renamed("CSP");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of CSP
		 * (Clinical Study Phase) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public CSP getCSP(int rep) 
		{ 
			return (CSP)this.get_Renamed("CSP", rep);
		}

		/** 
		 * Returns the number of existing repetitions of CSP 
		 */ 
		public int CSPReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("CSP").Length; 
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
