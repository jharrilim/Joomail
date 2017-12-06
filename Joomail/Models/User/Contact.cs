using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Joomail.Models.Phone;
namespace Joomail.Models.User
{
    public class Contact
    {
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string DisplayName { get; set; }
		public PhoneNumber MobileNumber { get; set; }
		public MailAddress EmailAddress { get; set; }

	}
}
