using System;

namespace ca.uhn
{
	/// <summary>
	/// Rebuilt tokenizer from java implementation.  Tokenizer would take way too long on large text.
	/// </summary>
	public class Tokenizer
	{
		private string _rawText;
		private int _currentToken=-1;
		private string[] _tokens;
		private string _delimiters=null;
		private bool _includeDelims = false;

		public Tokenizer(string source)
		{
			_rawText= source;
		}

		public Tokenizer(string source, string delimiters)	: this(source)
		{
			_delimiters = delimiters;
		}

		public Tokenizer(string source, string delimiters, bool includeDelims)
			: this(source, delimiters)
		{
			_includeDelims = includeDelims;
		}

		private void SetTokens()
		{
			if(_tokens==null)
			{
				_tokens = _rawText.Split(_delimiters.ToCharArray());		
			}
		}

		public string NextToken()
		{
			SetTokens();
			_currentToken++;
			if(_currentToken>=_tokens.Length)
				throw new ArgumentException("Out of bounds");

			string ret = _tokens[_currentToken];
			if(_includeDelims)
				ret += _delimiters;
			return ret;
		}	

		public bool HasMoreTokens
		{
			get
			{
				SetTokens();
				if(_currentToken>=_tokens.Length-1)
					return false;
				else
					return true;
			}
		}

		public void Reset()
		{ 
			_currentToken=-1;
		}


	}



	/*

	*/
}
