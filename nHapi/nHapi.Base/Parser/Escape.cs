/// <summary>The contents of this file are subject to the Mozilla Public License Version 1.1 
/// (the "License"); you may not use this file except in compliance with the License. 
/// You may obtain a copy of the License at http://www.mozilla.org/MPL/ 
/// Software distributed under the License is distributed on an "AS IS" basis, 
/// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the 
/// specific language governing rights and limitations under the License. 
/// The Original Code is "Escape.java".  Description: 
/// "Handles "escaping" and "unescaping" of text according to the HL7 escape sequence rules
/// defined in section 2.10 of the standard (version 2.4)" 
/// The Initial Developer of the Original Code is University Health Network. Copyright (C) 
/// 2001.  All Rights Reserved. 
/// Contributor(s): Mark Lee (Skeva Technologies); Elmar Hinz 
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
namespace NHapi.Base.parser
{
	
	/// <summary> Handles "escaping" and "unescaping" of text according to the HL7 escape sequence rules
	/// defined in section 2.10 of the standard (version 2.4).  Currently, escape sequences for 
	/// multiple character sets are unsupported.  The highlighting, hexademical, and locally 
	/// defined escape sequences are also unsupported.  
	/// </summary>
	/// <author>  Bryan Tripp
	/// </author>
	public class Escape
	{
		
		//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
		private static System.Collections.Hashtable variousEncChars = new System.Collections.Hashtable(5);
		
		/// <summary>Creates a new instance of Escape </summary>
		public Escape()
		{
		}
		
		public static System.String escape(System.String text, EncodingCharacters encChars)
		{
			System.Text.StringBuilder result = new System.Text.StringBuilder();
			int textLength = text.Length;
			//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
			System.Collections.Hashtable esc = getEscapeSequences(encChars);
			//UPGRADE_TODO: Method 'java.util.HashMap.keySet' was converted to 'SupportClass.HashSetSupport' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMapkeySet'"
			SupportClass.SetSupport keys = new SupportClass.HashSetSupport(esc.Keys);
			System.String escChar = System.Convert.ToString(encChars.EscapeCharacter);
			int position = 0;
			while (position < textLength)
			{
				System.Collections.IEnumerator it = keys.GetEnumerator();
				bool isReplaced = false;
				//UPGRADE_TODO: Method 'java.util.Iterator.hasNext' was converted to 'System.Collections.IEnumerator.MoveNext' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratorhasNext'"
				while (it.MoveNext() && !isReplaced)
				{
					//UPGRADE_TODO: Method 'java.util.Iterator.next' was converted to 'System.Collections.IEnumerator.Current' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratornext'"
					System.String seq = (System.String) it.Current;
					//UPGRADE_TODO: Method 'java.util.HashMap.get' was converted to 'System.Collections.Hashtable.Item' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMapget_javalangObject'"
					System.String val = (System.String) esc[seq];
					if (text.Substring(position, (position + 1) - (position)).Equals(val))
					{
						result.Append(seq);
						isReplaced = true;
					}
				}
				if (!isReplaced)
				{
					result.Append(text.Substring(position, ((position + 1)) - (position)));
				}
				position++;
			}
			return result.ToString();
		}
		
		public static System.String unescape(System.String text, EncodingCharacters encChars)
		{
			System.Text.StringBuilder result = new System.Text.StringBuilder();
			int textLength = text.Length;
			//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
			System.Collections.Hashtable esc = getEscapeSequences(encChars);
			//UPGRADE_TODO: Method 'java.util.HashMap.keySet' was converted to 'SupportClass.HashSetSupport' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMapkeySet'"
			SupportClass.SetSupport keys = new SupportClass.HashSetSupport(esc.Keys);
			System.String escChar = System.Convert.ToString(encChars.EscapeCharacter);
			int position = 0;
			while (position < textLength)
			{
				System.Collections.IEnumerator it = keys.GetEnumerator();
				bool isReplaced = false;
				//UPGRADE_TODO: Method 'java.util.Iterator.hasNext' was converted to 'System.Collections.IEnumerator.MoveNext' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratorhasNext'"
				while (it.MoveNext() && !isReplaced)
				{
					//UPGRADE_TODO: Method 'java.util.Iterator.next' was converted to 'System.Collections.IEnumerator.Current' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilIteratornext'"
					System.String seq = (System.String) it.Current;
					//UPGRADE_TODO: Method 'java.util.HashMap.get' was converted to 'System.Collections.Hashtable.Item' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMapget_javalangObject'"
					System.String val = (System.String) esc[seq];
					int seqLength = seq.Length;
					if (position + seqLength <= textLength)
					{
						if (text.Substring(position, (position + seqLength) - (position)).Equals(seq))
						{
							result.Append(val);
							isReplaced = true;
							position = position + seq.Length;
						}
					}
				}
				if (!isReplaced)
				{
					result.Append(text.Substring(position, ((position + 1)) - (position)));
					position++;
				}
			}
			return result.ToString();
		}
		
		/// <summary> Applies escape sequences so that the given text can be safely transmitted 
		/// in a delimited message.  A double escape character (e.g. \\) in the given 
		/// text is not itself escaped (e.g. \E\\E\) but is instead translated into a 
		/// single escape character for transmission (e.g. \).  This allows you to 
		/// add escape sequences not handled by this method (e.g. to send \.br\ across
		/// the wire you would set the text of a field to \\.br\\). 
		/// </summary>
		
		/*
		public static String escape_old(String text, EncodingCharacters encChars) {
		String result = text;
		HashMap esc = getEscapeSequences(encChars);
		Set keys = esc.keySet();
		Iterator it = keys.iterator();
		
		//need to do the escape for the escape character first, and skip it in the loop
		result = escapeEscapeCharacters(result, encChars);
		String escChar = String.valueOf(encChars.getEscapeCharacter());
		while (it.hasNext()) {
		String seq = (String)it.next();
		String val = (String)esc.get(seq);
		if (!val.equals(escChar)) result = replace(result, val, seq); //don't escape the escape character here
		}
		return result;
		}
		*/
		
		/// <summary> Removes escape sequences, replacing them with the text they represent.  </summary>
		/*
		public static String unescape_old(String text, EncodingCharacters encChars) {
		String result = text;
		HashMap esc = getEscapeSequences(encChars);
		Set keys = esc.keySet();
		Iterator it = keys.iterator();
		while (it.hasNext()) {
		String seq = (String)it.next();
		String val = (String)esc.get(seq);
		result = replace(result, seq, val);
		}
		return result;
		}
		*/
		
		/// <summary> Replaces single escape characters with the escape sequence, and double escape characters 
		/// with single escape characters. 
		/// </summary>
		/*
		private static String escapeEscapeCharacters(String text, EncodingCharacters encChars) {
		String result = text;
		StringBuffer escCharSeq = new StringBuffer();
		escCharSeq.append(encChars.getEscapeCharacter());
		escCharSeq.append('E');
		escCharSeq.append(encChars.getEscapeCharacter());
		String escChar = String.valueOf(encChars.getEscapeCharacter());
		result = replace(result, escChar, escCharSeq.toString());
		result = replace(result, escCharSeq.toString() + escCharSeq.toString(), escChar);
		return result;        
		}
		*/
		
		/// <summary> Replaces all occurences of the string "replace" with the string "with", in 
		/// the string "originalText". 
		/// </summary>
		/*
		private static String replace(String originalText, String replace, String with) {
		StringBuffer result = new StringBuffer();
		int replaceLength = replace.length();
		boolean done = false;
		int cursor = 0; 
		while (!done) {
		int nextPosition = originalText.indexOf(replace, cursor);
		if (nextPosition < 0) {
		done = true;
		result.append(originalText.substring(cursor));
		break;
		}
		result.append(originalText.substring(cursor, nextPosition));
		result.append(with);
		cursor = nextPosition + replaceLength;
		}
		return result.toString();
		}
		*/
		
		/// <summary> Returns a HashTable with escape sequences as keys, and corresponding 
		/// Strings as values.  
		/// </summary>
		//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
		private static System.Collections.Hashtable getEscapeSequences(EncodingCharacters encChars)
		{
			//escape sequence strings must be assembled using the given escape character 
			
			//see if this has already been done for this set of encoding characters
			//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
			System.Collections.Hashtable escapeSequences = null;
			//UPGRADE_TODO: Method 'java.util.HashMap.get' was converted to 'System.Collections.Hashtable.Item' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMapget_javalangObject'"
			System.Object o = variousEncChars[encChars];
			if (o == null)
			{
				//this means we haven't got the sequences for these encoding characters yet - let's make them
				escapeSequences = makeEscapeSequences(encChars);
				variousEncChars[encChars] = escapeSequences;
			}
			else
			{
				//we already have escape sequences for these encoding characters
				//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
				escapeSequences = (System.Collections.Hashtable) o;
			}
			return escapeSequences;
		}
		
		/// <summary> Constructs escape sequences using the given escape character - this should only 
		/// be called by getEscapeCharacter(), which will cache the results for subsequent use.
		/// </summary>
		//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
		private static System.Collections.Hashtable makeEscapeSequences(EncodingCharacters ec)
		{
			//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
			System.Collections.Hashtable seqs = new System.Collections.Hashtable();
			char[] codes = new char[]{'F', 'S', 'T', 'R', 'E'};
			char[] values = new char[]{ec.FieldSeparator, ec.ComponentSeparator, ec.SubcomponentSeparator, ec.RepetitionSeparator, ec.EscapeCharacter};
			for (int i = 0; i < codes.Length; i++)
			{
				System.Text.StringBuilder seq = new System.Text.StringBuilder();
				seq.Append(ec.EscapeCharacter);
				seq.Append(codes[i]);
				seq.Append(ec.EscapeCharacter);
				seqs[seq.ToString()] = System.Convert.ToString(values[i]);
			}
			seqs["\\X000d\\"] = System.Convert.ToString('\r');
			return seqs;
		}
		
		/// <summary> Test harness</summary>
		[STAThread]
		public static void  Main(System.String[] args)
		{
			System.String testString = "foo$r$this is $ $p$test$r$r$ string";
			//System.out.println(testString);
			//System.out.println(replace(testString, "$r$", "***"));
			//System.out.println(replace(testString, "$", "+"));
			
			//test speed gain with cache
			int n = 100000;
			//UPGRADE_TODO: Class 'java.util.HashMap' was converted to 'System.Collections.Hashtable' which has a different behavior. "ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?index='!DefaultContextWindowIndex'&keyword='jlca1073_javautilHashMap'"
			System.Collections.Hashtable seqs;
			EncodingCharacters ec = new EncodingCharacters('|', "^~\\&");
			//warm up the JIT 
			for (int i = 0; i < n; i++)
			{
				seqs = makeEscapeSequences(ec);
			}
			for (int i = 0; i < n; i++)
			{
				seqs = getEscapeSequences(ec);
			}
			//time
			long start = (System.DateTime.Now.Ticks - 621355968000000000) / 10000;
			for (int i = 0; i < n; i++)
			{
				seqs = makeEscapeSequences(ec);
			}
			System.Console.Out.WriteLine("Time to make " + n + " times: " + ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 - start));
			start = (System.DateTime.Now.Ticks - 621355968000000000) / 10000;
			for (int i = 0; i < n; i++)
			{
				seqs = getEscapeSequences(ec);
			}
			System.Console.Out.WriteLine("Time to get " + n + " times: " + ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 - start));
			start = (System.DateTime.Now.Ticks - 621355968000000000) / 10000;
			for (int i = 0; i < n; i++)
			{
				seqs = makeEscapeSequences(ec);
			}
			System.Console.Out.WriteLine("Time to make " + n + " times: " + ((System.DateTime.Now.Ticks - 621355968000000000) / 10000 - start));
			
			//test escape: 
			testString = "this | is ^ a field \\T\\ with & some ~ bad stuff \\T\\";
			System.Console.Out.WriteLine("Original:  " + testString);
			System.String escaped = escape(testString, ec);
			System.Console.Out.WriteLine("Escaped:   " + escaped);
			System.Console.Out.WriteLine("Unescaped: " + unescape(escaped, ec));
		}
	}
}