using System;
using Joomail.Models.Phone;
using Xunit;

namespace Joomail.Tests.Models.Phone
{
	[Trait("Category", "Phone")]
    public class PhoneNumberTests
    {
		[Theory]
		[InlineData("(905) 123-7654")]
		[InlineData("416-123-7654")]
		public void CreateNorthAmericanPhoneNumber(string number)
		{
			PhoneNumber num = PhoneNumber.Create(number);
	    }

		[Theory]
		[InlineData("123dj02")]
		[InlineData("(416) 123 7654 11")]
		[InlineData("9090 (416) 123 7654")]
		public void CreatePhoneNumberThrowsException(string number)
		{
			Xunit.Assert.Throws<PhoneNumberFormatException>(() => 
			{
				PhoneNumber num = PhoneNumber.Create(number);
			});
		}
    }
}
