using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment
{

	/**
	 * <p>Represents an HL7 TCD message segment. 
	 * This segment has the following fields:</p><p>
	 * TCD-1: Universal Service Identifier (CE)<br> 
	 * TCD-2: Auto-Dilution Factor (SN)<br> 
	 * TCD-3: Rerun Dilution Factor (SN)<br> 
	 * TCD-4: Pre-Dilution Factor (SN)<br> 
	 * TCD-5: Endogenous Content of Pre-Dilution Diluent (SN)<br> 
	 * TCD-6: Automatic Repeat Allowed (ID)<br> 
	 * TCD-7: Reflex Allowed (ID)<br> 
	 * TCD-8: Analyte Repeat Status (CE)<br> 
	 * </p><p>The get...() methods return data from individual fields.  These methods 
	 * do not throw exceptions and may therefore have to handle exceptions internally.  
	 * If an exception is handled internally, it is logged and null is returned.  
	 * This is not expected to happen - if it does happen this indicates not so much 
	 * an exceptional circumstance as a bug in the code for this class.</p>    
	 */
	[Serializable]
	public class TCD : AbstractSegment  
	{

		/**
		 * Creates a TCD (Test Code Detail) segment object that belongs to the given 
		 * message.  
		 */
		public TCD(Group parent, ModelClassFactory factory) : base(parent,factory) 
		{
			Message message = Message;
			try 
			{
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(SN), false, 1, 20, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
			}
		}

		/**
		* Returns Universal Service Identifier(TCD-1).
		*/
		public CE UniversalServiceIdentifier
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (CE)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Auto-Dilution Factor(TCD-2).
		*/
		public SN AutoDilutionFactor
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (SN)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Rerun Dilution Factor(TCD-3).
		*/
		public SN RerunDilutionFactor
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (SN)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Pre-Dilution Factor(TCD-4).
		*/
		public SN PreDilutionFactor
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (SN)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Endogenous Content of Pre-Dilution Diluent(TCD-5).
		*/
		public SN EndogenousContentOfPreDilutionDiluent
		{
			get
			{
				SN ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (SN)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Automatic Repeat Allowed(TCD-6).
		*/
		public ID AutomaticRepeatAllowed
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(6, 0);
					ret = (ID)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Reflex Allowed(TCD-7).
		*/
		public ID ReflexAllowed
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(7, 0);
					ret = (ID)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}

		/**
		* Returns Analyte Repeat Status(TCD-8).
		*/
		public CE AnalyteRepeatStatus
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (CE)t;
				}
				catch (HL7Exception he) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
					throw new System.Exception("An unexpected error ocurred", he);
				} 
				catch (System.Exception ex) 
				{
					HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
					throw new System.Exception("An unexpected error ocurred", ex);
				}
				return ret;
			}
		}


	}}