using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    public class EMail : INotification
    {
        public EMail(string emailAdress)
        {
            EmailAdress = emailAdress;
            SuccessTextResult = "EmailSent to :" + EmailAdress;
        }
        private string EmailAdress { get; }

        public string SuccessTextResult { get; }

        public string SendAlarm()
        {
            return SuccessTextResult;
        }
    }
}
