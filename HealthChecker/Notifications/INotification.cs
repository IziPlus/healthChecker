using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    public interface INotification
    {
        string SendAlarm();
    }
}
