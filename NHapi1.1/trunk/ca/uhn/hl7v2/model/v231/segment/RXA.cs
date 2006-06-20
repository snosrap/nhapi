using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v231.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v231.segment
{

	/**
	 * <p>Represents an HL7 RXA message segment. 
	 * This segment has the following fields:</p><p>
	 * RXA-1: Give Sub-ID Counter (NM)<br> 
	 * RXA-2: Administration Sub-ID Counter (NM)<br> 
	 * RXA-3: Date/Time Start of Administration (TS)<br> 
	 * RXA-4: Date/Time End of Administration (TS)<br> 
	 * RXA-5: Administered Code (CE)<br> 
	 * RXA-6: Administered Amount (NM)<br> 
	 * RXA-7: Administered Units (CE)<br> 
	 * RXA-8: Administered Dosage Form (CE)<br> 
	 * RXA-9: Administration Notes (CE)<br> 
	 * RXA-10: Administering Provider (XCN)<br> 
	 * RXA-11: Administered-at Location (LA2)<br> 
	 * RXA-12: Administered Per (Time Unit) (ST)<br> 
	 * RXA-13: Administered Strength (NM)<br> 
	 * RXA-14: Administered Strength Units (CE)<br> 
	 * RXA-15: Substance Lot Number (ST)<br> 
	 * RXA-16: Substance Expiration Date (TS)<br> 
	 * RXA-17: Substance Manufacturer Name (CE)<br> 
	 * RXA-18: Substance Refusal Reason (CE)<br> 
	 * RXA-19: Indication (CE)<br> 
	 * RXA-20: Completion Status (ID)<br> 
	 * RXA-21: Action Code-RXA (ID)<br> 
	 * RXA-22: System Entry Date/Time (TS)<br> 
	 * </p><p>The get...() methods return data from individual fields.  These methods 
	 * do not throw exceptions and may therefore have to handle exceptions internally.  
	 * If an exception is handled internally, it is logged and null is returned.  
	 * This is not expected to happen - if it does happen this indicates not so much 
	 * an exceptional circumstance as a bug in the code for this class.</p>    
	 */
	[Serializable]
	public class RXA : AbstractSegment  
	{

		/**
		 * Creates a RXA (RXA - pharmacy/treatment administration segment) segment object that belongs to the given 
		 * message.  
		 */
		public RXA(Group parent, ModelClassFactory factory) : base(parent,factory) 
		{
			Message message = Message;
			try 
			{
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 4, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(TS), true, 1, 26, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 100, new System.Object[]{message});
				this.add(typeof(NM), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(XCN), false, 0, 200, new System.Object[]{message});
				this.add(typeof(LA2), false, 1, 200, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 20, new System.Object[]{message});
				this.add(typeof(NM), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 60, new System.Object[]{message});
				this.add(typeof(ST), false, 0, 20, new System.Object[]{message});
				this.add(typeof(TS), false, 0, 26, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 322});
				this.add(typeof(ID), false, 1, 2, new System.Object[]{message, 323});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
			}
		}

		/**
		* Returns Give Sub-ID Counter(RXA-1).
		*/
		public NM GiveSubIDCounter
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		* Returns Administration Sub-ID Counter(RXA-2).
		*/
		public NM AdministrationSubIDCounter
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(2, 0);
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
		* Returns Date/Time Start of Administration(RXA-3).
		*/
		public TS DateTimeStartOfAdministration
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		* Returns Date/Time End of Administration(RXA-4).
		*/
		public TS DateTimeEndOfAdministration
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
		* Returns Administered Code(RXA-5).
		*/
		public CE AdministeredCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(5, 0);
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
		* Returns Administered Amount(RXA-6).
		*/
		public NM AdministeredAmount
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(6, 0);
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
		* Returns Administered Units(RXA-7).
		*/
		public CE AdministeredUnits
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
		* Returns Administered Dosage Form(RXA-8).
		*/
		public CE AdministeredDosageForm
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

		/**
		* Returns a single repetition of Administration Notes(RXA-9).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getAdministrationNotes(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(9, rep);
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
		 * Returns all repetitions of Administration Notes (RXA-9).
		 */
		public CE[] getAdministrationNotes() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(9);  
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
		* Returns a single repetition of Administering Provider(RXA-10).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XCN getAdministeringProvider(int rep)
		{
			XCN ret = null;
			try
			{
				Type t = this.getField(10, rep);
				ret = (XCN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Administering Provider (RXA-10).
		 */
		public XCN[] getAdministeringProvider() 
		{
			XCN[] ret = null;
			try 
			{
				Type[] t = this.getField(10);  
				ret = new XCN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XCN)t[i];
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
		* Returns Administered-at Location(RXA-11).
		*/
		public LA2 AdministeredAtLocation
		{
			get
			{
				LA2 ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (LA2)t;
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
		* Returns Administered Per (Time Unit)(RXA-12).
		*/
		public ST AdministeredPerTimeUnit
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(12, 0);
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
		* Returns Administered Strength(RXA-13).
		*/
		public NM AdministeredStrength
		{
			get
			{
				NM ret = null;
				try
				{
					Type t = this.getField(13, 0);
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
		* Returns Administered Strength Units(RXA-14).
		*/
		public CE AdministeredStrengthUnits
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
		* Returns a single repetition of Substance Lot Number(RXA-15).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public ST getSubstanceLotNumber(int rep)
		{
			ST ret = null;
			try
			{
				Type t = this.getField(15, rep);
				ret = (ST)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Substance Lot Number (RXA-15).
		 */
		public ST[] getSubstanceLotNumber() 
		{
			ST[] ret = null;
			try 
			{
				Type[] t = this.getField(15);  
				ret = new ST[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (ST)t[i];
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
		* Returns a single repetition of Substance Expiration Date(RXA-16).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public TS getSubstanceExpirationDate(int rep)
		{
			TS ret = null;
			try
			{
				Type t = this.getField(16, rep);
				ret = (TS)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Substance Expiration Date (RXA-16).
		 */
		public TS[] getSubstanceExpirationDate() 
		{
			TS[] ret = null;
			try 
			{
				Type[] t = this.getField(16);  
				ret = new TS[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (TS)t[i];
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
		* Returns a single repetition of Substance Manufacturer Name(RXA-17).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getSubstanceManufacturerName(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(17, rep);
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
		 * Returns all repetitions of Substance Manufacturer Name (RXA-17).
		 */
		public CE[] getSubstanceManufacturerName() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(17);  
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
		* Returns a single repetition of Substance Refusal Reason(RXA-18).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getSubstanceRefusalReason(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(18, rep);
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
		 * Returns all repetitions of Substance Refusal Reason (RXA-18).
		 */
		public CE[] getSubstanceRefusalReason() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(18);  
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
		* Returns a single repetition of Indication(RXA-19).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getIndication(int rep)
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
		 * Returns all repetitions of Indication (RXA-19).
		 */
		public CE[] getIndication() 
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
		* Returns Completion Status(RXA-20).
		*/
		public ID CompletionStatus
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		* Returns Action Code-RXA(RXA-21).
		*/
		public ID ActionCodeRXA
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(21, 0);
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
		* Returns System Entry Date/Time(RXA-22).
		*/
		public TS SystemEntryDateTime
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(22, 0);
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


	}}