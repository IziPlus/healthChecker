using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    public class Telephone : INotification
    {
        public string TelNumber { get; }
        public string SuccessTextResult { get; }

        public Telephone(string telNumber)
        {
            TelNumber = telNumber;
            SuccessTextResult = "Call With :" + telNumber;
        }

        public string SendAlarm()
        {
            return SuccessTextResult;
        }
    }
}
