using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that parses an URL address given in the format:
            //[protocol]://[server]/[resource]
            //and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
            //[protocol] = "http"
            //[server] = "www.devbg.org"
            //[resource] = "/forum/index.php"
            string link = "http://devbg.org/forum/index.php";
            Regex regexProtocol = new Regex(@"(?<protocol>[^.]*)://");
            Regex regexServer = new Regex(@"\b(://(?<server>.*?)/)\b|\b(^(?<server>[.]*?)/)\b|\b^(?<server>(www.)*?([\w\d]*\.)*([a-z]{2,3}))\b");
            Regex regexResource = new Regex(@"\.[a-z]{2,3}(?<resource>/.*)");
            Match protocol = regexProtocol.Match(link);
            Match server = regexServer.Match(link);
            Match resource = regexResource.Match(link);
            string one = protocol.Groups["protocol"].ToString();
            string two = server.Groups["server"].ToString();
            string three = resource.Groups["resource"].ToString();
            Console.WriteLine("[protocol] = \"{0}\"",one);
            Console.WriteLine("[server] = \"{0}\"", two);
            Console.WriteLine("[resource] = \"{0}\"", three);

        }
    }
}
