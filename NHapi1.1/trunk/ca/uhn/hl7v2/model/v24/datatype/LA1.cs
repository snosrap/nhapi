using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

	///<summary>
	/// <p>The HL7 LA1 (Location with address information (variant 1)) data type.  Consists of the following components: </p><ol>
	/// <li>point of care (IS) (IS)</li>
	/// <li>room (IS)</li>
	/// <li>bed (IS)</li>
	/// <li>facility (HD) (HD)</li>
	/// <li>location status (IS)</li>
	/// <li>person location type (IS)</li>
	/// <li>building (IS)</li>
	/// <li>floor (IS)</li>
	/// <li>address (AD)</li>
	/// </ol>
	///</summary>
	public class LA1 : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a LA1.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public LA1(Message message) : base(message)
		{
			data = new Type[9];
			data[0] = new IS(message, 0);
			data[1] = new IS(message, 0);
			data[2] = new IS(message, 0);
			data[3] = new HD(message);
			data[4] = new IS(message, 0);
			data[5] = new IS(message, 0);
			data[6] = new IS(message, 0);
			data[7] = new IS(message, 0);
			data[8] = new AD(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 9 element LA1 composite"); 
			} 
		} 
		///<summary>
		/// Returns point of care (IS) (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS PointOfCare 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(0);
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
		/// Returns room (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS Room 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(1);
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
		/// Returns bed (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS Bed 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(2);
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
		/// Returns facility (HD) (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public HD Facility 
		{
			get
			{
				HD ret = null;
				try 
				{
					ret = (HD)getComponent(3);
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
		/// Returns location status (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS LocationStatus 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(4);
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
		/// Returns person location type (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS PersonLocationType 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(5);
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
		/// Returns building (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS Building 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(6);
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
		/// Returns floor (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS Floor 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(7);
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
		/// Returns address (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public AD Address 
		{
			get
			{
				AD ret = null;
				try 
				{
					ret = (AD)getComponent(8);
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