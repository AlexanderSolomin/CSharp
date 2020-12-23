using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    class SqrtOperation
    {
        public static int Sq(double a, double b, double c, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;

            double d = b * b - 4 * a * c;

            if (d < 0)
            {
                return -1;
            }
            else if (d == 0)
            {
                x1 = x2 = -(b / 2 * a);
                return 0;
            }
            else
            {
                double sqD = System.Math.Sqrt(d);
                x1 = (-b + sqD) / (2 * a);
                x2 = (-b - sqD) / (2 * a);
                return 1;
            }
        }
    }
}
