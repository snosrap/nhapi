using System;
using System.Collections;
using System.Text;

namespace ca.uhn.hl7v2
{
    
	public class SQLException : Exception
	{
      
		public SQLException() { }
		public SQLException(string message) : base(message) { }
		public SQLException(string message, Exception inner) : base(message, inner) { }
		protected SQLException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
