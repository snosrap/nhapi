using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

	///<summary>
	/// <p>The HL7 DLT (delta check) data type.  Consists of the following components: </p><ol>
	/// <li>Range (NR)</li>
	/// <li>numeric threshold (NM)</li>
	/// <li>change computation (ST)</li>
	/// <li>length of time-days (NM)</li>
	/// </ol>
	///</summary>
	[Serializable]
	public class DLT : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a DLT.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public DLT(Message message) : base(message)
		{
			data = new Type[4];
			data[0] = new NR(message);
			data[1] = new NM(message);
			data[2] = new ST(message);
			data[3] = new NM(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element DLT composite"); 
			} 
		} 
		///<summary>
		/// Returns Range (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NR Range 
		{
			get
			{
				NR ret = null;
				try 
				{
					ret = (NR)getComponent(0);
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
		/// Returns numeric threshold (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NM NumericThreshold 
		{
			get
			{
				NM ret = null;
				try 
				{
					ret = (NM)getComponent(1);
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
		/// Returns change computation (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST ChangeComputation 
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
		/// Returns length of time-days (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NM LengthOfTimeDays 
		{
			get
			{
				NM ret = null;
				try 
				{
					ret = (NM)getComponent(3);
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