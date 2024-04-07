using System.Net;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry("microsoft.com");
                foreach (IPAddress ip in host.AddressList)
                {
                    Console.WriteLine(ip);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
