using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using Joomail.Models.Notification;

namespace Joomail.Services
{
	public abstract class ScheduledMailService : IScheduledPollingService
	{
		private double UpdateTime { get; }
		private Timer Timer { get; }

		public ScheduledMailService(double updateInterval)
		{
			UpdateTime = updateInterval;
			this.Timer = new Timer(updateInterval);
		}

		public abstract Task CheckMail();

		public void StartPolling()
		{
			this.Timer.Elapsed += async (sender, e) => await CheckMail();
			this.Timer.Start();
		}

		public void StopPolling()
		{
			this.Timer.Stop();
		}

	}
}
