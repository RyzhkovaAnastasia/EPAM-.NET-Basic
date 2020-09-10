using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Homework3
{
    public class Triangle
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public double ASide
        {
            get { return _a; }
        }
        public double BSide
        {
            get { return _b; }
        }
        public double CSide
        {
            get { return _c; }
        }

        public Triangle(double a, double b, double c)
        {
            if ((a + b > c) && (b + c > a) && (a + c > b) && 
                a > 0 && b > 0 && c > 0)
            {
                _a = a;
                _b = b;
                _c = c;            
            }
            else
            {
                throw new Exception("Triangle cannot exist");
            }           
        }
        
        public double Square()
        {
            double semiperimetr = Perimeter()/2;
            return Sqrt(semiperimetr * (semiperimetr - _a) * (semiperimetr - _b) * (semiperimetr - _c));
        }

        public double Perimeter()
        {
            return _a + _b + _c;
        }
    }
}
