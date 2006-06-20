using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

	///<summary>
	/// <p>The HL7 CM_NDL (observing practitioner) data type.  Consists of the following components: </p><ol>
	/// <li>name (CN)</li>
	/// <li>start date/time (TS)</li>
	/// <li>end date/time (TS)</li>
	/// <li>point of care (IS) (IS)</li>
	/// <li>room (IS)</li>
	/// <li>bed (IS)</li>
	/// <li>facility (HD) (HD)</li>
	/// <li>location status (IS)</li>
	/// <li>person location type (IS)</li>
	/// <li>building (IS)</li>
	/// <li>floor (ST)</li>
	/// </ol>
	///</summary>
	public class CM_NDL : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a CM_NDL.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public CM_NDL(Message message) : base(message)
		{
			data = new Type[11];
			data[0] = new CN(message);
			data[1] = new TS(message);
			data[2] = new TS(message);
			data[3] = new IS(message, 0);
			data[4] = new IS(message, 0);
			data[5] = new IS(message, 0);
			data[6] = new HD(message);
			data[7] = new IS(message, 0);
			data[8] = new IS(message, 0);
			data[9] = new IS(message, 0);
			data[10] = new ST(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 11 element CM_NDL composite"); 
			} 
		} 
		///<summary>
		/// Returns name (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public CN Name 
		{
			get
			{
				CN ret = null;
				try 
				{
					ret = (CN)getComponent(0);
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
		/// Returns start date/time (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public TS StartDateTime 
		{
			get
			{
				TS ret = null;
				try 
				{
					ret = (TS)getComponent(1);
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
		/// Returns end date/time (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public TS EndDateTime 
		{
			get
			{
				TS ret = null;
				try 
				{
					ret = (TS)getComponent(2);
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
		/// Returns point of care (IS) (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS PointOfCare 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(3);
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
		/// Returns room (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS Room 
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
		/// Returns bed (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS Bed 
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
		/// Returns facility (HD) (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public HD Facility 
		{
			get
			{
				HD ret = null;
				try 
				{
					ret = (HD)getComponent(6);
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
		/// Returns location status (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS LocationStatus 
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
		/// Returns person location type (component #8).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS PersonLocationType 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(8);
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
		/// Returns building (component #9).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS Building 
		{
			get
			{
				IS ret = null;
				try 
				{
					ret = (IS)getComponent(9);
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
		/// Returns floor (component #10).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST Floor 
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
	}}