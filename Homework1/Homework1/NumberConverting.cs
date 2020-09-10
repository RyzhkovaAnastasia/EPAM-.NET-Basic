using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public static class NumberConverting
    {
        public static string ConvertDecimalToBinary(int decimalNumber)
        {
            if (decimalNumber < 0)
            {
                throw new FormatException("Decimal number was negative");
            }

            string binaryNumber = String.Empty;

            while (decimalNumber > 0)
            {
                int modulo = decimalNumber % 2;
                decimalNumber /= 2;

                binaryNumber += modulo.ToString();
            }

            char[] binaryNumberCharArray = binaryNumber.ToCharArray();
            Array.Reverse(binaryNumberCharArray);
            return new string(binaryNumberCharArray);
        }
    }
}
