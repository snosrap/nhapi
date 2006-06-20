using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

	///<summary>
	/// <p>The HL7 CE (coded element) data type.  Consists of the following components: </p><ol>
	/// <li>identifier (ID)</li>
	/// <li>text (ST)</li>
	/// <li>name of coding system (ST)</li>
	/// <li>alternate identifier (ID)</li>
	/// <li>alternate text (ST)</li>
	/// <li>name of alternate coding system (ST)</li>
	/// </ol>
	///</summary>
	public class CE : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a CE.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public CE(Message message) : base(message)
		{
			data = new Type[6];
			data[0] = new ID(message, 0);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ID(message, 0);
			data[4] = new ST(message);
			data[5] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 6 element CE composite"); 
			} 
		} 
		///<summary>
		/// Returns identifier (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID Identifier 
		{
			get
			{
				ID ret = null;
				try 
				{
					ret = (ID)getComponent(0);
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
		/// Returns text (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST Text 
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
		/// Returns name of coding system (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST NameOfCodingSystem 
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
		/// Returns alternate identifier (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID AlternateIdentifier 
		{
			get
			{
				ID ret = null;
				try 
				{
					ret = (ID)getComponent(3);
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
		/// Returns alternate text (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST AlternateText 
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
		/// Returns name of alternate coding system (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST NameOfAlternateCodingSystem 
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
	}}