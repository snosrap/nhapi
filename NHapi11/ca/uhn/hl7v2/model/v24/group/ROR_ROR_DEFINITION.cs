using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the ROR_ROR_DEFINITION Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: QRD (Original-Style Query Definition) <b></b><br>
 * 1: QRF (Original Style Query Filter) <b>optional </b><br>
 * 2: ROR_ROR_PATIENT (a Group object) <b>optional </b><br>
 * 3: ROR_ROR_ORDER (a Group object) <b>repeating</b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class ROR_ROR_DEFINITION : AbstractGroup 
	{

		/** 
		 * Creates a new ROR_ROR_DEFINITION Group.
		 */
		public ROR_ROR_DEFINITION(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(QRD), true, false);
				this.add(typeof(QRF), false, false);
				this.add(typeof(ROR_ROR_PATIENT), false, false);
				this.add(typeof(ROR_ROR_ORDER), true, true);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating ROR_ROR_DEFINITION - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns QRD (Original-Style Query Definition) - creates it if necessary
		 */
		public QRD QRD 
		{ 
			get
			{
				QRD ret = null;
				try 
				{
					ret = (QRD)this.get_Renamed("QRD");
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
		 * Returns QRF (Original Style Query Filter) - creates it if necessary
		 */
		public QRF QRF 
		{ 
			get
			{
				QRF ret = null;
				try 
				{
					ret = (QRF)this.get_Renamed("QRF");
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
		 * Returns ROR_ROR_PATIENT (a Group object) - creates it if necessary
		 */
		public ROR_ROR_PATIENT PATIENT 
		{ 
			get
			{
				ROR_ROR_PATIENT ret = null;
				try 
				{
					ret = (ROR_ROR_PATIENT)this.get_Renamed("PATIENT");
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
		 * Returns  first repetition of ROR_ROR_ORDER (a Group object) - creates it if necessary
		 */
		public ROR_ROR_ORDER getORDER() 
		{
			ROR_ROR_ORDER ret = null;
			try 
			{
				ret = (ROR_ROR_ORDER)this.get_Renamed("ORDER");
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
				throw new System.Exception("An unexpected error ocurred",e);
			}
			return ret;
		}

		/**
		 * Returns a specific repetition of ROR_ROR_ORDER
		 * (a Group object) - creates it if necessary
		 * throws HL7Exception if the repetition requested is more than one 
		 *     greater than the number of existing repetitions.
		 */
		public ROR_ROR_ORDER getORDER(int rep) 
		{ 
			return (ROR_ROR_ORDER)this.get_Renamed("ORDER", rep);
		}

		/** 
		 * Returns the number of existing repetitions of ROR_ROR_ORDER 
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
