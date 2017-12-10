using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Joomail.Models.Phone
{
    public class PhoneNumberFormatException : Exception
    {
		public PhoneNumberFormatException() : base() { }

		public PhoneNumberFormatException(string msg) : base(msg) { }

		public PhoneNumberFormatException(string msg, Exception inner) 
			: base(msg, inner) { }

		public PhoneNumberFormatException(SerializationInfo info, StreamingContext context) 
			: base(info, context) { }
    }
}
