using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    class Telephone : Notification
    {
        private string TelNumber { get; set; }

        public Telephone(string telNumber)
        {
            TelNumber = telNumber;
        }

        public override void SendAlarm()
        {
            Console.WriteLine("Call With :" + TelNumber);
        }
    }
}
