using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void RootCalculation()
        {
            double number;
            int power;
            double accurancy;
            double rootResult;

            Console.WriteLine("Calculate root of number");
            Console.WriteLine("Enter number: ");
            Double.TryParse(Console.ReadLine(), out number);

            Console.WriteLine("Enter power of root: ");
            Int32.TryParse(Console.ReadLine(), out power);

            Console.WriteLine("Enter accuracy of the result (not required - press enter): ");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Double.TryParse(Console.ReadLine(), out accurancy);
                rootResult = RootCalculator.CalculateRootOfNumber(number, power, accurancy);
            }
            else
            {
                rootResult = RootCalculator.CalculateRootOfNumber(number, power);
            }

            Console.WriteLine($"Custom method: The {power} root of the power of {number} is {rootResult}");
            Console.WriteLine($"Library method: The {power} root of the power of {number} is {Math.Pow(number, 1.0 / power)}");
        }

        static void ConvertingDecimalToBinary()
        {
            int number;
            Console.WriteLine("Convert Decimal To Binary");
            Console.WriteLine("Enter number: ");
            Int32.TryParse(Console.ReadLine(), out number);

            var binaryNumber = NumberConverting.ConvertDecimalToBinary(number);
            Console.WriteLine($"Custom method: decimal number {number} is {binaryNumber} in binary code");
            Console.WriteLine($"Library method: decimal number {number} is {Convert.ToString(number, 2)} in binary code");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Claculate root \n" +
                "2. Convert decimal to binary number\n" +
                "Press any symbol to exit \n"+
                "Enter number of menu and press Enter: ");
            int menuNumber;
            Int32.TryParse(Console.ReadLine(), out menuNumber);

            switch (menuNumber)
            {
                case 1:
                    RootCalculation();
                    break;
                case 2:
                    ConvertingDecimalToBinary();
                    break;
            }   
            Console.ReadKey();
        }
    }
}
