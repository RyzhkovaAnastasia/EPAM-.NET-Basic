using System;

namespace Homework4_1
{
    class Program
    {
        static Vector3D EnterCoordinates(string numOfVector)
        {
            double x;
            double y;
            double z;

            Console.WriteLine($"Enter coordinates of the {numOfVector} vector: ");
            Console.Write("Enter x: ");
            Double.TryParse(Console.ReadLine(), out x);
            Console.Write("Enter y: ");
            Double.TryParse(Console.ReadLine(), out y);
            Console.Write("Enter z: ");
            Double.TryParse(Console.ReadLine(), out z);

            Vector3D vector = new Vector3D(x, y, z);
            return vector;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("3D Vector Calculator");
            Vector3D vector1 = EnterCoordinates("first");
            Vector3D vector2 = EnterCoordinates("second");

            Console.WriteLine($"Addition of two vectors: {(vector1 + vector2).ToString()}");
            Console.WriteLine($"Substraction of two vectors: {(vector1 + vector2).ToString()}");
            Console.WriteLine($"Multiplication of two vectors: {(vector1 % vector2).ToString()}");
            Console.WriteLine($"Scalar multiplication of two vectors: {(vector1 * vector2).ToString()}");
            Console.WriteLine();

            Console.WriteLine("Сompute operations on vector and term");
            double term;
            Vector3D vector = EnterCoordinates("");
            Console.Write("Enter term: ");
            Double.TryParse(Console.ReadLine(), out term);
            Console.WriteLine($"Addition of vector and term: {(vector + term).ToString()}");
            Console.WriteLine($"Substraction of vector and term: {(vector - term).ToString()}");
            Console.WriteLine($"Multiplication of vector and term: {(vector * term).ToString()}");
            Console.WriteLine($"Division of vector and term: {(vector / term).ToString()}");

            Console.ReadKey();
        }
    }
}
