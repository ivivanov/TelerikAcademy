using System;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point xy = new Point();
            Type type = typeof(Point);

            object[] allAttributes =

              type.GetCustomAttributes(false);

            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("{0}: {1}", attr, attr.Version);
            }
        }
    }
    [VersionAttribute(5.5)]
    public class Point
    {
        int x;
        int y;
    }
}