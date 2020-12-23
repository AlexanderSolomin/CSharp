using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriClass
{
    class Triangle
    {
        public double pA()
        {
            return a;
        }
        public double pB()
        {
            return b;
        }
        public double pC()
        {
            return c;
        }
        public void Sides(double am, double bm, double cm)
        {
            a = am;
            b = bm;
            c = cm;
        }

        public double Perim()
        {
            return a + b + c;
        }

        public double Area()
        {
            double p = Perim();
            return Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
        }

        public bool TriangleExist()
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

        private double a;
        private double b;
        private double c;
    }
}
