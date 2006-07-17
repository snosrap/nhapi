/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "CN.java".  Description: 
/// "The HL7 CN (composite ID number and name) data type" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2002.  All Rights Reserved. 
/// Contributor(s): ______________________________________. 
/// Alternatively, the contents of this file may be used under the terms of the 
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are 
/// applicable instead of those above.  If you wish to allow use of your version of this 
/// file only under the terms of the GPL and not to allow others to use your version 
/// of this file under the MPL, indicate your decision by deleting  the provisions above 
/// and replace  them with the notice and other provisions required by the GPL License.  
/// If you do not delete the provisions above, a recipient may use your version of 
/// this file under either the MPL or the GPL. 
/// </summary>
using System;
using Composite = ca.uhn.hl7v2.model.Composite;
using DataTypeException = ca.uhn.hl7v2.model.DataTypeException;
using Message = ca.uhn.hl7v2.model.Message;
using Type = ca.uhn.hl7v2.model.Type;
using AbstractType = ca.uhn.hl7v2.model.AbstractType;
using HapiLogFactory = ca.uhn.log.HapiLogFactory;
namespace ca.uhn.hl7v2.model.v21.datatype
{
	
	/// <summary> <p>The HL7 CN (composite ID number and name) data type.  Consists of the following components: </p><ol>
	/// <li>ID (ST)</li>
	/// <li>family name (ST)</li>
	/// <li>given name (ST)</li>
	/// <li>middle initial or name (ST)</li>
	/// <li>degree (ST)</li>
	/// </ol>
	/// </summary>
	public class CN:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns ID (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST ID
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(0);
				}
				catch (DataTypeException e)
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
			
		}
		/// <summary> Returns family name (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST FamilyName
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(1);
				}
				catch (DataTypeException e)
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
			
		}
		/// <summary> Returns given name (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST GivenName
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(2);
				}
				catch (DataTypeException e)
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
			
		}
		/// <summary> Returns middle initial or name (component #3).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST MiddleInitialOrName
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(3);
				}
				catch (DataTypeException e)
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
			
		}
		/// <summary> Returns degree (component #4).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ST Degree
		{
			get
			{
				ST ret = null;
				try
				{
					ret = (ST) getComponent(4);
				}
				catch (DataTypeException e)
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
			
		}
		
		private Type[] data;
		
		/// <summary> Creates a CN.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CN(Message message):base(message)
		{
			data = new Type[5];
			data[0] = new ST(message);
			data[1] = new ST(message);
			data[2] = new ST(message);
			data[3] = new ST(message);
			data[4] = new ST(message);
		}
		
		/// <summary> Returns an individual data component.</summary>
		/// <throws>  DataTypeException if the given element number is out of range. </throws>
		public virtual Type getComponent(int number)
		{
			
			try
			{
				return this.data[number];
			}
			catch (System.IndexOutOfRangeException)
			{
				throw new DataTypeException("Element " + number + " doesn't exist in 5 element CN composite");
			}
		}
	}
}
