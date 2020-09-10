using System;
using static System.Math;
using static System.Exception;

namespace Homework1
{
    public static class RootCalculator
    {
        public static double CalculateRootOfNumber(double number, int power, double accuracy = 1E-15)
        {
            if ((number < 0 && power % 2 == 0) || power < 0) {
                throw new FormatException("Solution has no real roots");
            }

            double oldRoot = number / 2;

            while (true)
            {
                double root = 1.0 / power * (((power - 1) * oldRoot) + (number / Pow(oldRoot, power - 1.0))); 

                if (Abs(oldRoot - root) <= accuracy)
                {
                    return root;
                }
                oldRoot = root;
            }
        }
    }
}
