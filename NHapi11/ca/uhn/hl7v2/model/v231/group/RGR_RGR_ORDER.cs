using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RGR_RGR_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (ORC - common order segment) <b></b><br>
 * 1: RGR_RGR_ENCODING (a Group object) <b>optional </b><br>
 * 2: RXG (RXG - pharmacy/treatment give segment) <b>repeating</b><br>
 * 3: RXR (RXR - pharmacy/treatment route segment) <b>repeating</b><br>
 * 4: RXC (RXC - pharmacy/treatment component order segment) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class RGR_RGR_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new RGR_RGR_ORDER Group.
		 */
		public RGR_RGR_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RGR_RGR_ENCODING), false, false);
				this.add(typeof(RXG), true, true);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RXC), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RGR_RGR_ORDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORC (ORC - common order segment) - creates it if necessary
		 */
		public ORC ORC 
		{ 
			get
			{
				ORC ret = null;
				try 
				{
					ret = (ORC)this.get_Renamed("ORC");
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
		 * Returns RGR_RGR_ENCODING (a Group object) - creates it if necessary
		 */
		public RGR_RGR_ENCODING ENCODING 
		{ 
			get
			{
				RGR_RGR_ENCODING ret = null;
				try 
				{
					ret = (RGR_RGR_ENCODING)this.get_Renamed("ENCODING");
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
		 * Returns  first repetition of RXG (RXG - pharmacy/treatment give segment) - creates it if necessary
		 */
		public RXG getRXG() 
		{
			RXG ret = null;
			try 
			{
				ret = (RXG)this.get_Renamed("RXG");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RXG
		 * (RXG - pharmacy/treatment give segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RXG getRXG(int rep) 
		{ 
			return (RXG)this.get_Renamed("RXG", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RXG 
		 */ 
		public int RXGReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("RXG").Length; 
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
		 * Returns  first repetition of RXR (RXR - pharmacy/treatment route segment) - creates it if necessary
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
		 * (RXR - pharmacy/treatment route segment) - creates it if necessary
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
		 * Returns  first repetition of RXC (RXC - pharmacy/treatment component order segment) - creates it if necessary
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
		 * (RXC - pharmacy/treatment component order segment) - creates it if necessary
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
