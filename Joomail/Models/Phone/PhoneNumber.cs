using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joomail.Models.Phone
{
    public class PhoneNumber
    {
		public string CountryCode { get; }
		public string AreaCode { get; }
		public string Prefix { get; }
		public string LineNumber { get; }
		internal PhoneNumber(string cc, string ac, string pf, string ln)
		{
			CountryCode = cc ?? "";
			AreaCode = ac;
			Prefix = pf;
			LineNumber = ln;
		}

		public static PhoneNumber Create(string phoneNumber)
		{
			// TODO: regex parse
			//return new PhoneNumber();
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return String.Format(PhoneNumberTemplate.Get(CountryCode),
				CountryCode == "" ? "" : $"+{CountryCode} ",
				AreaCode,
				Prefix,
				LineNumber);
		}
	}
}
