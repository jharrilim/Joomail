using System;
using System.Net.Mail;
using Xunit;
using Joomail.Models.Mail;

namespace Joomail.Tests.Models
{
    public class MailBuilderTests
    {
		[Theory]
		[InlineData("a@gmail.com", "b@gmail.com", "RE: Hello World", "hey", null)]
		[InlineData("a@gmail.com", "b@gmail.com", "RE: Hello World", "hey", "FooBar1")]
		public void DisplayNameDoesNotThrowException(string to, string from, string subject, string body, string displayName)
		{
			MailBuilder.Create(to, from, subject, body, displayName);
		}
    }
}
