using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //sides of triangle
            double a = 0;
            double b = 0;
            double c = 0;

            Console.WriteLine("Find perimetr and sqare of a triangle");

            Console.WriteLine("Enter first side of the triangle: ");
            Double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter second side of the triangle: ");
            Double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Enter third side of the triangle: ");
            Double.TryParse(Console.ReadLine(), out c);

            try
            {
                Triangle triangle = new Triangle(a, b, c);
                double perimetr = triangle.Perimeter();
                double square = triangle.Square();

                Console.WriteLine($"Perimetr of the triangle is {perimetr}");
                Console.WriteLine($"Square of the triangle is {square}");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
