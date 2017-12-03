using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Joomail.Models.Mail
{
    internal static class MailBuilder
    {
		private static MailMessage Message { get; set; }

		public static MailMessage Create(string to, string from, string subject, string body, string displayName = null)
		{
			MailAddress toAddress = new MailAddress(to);
			MailAddress fromAddress = new MailAddress(from, displayName);
			MailMessage mail = new MailMessage()
			{
				Subject = subject,
				Body = body
			};

			return mail;
		}

    }
}
