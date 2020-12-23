using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy
{
    class Program
    {
        static void Main()
        {

            Triangle t1 = new Triangle(10);
            Triangle t2 = new Triangle(6, 5, 6);
            Circle c1 = new Circle(15);
            Square s1 = new Square(8);

            t1.Print();
            t2.Print();
            c1.Print();
            s1.Print();

            t1.Degree = 45;
            t2.Degree = 38;
            s1.Degree = 15;

            t1.Rotation();
            t2.Rotation();
            s1.Rotation();

        }

    }
}
