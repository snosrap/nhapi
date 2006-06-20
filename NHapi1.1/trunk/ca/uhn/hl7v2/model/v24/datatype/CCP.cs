using ca.uhn.hl7v2.model;
using ca.uhn.log;

namespace ca.uhn.hl7v2.model.v24.datatype
{

	///<summary>
	/// <p>The HL7 CCP (channel calibration parameters) data type.  Consists of the following components: </p><ol>
	/// <li>channel calibration sensitivity correction factor (NM)</li>
	/// <li>channel calibration baseline (NM)</li>
	/// <li>channel calibration time skew (NM)</li>
	/// </ol>
	///</summary>
	public class CCP : AbstractType, Composite
	{
		private Type[] data;

		///<summary>
		/// Creates a CCP.
		/// <param name="message">The Message to which this Type belongs</param>
		///</summary>
		public CCP(Message message) : base(message)
		{
			data = new Type[3];
			data[0] = new NM(message);
			data[1] = new NM(message);
			data[2] = new NM(message);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 3 element CCP composite"); 
			} 
		} 
		///<summary>
		/// Returns channel calibration sensitivity correction factor (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NM ChannelCalibrationSensitivityCorrectionFactor 
		{
			get
			{
				NM ret = null;
				try 
				{
					ret = (NM)getComponent(0);
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
		/// Returns channel calibration baseline (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NM ChannelCalibrationBaseline 
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
		/// Returns channel calibration time skew (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		///</summary>
		public NM ChannelCalibrationTimeSkew 
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
	}}