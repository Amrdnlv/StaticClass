using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
     static class StaticCalculation
    {
        static public double Sum(double a, double b)
        {
            return a + b;
        }
        static public double Minus(double a, double b)
        {
            return a - b;
        }
        static public double Umn(double a, double b)
        {
            return a * b;
        }
        static public double Del(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }


    }
}
