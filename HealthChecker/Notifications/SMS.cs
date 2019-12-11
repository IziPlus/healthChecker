using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    public class SMS : INotification
    {
        public SMS(string mobileNumber)
        {
            MobileNumber = mobileNumber;
        }

        public string MobileNumber { get; }

        public string SendAlarm()
        {
            return "Send SMS To :" + MobileNumber;
        }
    }
}
