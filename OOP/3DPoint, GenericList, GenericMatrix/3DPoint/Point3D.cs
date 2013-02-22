using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _3DPoint
{
    public class Point3D
    {
        //Write a static class with a static method to calculate the distance between two points in the 3D space.
        static class Distance
        {
            public static double Calculate(Point3D.Point a, Point3D.Point b)
            {
                int deltaX = b.X - a.X;
                int deltaY = b.Y - a.Y;
                int deltaZ = b.Z - a.Z;

                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
            }
        }

        //Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point.
        public struct Point
        {
            public int X
            {
                get;
                set;
            }
            public int Y
            {
                get;
                set;
            }
            public int Z
            {
                get;
                set;
            }

            //Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.
            private static readonly Point o;
            public static Point O
            {
                get
                {
                    return o;
                }
            }

            public override string ToString()
            {
                return "{" + X + " " + Y + " " + Z + "}";
            }
            
        }

        //Create a class Path to hold a sequence of points in the 3D space. 
        public class Path
        {
            private List<Point> sequence;
            public Path()
            {
                sequence = new List<Point>();
            }
            public List<Point> Sequence
            {
                get
                {
                    return this.sequence;
                }
                set
                {
                    this.sequence = value;
                }
            }

            public void Add(Point point)
            {
                this.sequence.Add(point);
            }

            public Point this[int i]
            {
                get
                {
                    if (i == null || i >= sequence.Count || i < 0)
                    {
                        throw new ArgumentException("Invalid index!");
                    }
                    return sequence[i];
                }
                set
                {
                    if (i == null || i >= sequence.Count || i < 0)
                    {
                        throw new ArgumentException("Invalid index!");
                    }
                    sequence[i] = value;
                }
            }
            public int Count
            {
                get
                {
                    return this.sequence.Count;
                }
            }
        }

        //Create a static class PathStorage with static methods to save and load paths from a text file. Use a file format of your choice.
        static class PathStorage
        {
            public static Path LoadPaths(string pathFromFile)
            {
                Path pointsPath = new Path();
                
                try
                {
                    Encoding win1251 = Encoding.GetEncoding("Windows-1251");
                    StreamReader reader = new StreamReader(pathFromFile, win1251);
                    
                    using (reader)
                    {
                        string line = reader.ReadLine();
                        
                        while (line != null)
                        {
                            pointsPath.Add(ParseLineToPoint(line));
                           
                            line = reader.ReadLine();
                        }
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
                Console.WriteLine("Reading from file successfully finished!");
                return pointsPath;
            }

            public static void SavePaths(Path pathToFile)
            {
                try
                {
                    Encoding win1251 = Encoding.GetEncoding("Windows-1251");
                    StreamWriter writer = new StreamWriter(@"../../savedPaths.txt", false, win1251);
                    List<Point> path = pathToFile.Sequence;
                    using (writer)
                    {
                        for (int i = 0; i < path.Count; i++)
                        {
                            string point = path[i].ToString();
                            writer.WriteLine(point.Trim(new char[] { '{', '}' }));
                        }
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine(exeption.Message);
                }
                Console.WriteLine("Savind to file savedPaths.txt successfully finished!");
            }

            private static Point ParseLineToPoint(string line)
            {
                string[] splited = line.Split();
                Point point = new Point();
                point.X = int.Parse(splited[0]);
                point.Y = int.Parse(splited[1]);
                point.Z = int.Parse(splited[2]);
                return point;
            }
        }

        static void Main(string[] args)
        {
            Path sequenceOfPoints = new Path();
            ///////////////Read from file sequence of points/////////////
            sequenceOfPoints = PathStorage.LoadPaths(@"../../paths.txt");

            ///////////////Save the read sequence of points to a new file/////////////
            PathStorage.SavePaths(sequenceOfPoints);

            /////////////Testing distance function//////////////////////
            Console.WriteLine(new string('-',80));
            Console.WriteLine("Testing distance function");
            Point point1 = new Point();
            point1.X = 1;
            point1.Y = 2;
            point1.Z = 0;
            Console.WriteLine("Point 1: {0}",point1);
            Console.WriteLine("Point 2: {0}",Point.O);
            Console.WriteLine("Distance between point: {0} and point: {1} = {2:F2}", point1, Point.O, Distance.Calculate(point1, Point.O));

        }
    }
}
