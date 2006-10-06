using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v23.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the RDS_O01_ORDER_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: RXO (Pharmacy prescription order segment) <b></b><br>
 * 1: RDS_O01_ORDER_DETAIL_SUPPLEMENT (a Group object) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v23.group
{
	public class RDS_O01_ORDER_DETAIL : AbstractGroup 
	{

		/** 
		 * Creates a new RDS_O01_ORDER_DETAIL Group.
		 */
		public RDS_O01_ORDER_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(RXO), true, false);
				this.add(typeof(RDS_O01_ORDER_DETAIL_SUPPLEMENT), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating RDS_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns RXO (Pharmacy prescription order segment) - creates it if necessary
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
		 * Returns RDS_O01_ORDER_DETAIL_SUPPLEMENT (a Group object) - creates it if necessary
		 */
		public RDS_O01_ORDER_DETAIL_SUPPLEMENT ORDER_DETAIL_SUPPLEMENT 
		{ 
			get
			{
				RDS_O01_ORDER_DETAIL_SUPPLEMENT ret = null;
				try 
				{
					ret = (RDS_O01_ORDER_DETAIL_SUPPLEMENT)this.get_Renamed("ORDER_DETAIL_SUPPLEMENT");
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
