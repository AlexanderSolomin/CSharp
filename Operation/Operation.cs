using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Operation
    {
        public static double S(double a, double b, double c)
        {
            double p = a + b + c;

            bool ok = TriangleExist(a, b, c);
            if (ok)
            {
                return Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
            }
            else
            {
                throw new ArgumentException("Фигура не является треугольником");
            }
        }

        public static double S(double a)
        {
            double p = 3 * a;
            return Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - a) * (p / 2 - a));
        }

        private static bool TriangleExist(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
