/// <summary> The contents of this file are subject to the Mozilla Public License Version 1.1
/// (the "License"); you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/
/// Software distributed under the License is distributed on an "AS IS" basis,
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
/// specific language governing rights and limitations under the License.
/// 
/// The Original Code is "HtmlTableParser.java".  Description:
/// "An implementation of Parser that supports traditionally encoded (i.e"
/// The Initial Developer of the Original Code is University Health Network. Copyright (C)
/// 2001.  All Rights Reserved.
/// 
/// Alternatively, the contents of this file may be used under the terms of the
/// GNU General Public License (the  “GPL”), in which case the provisions of the GPL are
/// applicable instead of those above.  If you wish to allow use of your version of this
/// file only under the terms of the GPL and not to allow others to use your version
/// of this file under the MPL, indicate your decision by deleting  the provisions above
/// and replace  them with the notice and other provisions required by the GPL License.
/// If you do not delete the provisions above, a recipient may use your version of
/// this file under either the MPL or the GPL.
/// 
/// </summary>
using System;
using HL7Exception = ca.uhn.hl7v2.HL7Exception;
using Group = ca.uhn.hl7v2.model.Group;
using Message = ca.uhn.hl7v2.model.Message;
using Primitive = ca.uhn.hl7v2.model.Primitive;
using Segment = ca.uhn.hl7v2.model.Segment;
using Structure = ca.uhn.hl7v2.model.Structure;
using Type = ca.uhn.hl7v2.model.Type;
using Varies = ca.uhn.hl7v2.model.Varies;
using Terser = ca.uhn.hl7v2.util.Terser;
using MessageIterator = ca.uhn.hl7v2.util.MessageIterator;
using FilterIterator = ca.uhn.hl7v2.util.FilterIterator;
using HapiLog = ca.uhn.log.HapiLog;
using HapiLogFactory = ca.uhn.log.HapiLogFactory;
using System.Web.UI.WebControls;
using System.Web.UI;
using ca.uhn.hl7v2.parser;

namespace ca.uhn
{
	
	public class HtmlTableMessageViewer
	{
		private static readonly HapiLog log= HapiLogFactory.getHapiLog(typeof(HtmlTableMessageViewer));
		private string _cssSegmentHeader;
		private string _cssSegmentField;
		private string _cssComponentField;
		private int _componentCellSpacing=0;
		private int _componentCellPadding=5;
		private int _componentBorder=1;

		#region Constructors
		/// <summary>Creates a new PipeParser </summary>
		public HtmlTableMessageViewer()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cssClassSegmentHeader">CSS Class name to use for the segment header (e.g. MSH, ACK, etc)</param>
		public HtmlTableMessageViewer(string cssSegmentHeader,string cssSegmentField,string cssComponentField)
		{
			_cssSegmentHeader = cssSegmentHeader;
			_cssSegmentField = cssSegmentField;
			_cssComponentField = cssComponentField;
		}		

		public HtmlTableMessageViewer(string cssSegmentHeader,string cssSegmentField,string cssComponentField, int componentCellSpacing, int componentCellPadding, int componentBorder)
		{
			_cssSegmentHeader = cssSegmentHeader;
			_cssSegmentField = cssSegmentField;
			_cssComponentField = cssComponentField;
			_componentBorder = componentBorder;
			_componentCellPadding = componentCellPadding;
			_componentCellSpacing = componentCellSpacing;
		}	

		#endregion

		
		/// <summary> Removes unecessary delimiters from the end of a field or segment.
		/// This seems to be more convenient than checking to see if they are needed
		/// while we are building the encoded string.
		/// </summary>
		private System.String stripExtraDelimiters(System.String in_Renamed, char delim)
		{
			char[] chars = in_Renamed.ToCharArray();
			
			//search from back end for first occurance of non-delimiter ...
			int c = chars.Length - 1;
			bool found = false;
			while (c >= 0 && !found)
			{
				if (chars[c--] != delim)
					found = true;
			}
			
			System.String ret = "";
			if (found)
				ret = new System.String(chars, 0, c + 2);
			return ret;
		}
		
		
		/// <summary> Formats a Message object into an html table object using the given
		/// </summary>
		/// <throws>  HL7Exception if the data fields in the message do not permit encoding </throws>
		/// <summary>      (e.g. required fields are null)
		/// </summary>
		/// <throws>  EncodingNotSupportedException if the requested encoding is not </throws>
		/// <summary>      supported by this parser.
		/// </summary>
		public Table buildTable(Message source)
		{
			//get encoding characters ...
			Segment msh = (Segment) source.get_Renamed("MSH");
			System.String fieldSepString = Terser.Get(msh, 1, 0, 1, 1);
			
			if (fieldSepString == null)
				throw new HL7Exception("Can't encode message: MSH-1 (field separator) is missing");
			
			char fieldSep = '|';
			if (fieldSepString != null && fieldSepString.Length > 0)
				fieldSep = fieldSepString[0];
			
			System.String encCharString = Terser.Get(msh, 2, 0, 1, 1);
			
			EncodingCharacters en = new EncodingCharacters(fieldSep, encCharString);
			
			//pass down to group encoding method which will operate recursively on children ...
			Table tbl = new Table();
			encode((Group) source, en, tbl);
			return tbl;
		}

		/// <summary> Encodes the given Type, using the given encoding characters. 
		/// It is assumed that the Type represents a complete field rather than a component.
		/// </summary>
		protected virtual Control encode(Type source, EncodingCharacters encodingChars)
		{
			if(source is ca.uhn.hl7v2.model.Composite)
			{
				TableCell td;
				TableRow tr;
				Table tbl = new Table();
				tbl.Attributes["border"]=_componentBorder.ToString();
				tbl.CellSpacing = _componentCellSpacing;
				tbl.CellPadding = _componentCellPadding;
				for (int i = 1; i <= Terser.numComponents(source); i++)
				{
					
					
					for (int j = 1; j <= Terser.numSubComponents(source, i); j++)
					{
						tr = new TableRow();
						Primitive p = Terser.getPrimitive(source, i, j);
						Type type = (Type)p;
						td = new TableCell();
						if(_cssComponentField!=null)
							td.CssClass = _cssComponentField;
						string desc = "&nbsp;";
						if(type.Description!=null && type.Description.Trim().Length>0)
							desc = type.Description;
						if(j>1)
							desc = "&nbsp;&nbsp;&nbsp;-" + desc;
						
						td.Text = desc;
						tr.Cells.Add(td);
						string val = "&nbsp;";
						if(p.Value!=null && p.Value.Trim().Length>0)
						{
							val = p.Value;
						}
						td = new TableCell();
						td.Text = val;
						tr.Cells.Add(td);
						tbl.Rows.Add(tr);	
					}
					
				}
				return tbl;
			}
			else
			{
				Primitive p = Terser.getPrimitive(source,1,1);
				string val = "&nbsp;";
				
				if(p.Value!=null && p.Value.Trim().Length>0)
					val = p.Value;
				return new LiteralControl(val);
			}
		}
		
		/// <summary> Returns given group serialized as a pipe-encoded string - this method is called
		/// by encode(Message source, String encoding).
		/// </summary>
		protected virtual void encode(Group source, EncodingCharacters encodingChars, Table tbl)
		{
			
			System.String[] names = source.Names;
			for (int i = 0; i < names.Length; i++)
			{
				Structure[] reps = source.getAll(names[i]);
				for (int rep = 0; rep < reps.Length; rep++)
				{
					if (reps[rep] is Group)
					{
						Group g = (Group)reps[rep];
						encode(g, encodingChars, tbl);

					}
					else
					{
						Segment segment = (Segment)reps[rep];
						encode(segment, encodingChars, tbl);
					}
				}
			}
			
		}

	

		/// <returns> true if the segment is MSH, FHS, or BHS.  These need special treatment 
		/// because they define delimiters.
		/// </returns>
		/// <param name="theSegmentName">
		/// </param>
		protected virtual bool isDelimDefSegment(System.String theSegmentName)
		{
			bool is_Renamed = false;
			if (theSegmentName.Equals("MSH") || theSegmentName.Equals("FHS") || theSegmentName.Equals("BHS"))
			{
				is_Renamed = true;
			}
			return is_Renamed;
		}
		
		protected virtual void encode(Segment source, EncodingCharacters encodingChars, Table tbl)
		{
			TableRow tr;
			TableCell td;
			tr = new TableRow();
			td = new TableCell();
			td.ColumnSpan = 3;
			if(_cssSegmentHeader!=null && _cssSegmentHeader.Trim().Length>0)
			{
				tr.CssClass=_cssSegmentHeader;
			}
			td.Text = source.getStructureName();
			tr.Cells.Add(td);
			tbl.Rows.Add(tr);
			
			
			//start at field 2 for MSH segment because field 1 is the field delimiter
			int startAt = 1;
			if (isDelimDefSegment(source.getStructureName()))
				startAt = 2;
			
			//loop through fields; for every field delimit any repetitions and add field delimiter after ...
			int numFields = source.numFields();
			for (int i = startAt; i <= numFields; i++)
			{
				try
				{
					tr = new TableRow();
					
					td = new TableCell();
					td.Text = i.ToString();
					tr.Cells.Add(td);
					
					Type[] reps = source.getField(i);
					string description = source.getFieldDescription(i);
					td = new TableCell();
					if(_cssSegmentField!=null)
						td.CssClass = _cssSegmentField;
					if(description!=null && description.Trim().Length>0)
						td.Text = description;
					else
						td.Text ="&nbsp;";
					
					tr.Cells.Add(td);
					
					td = new TableCell();
					if(reps.Length==0)
						td.Text = "&nbsp;";
					else
					{
						for (int j = 0; j < reps.Length; j++)
						{
							td.Controls.Add(encode(reps[j], encodingChars));
							if(j<reps.Length-1)
								td.Controls.Add(new LiteralControl("<hr size='2'>"));
						}
					}
					tr.Cells.Add(td);
					tbl.Rows.Add(tr);
				}
				catch (HL7Exception e)
				{
					log.error("Error while encoding segment: ", e);
				}
			}
		}
		
	
		
		
	}
}