using Xunit;
using HealthChecker.Servers;
using HealthChecker.Notifications;
using System.Collections.Generic;

namespace HealthCheckerTest
{
    public class HealthCheckerTest
    {
        [Fact]
        public void HealthCheckForDbServer()
        {
            var connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password = myPassword;";
            var dBQuery = "SELECT COUNT(*) FROM sys.dm_os_performance_counters";

            var server = new DBServer(connectionString, dBQuery);

            var sms = new SMS("09936386808");

            var notifications = new List<INotification> { sms };

            var healthCheckerInstance = new HealthChecker.HealthChecker(server, notifications);

            if (!healthCheckerInstance.Server.HealthCheck())
                healthCheckerInstance.Notifications.ForEach(x =>
                {
                    var result = x.SendAlarm();
                    Assert.Equal(sms.SuccessTextResult , result);
                });
        }

        [Fact]
        public void HealthCheckForFileServer()
        {
            var destinationPath = "C://1.txt";

            var server = new FileServer(destinationPath);

            var eMail = new EMail("Reza.izi@chmail.ir");

            var notifications = new List<INotification> { eMail };

            var healthCheckerInstance = new HealthChecker.HealthChecker(server, notifications);

            if (!healthCheckerInstance.Server.HealthCheck())
                healthCheckerInstance.Notifications.ForEach(x =>
                {
                    var result = x.SendAlarm();
                    Assert.Equal(eMail.SuccessTextResult, result);
                });
        }


        [Fact]
        public void HealthCheckForWebServer()
        {
            var url = "www.google.com";

            var server = new WebServer(url);

            var telephone = new Telephone("02133252194");

            var notifications = new List<INotification> { telephone };

            var healthCheckerInstance = new HealthChecker.HealthChecker(server, notifications);

            if (!healthCheckerInstance.Server.HealthCheck())
                healthCheckerInstance.Notifications.ForEach(x =>
                {
                    var result = x.SendAlarm();
                    Assert.Equal(telephone.SuccessTextResult, result);
                });
        }

    }
}
