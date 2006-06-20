using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using ca.uhn.hl7v2.model.v24.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SUR_P09_FACILITY_DETAIL Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: FAC (Facility) <b></b><br>
 * 1: PDC (Product Detail Country) <b></b><br>
 * 2: NTE (Notes and Comments) <b></b><br>
 */
namespace ca.uhn.hl7v2.model.v24.group
{
	public class SUR_P09_FACILITY_DETAIL : AbstractGroup 
	{

		/** 
		 * Creates a new SUR_P09_FACILITY_DETAIL Group.
		 */
		public SUR_P09_FACILITY_DETAIL(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(FAC), true, false);
				this.add(typeof(PDC), true, false);
				this.add(typeof(NTE), true, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SUR_P09_FACILITY_DETAIL - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns FAC (Facility) - creates it if necessary
		 */
		public FAC FAC 
		{ 
			get
			{
				FAC ret = null;
				try 
				{
					ret = (FAC)this.get_Renamed("FAC");
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
		 * Returns PDC (Product Detail Country) - creates it if necessary
		 */
		public PDC PDC 
		{ 
			get
			{
				PDC ret = null;
				try 
				{
					ret = (PDC)this.get_Renamed("PDC");
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
		 * Returns NTE (Notes and Comments) - creates it if necessary
		 */
		public NTE NTE 
		{ 
			get
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
		}

	}
}
