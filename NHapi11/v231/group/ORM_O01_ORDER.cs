using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORM_O01_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (ORC - common order segment) <b></b><br>
 * 1: ORM_O01_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 2: CTI (CTI - clinical trial identification segment) <b>optional repeating</b><br>
 * 3: BLG (BLG - billing segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class ORM_O01_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new ORM_O01_ORDER Group.
		 */
		public ORM_O01_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(ORM_O01_ORDER_DETAIL), false, false);
				this.add(typeof(CTI), false, true);
				this.add(typeof(BLG), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_ORDER - this is probably a bug in the source code generator.", e);
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
		 * Returns ORM_O01_ORDER_DETAIL (a Group object) - creates it if necessary
		 */
		public ORM_O01_ORDER_DETAIL ORDER_DETAIL 
		{ 
			get
			{
				ORM_O01_ORDER_DETAIL ret = null;
				try 
				{
					ret = (ORM_O01_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
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
		 * Returns  first repetition of CTI (CTI - clinical trial identification segment) - creates it if necessary
		 */
		public CTI getCTI() 
		{
			CTI ret = null;
			try 
			{
				ret = (CTI)this.get_Renamed("CTI");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of CTI
		 * (CTI - clinical trial identification segment) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public CTI getCTI(int rep) 
		{ 
			return (CTI)this.get_Renamed("CTI", rep);
		}

		/** 
		 * Returns the number of existing repetitions of CTI 
		 */ 
		public int CTIReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("CTI").Length; 
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
		 * Returns BLG (BLG - billing segment) - creates it if necessary
		 */
		public BLG BLG 
		{ 
			get
			{
				BLG ret = null;
				try 
				{
					ret = (BLG)this.get_Renamed("BLG");
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
