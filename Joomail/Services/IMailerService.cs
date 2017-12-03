using Joomail.Models.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joomail.Services
{
    interface IMailerService: IMailer
    {
		void SendNotification();
		Task CheckMail();
    }
}
