using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v24.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v24.segment
{

	/**
	 * <p>Represents an HL7 NK1 message segment. 
	 * This segment has the following fields:</p><p>
	 * NK1-1: Set ID - NK1 (SI)<br> 
	 * NK1-2: Name (XPN)<br> 
	 * NK1-3: Relationship (CE)<br> 
	 * NK1-4: Address (XAD)<br> 
	 * NK1-5: Phone Number (XTN)<br> 
	 * NK1-6: Business Phone Number (XTN)<br> 
	 * NK1-7: Contact Role (CE)<br> 
	 * NK1-8: Start Date (DT)<br> 
	 * NK1-9: End Date (DT)<br> 
	 * NK1-10: Next of Kin / Associated Parties Job Title (ST)<br> 
	 * NK1-11: Next of Kin / Associated Parties Job Code/Class (JCC)<br> 
	 * NK1-12: Next of Kin / Associated Parties Employee Number (CX)<br> 
	 * NK1-13: Organization Name - NK1 (XON)<br> 
	 * NK1-14: Marital Status (CE)<br> 
	 * NK1-15: Administrative Sex (IS)<br> 
	 * NK1-16: Date/Time Of Birth (TS)<br> 
	 * NK1-17: Living Dependency (IS)<br> 
	 * NK1-18: Ambulatory Status (IS)<br> 
	 * NK1-19: Citizenship (CE)<br> 
	 * NK1-20: Primary Language (CE)<br> 
	 * NK1-21: Living Arrangement (IS)<br> 
	 * NK1-22: Publicity Code (CE)<br> 
	 * NK1-23: Protection Indicator (ID)<br> 
	 * NK1-24: Student Indicator (IS)<br> 
	 * NK1-25: Religion (CE)<br> 
	 * NK1-26: Mother's Maiden Name (XPN)<br> 
	 * NK1-27: Nationality (CE)<br> 
	 * NK1-28: Ethnic Group (CE)<br> 
	 * NK1-29: Contact Reason (CE)<br> 
	 * NK1-30: Contact Person's Name (XPN)<br> 
	 * NK1-31: Contact Person's Telephone Number (XTN)<br> 
	 * NK1-32: Contact Person's Address (XAD)<br> 
	 * NK1-33: Next of Kin/Associated Party's Identifiers (CX)<br> 
	 * NK1-34: Job Status (IS)<br> 
	 * NK1-35: Race (CE)<br> 
	 * NK1-36: Handicap (IS)<br> 
	 * NK1-37: Contact Person Social Security Number (ST)<br> 
	 * </p><p>The get...() methods return data from individual fields.  These methods 
	 * do not throw exceptions and may therefore have to handle exceptions internally.  
	 * If an exception is handled internally, it is logged and null is returned.  
	 * This is not expected to happen - if it does happen this indicates not so much 
	 * an exceptional circumstance as a bug in the code for this class.</p>    
	 */
	[Serializable]
	public class NK1 : AbstractSegment  
	{

		/**
		 * Creates a NK1 (Next of kin / associated parties) segment object that belongs to the given 
		 * message.  
		 */
		public NK1(Group parent, ModelClassFactory factory) : base(parent,factory) 
		{
			Message message = Message;
			try 
			{
				this.add(typeof(SI), true, 1, 4, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(DT), false, 1, 8, new System.Object[]{message});
				this.add(typeof(ST), false, 1, 60, new System.Object[]{message});
				this.add(typeof(JCC), false, 1, 20, new System.Object[]{message});
				this.add(typeof(CX), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XON), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 1, new System.Object[]{message, 1});
				this.add(typeof(TS), false, 1, 26, new System.Object[]{message});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 223});
				this.add(typeof(IS), false, 0, 2, new System.Object[]{message, 9});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 220});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 136});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 231});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XPN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XTN), false, 0, 250, new System.Object[]{message});
				this.add(typeof(XAD), false, 0, 250, new System.Object[]{message});
				this.add(typeof(CX), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 311});
				this.add(typeof(CE), false, 0, 250, new System.Object[]{message});
				this.add(typeof(IS), false, 1, 2, new System.Object[]{message, 295});
				this.add(typeof(ST), false, 1, 16, new System.Object[]{message});
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
			}
		}

		/**
		* Returns Set ID - NK1(NK1-1).
		*/
		public SI SetIDNK1
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
		* Returns a single repetition of Name(NK1-2).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XPN getName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(2, rep);
				ret = (XPN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Name (NK1-2).
		 */
		public XPN[] getName() 
		{
			XPN[] ret = null;
			try 
			{
				Type[] t = this.getField(2);  
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XPN)t[i];
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
		* Returns Relationship(NK1-3).
		*/
		public CE Relationship
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(3, 0);
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
		* Returns a single repetition of Address(NK1-4).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XAD getAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(4, rep);
				ret = (XAD)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Address (NK1-4).
		 */
		public XAD[] getAddress() 
		{
			XAD[] ret = null;
			try 
			{
				Type[] t = this.getField(4);  
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XAD)t[i];
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
		* Returns a single repetition of Phone Number(NK1-5).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XTN getPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (XTN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Phone Number (NK1-5).
		 */
		public XTN[] getPhoneNumber() 
		{
			XTN[] ret = null;
			try 
			{
				Type[] t = this.getField(5);  
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XTN)t[i];
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
		* Returns a single repetition of Business Phone Number(NK1-6).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XTN getBusinessPhoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (XTN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Business Phone Number (NK1-6).
		 */
		public XTN[] getBusinessPhoneNumber() 
		{
			XTN[] ret = null;
			try 
			{
				Type[] t = this.getField(6);  
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XTN)t[i];
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
		* Returns Contact Role(NK1-7).
		*/
		public CE ContactRole
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
		* Returns Start Date(NK1-8).
		*/
		public DT StartDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(8, 0);
					ret = (DT)t;
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
		* Returns End Date(NK1-9).
		*/
		public DT EndDate
		{
			get
			{
				DT ret = null;
				try
				{
					Type t = this.getField(9, 0);
					ret = (DT)t;
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
		* Returns Next of Kin / Associated Parties Job Title(NK1-10).
		*/
		public ST NextOfKinAssociatedPartiesJobTitle
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(10, 0);
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
		* Returns Next of Kin / Associated Parties Job Code/Class(NK1-11).
		*/
		public JCC NextOfKinAssociatedPartiesJobCodeClass
		{
			get
			{
				JCC ret = null;
				try
				{
					Type t = this.getField(11, 0);
					ret = (JCC)t;
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
		* Returns Next of Kin / Associated Parties Employee Number(NK1-12).
		*/
		public CX NextOfKinAssociatedPartiesEmployeeNumber
		{
			get
			{
				CX ret = null;
				try
				{
					Type t = this.getField(12, 0);
					ret = (CX)t;
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
		* Returns a single repetition of Organization Name - NK1(NK1-13).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XON getOrganizationNameNK1(int rep)
		{
			XON ret = null;
			try
			{
				Type t = this.getField(13, rep);
				ret = (XON)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Organization Name - NK1 (NK1-13).
		 */
		public XON[] getOrganizationNameNK1() 
		{
			XON[] ret = null;
			try 
			{
				Type[] t = this.getField(13);  
				ret = new XON[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XON)t[i];
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
		* Returns Marital Status(NK1-14).
		*/
		public CE MaritalStatus
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
		* Returns Administrative Sex(NK1-15).
		*/
		public IS AdministrativeSex
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(15, 0);
					ret = (IS)t;
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
		* Returns Date/Time Of Birth(NK1-16).
		*/
		public TS DateTimeOfBirth
		{
			get
			{
				TS ret = null;
				try
				{
					Type t = this.getField(16, 0);
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
		* Returns a single repetition of Living Dependency(NK1-17).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public IS getLivingDependency(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(17, rep);
				ret = (IS)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Living Dependency (NK1-17).
		 */
		public IS[] getLivingDependency() 
		{
			IS[] ret = null;
			try 
			{
				Type[] t = this.getField(17);  
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (IS)t[i];
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
		* Returns a single repetition of Ambulatory Status(NK1-18).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public IS getAmbulatoryStatus(int rep)
		{
			IS ret = null;
			try
			{
				Type t = this.getField(18, rep);
				ret = (IS)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Ambulatory Status (NK1-18).
		 */
		public IS[] getAmbulatoryStatus() 
		{
			IS[] ret = null;
			try 
			{
				Type[] t = this.getField(18);  
				ret = new IS[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (IS)t[i];
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
		* Returns a single repetition of Citizenship(NK1-19).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getCitizenship(int rep)
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
		 * Returns all repetitions of Citizenship (NK1-19).
		 */
		public CE[] getCitizenship() 
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
		* Returns Primary Language(NK1-20).
		*/
		public CE PrimaryLanguage
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(20, 0);
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
		* Returns Living Arrangement(NK1-21).
		*/
		public IS LivingArrangement
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(21, 0);
					ret = (IS)t;
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
		* Returns Publicity Code(NK1-22).
		*/
		public CE PublicityCode
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(22, 0);
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
		* Returns Protection Indicator(NK1-23).
		*/
		public ID ProtectionIndicator
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(23, 0);
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
		* Returns Student Indicator(NK1-24).
		*/
		public IS StudentIndicator
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(24, 0);
					ret = (IS)t;
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
		* Returns Religion(NK1-25).
		*/
		public CE Religion
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

		/**
		* Returns a single repetition of Mother's Maiden Name(NK1-26).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XPN getMotherSMaidenName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(26, rep);
				ret = (XPN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Mother's Maiden Name (NK1-26).
		 */
		public XPN[] getMotherSMaidenName() 
		{
			XPN[] ret = null;
			try 
			{
				Type[] t = this.getField(26);  
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XPN)t[i];
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
		* Returns Nationality(NK1-27).
		*/
		public CE Nationality
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(27, 0);
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
		* Returns a single repetition of Ethnic Group(NK1-28).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getEthnicGroup(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(28, rep);
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
		 * Returns all repetitions of Ethnic Group (NK1-28).
		 */
		public CE[] getEthnicGroup() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(28);  
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
		* Returns a single repetition of Contact Reason(NK1-29).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getContactReason(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(29, rep);
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
		 * Returns all repetitions of Contact Reason (NK1-29).
		 */
		public CE[] getContactReason() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(29);  
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
		* Returns a single repetition of Contact Person's Name(NK1-30).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XPN getContactPersonSName(int rep)
		{
			XPN ret = null;
			try
			{
				Type t = this.getField(30, rep);
				ret = (XPN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Contact Person's Name (NK1-30).
		 */
		public XPN[] getContactPersonSName() 
		{
			XPN[] ret = null;
			try 
			{
				Type[] t = this.getField(30);  
				ret = new XPN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XPN)t[i];
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
		* Returns a single repetition of Contact Person's Telephone Number(NK1-31).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XTN getContactPersonSTelephoneNumber(int rep)
		{
			XTN ret = null;
			try
			{
				Type t = this.getField(31, rep);
				ret = (XTN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Contact Person's Telephone Number (NK1-31).
		 */
		public XTN[] getContactPersonSTelephoneNumber() 
		{
			XTN[] ret = null;
			try 
			{
				Type[] t = this.getField(31);  
				ret = new XTN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XTN)t[i];
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
		* Returns a single repetition of Contact Person's Address(NK1-32).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public XAD getContactPersonSAddress(int rep)
		{
			XAD ret = null;
			try
			{
				Type t = this.getField(32, rep);
				ret = (XAD)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Contact Person's Address (NK1-32).
		 */
		public XAD[] getContactPersonSAddress() 
		{
			XAD[] ret = null;
			try 
			{
				Type[] t = this.getField(32);  
				ret = new XAD[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (XAD)t[i];
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
		* Returns a single repetition of Next of Kin/Associated Party's Identifiers(NK1-33).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CX getNextOfKinAssociatedPartySIdentifiers(int rep)
		{
			CX ret = null;
			try
			{
				Type t = this.getField(33, rep);
				ret = (CX)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Next of Kin/Associated Party's Identifiers (NK1-33).
		 */
		public CX[] getNextOfKinAssociatedPartySIdentifiers() 
		{
			CX[] ret = null;
			try 
			{
				Type[] t = this.getField(33);  
				ret = new CX[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (CX)t[i];
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
		* Returns Job Status(NK1-34).
		*/
		public IS JobStatus
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(34, 0);
					ret = (IS)t;
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
		* Returns a single repetition of Race(NK1-35).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getRace(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(35, rep);
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
		 * Returns all repetitions of Race (NK1-35).
		 */
		public CE[] getRace() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(35);  
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
		* Returns Handicap(NK1-36).
		*/
		public IS Handicap
		{
			get
			{
				IS ret = null;
				try
				{
					Type t = this.getField(36, 0);
					ret = (IS)t;
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
		* Returns Contact Person Social Security Number(NK1-37).
		*/
		public ST ContactPersonSocialSecurityNumber
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(37, 0);
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


	}}