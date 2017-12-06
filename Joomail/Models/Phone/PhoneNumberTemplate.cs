using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joomail.Models.Phone
{
    public static class PhoneNumberTemplate
    {
		public static readonly string NorthAmericanNumberingPlan = "{0}({1}) {2}-{3}";

		public static string Get(string countryCode)
		{
			switch (countryCode)
			{
				case "1":
					return NorthAmericanNumberingPlan;
				default:
					return NorthAmericanNumberingPlan;
			}
		}
    }
}
