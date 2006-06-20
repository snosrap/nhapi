using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

	///<summary>
	/// <p>The HL7 CF (coded element with formatted values) data type.  Consists of the following components: </p><ol>
	/// <li>identifier (ST)</li>
	/// <li>formatted text (FT)</li>
	/// <li>name of coding system (ST)</li>
	/// <li>alternate identifier (ST)</li>
	/// <li>alternate formatted text (FT)</li>
	/// <li>name of alternate coding system (ST)</li>
	/// </ol>
	///</summary>
	[Serializable]
	public class CF : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a CF.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public CF(Message message) : base(message)
		{
			data = new Type[6];
			data[0] = new ST(message);
			data[1] = new FT(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new FT(message);
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
		///<param name="number">The ordinal item to get</param>
		///<returns>The data component (as a type) at the requested number (ordinal)</returns>
		///<summary>
		public Type getComponent(int number) 
		{ 

			try 
			{ 
				return this.data[number]; 
			} 
			catch (System.ArgumentOutOfRangeException) 
			{ 
				throw new DataTypeException("Element " + number + " doesn't exist in 6 element CF composite"); 
			} 
		} 
		///<summary>
		/// Returns identifier (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST Identifier 
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
		/// Returns formatted text (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public FT FormattedText 
		{
			get
			{
				FT ret = null;
				try 
				{
					ret = (FT)getComponent(1);
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
		public ST AlternateIdentifier 
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
		/// Returns alternate formatted text (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public FT AlternateFormattedText 
		{
			get
			{
				FT ret = null;
				try 
				{
					ret = (FT)getComponent(4);
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