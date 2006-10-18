using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the OML_O21_ORDER_GENERAL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: OML_O21_CONTAINER_1 (a Group object) <b>optional </b><br>
 * 1: OML_O21_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class OML_O21_ORDER_GENERAL : AbstractGroup 
	{

		/** 
		 * Creates a new OML_O21_ORDER_GENERAL Group.
		 */
		public OML_O21_ORDER_GENERAL(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(OML_O21_CONTAINER_1), false, false);
				this.add(typeof(OML_O21_ORDER), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating OML_O21_ORDER_GENERAL - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns OML_O21_CONTAINER_1 (a Group object) - creates it if necessary
		 */
		public OML_O21_CONTAINER_1 CONTAINER_1 
		{ 
			get
			{
				OML_O21_CONTAINER_1 ret = null;
				try 
				{
					ret = (OML_O21_CONTAINER_1)this.get_Renamed("CONTAINER_1");
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
		 * Returns  first repetition of OML_O21_ORDER (a Group object) - creates it if necessary
		 */
		public OML_O21_ORDER getORDER() 
		{
			OML_O21_ORDER ret = null;
			try 
			{
				ret = (OML_O21_ORDER)this.get_Renamed("ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of OML_O21_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public OML_O21_ORDER getORDER(int rep) 
		{ 
			return (OML_O21_ORDER)this.get_Renamed("ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of OML_O21_ORDER 
		 */ 
		public int ORDERReps 
		{ 
			get
			{
				int reps = -1; 
				try 
				{ 
					reps = this.getAll("ORDER").Length; 
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
