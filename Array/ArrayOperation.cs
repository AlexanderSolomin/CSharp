using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ArrayOperation
    {
        public static int Mult(int[] a)
        {
            int m = 1;
            int iMin = System.Array.IndexOf(a, a.Min());
            int iMax = System.Array.IndexOf(a, a.Max());

            if (iMin < iMax)
            {
                for (int i = iMin + 1; i < iMax; i++)
                {
                    m *= a[i];
                }
            }
            else
            {
                for (int i = iMax + 1; i < iMin; i++)
                {
                    m *= a[i];
                }
            }
            return m;
        }
        public static void EvenOddSum(int[] a)
        {
            int odd = 0, even = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (Even(a[i]))
                {
                    even += a[i];
                }
                else
                {
                    odd += a[i];
                }
            }

            Output("Sum odd: ", odd);
            Output("Sum even: ", even);
        }
        public static bool Even(int e)
        {
            return e % 2 == 0;
        }

        public static void NegPos(int[] a)
        {
            int neg = 0, pos = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    neg += a[i];
                }
                else
                {
                    pos += a[i];
                }
            }
            Output("Sum negative: ", neg);
            Output("Sum positive: ", pos);
        }

        public static void Input(int[] a)
        {
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("Enter value {0}: ", (i + 1));
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid value!");
                Input(a);
            }

        }

        public static void Output(string s, int a)
        {
            Console.WriteLine($"{s}{a}");
        }
    }
}

