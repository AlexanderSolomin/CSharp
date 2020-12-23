using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public int Degree { get; set; }
        public void Rotation()
        {
            Console.WriteLine("{0} повёрнут на {1} градусов\n", shapeName, Degree);
        }
        public Triangle() { }
        public Triangle(double aaa) : base(shapeName: "Равнобедренный треугольник")
        {
            a = b = c = aaa;
        }
        public Triangle(double a, double b, double c) : base(shapeName: "Треугольник")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double A()
        {
            return a;
        }
        public double B()
        {
            return b;
        }
        public double C()
        {
            return c;
        }

        public override double P()
        {
            return a + b + c;
        }

        public override double S()
        {
            double p = P();
            return Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Длина стороны A: {0}", A());
            Console.WriteLine("Длина стороны B: {0}", B());
            Console.WriteLine("Длина стороны C: {0}", C());
            Console.WriteLine("Периметр: {0}", P());
            Console.WriteLine("Площадь: {0}\n", S());
        }

    }
}
