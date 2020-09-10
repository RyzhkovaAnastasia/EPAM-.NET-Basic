using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm algo = new Algorithm();

            int num1;
            int num2;
            int res;
            string time = String.Empty;

            Console.WriteLine($"Find the greatest common divisor of two integers");
            Console.Write("Enter number1: ");
            Int32.TryParse(Console.ReadLine(), out num1);

            Console.Write("Enter number2: ");
            Int32.TryParse(Console.ReadLine(), out num2);

            res = algo.EuclideanAlgorithm(num1, num2, out time);
            Console.WriteLine($"Euclidian algorithm: {res} Time: {time}");

           
            res = algo.BinaryGCDAlgorithm(num1, num2, out time);
            Console.WriteLine($"Stain algoritm: {res} Time: {time}");


            Console.WriteLine("\n Find the greatest common divisor of some integers");
            Console.WriteLine("Enter integer numbers separated by commas");

            string [] substringNumbers = Console.ReadLine().Split(',');
            int[] numbers = new int[substringNumbers.Length];

            for (int i = 0; i < substringNumbers.Length; i++)
            {
                Int32.TryParse(substringNumbers[i], out numbers[i]);
            }
            
            res = algo.EuclideanAlgorithm(numbers);
            Console.WriteLine($"Euclidian algorithm: {res}");

            Console.ReadKey();

        }
    }
}
