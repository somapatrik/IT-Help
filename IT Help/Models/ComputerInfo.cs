using System.IO;

namespace IT_Help.Models
{
    internal class ComputerInfo
    {
        public string Machinename => Environment.MachineName;
        public string Hostname => System.Net.Dns.GetHostName();
        public string OSVersion => Environment.OSVersion.ToString();
        public IEnumerable<DriveInfo> Drives => DriveInfo.GetDrives();
    }
}
