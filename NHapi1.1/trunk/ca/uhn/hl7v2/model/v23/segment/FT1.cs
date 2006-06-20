using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment
{

	/**
	 * <p>Represents an HL7 FT1 message segment. 
	 * This segment has the following fields:</p><p>
	 * FT1-1: Set ID - Financial Transaction (SI)<br> 
	 * FT1-2: Transaction ID (ST)<br> 
	 * FT1-3: Transaction Batch ID (ST)<br> 
	 * FT1-4: Transaction Date (TS)<br> 
	 * FT1-5: Transaction Posting Date (TS)<br> 
	 * FT1-6: Transaction Type (ID)<br> 
	 * FT1-7: Transaction Code (CE)<br> 
	 * FT1-8: Transaction Description (ST)<br> 
	 * FT1-9: Transaction Description - alternate (ST)<br> 
	 * FT1-10: Transaction Quantity (NM)<br> 
	 * FT1-11: Transaction Amount - Extended (CP)<br> 
	 * FT1-12: Transaction Amount - Unit (CP)<br> 
	 * FT1-13: Department Code (CE)<br> 
	 * FT1-14: Insurance Plan ID (CE)<br> 
	 * FT1-15: Insurance Amount (CP)<br> 
	 * FT1-16: Assigned Patient Location (PL)<br> 
	 * FT1-17: Fee Schedule (ID)<br> 
	 * FT1-18: Patient Type (ID)<br> 
	 * FT1-19: Diagnosis Code (CE)<br> 
	 * FT1-20: Performed By Code (XCN)<br> 
	 * FT1-21: Ordered By Code (XCN)<br> 
	 * FT1-22: Unit Cost (NM)<br> 
	 * FT1-23: Filler Order Number (EI)<br> 
	 * FT1-24: Entered By Code (XCN)<br> 
	 * FT1-25: Procedure Code (CE)<br> 
	 * </p><p>The get...() methods return data from individual fields.  These methods 
	 * do not throw exceptions and may therefore have to handle exceptions internally.  
	 * If an exception is handled internally, it is logged and null is returned.  
	 * This is not expected to happen - if it does happen this indicates not so much 
	 * an exceptional circumstance as a bug in the code for this class.</p>    
	 */
	[Serializable]
	public class FT1 : AbstractSegment  
	{

		/**
		 * Creates a FT1 (Financial transaction) segment object that belongs to the given 
		 * message.  
		 */
		public FT1(Group parent, ModelClassFactory factory) : base(parent,factory) 
		{
			Message message = Message;
			try 
			{
				this.add(typeof(SI), false, 1, 4, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 10, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(ID), true, 1, 8, new System.Object[]{message, 17});
				this.add(typeof(CE), true, 1, 80, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 40, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 6, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 8, new System.Object[]{message});
				this.add(typeof(CP), false, 1, 12, new System.Object[]{message});
				this.add(typeof(PL), false, 1, 12, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 24});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 18});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 120, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 120, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 12, new System.Object[]{message});
				this.add(typeof(EI), false, 1, 22, new System.Object[]{message});
				this.add(typeof(XCN), false, 1, 120, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 80, new System.Object[]{message});
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
			}
		}

		/**
		* Returns Set ID - Financial Transaction(FT1-1).
		*/
		public SI SetIDFinancialTransaction
		{
			get
			{
				SI ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (SI)t;
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
		* Returns Transaction ID(FT1-2).
		*/
		public ST TransactionID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (ST)t;
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
		* Returns Transaction Batch ID(FT1-3).
		*/
		public ST TransactionBatchID
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (ST)t;
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
		* Returns Transaction Date(FT1-4).
		*/
		public TS TransactionDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (TS)t;
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
		* Returns Transaction Posting Date(FT1-5).
		*/
		public TS TransactionPostingDate
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (TS)t;
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
		* Returns Transaction Type(FT1-6).
		*/
		public ID TransactionType
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
		* Returns Transaction Code(FT1-7).
		*/
		public CE TransactionCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(7, 0);
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
		* Returns Transaction Description(FT1-8).
		*/
		public ST TransactionDescription
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (ST)t;
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
		* Returns Transaction Description - alternate(FT1-9).
		*/
		public ST TransactionDescriptionAlternate
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (ST)t;
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
		* Returns Transaction Quantity(FT1-10).
		*/
		public NM TransactionQuantity
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(10, 0);
					ret = (NM)t;
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
		* Returns Transaction Amount - Extended(FT1-11).
		*/
		public CP TransactionAmountExtended
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (CP)t;
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
		* Returns Transaction Amount - Unit(FT1-12).
		*/
		public CP TransactionAmountUnit
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CP)t;
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
		* Returns Department Code(FT1-13).
		*/
		public CE DepartmentCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		* Returns Insurance Plan ID(FT1-14).
		*/
		public CE InsurancePlanID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(14, 0);
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
		* Returns Insurance Amount(FT1-15).
		*/
		public CP InsuranceAmount
		{
			get
			{
				CP ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (CP)t;
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
		* Returns Assigned Patient Location(FT1-16).
		*/
		public PL AssignedPatientLocation
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(16, 0);
					ret = (PL)t;
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
		* Returns Fee Schedule(FT1-17).
		*/
		public ID FeeSchedule
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(17, 0);
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
		* Returns Patient Type(FT1-18).
		*/
		public ID PatientType
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(18, 0);
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
		* Returns a single repetition of Diagnosis Code(FT1-19).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getDiagnosisCode(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(19, rep);
				ret = (CE)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Diagnosis Code (FT1-19).
		 */
		public CE[] getDiagnosisCode() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(19);  
				ret = new CE[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (CE)t[i];
				}
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
			} 
			catch (System.Exception cce) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", cce);
				throw new System.Exception("An unexpected error ocurred", cce);
			}
			return ret;
		}

		/**
		* Returns Performed By Code(FT1-20).
		*/
		public XCN PerformedByCode
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(20, 0);
					ret = (XCN)t;
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
		* Returns Ordered By Code(FT1-21).
		*/
		public XCN OrderedByCode
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (XCN)t;
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
		* Returns Unit Cost(FT1-22).
		*/
		public NM UnitCost
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(22, 0);
					ret = (NM)t;
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
		* Returns Filler Order Number(FT1-23).
		*/
		public EI FillerOrderNumber
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(23, 0);
					ret = (EI)t;
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
		* Returns Entered By Code(FT1-24).
		*/
		public XCN EnteredByCode
		{
			get
			{
				XCN ret = null;
				try
				{
					Type t = this.getField(24, 0);
					ret = (XCN)t;
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
		* Returns Procedure Code(FT1-25).
		*/
		public CE ProcedureCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(25, 0);
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