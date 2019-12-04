using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker.Notifications
{
    class EMail : Notification
    {
        public EMail(string emailAdress)
        {
            EmailAdress = emailAdress;
        }
        private string EmailAdress { get; set; }
        public override void SendAlarm()
        {
            Console.WriteLine("EmailSent to :" + EmailAdress);
        }
    }
}
