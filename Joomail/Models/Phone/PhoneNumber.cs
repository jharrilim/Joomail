using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
			Match match = Regex.Match(phoneNumber, @"\(?\d{3}\)?-? *(\d{3})-? *-?(\d{4})$");
			if (!match.Success)
				throw new PhoneNumberFormatException($"Phone Number is invalid: {phoneNumber}");

			return new PhoneNumber
				(
					"", 
					match.Groups[0].Value,
					match.Groups[1].Value,
					match.Groups[2].Value
				);
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
