using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joomail.Services
{
    interface IScheduledPollingService
    {
		void StartPolling();
		void StopPolling();
    }
}
