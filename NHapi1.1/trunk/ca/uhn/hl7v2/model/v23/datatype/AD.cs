using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

	///<summary>
	/// <p>The HL7 AD (address) data type.  Consists of the following components: </p><ol>
	/// <li>street address (ST)</li>
	/// <li>other designation (ST)</li>
	/// <li>city (ST)</li>
	/// <li>state or province (ST)</li>
	/// <li>zip or postal code (ST)</li>
	/// <li>country (ID)</li>
	/// <li>address type (ID)</li>
	/// <li>other geographic designation (ST)</li>
	/// </ol>
	///</summary>
	public class AD : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a AD.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public AD(Message message) : base(message)
		{
			data = new Type[8];
			data[0] = new ST(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new ID(message, 0);
			data[6] = new ID(message, 0);
			data[7] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 8 element AD composite"); 
			} 
		} 
		///<summary>
		/// Returns street address (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST StreetAddress 
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
		/// Returns other designation (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST OtherDesignation 
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
		/// Returns city (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST City 
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
		/// Returns state or province (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST StateOrProvince 
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
		/// Returns zip or postal code (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST ZipOrPostalCode 
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
		/// Returns country (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID Country 
		{
			get
			{
				ID ret = null;
				try 
				{
					ret = (ID)getComponent(5);
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
		/// Returns address type (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID AddressType 
		{
			get
			{
				ID ret = null;
				try 
				{
					ret = (ID)getComponent(6);
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
		/// Returns other geographic designation (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST OtherGeographicDesignation 
		{
			get
			{
				ST ret = null;
				try 
				{
					ret = (ST)getComponent(7);
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