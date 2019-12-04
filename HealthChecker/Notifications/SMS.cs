using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    class SMS : Notification
    {
        public SMS(string mobileNumber)
        {
            MobileNumber = mobileNumber;
        }
        public string MobileNumber { get; set; }

        public override void SendAlarm()
        {
            Console.WriteLine("Send SMS To :" + MobileNumber);
        }
    }
}
