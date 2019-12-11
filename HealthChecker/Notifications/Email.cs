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
        }
        private string EmailAdress { get; set; }

        public string SendAlarm()
        {
            return "EmailSent to :" + EmailAdress;
        }
    }
}
