using System;


    class Triangle
    {

        private double a;
        private double b;
        private double c;
        public Triangle(double aaa)
        {
            a = b = c = aaa;
        }
        public Triangle(double am, double bm, double cm)
        {
            a = am;
            b = bm;
            c = cm;
        }
        public double Pa()
        {
            return a;
        }
        public double Pb()
        {
            return b;
        }
        public double Pc()
        {
            return c;
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
        public bool TriangleEq()
        {
            if (a == b && b == c)
            {
                return true;
            }
            else return false; 
        }
        
    }

