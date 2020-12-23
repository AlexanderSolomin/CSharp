using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Dist
    {
        public struct Distance
        {
            public int feet;
            public int inch;
        }
        static int TotalInches(int feet, int inch)
        {
            return (feet * 12 + inch);
        }
        static void Main(string[] args)
        {
            Distance a = new Distance();
            Console.WriteLine("Please enter feet 1: ");
            a.feet = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter inch 1: ");
            a.inch = int.Parse(Console.ReadLine());

            Distance b = new Distance();
            Console.WriteLine("Please enter feet 2: ");
            b.feet = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter inch 2: ");
            b.inch = int.Parse(Console.ReadLine());

            Distance d = new Distance
            {
                feet = (TotalInches(a.feet, a.inch) + TotalInches(b.feet, b.inch)) / 12,
                inch = (TotalInches(a.feet, a.inch) + TotalInches(b.feet, b.inch)) % 12
            };

            Console.WriteLine($"Summ: {d.feet}'-{d.inch}\"");

        }
    }
}
