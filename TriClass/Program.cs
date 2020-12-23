using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TriClass
{
    class Program
    {
        static void Main()
        {
            Triangle newTr = NewTriangle();
            Write(newTr);
        }
        static Triangle NewTriangle()
        {
            Triangle newTri = new Triangle();
            try
            {
                Console.Write("Введите длину стороны а: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите длину стороны b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите длину стороны c: ");
                double c = double.Parse(Console.ReadLine());
                newTri.Sides(a, b, c);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода!");
                NewTriangle();
            }
            return newTri;
        }

        static void Write(Triangle toWrite)
        {
            if (toWrite.TriangleExist())
            {
                Console.WriteLine("Сторона A: {0}", toWrite.pA());
                Console.WriteLine("Сторона B: {0}", toWrite.pB());
                Console.WriteLine("Сторона C: {0}", toWrite.pC());
                Console.WriteLine("Периметр: {0}", toWrite.Perim());
                Console.WriteLine("Площадь: {0}", toWrite.Area());
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
                Main();
            }
        }

    }
}
