using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Homework2
{
    public class Algorithm
    {
        delegate int CurrentAlg(int number1, int number2);

        public int EuclideanAlgorithm(int number1, int number2)
        {
            number1 = Abs(number1);
            number2 = Abs(number2);

            if(number1 == 0 && number2 == 0)
            {
                throw new Exception("GCD 0 and 0 - undefined");
            }
                while (number2 != 0)
                {
                    if (number1 > number2)
                    {
                        number1 -= number2;
                    }
                    else
                    {
                        number2 -= number1;
                    }
                }
                return number1;
        }

        public int EuclideanAlgorithm(params int[] numbers)
        {
            if (numbers.Length > 1)
            {
                int[] newParams = new int[numbers.Length / 2 + (numbers.Length % 2)];
                int iterator = 0;

                
                    for (int i = 0; i < numbers.Length - (numbers.Length % 2); i = i + 2)
                    {
                        newParams[iterator++] = EuclideanAlgorithm(numbers[i], numbers[i + 1]);
                    }

                if (numbers.Length % 2 == 1)
                {
                    newParams[newParams.Length - 1] = numbers[numbers.Length - 1];
                }
                return EuclideanAlgorithm(newParams); 
            }
            else
            {
                return numbers[0];
            }
        }

        public int BinaryGCDAlgorithm(int number1, int number2)
        {
            number1 = Abs(number1);
            number2 = Abs(number2);

            if (number1 == 0 && number2 == 0)
            {
                throw new Exception("GCD 0 and 0 - undefined");
            }

            if (number1 == number2 || number1 == 0)
            {
                return number2;
            }

            if (number2 == 0)
            {
                return number1;
            }

            if ((number1 & 1) == 0)
            {
                return (number2 & 1) == 1
                    ? BinaryGCDAlgorithm(number1 >> 1, number2)
                    : BinaryGCDAlgorithm(number1 >> 1, (number2 >> 1)) << 1;
            }
            else if ((number2 & 1) == 0)
            {
                return BinaryGCDAlgorithm(number1, number2 >> 1);
            }
            else
            {
                return number1 > number2
                    ? BinaryGCDAlgorithm((number1 - number2) >> 1, number2)
                    : BinaryGCDAlgorithm((number2 - number1) >> 1, number1);
            }
        }

        public int EuclideanAlgorithm(int number1, int number2, out string runTime)
        {
            CurrentAlg algorithm = EuclideanAlgorithm;
            return AlgorithmTiming(algorithm, number1, number2, out runTime);
           
        }

        public int BinaryGCDAlgorithm(int number1, int number2, out string runTime)
        {
            CurrentAlg algorithm = BinaryGCDAlgorithm;
            return AlgorithmTiming(algorithm, number1, number2, out runTime);
        }

        private int AlgorithmTiming(CurrentAlg algorithm, int number1, int number2, out string time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int algoResult = algorithm(number1, number2);
            for (int i = 0; i < 1000000000; i++) { }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            time =  String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);

            return algoResult;

        }

    }
}
