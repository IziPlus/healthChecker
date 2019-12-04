using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    abstract class Notification
    {
        public abstract void SendAlarm();
    }
}
