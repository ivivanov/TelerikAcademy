/* 
* Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. Define two new classes Triangle and Rectangle 
* that implement the virtual method and return the surface of the figure (height*width for rectangle and height*width/2 for triangle).
* Define class Circle and suitable constructor so that on initialization 
* height must be kept equal to width and implement the CalculateSurface() method. Write a program that tests the behavior of  
* the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
*/

using System;
using System.Collections.Generic;

namespace task1_AbstractClassShape
{
    class TestApp
    {
        static void Main(string[] args)
        {
            List<Shape> figures = new List<Shape>();
            figures.Add(new Circle(3));
            figures.Add(new Triangle(4, 6));
            figures.Add(new Rectangle(4, 4));
            foreach (Shape figure in figures)
            {
                Console.WriteLine("Surface of {0} is {1:F2}", figure.GetType().Name, figure.CalculateSurface());
            }
        }
    }
}
