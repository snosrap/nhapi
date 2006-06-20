using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

	///<summary>
	/// <p>The HL7 PPN (performing person time stamp) data type.  Consists of the following components: </p><ol>
	/// <li>ID number (ST)</li>
	/// <li>family name (ST)</li>
	/// <li>given name (ST)</li>
	/// <li>middle initial or name (ST)</li>
	/// <li>suffix (e.g., JR or III) (ST)</li>
	/// <li>prefix (e.g., DR) (ST)</li>
	/// <li>degree (e.g., MD) (ST)</li>
	/// <li>source table (ID)</li>
	/// <li>assigning authority (HD)</li>
	/// <li>name type code (ID)</li>
	/// <li>identifier check digit (ST)</li>
	/// <li>code identifying the check digit scheme employed (ID)</li>
	/// <li>identifier type code (IS)</li>
	/// <li>assigning facility (HD)</li>
	/// <li>Date/Time Action Performed (TS)</li>
	/// </ol>
	///</summary>
	public class PPN : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a PPN.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public PPN(Message message) : base(message)
		{
			data = new Type[15];
			data[0] = new ST(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ST(message);
			data[6] = new ST(message);
			data[7] = new ID(message, 0);
			data[8] = new HD(message);
			data[9] = new ID(message, 0);
			data[10] = new ST(message);
			data[11] = new ID(message, 0);
			data[12] = new IS(message, 0);
			data[13] = new HD(message);
			data[14] = new TS(message);
		}

		///<summary>
		/// Returns an array containing the data elements.
		///</summary>
		public Type[] Components
		{ 
			get
			{
				return this.data; 
			}
		}

		///<summary>
		/// Returns an individual data component.
		/// @throws DataTypeException if the given element number is out of range.
		///<param name="number">The ordinal item to get</param>	///<returns>The data component (as a type) at the requested number (ordinal)</returns>	///<summary>
		public Type getComponent(int number) 
		{ 

			try 
			{ 
				return this.data[number]; 
			} 
			catch (System.ArgumentOutOfRangeException) 
			{ 
				throw new DataTypeException("Element " + number + " doesn't exist in 15 element PPN composite"); 
			} 
		} 
		///<summary>
		/// Returns ID number (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST IDNumber 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(0);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns family name (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST FamilyName 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(1);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns given name (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST GivenName 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(2);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns middle initial or name (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST MiddleInitialOrName 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(3);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns suffix (e.g., JR or III) (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST SuffixEgJRorIII 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(4);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns prefix (e.g., DR) (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST PrefixEgDR 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(5);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns degree (e.g., MD) (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST DegreeEgMD 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(6);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns source table (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID SourceTable 
		{
			get
			{
				ID ret = null;
				try 
				{
					ret = (ID)getComponent(7);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns assigning authority (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public HD AssigningAuthority 
		{
			get
			{
				HD ret = null;
				try 
				{
					ret = (HD)getComponent(8);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns name type code (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID NameTypeCode 
		{
			get
			{
				ID ret = null;
				try 
				{
					ret = (ID)getComponent(9);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns identifier check digit (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST IdentifierCheckDigit 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(10);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns code identifying the check digit scheme employed (component #11).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID CodeIdentifyingTheCheckDigitSchemeEmployed 
		{
			get
			{
				ID ret = null;
				try 
				{
					ret = (ID)getComponent(11);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns identifier type code (component #12).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS IdentifierTypeCode 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(12);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns assigning facility (component #13).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public HD AssigningFacility 
		{
			get
			{
				HD ret = null;
				try 
				{
					ret = (HD)getComponent(13);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
		///<summary>
		/// Returns Date/Time Action Performed (component #14).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public TS DateTimeActionPerformed 
		{
			get
			{
				TS ret = null;
				try 
				{
					ret = (TS)getComponent(14);
				} 
				catch (DataTypeException e) 
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}

		}
	}}