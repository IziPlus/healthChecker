using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    class Telephone : INotification
    {
        public string TelNumber { get; }

        public Telephone(string telNumber)
        {
            TelNumber = telNumber;
        }

        public string SendAlarm()
        {
            return "Call With :" + TelNumber;
        }
    }
}
