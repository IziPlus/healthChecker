using HealthChecker.Notifications;
using HealthChecker.Servers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthChecker
{
    public class HealthChecker
    {
        public HealthChecker(IServer server, List<INotification> notifications)
        {
            Notifications = notifications;
            Server = server;
        }

        public IServer Server { get; }
        public List<INotification> Notifications { get; }
    }
}
