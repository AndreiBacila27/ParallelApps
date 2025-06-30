using StudentManager_Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NetTcpBinding binding = new NetTcpBinding();
            Uri baseAddress = new Uri("net.tcp://localhost:8000/wcfserver");
            using (ServiceHost serviceHost = new ServiceHost(typeof(WCFServer), baseAddress))
            {
                serviceHost.AddServiceEndpoint(typeof(IWCFServer), binding, baseAddress);
                serviceHost.Open();
                Console.WriteLine($"The WCF server is ready at {baseAddress}.");
                Console.WriteLine("Press <ENTER> to terminate service...");
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
