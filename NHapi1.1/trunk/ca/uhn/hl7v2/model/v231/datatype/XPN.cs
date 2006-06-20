using System;using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v231.datatype
{

	///<summary>
	/// <p>The HL7 XPN (extended person name) data type.  Consists of the following components: </p><ol>
	/// <li>family+last name (FN)</li>
	/// <li>given name (ST)</li>
	/// <li>middle initial or name (ST)</li>
	/// <li>suffix (e.g., JR or III) (ST)</li>
	/// <li>prefix (e.g., DR) (ST)</li>
	/// <li>degree (e.g., MD) (IS)</li>
	/// <li>name type code (ID)</li>
	/// <li>Name Representation code (ID)</li>
	/// </ol>
	///</summary>
	[Serializable]
	public class XPN : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a XPN.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public XPN(Message message) : base(message)
		{
			data = new Type[8];
			data[0] = new FN(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
			data[5] = new IS(message, 0);
			data[6] = new ID(message, 0);
			data[7] = new ID(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 8 element XPN composite"); 
			} 
		} 
		///<summary>
		/// Returns family+last name (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public FN FamilyLastName 
		{
			get
			{
				FN ret = null;
				try 
				{
					ret = (FN)getComponent(0);
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
		/// Returns given name (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST GivenName 
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
		/// Returns middle initial or name (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST MiddleInitialOrName 
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
		/// Returns suffix (e.g., JR or III) (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST SuffixEgJRorIII 
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
		/// Returns prefix (e.g., DR) (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ST PrefixEgDR 
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
		/// Returns degree (e.g., MD) (component #5).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public IS DegreeEgMD 
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
		/// Returns name type code (component #6).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID NameTypeCode 
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
		/// Returns Name Representation code (component #7).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public ID NameRepresentationCode 
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
	}}