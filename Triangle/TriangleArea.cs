using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите значение периметра равностороннего треугольника");
            string temp = Console.ReadLine();
            double p = double.Parse(temp);
            double a = p / 3;
            double S = Math.Sqrt(p * 3 * (p - a));

            Console.WriteLine("{0,-20} {1,5}", "Сторона", "Периметр");
            Console.WriteLine("{0,-20:F2} {1,5:F2} \n", a, S);
        }
                                      
    }
}
