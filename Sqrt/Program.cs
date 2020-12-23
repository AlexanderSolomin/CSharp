using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = double.Parse(Console.ReadLine());

            switch (SqrtOperation.Sq(a, b, c, out double x1, out double x2))
            {
                case -1:
                    Console.Write($"a = {a}, b = {b}, c = {c}, решения нет\n");
                    break;
                case 0:
                    Console.Write($"a = {a}, b = {b}, c = {c}, x1 = x2 = {x1}\n");
                    break;
                case 1:
                    Console.Write($"a = {a}, b = {b}, c = {c}, x1 = {x1}, x2 = {x2}\n");
                    break;
                default:
                    break;
            }
        }
    }
}
