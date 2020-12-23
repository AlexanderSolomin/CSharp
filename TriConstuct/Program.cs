using System;

    class Program
    {
        static void Main()
        {
            
            Triangle newTri1 = new Triangle(10);
            Triangle newTri2 = new Triangle(6, 5, 6);

            Write(newTri1);
            Write(newTri2);

        }

        static void Write(Triangle newTri)
        {
            if (newTri.TriangleExist())
            {
                Console.WriteLine("Сторона A: {0}", newTri.Pa());
                Console.WriteLine("Сторона B: {0}", newTri.Pb());
                Console.WriteLine("Сторона C: {0}", newTri.Pc());
                Console.WriteLine("Периметр: {0}", newTri.Perim());
                Console.WriteLine("Площадь: {0}", newTri.Area());
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
                Main();
            }
        }

    }
