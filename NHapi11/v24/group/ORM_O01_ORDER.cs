using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ORM_O01_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: ORM_O01_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 2: FT1 (Financial Transaction) <b>optional repeating</b><br>
 * 3: CTI (Clinical Trial Identification) <b>optional repeating</b><br>
 * 4: BLG (Billing) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
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
				this.add(typeof(FT1), false, true);
				this.add(typeof(CTI), false, true);
				this.add(typeof(BLG), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ORM_O01_ORDER - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns ORC (Common Order) - creates it if necessary
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
		 * Returns  first repetition of FT1 (Financial Transaction) - creates it if necessary
		 */
		public FT1 getFT1() 
		{
			FT1 ret = null;
			try 
			{
				ret = (FT1)this.get_Renamed("FT1");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of FT1
		 * (Financial Transaction) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public FT1 getFT1(int rep) 
		{ 
			return (FT1)this.get_Renamed("FT1", rep);
		}

		/** 
		 * Returns the number of existing repetitions of FT1 
		 */ 
		public int FT1Reps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("FT1").Length; 
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
		 * Returns  first repetition of CTI (Clinical Trial Identification) - creates it if necessary
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
		 * (Clinical Trial Identification) - creates it if necessary
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
		 * Returns BLG (Billing) - creates it if necessary
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
