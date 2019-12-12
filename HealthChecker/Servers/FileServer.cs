
namespace HealthChecker.Servers
{
    public class FileServer : IServer
    {
        public FileServer(string destinationPath)
        {
            DestinationPath = destinationPath;
        }
        public string DestinationPath { get; }

        public bool HealthCheck()
        {
            return false;
        }
    }
}
