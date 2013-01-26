using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace task4_DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create web client simulating IE6.
            using (WebClient client = new WebClient())
            {
                client.Headers["User-Agent"] =
                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
                "(compatible; MSIE 6.0; Windows NT 5.1; " +
                ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";

                // Download data.
                try
                {
                    client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "picture.jpg");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The address parameter is null.");
                }
                catch (WebException)
                {
                    Console.WriteLine(@"The URI formed by combining BaseAddress and address is invalid.
                    -or-
                    filename is null or Empty.
                    -or-
                    The file does not exist.
                    -or- An error occurred while downloading data.");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("The method has been called simultaneously on multiple threads.");
                }
            }
        }
    }
}
