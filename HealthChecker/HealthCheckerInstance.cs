using System;
using System.Collections.Generic;
using HealthChecker.Servers;
using HealthChecker.Notifications;

namespace HealthChecker
{
    class HealthCheckerInstance
    {
        public HealthCheckerInstance(Server server,List<Notification> notifications)
        {
            Notifications = notifications;
            Server = server;
        }

        private Server Server { get; set; }

        private List<Notification> Notifications { get; set; }

        public Server GetServer()
        {
            return Server;
        }
        public List<Notification> GetNotifications()
        {
            return Notifications;
        }

    }
}
