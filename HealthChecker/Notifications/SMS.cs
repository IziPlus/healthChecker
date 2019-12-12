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
            SuccessTextResult = "Send SMS To :" + mobileNumber;
        }

        public string MobileNumber { get; }
        public string SuccessTextResult { get; }

        public string SendAlarm()
        {
            return SuccessTextResult;
        }
    }
}
