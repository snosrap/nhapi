using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RSP_Z86_COMMON_ORDER Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: ORC (Common Order) <b></b><br>
 * 1: RSP_Z86_ORDER_DETAIL (a Group object) <b>optional </b><br>
 * 2: RSP_Z86_ENCODED_ORDER (a Group object) <b>optional </b><br>
 * 3: RSP_Z86_DISPENSE (a Group object) <b>optional </b><br>
 * 4: RSP_Z86_GIVE (a Group object) <b>optional </b><br>
 * 5: RSP_Z86_ADMINISTRATION (a Group object) <b>optional </b><br>
 * 6: RSP_Z86_OBSERVATION (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class RSP_Z86_COMMON_ORDER : AbstractGroup 
	{

		/** 
		 * Creates a new RSP_Z86_COMMON_ORDER Group.
		 */
		public RSP_Z86_COMMON_ORDER(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(ORC), true, false);
				this.add(typeof(RSP_Z86_ORDER_DETAIL), false, false);
				this.add(typeof(RSP_Z86_ENCODED_ORDER), false, false);
				this.add(typeof(RSP_Z86_DISPENSE), false, false);
				this.add(typeof(RSP_Z86_GIVE), false, false);
				this.add(typeof(RSP_Z86_ADMINISTRATION), false, false);
				this.add(typeof(RSP_Z86_OBSERVATION), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RSP_Z86_COMMON_ORDER - this is probably a bug in the source code generator.", e);
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
		 * Returns RSP_Z86_ORDER_DETAIL (a Group object) - creates it if necessary
		 */
		public RSP_Z86_ORDER_DETAIL ORDER_DETAIL 
		{ 
			get
			{
				RSP_Z86_ORDER_DETAIL ret = null;
				try 
				{
					ret = (RSP_Z86_ORDER_DETAIL)this.get_Renamed("ORDER_DETAIL");
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
		 * Returns RSP_Z86_ENCODED_ORDER (a Group object) - creates it if necessary
		 */
		public RSP_Z86_ENCODED_ORDER ENCODED_ORDER 
		{ 
			get
			{
				RSP_Z86_ENCODED_ORDER ret = null;
				try 
				{
					ret = (RSP_Z86_ENCODED_ORDER)this.get_Renamed("ENCODED_ORDER");
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
		 * Returns RSP_Z86_DISPENSE (a Group object) - creates it if necessary
		 */
		public RSP_Z86_DISPENSE DISPENSE 
		{ 
			get
			{
				RSP_Z86_DISPENSE ret = null;
				try 
				{
					ret = (RSP_Z86_DISPENSE)this.get_Renamed("DISPENSE");
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
		 * Returns RSP_Z86_GIVE (a Group object) - creates it if necessary
		 */
		public RSP_Z86_GIVE GIVE 
		{ 
			get
			{
				RSP_Z86_GIVE ret = null;
				try 
				{
					ret = (RSP_Z86_GIVE)this.get_Renamed("GIVE");
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
		 * Returns RSP_Z86_ADMINISTRATION (a Group object) - creates it if necessary
		 */
		public RSP_Z86_ADMINISTRATION ADMINISTRATION 
		{ 
			get
			{
				RSP_Z86_ADMINISTRATION ret = null;
				try 
				{
					ret = (RSP_Z86_ADMINISTRATION)this.get_Renamed("ADMINISTRATION");
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
		 * Returns  first repetition of RSP_Z86_OBSERVATION (a Group object) - creates it if necessary
		 */
		public RSP_Z86_OBSERVATION getOBSERVATION() 
		{
			RSP_Z86_OBSERVATION ret = null;
			try 
			{
				ret = (RSP_Z86_OBSERVATION)this.get_Renamed("OBSERVATION");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of RSP_Z86_OBSERVATION
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public RSP_Z86_OBSERVATION getOBSERVATION(int rep) 
		{ 
			return (RSP_Z86_OBSERVATION)this.get_Renamed("OBSERVATION", rep);
		}

		/** 
		 * Returns the number of existing repetitions of RSP_Z86_OBSERVATION 
		 */ 
		public int OBSERVATIONReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("OBSERVATION").Length; 
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
