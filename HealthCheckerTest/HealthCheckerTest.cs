using System;
using Xunit;
using HealthChecker;
using HealthChecker.Servers;
using HealthChecker.Notifications;
using System.Collections.Generic;

namespace HealthCheckerTest
{
    public class HealthCheckerTest
    {
        
        [Fact]
        public void Test1()
        {
            var connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;";
            var dBQuery = "SELECT COUNT(*) FROM sys.dm_os_performance_counters";

            var server = new DBServer(connectionString, dBQuery);

            var sms = new SMS("09936386808");

            var email = new EMail("reza.izi@chmail.ir");

            var notifications = new List<INotification> { sms, email };

            var healthCheckerIntanse = new HealthChecker.HealthChecker((IServer)server, notifications);

            if (!healthCheckerIntanse.Server.HealthCheck())
                healthCheckerIntanse.Notifications.ForEach(x =>
                {
                    var result = x.SendAlarm();
                    Assert.NotEqual("",result);
                });
        }
    }
}
