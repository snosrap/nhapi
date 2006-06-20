using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

	///<summary>
	/// <p>The HL7 ELD (error) data type.  Consists of the following components: </p><ol>
	/// <li>segment ID (ST)</li>
	/// <li>sequence (NM)</li>
	/// <li>field position (NM)</li>
	/// <li>code identifying error (CE)</li>
	/// </ol>
	///</summary>
	[Serializable]
	public class ELD : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a ELD.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public ELD(Message message) : base(message)
		{
			data = new Type[4];
			data[0] = new ST(message);
			data[1] = new NM(message);
			data[2] = new NM(message);
			data[3] = new CE(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 4 element ELD composite"); 
			} 
		} 
		///<summary>
		/// Returns segment ID (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST SegmentID 
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
		/// Returns sequence (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NM Sequence 
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
		/// Returns field position (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NM FieldPosition 
		{
			get
			{
				NM ret = null;
				try 
				{
					ret = (NM)getComponent(2);
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
		/// Returns code identifying error (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public CE CodeIdentifyingError 
		{
			get
			{
				CE ret = null;
				try 
				{
					ret = (CE)getComponent(3);
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