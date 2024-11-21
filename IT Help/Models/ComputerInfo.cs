using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Help.Models
{
    internal class ComputerInfo
    {
        public string Machinename => Environment.MachineName;
        public string Hostname => System.Net.Dns.GetHostName();
        public string OSVersion => Environment.OSVersion.ToString();
    }
}
