/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "CK.java".  Description: 
/// "The HL7 CK (composite ID with check digit) data type" 
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
	
	/// <summary> <p>The HL7 CK (composite ID with check digit) data type.  Consists of the following components: </p><ol>
	/// <li>ID number (NM)</li>
	/// <li>check digit (NM)</li>
	/// <li>code identifying check digit scheme employed (ID)</li>
	/// </ol>
	/// </summary>
	public class CK:AbstractType, Composite
	{
		/// <summary> Returns an array containing the data elements.</summary>
		virtual public Type[] Components
		{
			get
			{
				return this.data;
			}
			
		}
		/// <summary> Returns ID number (component #0).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM IDNumber
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(0);
				}
				catch (DataTypeException e)
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
			
		}
		/// <summary> Returns check digit (component #1).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public NM CheckDigit
		{
			get
			{
				NM ret = null;
				try
				{
					ret = (NM) getComponent(1);
				}
				catch (DataTypeException e)
				{
					HapiLogFactory.getHapiLog(this.GetType()).error("Unexpected problem accessing known data type component - this is a bug.", e);
					throw new System.Exception("An unexpected error ocurred",e);
				}
				return ret;
			}
			
		}
		/// <summary> Returns code identifying check digit scheme employed (component #2).  This is a convenience method that saves you from 
		/// casting and handling an exception.
		/// </summary>
		virtual public ID CodeIdentifyingCheckDigitSchemeEmployed
		{
			get
			{
				ID ret = null;
				try
				{
					ret = (ID) getComponent(2);
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
		
		/// <summary> Creates a CK.</summary>
		/// <param name="message">the Message to which this Type belongs
		/// </param>
		public CK(Message message):base(message)
		{
			data = new Type[3];
			data[0] = new NM(message);
			data[1] = new NM(message);
			data[2] = new ID(message, 0);
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
				throw new DataTypeException("Element " + number + " doesn't exist in 3 element CK composite");
			}
		}
	}
}
