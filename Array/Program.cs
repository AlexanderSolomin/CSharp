using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght: ");
            int num = int.Parse(Console.ReadLine());
            int[] a = new int[num];

            ArrayOperation.Input(a);
            ArrayOperation.NegPos(a);
            ArrayOperation.EvenOddSum(a);

            ArrayOperation.Output("Sum: ", a.Sum());
            ArrayOperation.Output("Average: ", (int)a.Average());
            ArrayOperation.Output("Min: ", a.Min());
            ArrayOperation.Output("Index of min: ", System.Array.IndexOf(a, a.Min()));
            ArrayOperation.Output("Max: ", a.Max());
            ArrayOperation.Output("Index of min: ", System.Array.IndexOf(a, a.Max()));
            ArrayOperation.Output("Product of min & max index: ", ArrayOperation.Mult(a));
        }
    }
}
