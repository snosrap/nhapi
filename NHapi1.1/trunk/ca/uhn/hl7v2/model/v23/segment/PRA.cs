using System;
using ca.uhn.hl7v2.model;
using ca.uhn.hl7v2.model.v23.datatype;

using ca.uhn.log;
using ca.uhn.hl7v2.parser;
using ca.uhn.hl7v2;

namespace ca.uhn.hl7v2.model.v23.segment
{

	/**
	 * <p>Represents an HL7 PRA message segment. 
	 * This segment has the following fields:</p><p>
	 * PRA-1: PRA - Primary Key Value (ST)<br> 
	 * PRA-2: Practioner Group (CE)<br> 
	 * PRA-3: Practioner Category (ID)<br> 
	 * PRA-4: Provider Billing (ID)<br> 
	 * PRA-5: Specialty (CM_SPD)<br> 
	 * PRA-6: Practitioner ID Numbers (CM_PLN)<br> 
	 * PRA-7: Privileges (CM_PIP)<br> 
	 * </p><p>The get...() methods return data from individual fields.  These methods 
	 * do not throw exceptions and may therefore have to handle exceptions internally.  
	 * If an exception is handled internally, it is logged and null is returned.  
	 * This is not expected to happen - if it does happen this indicates not so much 
	 * an exceptional circumstance as a bug in the code for this class.</p>    
	 */
	[Serializable]
	public class PRA : AbstractSegment  
	{

		/**
		 * Creates a PRA (Practitioner detail segment) segment object that belongs to the given 
		 * message.  
		 */
		public PRA(Group parent, ModelClassFactory factory) : base(parent,factory) 
		{
			Message message = Message;
			try 
			{
				this.add(typeof(ST), true, 1, 20, new System.Object[]{message});
				this.add(typeof(CE), false, 0, 60, new System.Object[]{message});
				this.add(typeof(ID), false, 0, 3, new System.Object[]{message, 0});
				this.add(typeof(ID), false, 1, 1, new System.Object[]{message, 186});
				this.add(typeof(CM_SPD), false, 0, 100, new System.Object[]{message});
				this.add(typeof(CM_PLN), false, 0, 100, new System.Object[]{message});
				this.add(typeof(CM_PIP), false, 0, 200, new System.Object[]{message});
			} 
			catch (HL7Exception he) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Can't instantiate " + this.getStructureName(), he);
			}
		}

		/**
		* Returns PRA - Primary Key Value(PRA-1).
		*/
		public ST PRAPrimaryKeyValue
		{
			get
			{
				ST ret = null;
				try
				{
					Type t = this.getField(1, 0);
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
		* Returns a single repetition of Practioner Group(PRA-2).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CE getPractionerGroup(int rep)
		{
			CE ret = null;
			try
			{
				Type t = this.getField(2, rep);
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
		 * Returns all repetitions of Practioner Group (PRA-2).
		 */
		public CE[] getPractionerGroup() 
		{
			CE[] ret = null;
			try 
			{
				Type[] t = this.getField(2);  
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
		* Returns a single repetition of Practioner Category(PRA-3).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public ID getPractionerCategory(int rep)
		{
			ID ret = null;
			try
			{
				Type t = this.getField(3, rep);
				ret = (ID)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Practioner Category (PRA-3).
		 */
		public ID[] getPractionerCategory() 
		{
			ID[] ret = null;
			try 
			{
				Type[] t = this.getField(3);  
				ret = new ID[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (ID)t[i];
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
		* Returns Provider Billing(PRA-4).
		*/
		public ID ProviderBilling
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(4, 0);
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
		* Returns a single repetition of Specialty(PRA-5).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CM_SPD getSpecialty(int rep)
		{
			CM_SPD ret = null;
			try
			{
				Type t = this.getField(5, rep);
				ret = (CM_SPD)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Specialty (PRA-5).
		 */
		public CM_SPD[] getSpecialty() 
		{
			CM_SPD[] ret = null;
			try 
			{
				Type[] t = this.getField(5);  
				ret = new CM_SPD[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (CM_SPD)t[i];
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
		* Returns a single repetition of Practitioner ID Numbers(PRA-6).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CM_PLN getPractitionerIDNumbers(int rep)
		{
			CM_PLN ret = null;
			try
			{
				Type t = this.getField(6, rep);
				ret = (CM_PLN)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Practitioner ID Numbers (PRA-6).
		 */
		public CM_PLN[] getPractitionerIDNumbers() 
		{
			CM_PLN[] ret = null;
			try 
			{
				Type[] t = this.getField(6);  
				ret = new CM_PLN[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (CM_PLN)t[i];
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
		* Returns a single repetition of Privileges(PRA-7).
		* @param rep the repetition number (this is a repeating field)
		* @throws HL7Exception if the repetition number is invalid.
		*/
		public CM_PIP getPrivileges(int rep)
		{
			CM_PIP ret = null;
			try
			{
				Type t = this.getField(7, rep);
				ret = (CM_PIP)t;
			} 
			catch (System.Exception ex) 
			{
				HapiLogFactory.getHapiLog(GetType()).error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
			}
			return ret;
		}

		/**
		 * Returns all repetitions of Privileges (PRA-7).
		 */
		public CM_PIP[] getPrivileges() 
		{
			CM_PIP[] ret = null;
			try 
			{
				Type[] t = this.getField(7);  
				ret = new CM_PIP[t.Length];
				for (int i = 0; i < ret.Length; i++) 
				{
					ret[i] = (CM_PIP)t[i];
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


	}}