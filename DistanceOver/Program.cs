using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOver
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance(5, 8);
            Distance d2 = new Distance(12, 6);
            Distance d3 = d1 + d2;
            Distance d4 = d1 - d2;


            Console.WriteLine("d1 = {0}", d1.ToString());
            Console.WriteLine("d2 = {0}", d2.ToString());
            Console.WriteLine("d1 + d2 = {0}", d3.ToString());
            Console.WriteLine("d1 - d2 = {0}", d4.ToString());
        }

    }
}
