using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    class Square : Shape, IRot
    {
        private double a;
        public int Degree { get; set; }
        
        public void Rotation()
        {
            Console.WriteLine("{0} повёрнут на {1} градусов\n", shapeName, Degree);
        }

        public Square(double a) : base(shapeName: "Квадрат")  
        {
            this.a = a;
        }
        public Square() { }
        private double A()
        {
            return a;
        }
        public override double P()
        {
            return a * 4;
        }
        public override double S()
        {
            return a * a;
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Длина стороны: {0}", A());
            Console.WriteLine("Периметр: {0}", P());
            Console.WriteLine("Площадь: {0}\n", S());
        }

    }
}
