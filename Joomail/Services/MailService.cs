using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Joomail.Services
{
	public class MailService : ScheduledMailService
	{
		public MailService(double updateInterval = 60000) : base(updateInterval) { }

		public override Task CheckMail()
		{
			return Task.Run(() => 
			{
				
			});
		}
	}
}
