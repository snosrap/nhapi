using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;
using ca.uhn.log;
using System;
using ca.uhn.hl7v2.model.v231.segment;

using ca.uhn.hl7v2.model;
/**
 * <p>Represents the SQM_S25_LOCATION_RESOURCE Group.  A Group is an ordered collection of message 
 * segments that can repeat together or be optionally in/excluded together.
 * This Group contains the following elements: </p>
 * 0: AIL (AIL - appointment information - location resource segment) <b></b><br>
 * 1: APR (APR - appointment preferences segment) <b>optional </b><br>
 */
namespace ca.uhn.hl7v2.model.v231.group
{
	[Serializable]
	public class SQM_S25_LOCATION_RESOURCE : AbstractGroup 
	{

		/** 
		 * Creates a new SQM_S25_LOCATION_RESOURCE Group.
		 */
		public SQM_S25_LOCATION_RESOURCE(Group parent, ModelClassFactory factory) : base(parent, factory)
		{
			try 
			{
				this.add(typeof(AIL), true, false);
				this.add(typeof(APR), false, false);
			} 
			catch(HL7Exception e) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected error creating SQM_S25_LOCATION_RESOURCE - this is probably a bug in the source code generator.", e);
			}
		}

		/**
		 * Returns AIL (AIL - appointment information - location resource segment) - creates it if necessary
		 */
		public AIL AIL 
		{ 
			get
			{
				AIL ret = null;
				try 
				{
					ret = (AIL)this.get_Renamed("AIL");
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
		 * Returns APR (APR - appointment preferences segment) - creates it if necessary
		 */
		public APR APR 
		{ 
			get
			{
				APR ret = null;
				try 
				{
					ret = (APR)this.get_Renamed("APR");
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
