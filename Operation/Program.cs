using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Треугольник равнобедренный (y/n)? ");
            string equal = Console.ReadLine();

            if (equal == "y")
            {
                Console.Write("Введите длину стороны: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write($"Площадь треугольника равна: {Operation.S(a)}\n");
            }
            else if (equal == string.Empty)
            {
                throw new ArgumentException("Необходимо ввести значение!\n");
            }
            else
            {
                Console.Write("Введите длину стороны а: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите длину стороны b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите длину стороны c: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write($"Площадь треугольника равна: {Operation.S(a, b, c)}\n");
            }
        }
    }
}
