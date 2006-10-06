using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RDE_O11_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXO (Pharmacy/Treatment Order) <b></b><br>
 * 1: NTE (Notes and Comments) <b>optional repeating</b><br>
 * 2: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
 * 3: RDE_O11_COMPONENT (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class RDE_O11_ORDER_DETAIL : AbstractGroup 
	{

		/** 
		 * Creates a new RDE_O11_ORDER_DETAIL Group.
		 */
		public RDE_O11_ORDER_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RXO), true, false);
				this.add(typeof(NTE), false, true);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RDE_O11_COMPONENT), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RDE_O11_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RXO (Pharmacy/Treatment Order) - creates it if necessary
		 */
		public RXO RXO 
		{ 
			get
			{
				RXO ret = null;
				try 
				{
					ret = (RXO)this.get_Renamed("RXO");
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
		 * Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
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
		 * (Notes and Comments) - creates it if necessary
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
		 * Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary
		 */
		public RXR getRXR() 
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

		/**
		 * Returns a specific repetition of RXR
		 * (Pharmacy/Treatment Route) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXR getRXR(int rep) 
		{ 
			return (RXR)this.get_Renamed("RXR", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXR 
		 */ 
		public int RXRReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXR").Length; 
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
		 * Returns RDE_O11_COMPONENT (a Group object) - creates it if necessary
		 */
		public RDE_O11_COMPONENT COMPONENT 
		{ 
			get
			{
				RDE_O11_COMPONENT ret = null;
				try 
				{
					ret = (RDE_O11_COMPONENT)this.get_Renamed("COMPONENT");
				} 
				catch(HL7Exception e) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
		}

	}
}
