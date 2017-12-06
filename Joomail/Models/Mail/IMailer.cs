using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Joomail.Models.Mail
{
    public interface IMailer
    {
		void SendMail(MailMessage mailMessage);
    }
}
