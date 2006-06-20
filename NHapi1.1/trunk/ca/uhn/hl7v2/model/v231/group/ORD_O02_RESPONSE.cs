using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORD_O02_RESPONSE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORD_O02_PATIENT (a Group object) <b>optional </b><br>
 * 1: ORD_O02_ORDER_DIET (a Group object) <b>repeating</b><br>
 * 2: ORD_O02_ORDER_TRAY (a Group object) <b>optional repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class ORD_O02_RESPONSE : AbstractGroup 
	{

		/** 
		 * Creates a new ORD_O02_RESPONSE Group.
		 */
		public ORD_O02_RESPONSE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORD_O02_PATIENT), false, false);
				this.add(typeof(ORD_O02_ORDER_DIET), true, true);
				this.add(typeof(ORD_O02_ORDER_TRAY), false, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORD_O02_RESPONSE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORD_O02_PATIENT (a Group object) - creates it if necessary
		 */
		public ORD_O02_PATIENT PATIENT 
		{ 
			get
			{
				ORD_O02_PATIENT ret = null;
				try 
				{
					ret = (ORD_O02_PATIENT)this.get_Renamed("PATIENT");
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
		 * Returns  first repetition of ORD_O02_ORDER_DIET (a Group object) - creates it if necessary
		 */
		public ORD_O02_ORDER_DIET getORDER_DIET() 
		{
			ORD_O02_ORDER_DIET ret = null;
			try 
			{
				ret = (ORD_O02_ORDER_DIET)this.get_Renamed("ORDER_DIET");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ORD_O02_ORDER_DIET
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ORD_O02_ORDER_DIET getORDER_DIET(int rep) 
		{ 
			return (ORD_O02_ORDER_DIET)this.get_Renamed("ORDER_DIET", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ORD_O02_ORDER_DIET 
		 */ 
		public int ORDER_DIETReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ORDER_DIET").Length; 
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
		 * Returns  first repetition of ORD_O02_ORDER_TRAY (a Group object) - creates it if necessary
		 */
		public ORD_O02_ORDER_TRAY getORDER_TRAY() 
		{
			ORD_O02_ORDER_TRAY ret = null;
			try 
			{
				ret = (ORD_O02_ORDER_TRAY)this.get_Renamed("ORDER_TRAY");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ORD_O02_ORDER_TRAY
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ORD_O02_ORDER_TRAY getORDER_TRAY(int rep) 
		{ 
			return (ORD_O02_ORDER_TRAY)this.get_Renamed("ORDER_TRAY", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ORD_O02_ORDER_TRAY 
		 */ 
		public int ORDER_TRAYReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ORDER_TRAY").Length; 
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
