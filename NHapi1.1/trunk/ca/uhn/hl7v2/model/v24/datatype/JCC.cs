using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

	///<summary>
	/// <p>The HL7 JCC (job code/class) data type.  Consists of the following components: </p><ol>
	/// <li>job code (IS)</li>
	/// <li>job class (IS)</li>
	/// </ol>
	///</summary>
	public class JCC : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a JCC.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public JCC(Message message) : base(message)
		{
			data = new Type[2];
			data[0] = new IS(message, 327);
			data[1] = new IS(message, 328);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 2 element JCC composite"); 
			} 
		} 
		///<summary>
		/// Returns job code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS JobCode 
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
		/// Returns job class (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS JobClass 
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
	}}