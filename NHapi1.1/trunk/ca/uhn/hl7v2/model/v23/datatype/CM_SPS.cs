using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v23.datatype
{

	///<summary>
	/// <p>The HL7 CM_SPS (specimen source) data type.  Consists of the following components: </p><ol>
	/// <li>specimen source name or code (CE)</li>
	/// <li>additives (TX)</li>
	/// <li>freetext (TX)</li>
	/// <li>body site (CE)</li>
	/// <li>site modifier (CE)</li>
	/// <li>collection modifier method code (CE)</li>
	/// </ol>
	///</summary>
	public class CM_SPS : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a CM_SPS.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public CM_SPS(Message message) : base(message)
		{
			data = new Type[6];
			data[0] = new CE(message);
			data[1] = new TX(message);
			data[2] = new TX(message);
			data[3] = new CE(message);
			data[4] = new CE(message);
			data[5] = new CE(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 6 element CM_SPS composite"); 
			} 
		} 
		///<summary>
		/// Returns specimen source name or code (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public CE SpecimenSourceNameOrCode 
		{
			get
			{
				CE ret = null;
				try 
				{
					ret = (CE)getComponent(0);
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
		/// Returns additives (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public TX Additives 
		{
			get
			{
				TX ret = null;
				try 
				{
					ret = (TX)getComponent(1);
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
		/// Returns freetext (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public TX Freetext 
		{
			get
			{
				TX ret = null;
				try 
				{
					ret = (TX)getComponent(2);
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
		/// Returns body site (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public CE BodySite 
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
		///<summary>
		/// Returns site modifier (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public CE SiteModifier 
		{
			get
			{
				CE ret = null;
				try 
				{
					ret = (CE)getComponent(4);
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
		/// Returns collection modifier method code (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public CE CollectionModifierMethodCode 
		{
			get
			{
				CE ret = null;
				try 
				{
					ret = (CE)getComponent(5);
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